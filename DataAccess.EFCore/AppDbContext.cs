using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EFCore
{
    public class AppDbContext : IdentityDbContext<Account>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

        public DbSet<UniSupervisor> UniSupervisors { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Training> Trainings { get; set; }

        public DbSet<Application> Applications { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<University> Universities { get; set; }

        public DbSet<StudentEmail> StudentEmails { get; set; }
        public DbSet<CReport> cReports { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<University>()
                .HasMany(u => u.Students)
                .WithOne(s => s.University)
                .HasForeignKey(s => s.UniversityId);
            builder.Entity<University>()
            .HasOne(u => u.UniSupervisor)
            .WithOne(s => s.University)
            .HasForeignKey<UniSupervisor>(s => s.UniversityId);
            builder.Entity<CReport>()
            .HasOne(c => c.student)
            .WithOne()
            .HasForeignKey<CReport>(s => s.StudentId);
            builder.Entity<Category>()
                .HasMany(c => c.Trainings)
                .WithOne(t => t.Category)
                .HasForeignKey(t => t.CategoryId);
            builder.Entity<Application>()
                .HasKey(a => new { a.StudentId, a.TrainingId });
            builder.Entity<Application>()
                .HasOne(a => a.Student)
                .WithMany(a=>a.Applications)
                .HasForeignKey(a=>a.StudentId);
            builder.Entity<Application>()
                .HasOne(a => a.Training)
                .WithMany(t => t.Applications)
                .HasForeignKey(a => a.TrainingId)
                .OnDelete(DeleteBehavior.NoAction);
            builder.Entity<Training>()
                .HasMany(t => t.Students)
                .WithOne(s => s.Training)
                .HasForeignKey(s => s.TrainingId);
            builder.Entity<Company>()
                .HasMany(c => c.Trainings)
                .WithOne(t => t.Company)
                .HasForeignKey(t => t.CompanyId);
            builder.Entity<Student>()
                .HasOne(s => s.Account)
                .WithOne()
                .HasForeignKey<Student>(s => s.AccountId);
            builder.Entity<Company>()
                .HasOne(c => c.Account)
                .WithOne()
                .HasForeignKey<Company>(c => c.AccountId);
            builder.Entity<UniSupervisor>()
                .HasOne(u => u.Account)
                .WithOne()
                .HasForeignKey<UniSupervisor>(s => s.AccountId);

            builder.Entity<Account>(entity =>
            {
                entity.ToTable(name: "Users");
            });

            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("UserRoles");
            });

            builder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("UserClaims");
            });

            builder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("UserLogins");
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });
            });

            builder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable("Roles");
            });

            builder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("RoleClaims");
            });

            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("UserRoles");
                entity.HasKey(ur => new { ur.UserId, ur.RoleId });
            });
        }
    }
}
