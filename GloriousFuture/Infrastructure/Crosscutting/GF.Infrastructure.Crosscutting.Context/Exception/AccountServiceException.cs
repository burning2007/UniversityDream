using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GF.Infrastructure.Crosscutting.Context
{
	public class AccountServiceException : Exception
	{
		/// <summary>
		/// 
		/// </summary>
		public AccountServiceException()
			: base()
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		public AccountServiceException(string message)
			: base(message)
		{
			
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
		public AccountServiceException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
}
