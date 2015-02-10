using Clinic.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Clinic.Models;
using System.Collections.Generic;

namespace ClinicUnitTest
{
    
    
    /// <summary>
    ///This is a test class for UserRepoTest and is intended
    ///to contain all UserRepoTest Unit Tests
    ///</summary>
    [TestClass()]
    public class UserRepoTest
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
        ///A test for DeleteUser
        ///</summary>
        [TestMethod()]
        public void CRUDUserTest()
        {
            UserRepo target = new UserRepo(); // TODO: Initialize to an appropriate value
            Guid userId = Guid.NewGuid();
            User user = new User();
            user.Id = userId;
            user.Username = "loxyme";
            user.Password = "p";
            target.AddUser(user);
            user.Username = "loxyme2";
            target.UpdateUser(user);

            User user2 = target.GetUserById(userId);
            Assert.AreEqual(target.GetUserById(userId).Id, target.GetUserById(user2.Id).Id);

            user2 = target.GetUserByName("loxyme2");
            Assert.AreEqual(user2.Username,"loxyme2");
            target.DeleteUser(userId);
          
        }

 
    }
}
