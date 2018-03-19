namespace NetchexCodeProject.Models
{
    public class PayFrequency
    {
		public int Id { get; set; }
		public string Name { get; set; }
		public int PayPeriodsPerYear { get; set; }

		public virtual EmployeePay EmployeePay { get; set; }
    }
}
