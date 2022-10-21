using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Data.Models
{
    public class Student
    { 

        public Student()
        {
            this.StudentCourses = new HashSet<StudentCourse>();
            this.Homeworks = new HashSet<Homework>();
        }

        public int Id { get; set; }


        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [MinLength(10)]
        [MaxLength(10)]


        public string PhoneNumber { get; set; }
        [Required]


        public DateTime RegisteredOn { get; set; }
        [Required]
        public DateTime Birthday { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }
        public ICollection<Homework> Homeworks { get; set; }
    }
}
