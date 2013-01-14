using GF.Domain.Context;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GF.Infrastructure.Crosscutting.Context;

namespace GF.Domain.Context.Test
{
    
    
    /// <summary>
    ///This is a test class for AccountTest and is intended
    ///to contain all AccountTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AccountTest
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
        ///A test for LockAccount
        ///</summary>
        public void LockAccountTest()
        {
            User target = new User(); 
            target.LockAccount();
            Assert.AreEqual(target.IsLocked, true);
        }

        /// <summary>
        ///A test for ChangePassword
        ///</summary>
        [TestMethod()]
        public void ChangePasswordTest()
        {
            User target = User.CreateAccount(Guid.Empty, "accountName","123456","zhangsan@gmail.com",
                120, false, "310123199009091234","张三", "" ,true, false); 
            string password = "abcdef"; 
            target.ChangePassword(password);
            Assert.AreEqual(target.Password, DataCryptography.EncryptString("abcdef"));

            password = "ab  1234";
            try
            {
                target.ChangePassword(password);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex is ArgumentException, true);
                Assert.AreEqual(target.Password, DataCryptography.EncryptString("abcdef"));
            }

            password = "ab1234 ";
            try
            {
                target.ChangePassword(password);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex is ArgumentException, true);
                Assert.AreEqual(target.Password, DataCryptography.EncryptString("abcdef"));
            }

            password = "ab123";
            try
            {
                target.ChangePassword(password);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex is ArgumentException, true);
                Assert.AreEqual(target.Password, DataCryptography.EncryptString("abcdef"));
            }

        }
    }
}
