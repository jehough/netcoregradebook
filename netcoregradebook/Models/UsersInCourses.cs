using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace netcoregradebook.Models
{
    public class UsersInCourses
    {

        public int UserID { get; set; }
        public int CourseId { get; set; }

        [ForeignKey ("AppUserId")]
        public AppUser AppUser { get; set; }
        public Course Course { get; set; }
    }
}
