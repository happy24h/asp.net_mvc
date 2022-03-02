using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class Test
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public double TheoryMark { get; set; }
        public double PracticeMark { get; set; }
        public double AssignmentMark { get; set; }

        [Display(Name = "Student")]
        public int StudentId { get; set; }

        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }
    }
}
