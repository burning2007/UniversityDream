using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Threading;


namespace GF.Infrastructure.Crosscutting.Context
{
	public class HostSendMail
	{
		/// <summary>
		/// send mail via mail entity
		/// </summary>
		/// <param name="emailModel"></param>
		/// <returns>send mail success return true otherwise return false</returns>
		public void SendMail(EMail emailModel)
		{
			ThreadPool.QueueUserWorkItem(new WaitCallback(Send), emailModel);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="emailModel"></param>
		private void Send(Object emailModel)
		{
			var eMail = (EMail)emailModel;
			MailMessage msg = new MailMessage();
			msg.From = new MailAddress(eMail.MailFrom, eMail.DisplaySenderName, eMail.Encoding);
			foreach (string mailTo in eMail.MailToList)
			{
				msg.To.Add(mailTo);
			}
			foreach (string mailCC in eMail.MailCCList)
			{
				msg.CC.Add(mailCC);
			}
			foreach (string mailBCC in eMail.MailBCCList)
			{
				msg.Bcc.Add(mailBCC);
			}
			msg.Subject = eMail.Subject;
			msg.SubjectEncoding = eMail.Encoding;
			msg.Body = eMail.ContentBody;
			msg.BodyEncoding = eMail.Encoding;
			msg.IsBodyHtml = eMail.IsBodyHtml;
			//msg.Priority = MailPriority.Normal;
			msg.Priority = MailPriority.High;
			SmtpClient client = new SmtpClient();
			client.Host = eMail.Host;
			if (eMail.Port != 0)
			{
				client.Port = eMail.Port;
			}
			if (!string.IsNullOrEmpty(eMail.UserName))
			{
				client.Credentials = new System.Net.NetworkCredential(eMail.UserName, eMail.Password);
			}
			client.EnableSsl = eMail.EnableSSL;
			client.Send(msg);           
		   
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public static HostSendMail CreateHostSendMail()
		{
			HostSendMail hostSendMail = new HostSendMail();
			return hostSendMail;
		}

		/// <summary>
		/// 
		/// </summary>
		public enum EmailCategory
		{ 
			RegisterAccount = 1,
			ActivationCode =2,
			ResetPassword = 3,
			ChangePassword = 4,
			Recharge = 5
		}
	}
}
