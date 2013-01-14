using GF.Application.Context.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GF.Domain.Context;
using GF.Infrastructure.Data.Context;
using System.Linq;
using System.Collections.Generic;

namespace GF.Application.Context.Test
{
    
    
    /// <summary>
    ///This is a test class for UniversityServiceTest and is intended
    ///to contain all UniversityServiceTest Unit Tests
    ///</summary>
    [TestClass()]
    public class UniversityServiceTest
    {


        private TestContext testContextInstance;
        private static Guid specialityId;
        private static Guid universityId;

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
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            specialityId = Guid.NewGuid();
            universityId = Guid.NewGuid();
        }
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
        ///A test for AddSpeciality
        ///</summary>
        [TestMethod()]
        public void AddSpecialityTest()
        {
            UniversityAppService target = new UniversityAppService(); 
            
            Speciality speciality = Speciality.CreateSpeciality(specialityId, "计算机", "理科", new Guid("D4FCA237-DA28-4B30-B357-0005CE66716A"),
                "工学","电气信息类", 4); 
            target.AddSpeciality(speciality);
            UniversityRepository repository = new UniversityRepository();
            var university = repository.Get(speciality.UniversityId);
            var createdSpeciality = university.Specialities.SingleOrDefault<Speciality>(s => s.Id == specialityId);
            Assert.AreNotEqual(createdSpeciality, null);
            Assert.AreEqual(createdSpeciality.Id, specialityId);
        }

        /// <summary>
        ///A test for RemoveSpeciality
        ///</summary>
        [TestMethod()]
        public void RemoveSpecialityTest()
        {
            UniversityAppService target = new UniversityAppService();
            Speciality speciality = Speciality.CreateSpeciality(specialityId, "计算机", "理科", new Guid("D4FCA237-DA28-4B30-B357-0005CE66716A"),
                "工学", "电气信息类", 4); 
            target.RemoveSpeciality(specialityId);
            UniversityRepository repository = new UniversityRepository();
            var university = repository.Get(speciality.UniversityId);
            var deleted = university.Specialities.SingleOrDefault<Speciality>(s => s.Id == specialityId);
            Assert.AreEqual(deleted, null);
        }

        /// <summary>
        ///A test for PublishEnrollPlan
        ///</summary>
        [TestMethod()]
        public void PublishEnrollPlanTest()
        {
            UniversityAppService target = new UniversityAppService(); // TODO: Initialize to an appropriate value
            UniversityEnrollPlan enrollPlan = null; // TODO: Initialize to an appropriate value
            target.PublishEnrollPlan(enrollPlan);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for UpdateEnrollPlan
        ///</summary>
        [TestMethod()]
        public void UpdateEnrollPlanTest()
        {
            UniversityAppService target = new UniversityAppService(); // TODO: Initialize to an appropriate value
            UniversityEnrollPlan enrollPlan = null; // TODO: Initialize to an appropriate value
            target.UpdateEnrollPlan(enrollPlan);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for RemoveEnrollPlan
        ///</summary>
        [TestMethod()]
        public void RemoveEnrollPlanTest()
        {
            UniversityAppService target = new UniversityAppService(); // TODO: Initialize to an appropriate value
            Guid enrollPlanId = new Guid(); // TODO: Initialize to an appropriate value
            target.RemoveEnrollPlan(enrollPlanId);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AddUniversity
        ///</summary>
        [TestMethod()]
        public void AddUniversityTest()
        {
            UniversityAppService target = new UniversityAppService();
            University university = University.CreateUniversity(universityId, "上海测试大学", "普通高校", "无", "上海市福州路1号", false, true, false, "上海市", "上海市"); 
            target.AddUniversity(university);
            using (UniversityRepository repository = new UniversityRepository())
            {
                var createdUniversity = repository.Get(universityId);
                Assert.AreNotEqual(createdUniversity, null);
                Assert.AreEqual(createdUniversity.Name, "上海测试大学");
            }
        }

        /// <summary>
        ///A test for UpdateUniversity
        ///</summary>
        [TestMethod()]
        public void UpdateUniversityTest()
        {
            UniversityAppService target = new UniversityAppService(); 
            using (UniversityRepository repository = new UniversityRepository())
            {
                var university = repository.Get(new Guid("AA1E7B07-3701-41FC-9291-D742B9E17DDE"));//universityId);
                university.Email = "shcsdx@gamil.com";
                target.UpdateUniversity(university);
                repository.Refresh(university);
                Assert.AreEqual(university.Email, "shcsdx@gamil.com");
            }
        }

        /// <summary>
        ///A test for RemoveUniversity
        ///</summary>
        [TestMethod()]
        public void RemoveUniversityTest()
        {
            UniversityAppService target = new UniversityAppService(); // TODO: Initialize to an appropriate value
            Guid universityId = new Guid(); // TODO: Initialize to an appropriate value
            target.RemoveUniversity(universityId);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for UpdateSpeciality
        ///</summary>
        [TestMethod()]
        public void UpdateSpecialityTest()
        {
            UniversityAppService target = new UniversityAppService(); // TODO: Initialize to an appropriate value
            Speciality speciality = null; // TODO: Initialize to an appropriate value
            target.UpdateSpeciality(speciality);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetByUniversityId
        ///</summary>
        [TestMethod()]
        public void GetByUniversityIdTest()
        {
            UniversityAppService target = new UniversityAppService(); // TODO: Initialize to an appropriate value
            Guid universityId = new Guid(); // TODO: Initialize to an appropriate value
            IEnumerable<SpecialityDTO> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<SpecialityDTO> actual;
            actual = target.GetSpecialitiesByUniversityId(universityId);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAll
        ///</summary>
        [TestMethod()]
        public void GetAllTest()
        {
            UniversityAppService target = new UniversityAppService(); 
            IList<University> actual;
            actual = target.GetAll();
            Assert.AreEqual(3158, actual.Count);
        }
    }
}
