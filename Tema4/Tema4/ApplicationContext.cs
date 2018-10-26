using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tema4
{
     public sealed class ApplicationContext : DbContext
     {
            public ApplicationContext()
            {
                Database.EnsureCreated();
            }

            public DbSet<Employee> Employees { get; set; }

            public DbSet<Customer> Customers { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB;Database=Employees;Trusted_Connection=True;");
                }

            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Employee>()
                    .Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                modelBuilder.Entity<Employee>()
                    .Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(70);

                modelBuilder.Entity<Employee>()
                    .Property(e => e.StartDate)
                    .IsRequired();

                modelBuilder.Entity<Employee>()
                    .Property(e => e.EndDate)
                    .IsRequired();

                modelBuilder.Entity<Customer>()
                    .Property(c => c.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                modelBuilder.Entity<Customer>()
                    .Property(c => c.Address)
                    .IsRequired()
                    .HasMaxLength(300);

                modelBuilder.Entity<Customer>()
                    .Property(c => c.PhoneNumber)
                    .IsRequired();

                modelBuilder.Entity<Customer>()
                    .Property(c => c.Email)
                    .IsRequired();
            }
        }
}
