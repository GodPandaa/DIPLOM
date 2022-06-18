using System;
using Microsoft.EntityFrameworkCore;
using DIPLOM.Domain;

namespace DIPLOM.Infrastructure
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {

        }

        public DbSet<Vacancy> Vacancies { get; set; }

        public DbSet<Employer> Employers { get; set; }

        public DbSet<Customer> Customers  { get; set; }

        public DbSet<Contract> Contracts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Vacancy>().HasOne(v => v.Contract).WithMany(c => c.Vacancies);
            modelBuilder.Entity<Customer>().HasOne(c => c.Contract).WithMany(c => c.Customers);
            modelBuilder.Entity<Employer>().HasOne(e => e.Contract).WithMany(c => c.Employers);
        }
    }
}
