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
            modelBuilder.Entity<Customer>().HasMany(c => c.Contracts).WithOne(c => c.Customer);
            modelBuilder.Entity<Employer>().HasMany(e => e.Contracts).WithOne(c => c.Employer);
        }
    }
}
