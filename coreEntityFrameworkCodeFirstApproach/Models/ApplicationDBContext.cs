﻿using Microsoft.EntityFrameworkCore;

namespace coreEntityFrameworkCodeFirstApproach.Models
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=CodeFirstDB;Integrated Security=true;TrustServerCertificate=true;");
        }
    }
}
