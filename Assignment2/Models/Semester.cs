using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class Semester
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Semester> Semesters { get; set; }
    }
}
