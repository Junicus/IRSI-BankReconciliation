using BankReconciliation.Models;
using BankReconciliation.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankReconciliation
{
  public partial class frmMain : Form
  {
	private readonly IFileService _fileService;
	private readonly Func<string, IFileParser> _parserFactory;
	private readonly IGLDataWriter _dataWriter;

	private List<Transaction> _transactions;

	public frmMain(IFileService fileService, Func<string, IFileParser> parserFactory, IGLDataWriter dataWriter)
	{
	  _fileService = fileService;
	  _parserFactory = parserFactory;
	  _dataWriter = dataWriter;

	  _transactions = new List<Transaction>();

	  InitializeComponent();

	  errorProvider.SetError(tbFilenameSource, "Select source file.");
	  errorProvider.SetError(tbFilenameDestination, "Select destination file.");
	}

	private async void cmdBrowseSource_Click(object sender, EventArgs e)
	{
	  if (ofdSource.ShowDialog(this) != DialogResult.Cancel)
	  {
		tbFilenameSource.Text = ofdSource.FileName.ToLower();
		errorProvider.SetError(tbFilenameSource, "");
		_fileService.FileName = ofdSource.FileName;
		var parser = _parserFactory(_fileService.FileExtension);
		var data = await Task.Run(() => { return parser.ParseFile(_fileService); });
		if (data != null)
		{
		  _transactions = data.ToList();
		}
		bsData.DataSource = _transactions;
	  }

	  if (tbFilenameDestination.Text != string.Empty && _transactions.Any())
	  {
		cmdProcess.Enabled = true;
	  }
	}

	private void cmdBrowseDestination_Click(object sender, EventArgs e)
	{
	  if (sfdDestination.ShowDialog() != DialogResult.Cancel)
	  {
		tbFilenameDestination.Text = sfdDestination.FileName.ToLower();
		errorProvider.SetError(tbFilenameDestination, "");
	  }
	  else
	  {
		tbFilenameDestination.Text = string.Empty;
		errorProvider.SetError(tbFilenameDestination, "Select destination file.");
	  }
	  if (tbFilenameDestination.Text != string.Empty && _transactions.Any())
	  {
		cmdProcess.Enabled = true;
	  }
	}

	private async void cmdProcess_Click(object sender, EventArgs e)
	{
	  await Task.Run(() => _dataWriter.WriteFile(tbFilenameDestination.Text, _transactions));
	}
  }
}
