using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GF.Infrastructure.Crosscutting.Context;
using System.Runtime.Serialization;

namespace GF.Domain.Context
{
    public class AccountException : GFException
    {

    }

    public class AchievementException : GFException
    {
        public AchievementException()
			: base()
		{
		}

		public AchievementException(string message)
			: base(message)
		{

		}


		public AchievementException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

        public AchievementException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
    }

	public class AccountPasswordIsNotMatchException : GFException
	{
		/// <summary>
		/// 
		/// </summary>
		public AccountPasswordIsNotMatchException()
			: base()
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		public AccountPasswordIsNotMatchException(string message)
			: base(message)
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
		public AccountPasswordIsNotMatchException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		public AccountPasswordIsNotMatchException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
