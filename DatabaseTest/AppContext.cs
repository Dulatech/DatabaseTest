using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DatabaseTest.Models;
using System.Data.Entity;

namespace DatabaseTest
{
    public class AppContext : DbContext
    {
        public AppContext() : base("ProjectDatabaseV8")
        {
            Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Employee> Employees { get; set; }

        public System.Data.Entity.DbSet<DatabaseTest.Models.Client> Clients { get; set; }

        public System.Data.Entity.DbSet<DatabaseTest.Models.Branch> Branches { get; set; }
    }
    public class AppDBInitializer : CreateDatabaseIfNotExists<AppContext>
    {
        protected override void Seed(AppContext context)
        {
            base.Seed(context);
        }
    }
}