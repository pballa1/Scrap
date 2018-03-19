﻿namespace NetchexCodeProject.Models
{
    public class Employee
    {
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string LastName { get; set; }
		public string SocialSecurityNumber { get; set; }
		public string BirthDate { get; set; }

		public virtual EmployeePay EmployeePay { get; set; }
    }
}
