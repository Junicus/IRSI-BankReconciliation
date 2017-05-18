using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankReconciliation.Models;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace BankReconciliation.Services.Parsers
{
  public class XLSParser : IFileParser
  {
	public IEnumerable<Transaction> ParseFile(IFileService fileService)
	{
	  int year = int.MinValue;
	  int period = int.MinValue;

	  using (var frmGetData = new frmRequestData())
	  {
		if (frmGetData.ShowDialog() == DialogResult.Cancel)
		  return null;

		year = frmGetData.Year;
		period = frmGetData.Period;
	  }

	  var transactions = new List<Transaction>();

	  var excelApp = new Excel.Application();
	  excelApp.Visible = false;

	  excelApp.Workbooks.Open(fileService.FileName);

	  Excel._Worksheet worksheet = excelApp.ActiveSheet;

	  var account = worksheet.Cells[1, "A"].Value2;
	  var ibalance = worksheet.Cells[1, "C"].Value2;

	  int currRow = 3;
	  do
	  {
		var tdateTemp = worksheet.Cells[currRow, "C"].Value2;
		var transactionDate = DateTime.FromOADate(tdateTemp);
		var GLCode = worksheet.Cells[currRow, "B"].Value2;
		decimal Debit = 0.0m;
		decimal Credit = 0.0m;
		var vendorName = string.Empty;
		var checkNumber = string.Empty;
		var sequence = worksheet.Cells[currRow, "F"].Value2;

		if (GLCode == "AP-PY")
		{
		  decimal.TryParse(worksheet.Cells[currRow, "G"].Value2.ToString(), out Debit);
		  decimal.TryParse(worksheet.Cells[currRow, "H"].Value2.ToString(), out Credit);

		  if (decimal.Equals(Debit, 0.0m))
		  {
			vendorName = worksheet.Cells[currRow, "D"].Value2;
			currRow += 1;
			string temp = worksheet.Cells[currRow, "A"].Value2.ToString();
			checkNumber = temp.Substring(0, temp.LastIndexOf("-")).TrimStart('0');

		  }
		  else
		  {
			string temp = worksheet.Cells[currRow, "D"].Value2.ToString();
			checkNumber = temp.Substring(0, temp.LastIndexOf("-")).TrimStart('0');
			currRow += 1;
			vendorName = worksheet.Cells[currRow, "A"].Value2;
		  }
		}

		if (GLCode == "GL-JE" || GLCode == "AP-IN")
		{
		  decimal.TryParse(worksheet.Cells[currRow, "G"].Value2.ToString(), out Debit);
		  decimal.TryParse(worksheet.Cells[currRow, "H"].Value2.ToString(), out Credit);

		  vendorName = worksheet.Cells[currRow, "D"].Value2;
		  //TODO: Verify AP-IN for vendorName;

		  if (worksheet.Cells[currRow + 1, "C"].Value2 == null) currRow += 1;

		  //if (worksheet.Cells[currRow,"B"].Value2!=null && !worksheet.Cells[currRow, "A"].Value2.ToString().StartsWith("Net Change"))
		  // currRow += 1;
		}

		transactions.Add(new Transaction()
		{
		  TransactionDate = transactionDate.ToString("M/d/yyyy"),
		  Period = period.ToString(),
		  Year = year.ToString(),
		  Acconut = account.ToString(),
		  IBalance = ibalance.ToString(),
		  GLCode = GLCode.ToString(),
		  VendorName = vendorName.ToString(),
		  CheckNumber = checkNumber,
		  Credit = Credit.ToString(),
		  DCredit = Credit,
		  Debit = Debit.ToString(),
		  DDebit = Debit,
		  Sequence = sequence
		});

		currRow += 1;

	  } while (!worksheet.Cells[currRow, "A"].Value2.ToString().StartsWith("Net Change"));

	  var movement = worksheet.Cells[currRow, "B"].Value2;
	  var fbalance = worksheet.Cells[currRow, "C"].Value2;

	  foreach (var t in transactions)
	  {
		t.Movement = movement.ToString();
		t.FBalance = fbalance.ToString();
	  }

	  excelApp.Quit();

	  return transactions;
	}
  }
}
