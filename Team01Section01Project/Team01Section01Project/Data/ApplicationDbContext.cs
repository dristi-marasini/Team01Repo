using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Team01Section01Project.Models;

namespace Team01Section01Project.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<DegreePlan> DegreePlans { get; set; }
        public DbSet<DegreePlanTermRequirement> DegreePlanTermRequirements { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DegreePlan>().ToTable("DegreePlan");
            modelBuilder.Entity<DegreePlanTermRequirement>().ToTable("DegreePlanTermRequirement");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}