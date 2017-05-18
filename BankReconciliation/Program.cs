using Autofac;
using BankReconciliation.Data;
using BankReconciliation.Services;
using BankReconciliation.Services.Parsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankReconciliation
{
  static class Program
  {
	private static IContainer Container { get; set; }

	[STAThread]
	static void Main()
	{
	  var assembly = Assembly.GetExecutingAssembly();
	  var builder = new ContainerBuilder();
	  builder.RegisterType<PeriodContext>().AsSelf();
	  builder.RegisterType<FileService>().As<IFileService>();
	  builder.RegisterType<GLDataWriter>().As<IGLDataWriter>();
	  builder.RegisterType<CSVParser>().Keyed<IFileParser>("CSVParser");
	  builder.RegisterType<XLSParser>().Keyed<IFileParser>("XLSParser");
	  builder.Register<Func<string, IFileParser>>(c =>
	  {
		var context = c.Resolve<IComponentContext>();
		return (s) =>
		{
		  switch (s)
		  {
			case ".csv":
			  return context.ResolveKeyed<IFileParser>("CSVParser");
			case ".xls":
			  return context.ResolveKeyed<IFileParser>("XLSParser");
			default:
			  throw new InvalidOperationException("File extension is invalid");
		  }
		};
	  });
	  builder.RegisterAssemblyTypes(assembly)
		  .AssignableTo<Form>();
	  Container = builder.Build();

	  Application.EnableVisualStyles();
	  Application.SetCompatibleTextRenderingDefault(false);
	  Application.Run(Container.Resolve<frmMain>());
	}
  }
}
