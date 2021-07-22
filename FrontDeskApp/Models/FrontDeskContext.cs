using System;
using System.Data.Entity;

namespace FrontDeskApp.Models
{
    public class FrontDeskContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Facility> Facilities { get; set; }
    }       
}