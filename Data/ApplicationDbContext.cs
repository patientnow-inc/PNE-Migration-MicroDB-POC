using Microsoft.EntityFrameworkCore;
using PNE_Microservice_POC.Models;
using System.Collections.Generic;

namespace PNE_Microservice_POC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(c => c.CreatedOn)
                .HasDefaultValueSql("NOW()");

            modelBuilder.Entity<Customer>()
                .Property(c => c.UpdatedOn)
                .HasDefaultValueSql("NOW()");
        }
    }
}
