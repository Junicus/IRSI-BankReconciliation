using BankReconciliation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankReconciliation.Services
{
  public interface IGLDataWriter
  {
	void WriteFile(string filename, IList<Transaction> transactions);
  }
}
