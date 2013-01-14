using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GF.Infrastructure.Crosscutting.Context
{
	public class AggregatesException : Exception
	{
		/// <summary>
		/// 
		/// </summary>
		public AggregatesException()
			: base()
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		public AggregatesException(string message)
			: base(message)
		{
			
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
		public AggregatesException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
}
