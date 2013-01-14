using GF.Infrastructure.Crosscutting.Context;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GF.Infrastructure.Crosscutting.Context.Test
{
    
    
    /// <summary>
    ///This is a test class for DataCryptographyTest and is intended
    ///to contain all DataCryptographyTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DataCryptographyTest
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
        ///A test for EncryptString
        ///</summary>
        public void EncryptStringTest()
        {
            string expected = string.Empty; 
            string actual = "Bruce";
            var encrpt = DataCryptography.EncryptString(actual);
            expected = DataCryptography.DecryptString(encrpt);
            Assert.AreEqual(expected, actual);
        }
    }
}
