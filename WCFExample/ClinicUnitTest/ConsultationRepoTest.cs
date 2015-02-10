using Clinic.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Clinic.Models;
using System.Collections.Generic;

namespace ClinicUnitTest
{
    
    
    /// <summary>
    ///This is a test class for ConsultationRepoTest and is intended
    ///to contain all ConsultationRepoTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ConsultationRepoTest
    {
        

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for GetConsultationById
        ///</summary>
        [TestMethod()]
        public void CRUDTest()
        {
            ConsultationRepo target = new ConsultationRepo();
            PatientRepo target2 = new PatientRepo();
            DoctorRepo target3 = new DoctorRepo();
            UserRepo target4 = new UserRepo();

            Guid patientId = Guid.NewGuid();
            string Name = "Georgica";
            string CNP = "1910112125803";
            string IdentityCardNo = "1";
            string Address = "Aurel Suciu nr 63";
            Patient patient = new Patient(patientId, Name, CNP, IdentityCardNo, Address);
            target2.AddPatient(patient);


            Guid userId = Guid.NewGuid();
            User user = new User();
            user.Username = "loxyme";
            user.Password = "p";
            user.Id = userId;

            Guid doctorId = Guid.NewGuid();
            Doctor doctor = new Doctor(doctorId,"Marinceanu", userId);
            doctor.User = user;
            target3.AddDoctor(doctor);

            Guid consultationId = Guid.NewGuid(); 
            DateTime dt = new DateTime();
            dt.AddDays(12);
            dt.AddMonths(2);
            dt.AddYears(2012);
            TimeSpan time = new TimeSpan();
            
            Consultation expected = new Consultation(consultationId, patientId, doctorId, dt,time,"flu");
            target.AddConsultation(expected);
            expected.Result = "aloalo";
            List<Consultation>cons = target.GetConsultationsByPatient(patientId);
            Consultation c = cons[0];
            Assert.AreEqual(patientId,c.PatientId);
            target.UpdateConsultation(expected);
            Assert.AreEqual(expected.Result, "aloalo");
            Consultation actual;
            actual = target.GetConsultationById(consultationId);
            Assert.AreEqual(expected.Id, actual.Id);
            target.DeleteConsultation(consultationId);
            target3.DeleteDoctor(doctorId);
            target4.DeleteUser(userId);
            
           
        }

       
    }
}
