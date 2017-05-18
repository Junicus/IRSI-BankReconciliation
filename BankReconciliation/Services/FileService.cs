using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankReconciliation.Services
{
  public class FileService : IFileService
  {
	public string FileName { get; set; }
	public bool Exists => File.Exists(FileName);
	public string FileExtension => new FileInfo(FileName).Extension;
  }
}
