using System;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using RiderMVC.Model;

namespace RiderMVC.DAL
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base()
        {
            Database.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["RiderMVCContext"]
                .ConnectionString;
            Database.SetInitializer<SchoolContext>(null);
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}