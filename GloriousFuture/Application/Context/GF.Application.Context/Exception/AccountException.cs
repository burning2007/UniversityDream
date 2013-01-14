using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using GF.Infrastructure.Crosscutting.Context;

namespace GF.Application.Context
{
    [Serializable]
	public class AccountException : GFException
	{
		/// <summary>
		/// 
		/// </summary>
		public AccountException()
			: base()
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		public AccountException(string message)
			: base(message)
		{
			
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
		public AccountException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		public AccountException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{ 
		}
	}

    [Serializable]
	public class UserNotExistException : GFException
	{
		/// <summary>
		/// 
		/// </summary>
		public UserNotExistException()
			: base()
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		public UserNotExistException(string message)
			: base(message)
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
		public UserNotExistException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		public UserNotExistException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}

    [Serializable]
	public class AccountIsExistException : GFException
	{
		/// <summary>
		/// 
		/// </summary>
		public AccountIsExistException()
			: base()
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		public AccountIsExistException(string message)
			: base(message)
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
		public AccountIsExistException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		public AccountIsExistException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}

	public class AccountEmailExistException : GFException
	{
		/// <summary>
		/// 
		/// </summary>
		public AccountEmailExistException()
			: base()
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		public AccountEmailExistException(string message)
			: base(message)
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
		public AccountEmailExistException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		public AccountEmailExistException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}

	public class AccountIdCardExistException : GFException
	{
		/// <summary>
		/// 
		/// </summary>
		public AccountIdCardExistException()
			: base()
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		public AccountIdCardExistException(string message)
			: base(message)
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
		public AccountIdCardExistException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		public AccountIdCardExistException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}

}
