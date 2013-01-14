using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace GF.Infrastructure.Crosscutting.Context
{
	[Serializable]
	public class GFException : Exception
	{
		/// <summary>
		/// 
		/// </summary>
		public GFException()
			: base()
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		public GFException(string message)
			: base(message)
		{
			
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
		public GFException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		public GFException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{ 
		}
	}
}
