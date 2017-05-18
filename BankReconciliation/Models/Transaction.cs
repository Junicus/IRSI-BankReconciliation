using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankReconciliation.Models
{
  public class Transaction
  {
	public string Period { get; set; }
	public string Year { get; set; }
	public string Acconut { get; set; }
	public string IBalance { get; set; }
	public string GLCode { get; set; }
	public string VendorName { get; set; }
	public string Sequence { get; set; }
	public string Credit { get; set; }
	public decimal DCredit { get; set; }
	public string Debit { get; set; }
	public decimal DDebit { get; set; }
	public string CheckNumber { get; set; }
	public string Movement { get; set; }
	public string FBalance { get; set; }
	public string TransactionDate { get; set; }
  }
}
