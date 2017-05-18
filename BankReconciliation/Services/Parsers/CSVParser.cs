using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankReconciliation.Models;

namespace BankReconciliation.Services.Parsers
{
  public class CSVParser : IFileParser
  {
	public IEnumerable<Transaction> ParseFile(IFileService fileService)
	{
	  throw new NotImplementedException();
	}
  }
}
