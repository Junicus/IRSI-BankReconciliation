using BankReconciliation.Models;
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
  public partial class frmAddNewPeriod : Form
  {
	public frmAddNewPeriod(int year, int period)
	{
	  InitializeComponent();

	  Year = year;
	  Period = period;

	  tbYear.Text = year.ToString();
	  tbPeriod.Text = period.ToString();
	}

	public DateTime StartDate { get; set; }
	public DateTime EndDate { get; set; }
	public int Year { get; set; }
	public int Period { get; set; }

	public Period PeriodEntity
	{
	  get => new Period
	  {
		Year = Year,
		PeriodNumber = Period,
		StartDate = StartDate,
		EndDate = EndDate
	  };
	}

	private void cmdOK_Click(object sender, EventArgs e)
	{
	  DialogResult = DialogResult.OK;
	  Close();
	}

	private void cmdCancel_Click(object sender, EventArgs e)
	{
	  DialogResult = DialogResult.Cancel;
	  Close();
	}

	private void dtpStartDate_ValueChanged(object sender, EventArgs e)
	{
	  StartDate = dtpStartDate.Value;
	}

	private void dtpEndDate_ValueChanged(object sender, EventArgs e)
	{
	  EndDate = dtpEndDate.Value;
	}
  }
}
