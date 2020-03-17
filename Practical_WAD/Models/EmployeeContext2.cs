namespace Practical_WAD.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EmployeeContext2 : DbContext
    {
        public EmployeeContext2()
            : base("name=EmployeeContext2")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public System.Data.Entity.DbSet<Practical_WAD.Models.Employees> Employees { get; set; }
    }
}
