using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace netcoregradebook.Models
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

            public DbSet<Course> Courses { get; set; }
            public DbSet<Assignment> Assignments { get; set; }
            public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Assignment>()
                .HasOne(p => p.Course)
                .WithMany(p => p.Assignments)
                .HasForeignKey(p => p.CourseId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);

            builder.Entity<Assignment>()
                .HasOne(p => p.Category)
                .WithMany(p => p.Assignments)
                .OnDelete(DeleteBehavior.Restrict);



        }
    }
}
