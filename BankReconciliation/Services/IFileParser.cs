using BankReconciliation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankReconciliation.Services
{
  public interface IFileParser
  {
	IEnumerable<Transaction> ParseFile(IFileService fileService);
  }
}
