using Shool.Data.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shool.Data.Models
{
    public class Subject
    {
        public Subject()
        {
            this.StudentsSubjects = new HashSet<StudentSubject>();
        }
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [MinLength(3)]

        public string Name { get; set; }

        [Required]
        public SubjectType SubjectType { get; set; }

        [Range(typeof(double), "2", "6")]

        public double AverageGrade { get; set; }

        public DateTime ReceivedOn { get; set; }
        public ICollection<StudentSubject> StudentsSubjects { get; set; }
    }
}
