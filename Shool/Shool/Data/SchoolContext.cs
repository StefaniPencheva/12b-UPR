using Microsoft.EntityFrameworkCore;
using Shool.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shool.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() { }

        public SchoolContext(DbContextOptions options)
            : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<StudentSubject> StudentSubjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBulder)
        {
            if (!optionsBulder.IsConfigured)
            {
                optionsBulder
                    .UseSqlServer(Configuration.ConnectionString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentSubject>().HasKey(x => new { x.StudentId, x.SubjectId });
        }
    }
}
