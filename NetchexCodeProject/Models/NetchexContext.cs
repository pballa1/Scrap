using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace NetchexCodeProject.Models
{
    public class NetchexContext : DbContext
    {
		private IConfigurationRoot _config;

		public NetchexContext(IConfigurationRoot config, DbContextOptions options) :
			base(options)
		{
			_config = config;
		}

		public DbSet<Employee> Employees { get; set; }
		public DbSet<EmployeePay> EmployeePays { get; set; }
		public DbSet<PayFrequency> PayFrequencies { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer(_config["ConnectionStrings:NetchexContextConnection"]);
		}
    }
}
