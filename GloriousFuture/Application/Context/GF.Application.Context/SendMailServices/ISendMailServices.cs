using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GF.Domain.Context.Aggregates;

namespace GF.Application.Context
{
	public interface ISendMailServices
	{
		bool SendMail(MailEntity mailEntry);
	}
}
