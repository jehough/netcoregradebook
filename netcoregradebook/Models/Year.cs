using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace netcoregradebook.Models
{
    public class Year
    {
        [Key]
        public int YearId { get; set; }
        public string Name { get; set; }
        public DateTime Q1Start { get; set; }
        public DateTime Q2Start { get; set; }
        public DateTime Q3Start { get; set; }
        public DateTime Q4Start { get; set; }
        public DateTime End { get; set; }

        public List<Course> Courses { get; set; }
    }
}
