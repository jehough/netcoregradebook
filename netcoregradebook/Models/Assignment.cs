using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace netcoregradebook.Models
{
    public class Assignment
    {
        [Key]
        public int AssignmentId { get; set; }
        public string Name { get; set; }
        public DateTime Due { get; set; }
        public int MaxPoints { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
