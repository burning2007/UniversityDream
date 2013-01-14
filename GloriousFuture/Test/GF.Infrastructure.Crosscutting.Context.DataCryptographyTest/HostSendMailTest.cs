
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using GF.Infrastructure.Crosscutting.Context;

namespace GF.Domain.Context.Test
{
	
	
	/// <summary>
	///This is a test class for SendMailServicesTest and is intended
	///to contain all SendMailServicesTest Unit Tests
	///</summary>
	[TestClass()]
	public class HostSendMailTest
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
		///A test for SendMail
		///</summary>
		public void SendMailTest()
		{
			HostSendMail target = new HostSendMail(); 
			EMail email = EMail.CreateEMail();

			email.UserName = "csh20121219";
			email.Password = "zcl19830713";
			email.MailFrom = "csh20121219@163.com";

			email.DisplaySenderName = "GloriousFuture";
			email.MailToList = new List<string>{"89358767@qq.com","burning201212@gmail.com"};
			email.MailCCList = new List<string>();
			email.MailBCCList = new List<string>();
			email.Encoding = Encoding.UTF8;
			email.Subject = "GloriousFuture Subject";
			email.ContentBody = "GloriousFuture content body text \n <h4>Hellow mail!!<br /><a href='http://www.google.com.hk'>google</a></h4>";
			email.Host = "smtp.163.com";
			//mailEntity.Port = 465;
			email.TimeOut = 999999;
			email.Encoding = Encoding.UTF8; //Encoding.GetEncoding("GB2312"); ;
			email.IsBodyHtml = true;
			email.EnableSSL = true;

			bool expected = true; 
			target.SendMail(email);
			bool actual = true;
			Assert.AreEqual(expected, actual);
			
		}
	}
}
