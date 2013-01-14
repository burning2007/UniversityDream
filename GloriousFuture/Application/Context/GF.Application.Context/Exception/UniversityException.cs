using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GF.Infrastructure.Crosscutting.Context;
using System.Runtime.Serialization;

namespace GF.Application.Context
{
	public class UniversityException : GFException
	{
		
	}

	public class UniversityNoEnrollPlanException : GFException
	{
		/// <summary>
		/// 
		/// </summary>
		public UniversityNoEnrollPlanException()
			: base()
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		public UniversityNoEnrollPlanException(string message)
			: base(message)
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
		public UniversityNoEnrollPlanException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		public UniversityNoEnrollPlanException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}

	public class UniversityEnrollPlanExistException : GFException
	{
		/// <summary>
		/// 
		/// </summary>
		public UniversityEnrollPlanExistException()
			: base()
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		public UniversityEnrollPlanExistException(string message)
			: base(message)
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
		public UniversityEnrollPlanExistException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		public UniversityEnrollPlanExistException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
	
	public class UniversityApplicationExistException : GFException
	{
		/// <summary>
		/// 
		/// </summary>
		public UniversityApplicationExistException()
			: base()
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		public UniversityApplicationExistException(string message)
			: base(message)
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
		public UniversityApplicationExistException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		public UniversityApplicationExistException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
