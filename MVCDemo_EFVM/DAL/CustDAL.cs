using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCDemo_EFVM.Models;
using System.Data.Entity;

namespace MVCDemo_EFVM.DAL
{
    public class CustDAL:DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>().ToTable("tblnewcust");

        }
        public DbSet<Customer> Customers { get; set; }
    }
}