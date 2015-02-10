using Clinic.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Clinic.Models;
using System.Collections.Generic;

namespace ClinicUnitTest
{
    
    
    /// <summary>
    ///This is a test class for PatientRepoTest and is intended
    ///to contain all PatientRepoTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PatientRepoTest
    {
        private Guid guid = Guid.NewGuid();
        private string Name = "Georgica";
        private string CNP = "1910112125803";
        private string IdentityCardNo = "1";
        private string Address = "Aurel Suciu nr 63";
        Patient patient;
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

        /// <summary>
        ///A test for UpdatePatient
        ///</summary>
        [TestMethod()]
        public void CRUDPatientTest()
        {
            PatientRepo target = new PatientRepo();
            patient = new Patient(guid, Name, CNP, IdentityCardNo, Address);
            Guid patientId = guid;

            target.AddPatient(patient);
            Assert.AreEqual(patient.Id,target.GetPatientById(guid).Id);
            patient.Name = "Ghita";
            target.UpdatePatient(patient);
            Patient p = target.GetPatientById(guid);
            Assert.AreEqual("Ghita",p.Name);
            target.DeletePatient(patientId);
            Assert.AreEqual(null, target.GetPatientById(guid));
        }

      
    }
}
