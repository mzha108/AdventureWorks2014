using Microsoft.EntityFrameworkCore;
using AdventureWorks2014.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureWorks2014.Services
{
    public class AdventureContext:DbContext
    {
        public AdventureContext(DbContextOptions<AdventureContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasOne(d => d.Person)
                      .WithOne(p => p.Employee)
                      .HasForeignKey<Employee>(d => d.BusinessEntityId);
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasOne(d => d.BusinessEntity)
                      .WithOne(p => p.Person)
                      .HasForeignKey<Person>(d => d.BusinessEntityId);
            });

            modelBuilder.Entity<EmailAddress>(entity =>
            {
                entity.HasKey(e => new { e.BusinessEntityId, e.EmailAddressId });
                entity.HasOne(d => d.Person)
                      .WithOne(p => p.EmailAddress)
                      .HasForeignKey<EmailAddress>(d => d.BusinessEntityId);
                entity.ToTable("EmailAddress", "Person");
                entity.Property(e => e.Email_Address)
                      .HasColumnName("EmailAddress");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department", "HumanResources");
            });

            modelBuilder.Entity<EmployeeDepartmentHistory>(entity =>
            {
                entity.HasKey(e => new { e.BusinessEntityId, e.StartDate, e.DepartmentId, e.ShiftId });
                entity.ToTable("EmployeeDepartmentHistory", "HumanResources");
                entity.HasOne(d => d.Department)
                      .WithMany(p => p.EmployeeDepartmentHistory)
                      .HasForeignKey(d => d.DepartmentId);
            });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Person> People { get; set; }
        public DbSet<BusinessEntity> BusinessEntities { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmailAddress> EmailAddresses { get; set; }
        public DbSet<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
