using BankReconciliation.Data;
using BankReconciliation.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankReconciliation.Services
{
  public class GLDataWriter : IGLDataWriter
  {
	private readonly PeriodContext _context;

	public GLDataWriter(PeriodContext context)
	{
	  _context = context;
	}

	public void WriteFile(string filename, IList<Transaction> transactions)
	{
	  Period period = null;

	  try
	  {
		period = _context.Periods.Find(int.Parse(transactions[0].Year), int.Parse(transactions[0].Period));
		if (period == null)
		{
		  using (var periodForm = new frmAddNewPeriod(int.Parse(transactions[0].Year), int.Parse(transactions[0].Period)))
		  {
			if (periodForm.ShowDialog() == DialogResult.Cancel)
			  throw new InvalidOperationException("Could not process transactions: Invalid Period");
			_context.Periods.Add(periodForm.PeriodEntity);
			_context.SaveChanges();
			period = _context.Periods.Find(int.Parse(transactions[0].Year), int.Parse(transactions[0].Period));
		  }
		}
	  }
	  catch (Exception ex)
	  {
		MessageBox.Show(ex.Message);
		throw new Exception("Exiting: Critical Error.", ex);
	  }

	  var outlines = new List<string>();

	  //Add Initial Balance
	  outlines.Add($"I{transactions[0].Acconut.PadLeft(6, ' ')}{period.StartDate.ToString("yyyyMMdd")}{(decimal.Parse(transactions[0].IBalance) * 100).ToString("f0").PadLeft(17, ' ')}");

	  foreach (var t in transactions)
	  {
		string output = "M";
		output += t.Acconut.PadRight(6, ' ');
		output += (0).ToString().PadRight(6, ' ');
		decimal amount;
		if (decimal.Parse(t.Credit) == 0m)
		{
		  switch (t.GLCode)
		  {
			case "AP-PY":
			  output += "RM";
			  break;
			case "GL-JE":
			  output += "J+";
			  break;
			case "AP-IN":
			  output += "DN";
			  break;
		  }
		  amount = decimal.Parse(t.Debit);
		}
		else
		{
		  switch (t.GLCode)
		  {
			case "AP-PY":
			  output += "AP";
			  break;
			case "GL-JE":
			  output += "J-";
			  break;
			case "AP-IN":
			  output += "CN";
			  break;
		  }
		  amount = decimal.Parse(t.Credit);
		}

		if (int.TryParse(t.CheckNumber, out int checknumber))
		{
		  if (checknumber.ToString().Length > 6)
			output += checknumber.ToString().Substring(0, 6);
		  else
			output += checknumber.ToString().PadLeft(6, ' ');
		}
		else
		{
		  if (int.TryParse(t.Sequence.Remove(t.Sequence.IndexOf("-"), 1), out checknumber))
		  {
			if (checknumber.ToString().Length > 6)
			  output += checknumber.ToString().Substring(0, 6);
			else
			  output += checknumber.ToString().PadLeft(6, ' ');
		  }
		}

		if (DateTime.ParseExact(t.TransactionDate, "M/d/yyyy", null, DateTimeStyles.None) < period.EndDate)
		{
		  output += DateTime.ParseExact(t.TransactionDate, "M/d/yyyy", null, DateTimeStyles.None).ToString("yyyyMMdd");
		}
		else
		{
		  output += period.EndDate.ToString("yyyyMMdd");
		}
		output += (amount * 100).ToString("f0").PadLeft(17, '0');
		output += t.VendorName.PadRight(140, ' ');

		outlines.Add(output);
	  }

	  //Add Final Balance
	  outlines.Add($"F{transactions[0].Acconut.PadLeft(6, ' ')}{period.EndDate.ToString("yyyyMMdd")}{(decimal.Parse(transactions[0].FBalance) * 100).ToString("f0").PadLeft(17, ' ')}");

	  File.WriteAllLines(filename, outlines);
	}
  }
}
