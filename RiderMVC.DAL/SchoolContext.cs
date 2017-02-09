using System;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using RiderMVC.Model;

namespace RiderMVC.DAL
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("name=RiderMVCContext")
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}