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
  public partial class frmRequestData : Form
  {
	private int _year;
	private int _period;

	public frmRequestData()
	{
	  InitializeComponent();

	  errorProvider.SetError(tbYear, "Must enter year");
	  errorProvider.SetError(tbPeriod, "Must enter period");
	}

	private void tbYear_TextChanged(object sender, EventArgs e)
	{
	  errorProvider.SetError(tbYear, "");
	  if (!int.TryParse(tbYear.Text, out _year))
		errorProvider.SetError(tbYear, "Invalid format");
	}

	private void tbPeriod_TextChanged(object sender, EventArgs e)
	{
	  errorProvider.SetError(tbPeriod, "");
	  if (!int.TryParse(tbPeriod.Text, out _period))
		errorProvider.SetError(tbPeriod, "Invalid format");
	}

	private void cmdOk_Click(object sender, EventArgs e)
	{
	  if (ValidateChildren())
	  {
		DialogResult = DialogResult.OK;
		Close();
	  }
	}

	private void cmdCancel_Click(object sender, EventArgs e)
	{
	  DialogResult = DialogResult.Cancel;
	  Close();
	}

	public int Year
	{
	  get { return _year; }
	}

	public int Period
	{
	  get { return _period; }
	}

	private void tbYear_Validating(object sender, CancelEventArgs e)
	{
	  if (int.TryParse(tbYear.Text, out _year))
		errorProvider.SetError(tbYear, "");
	  else
	  {
		errorProvider.SetError(tbYear, "Invalid Format");
		e.Cancel = true;
	  }
	}

	private void tbPeriod_Validating(object sender, CancelEventArgs e)
	{
	  if (int.TryParse(tbPeriod.Text, out _period))
		errorProvider.SetError(tbPeriod, "");
	  else
	  {
		errorProvider.SetError(tbPeriod, "Invalid Format");
		e.Cancel = true;
	  }

	}
  }
}
