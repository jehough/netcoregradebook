using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace netcoregradebook.Models
{
    public class AppUser : IdentityUser
    {   
        [Key]
        public int UserId { set; get; }
        public string FullName { set; get; }

        public virtual ICollection<UsersInCourses> UsersInCourses { get; set; }
        public virtual ICollection<AssignmentsForStudents> AssignmentsForStudents { get; set; }
    }
}
