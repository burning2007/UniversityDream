using GF.Application.Context;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GF.Domain.Context.Services.AccountService;
using GF.Domain.Context;
using GF.Infrastructure.Data.Context;
using System.Linq;
using GF.Infrastructure.Crosscutting.Context;
using System.Collections.Generic;
using GF.Application.Context.Services;

namespace GF.Application.Context.Test
{
	
	
	/// <summary>
	///This is a test class for AccountAppServiceTest and is intended
	///to contain all AccountAppServiceTest Unit Tests
	///</summary>
	[TestClass()]
	public class AccountAppServiceTest
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
		///A test for Register
		///</summary>
		[TestMethod()]
		public void RegisterTest()
		{
			IUserService accountSrv = new UserService(); 
			UserAppService target = new UserAppService(accountSrv);
            using (UserRepository accountRepository = new UserRepository())
            {
                var accounts = accountRepository.GetFiltered(a => a.AccountName == "zhangsan");
                if (accounts != null && accounts.ToList<User>().Count > 0)
                {
                    var existedAccount = accounts.Single<User>
                    (a => a.AccountName == "zhangsan");
                    if (existedAccount != null)
                    {
                        accountRepository.Remove(existedAccount);
                        accountRepository.Commit();
                    }
                }

                var accountAdd = User.CreateAccount(new Guid("D1111C18-A0BD-480B-99CA-AAF50B2D1818"), "zhangsan", "123456", "zhangsan@gmail.com",
                    120, false, "310123199009091244", "张三", "", true, false);

                target.Register(accountAdd);

                var accountInRepository = accountRepository.Get(accountAdd.Id);

                Assert.AreEqual(accountInRepository.AccountName, accountAdd.AccountName);
            }
		}

		/// <summary>
		///A test for ActivateAccount
		///</summary>
		[TestMethod()]
		public void ActivateAccountTest()
		{
			IUserService accountSrv = new UserService();
			UserAppService target = new UserAppService(accountSrv);
            using (UserRepository repository = new UserRepository())
            {
                Guid accountId = new Guid("D1111C18-A0BD-480B-99CA-AAF50B2D1818");
                var account = repository.Get(accountId);
                string activationCode = account.ActivationCode;
                target.ActivateAccount(accountId, activationCode);
                repository.Refresh(account);
                Assert.AreEqual(account.IsActive, true);
            }
		}

		/// <summary>
		///A test for Login
		///</summary>
		[TestMethod()]
		public void LoginTest()
		{
			IUserService accountSrv = new UserService();
			UserAppService target = new UserAppService(accountSrv);
			string userName = "zhangsan";
			string password = "123456";
			bool expected = true;
			bool actual;
			actual = target.Login(userName, password);
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		///A test for ChangePassword
		///</summary>
		[TestMethod()]
		public void ChangePasswordTest()
		{
			IUserService accountSrv = new UserService();
			UserRepository accountRepository = new UserRepository();
			UserAppService target = new UserAppService(accountSrv);
			Guid accountId = new Guid("D1111C18-A0BD-480B-99CA-AAF50B2D1818");
			var account = accountRepository.Get(accountId);
			string password = "abc123"; 
			target.ChangePassword(accountId, "123456", password);
			accountRepository.Refresh(account);
			Assert.AreEqual(account.Password, DataCryptography.EncryptString(password));
		}


		/// <summary>
		///A test for Recharge
		///</summary>
		[TestMethod()]
		public void RechargeTest()
		{
			IUserService accountSrv = new UserService();
			UserAppService target = new UserAppService(accountSrv);
			UserRepository accountRepository = new UserRepository();
			int original = 0;
			Guid accountId = new Guid("D1111C18-A0BD-480B-99CA-AAF50B2D1818");
			var account = accountRepository.Get(accountId);
			original = account.Coins;
			int coins = 10;
			target.Recharge(account.Id, coins);
			accountRepository.Refresh(account);
			Assert.AreEqual(original + coins, account.Coins);
		}

		/// <summary>
		///A test for ResetPassword
		///</summary>
		[TestMethod()]
		public void ResetPasswordTest()
		{
			IUserService accountSrv = new UserService();
			UserAppService target = new UserAppService(accountSrv);
			Guid accountId = new Guid("D1111C18-A0BD-480B-99CA-AAF50B2D1818");
			UserRepository accountRepository = new UserRepository();
			var account = accountRepository.Get(accountId);
			var password = account.Password;
            target.ResetPassword(accountId, "zhangsan@gmail.com");
			accountRepository.Refresh(account);
			Assert.AreNotEqual(account.Password, password);
		}

		/// <summary>
		///A test for ChangeAchievement
		///</summary>
		[TestMethod()]
		public void ChangeAchievementTest()
		{
			IUserService accountSrv = new UserService();
			UserAppService target = new UserAppService(accountSrv);
			AccountDTO account_dto = new AccountDTO()
			{
				AccountName = "zhangsan",
				Coins = 80,
				Email = "zhangsan123@gmail.com",
				Gender = true,
				Id = new Guid("D1111C18-A0BD-480B-99CA-AAF50B2D1818"),
				IdentityCardNumber = "310123199009091234",
				Name = "张三",
				Score = 600,
				SpecialityType = "理科",
				Year = DateTime.Parse("2012-09-09"),
				City = "上海市",
                Province = "上海市"
			};
			target.ChangeAchievement(account_dto);
			Assert.AreEqual(1, 1);
		}

        /// <summary>
        ///A test for CreateApplication
        ///</summary>
        [TestMethod()]
        public void CreateApplicationTest()
        {
            ApplicationService target = new ApplicationService();
            UniversityAppService universitySerivce = new UniversityAppService();

            ApplicationRepository appRepository = new ApplicationRepository();
            var app = appRepository.Get(new Guid("6079D394-C27A-4871-996A-AC9374097042"));
            if (app != null)
            {
                appRepository.Remove(app);
                appRepository.Commit();
                app = appRepository.Get(new Guid("6079D394-C27A-4871-996A-AC9374097042"));
                Assert.AreEqual(app, null);
            }
            GF.Domain.Context.Application application = new Domain.Context.Application(new Guid("D1111C18-A0BD-480B-99CA-AAF50B2D1818"), new Guid("408AD727-5E75-409C-A658-0AB0C6A9EFD2"), new Guid("6079D394-C27A-4871-996A-AC9374097042"));
            target.CreateApplication(application);
            app = appRepository.Get(new Guid("6079D394-C27A-4871-996A-AC9374097042"));
            Assert.AreNotEqual(app, null);
            Assert.AreEqual(app.Id, new Guid("6079D394-C27A-4871-996A-AC9374097042"));
            
        }

        /// <summary>
        ///A test for GetApplicationByUserId
        ///</summary>
        [TestMethod()]
        public void GetApplicationByUserIdTest()
        {
            ApplicationService target = new ApplicationService();
            Guid userId = new Guid("D1111C18-A0BD-480B-99CA-AAF50B2D1818"); 
            IEnumerable<GF.Domain.Context.Application> actual;
            actual = target.GetApplicationByUserId(userId);
            Assert.AreEqual(1, actual.ToList<GF.Domain.Context.Application>().Count);
        }
	}
}
