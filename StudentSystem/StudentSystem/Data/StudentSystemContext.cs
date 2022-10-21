using Microsoft.EntityFrameworkCore;
using StudentSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Data
{
    public class StudentSystemContext : DbContext
    {
        public StudentSystemContext() { }

        public StudentSystemContext(DbContextOptions options)
            : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses {get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Homework> Homewors { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBulder)
        //{
        //    if (!optionsBulder.IsConfigured)
        //    {
        //        optionsBulder.U .UseSqlServer(Configuration.ConnectionString);
        //    }
        //}

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
            modelBuilder.Entity<StudentCourse>().HasKey(x => new { x.StudentId, x.CourseId });
        }
    }
}
   
