using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace netcoregradebook.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }

        public ICollection<Assignment> Assignments { get; set; }
        public ICollection<Category> Categories { get; set; }
        public virtual ICollection<UsersInCourses> UsersinCourses { get; set; }

        public int YearId { get; set; }
        public Year Year { get; set; }
    }
}
