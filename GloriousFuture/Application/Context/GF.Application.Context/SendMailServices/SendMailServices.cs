using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using GF.Domain.Context.Aggregates;

namespace GF.Application.Context
{
	public class SendMailServices : ISendMailServices
	{
		/// <summary>
		/// send mail via mail entry
		/// </summary>
		/// <param name="mailEntity"></param>
		/// <returns>send mail success return true otherwise return false</returns>
		public bool SendMail(MailEntity mailEntity)
		{
			bool result = false;

			try
			{
				MailMessage msg = new MailMessage();
				msg.From = new MailAddress(mailEntity.MailFrom, mailEntity.DisplaySenderName, mailEntity.Encoding);
				foreach (string mailTo in mailEntity.MailToList)
				{
					msg.To.Add(mailTo);
				}
				foreach (string mailCC in mailEntity.MailCCList)
				{
					msg.CC.Add(mailCC);
				}
				foreach (string mailBCC in mailEntity.MailBCCList)
				{
					msg.Bcc.Add(mailBCC);
				}
				msg.Subject = mailEntity.Subject;
				msg.SubjectEncoding = mailEntity.Encoding;
				msg.Body = mailEntity.ContentBody;
				msg.BodyEncoding = mailEntity.Encoding;
				msg.IsBodyHtml = mailEntity.IsBodyHtml;
				msg.Priority = MailPriority.Normal;

				SmtpClient client = new SmtpClient();
				client.Host = mailEntity.Host;
				if (mailEntity.Port != 0)
				{
					client.Port = mailEntity.Port;
				}
				if (!string.IsNullOrEmpty(mailEntity.UserName))
				{
					client.Credentials = new System.Net.NetworkCredential(mailEntity.UserName, mailEntity.Password);
				}
				client.EnableSsl = mailEntity.EnableSSL;
				client.Send(msg);

				result = true;
			}
			catch (SmtpException smtpEx)
			{
				throw smtpEx;
			}

			return result;
		}
	}
}
