using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GF.Infrastructure.Crosscutting.Seedwork
{
    public class GfException : Exception
    {
       /// <summary>
		/// 
		/// </summary>
		public GfException()
			: base()
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		public GfException(string message)
			: base(message)
		{
			
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
        public GfException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
    }
}
