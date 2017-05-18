using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankReconciliation.Services
{
  public class FIleParserFactory : IFileParserFactory
  {
	private IContainer _container;

	public FIleParserFactory(IContainer container)
	{
	  _container = container;
	}

	public IFileParser CreateParser(IFileService fileService)
	{
	  switch (fileService.FileExtension)
	  {
		case ".csv":
		  return _container.ResolveKeyed<IFileParser>("CSVParser");
		case ".xls":
		  return _container.ResolveKeyed<IFileParser>("XLSParser");
		default:
		  throw new InvalidOperationException("File type not valid");
	  }
	}
  }
}
