using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GF.Infrastructure.Crosscutting.Context
{
	/// <summary>
	/// send mail entry
	/// </summary>
	public class EMail 
	{
		#region Properties
		/// <summary>        
		/// the email address that will send the email       
		/// </summary>      
		public String MailFrom { set; get; }
		/// <summary>       
		/// the email address list that will receive the email        
		/// </summary>    
		public List<String> MailToList { set; get; }
		/// <summary>       
		/// the CC email address list that will receive the email        
		/// </summary>    
		public List<String> MailCCList { set; get; }
		/// <summary>       
		/// the BCC email address list that will receive the email        
		/// </summary>    
		public List<String> MailBCCList { set; get; }
		private Encoding encoding;
		/// <summary>
		/// the Encoding type that will edcode the email content
		/// </summary>
		public Encoding Encoding
		{
			get
			{
				if (encoding == null)
				{
					encoding = Encoding.UTF8;
				}
				return encoding;
			}
			set
			{
				encoding = value;
			}
		}
		/// <summary>        
		/// the name of the user who send the email        
		/// </summary>  
		public String UserName { set; get; }
		/// <summary>       
		/// the password of the user who send the email      
		/// </summary>       
		public string Password { get; set; }
		/// <summary>        
		/// the sender name that will display in the sender item        
		/// </summary>    
		public String DisplaySenderName { set; get; }
		///  <summary>       
		/// mail subject      
		/// </summary>      
		public String Subject { set; get; }
		/// <summary>       
		/// mail content       
		/// </summary>        
		public String ContentBody { set; get; }
		///<summary>       
		/// mail host address, smtp.163.com / pop3.163.com    
		/// </summary>     
		public String Host { set; get; }
		///<summary>       
		/// mail host port       
		/// </summary>     
		public int Port { set; get; }
		/// <summary>
		/// SMTP Server used TLS2 OR SSL
		/// </summary>
		public bool EnableSSL { get; set; }
		///<summary>        
		/// if the mail body is in html format    
		/// </summary>
		public Boolean IsBodyHtml { set; get; }
		/// <summary>        
		/// the email send timeout       
		/// </summary>       
		public Int32 TimeOut { set; get; }
		#endregion

		#region Factory Method
		public static EMail CreateEMail()
		{
			EMail currentMailEntity = new EMail();
            currentMailEntity.MailBCCList = new List<string>();
            currentMailEntity.MailCCList = new List<string>();
            currentMailEntity.MailToList = new List<string>();

			return currentMailEntity;
		} 
		#endregion
	}
}
