using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectName.Infrastructure.Identity
{
    public class IdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        //private readonly string _connString = "Server=(localdb)\\MSSQLLocalDB_ADV;Database=;Trusted_Connection=True;MultipleActiveResultSets=true";

        public IdentityDbContext(DbContextOptions<IdentityDbContext> options) : base(options)
        { }

        //public IdentityDbContext()
        //{ }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {

        //        optionsBuilder.UseSqlServer(_connString);
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
