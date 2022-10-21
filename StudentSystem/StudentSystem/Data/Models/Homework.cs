using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Data.Models
{
   public  class Homework
   {
      
        public int Id { get; set; }


        //[Required]
        //public string Content { get; set; }
        [Required]
        //public ContentType ContentType { get; set; }
        //[Required]
        public DateTime SubmissionTime { get; set; }
        [Required]
        public string StudentId { get; set; }
        public Student Student { get; set; }
        [Required]
        public string CourseId { get; set; }
        [Required]
        public Course Course { get; set; }
    }
}
