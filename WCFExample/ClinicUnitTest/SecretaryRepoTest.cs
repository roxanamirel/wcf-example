using Clinic.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Clinic.Models;
using System.Collections.Generic;

namespace ClinicUnitTest
{
    
    
    /// <summary>
    ///This is a test class for SecretaryRepoTest and is intended
    ///to contain all SecretaryRepoTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SecretaryRepoTest
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
        ///A test for UpdateSecretary
        ///</summary>
        [TestMethod()]
        public void CRUDSecretaryTest()
        {
            SecretaryRepo target = new SecretaryRepo();
            UserRepo target2 = new UserRepo();

            Guid userId = Guid.NewGuid();
            User user = new User();
            user.Username = "loxymee";
            user.Password = "p";
            user.Id = userId;

            Guid secid = Guid.NewGuid();
            Secretary secretary = new Secretary(secid,"roxana",userId);
            secretary.User = user;
            target.AddSecretary(secretary);
            secretary.Name = "boby";
            target.UpdateSecretary(secretary);
            Secretary sec = target.GetSecretaryByUserId(userId);
            Assert.AreEqual(sec.Name, "boby");
            target.DeleteSecretary(secretary.Id);
            sec = target.GetSecretaryById(sec.Id);
            target2.DeleteUser(userId);
            User userr = target2.GetUserById(userId);
            Assert.IsNull(sec);
            Assert.IsNull(userr);
           
        }

      
    }
}
