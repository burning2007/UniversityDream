﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GF.Infrastructure.Crosscutting.Context
{
	public class AccountAppServiceException : Exception
	{
		/// <summary>
		/// 
		/// </summary>
		public AccountAppServiceException()
			: base()
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		public AccountAppServiceException(string message)
			: base(message)
		{
			
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
		public AccountAppServiceException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
}
