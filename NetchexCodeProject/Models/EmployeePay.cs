using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetchexCodeProject.Models
{
	public class EmployeePay
	{
		public int Id { get; set; }
		public DateTime HireDate { get; set; }
		public bool IsSalary { get; set; }
		public decimal Salary { get; set; }
		public decimal HourlyRate { get; set; }
		public int PayFrequencyId { get; set; }
		public decimal PayPeriodAmount { get; set; }
		public int EmployeeId { get; set; }

		[ForeignKey("Id")]
		[Required]
		public virtual PayFrequency PayFrequency { get; set; }

		[ForeignKey("Id")]
		[Required]
		public virtual Employee Employee { get; set; }
    }
}
