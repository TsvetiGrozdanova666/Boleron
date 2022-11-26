using System;
using System.Collections.Generic;
using System.Text;
using Boleron.DBmodels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Boleron.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
            public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CarPolicy>()
                .HasKey(c => c.CarPolicyID);

            builder.Entity<ExtremePolicy>()
                .HasKey(c => c.ExtremePolicyID);

            builder.Entity<User>()
                .HasMany(u => u.ExtremePolicies)
                .WithOne(e => e.Owner)
                .HasForeignKey(u => u.OwnerID);

            builder.Entity<User>()
                .HasMany(u => u.CarPolicies)
                .WithOne(e => e.Owner)
                .HasForeignKey(u => u.OwnerID);

            base.OnModelCreating(builder);
        }
    }

}
