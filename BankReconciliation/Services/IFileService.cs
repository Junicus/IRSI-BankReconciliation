using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankReconciliation.Services
{
  public interface IFileService
  {
	string FileName { get; set; }
	bool Exists { get; }
	string FileExtension { get; }
  }
}
