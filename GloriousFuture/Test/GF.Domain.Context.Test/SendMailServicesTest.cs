using GF.Application.Context;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using GF.Domain.Context.Aggregates;
using System.Text;

namespace GF.Domain.Context.Test
{
    
    
    /// <summary>
    ///This is a test class for SendMailServicesTest and is intended
    ///to contain all SendMailServicesTest Unit Tests
    ///</summary>
	[TestClass()]
	public class SendMailServicesTest
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
		[TestMethod()]
		public void SendMailTest()
		{
			SendMailServices target = new SendMailServices(); // TODO: Initialize to an appropriate value
			MailEntity mailEntity = MailEntity.CreateMailEntry(); // TODO: Initialize to an appropriate value

			mailEntity.UserName = "csh20121219";
			mailEntity.Password = "zcl19830713";
			mailEntity.MailFrom = "csh20121219@163.com";
			mailEntity.DisplaySenderName = "GloriousFuture";
			mailEntity.MailToList = new List<string>{"89358767@qq.com","burning2007@163.com"};
			mailEntity.MailCCList = new List<string>();
			mailEntity.MailBCCList = new List<string>();
			mailEntity.Encoding = Encoding.UTF8;
			mailEntity.Subject = "GloriousFuture Subject";
			mailEntity.ContentBody = "GloriousFuture content body text \n <h4>Hellow mail!!<br /><a href='http://www.google.com.hk'>google</a></h4>";
			mailEntity.Host = "smtp.163.com";
			//mailEntity.Port = 465;
			mailEntity.TimeOut = 999999;
			mailEntity.Encoding = Encoding.UTF8; //Encoding.GetEncoding("GB2312"); ;
			mailEntity.IsBodyHtml = true;
			mailEntity.EnableSSL = true;

			bool expected = true; // TODO: Initialize to an appropriate value
			bool actual;
			actual = target.SendMail(mailEntity);
			Assert.AreEqual(expected, actual);
			
		}
	}
}
