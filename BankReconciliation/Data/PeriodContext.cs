using BankReconciliation.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankReconciliation.Data
{
  public class PeriodContext : DbContext
  {
	public PeriodContext()
	{
	}

	public PeriodContext(string connectionString) : base(connectionString)
	{
	}

	public DbSet<Period> Periods { get; set; }
  }
}
