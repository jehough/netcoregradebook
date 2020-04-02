using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoregradebook.Models
{
    public class Category
    {
        public int Weight { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public List<Assignment> Assignments { get; set; }
    }
}
