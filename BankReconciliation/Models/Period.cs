using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankReconciliation.Models
{
  public class Period : IEquatable<Period>
  {
	[Key, Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int Year { get; set; }

	[Key, Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int PeriodNumber { get; set; }

	public DateTime StartDate { get; set; }
	public DateTime EndDate { get; set; }

	public bool Equals(Period other)
	{
	  bool result = false;
	  if ((Year.Equals(other.Year)) && (PeriodNumber.Equals(other.PeriodNumber)) &&
		  (StartDate.Equals(other.StartDate)) && EndDate.Equals(other.EndDate))
		result = true;
	  return result;
	}

	public override bool Equals(object obj)
	{
	  if (obj == null)
		return false;

	  Period p = obj as Period;
	  if (p == null)
		return false;

	  return Equals(p);
	}

	public override int GetHashCode()
	{
	  return Year ^ PeriodNumber;
	}
  }
}
