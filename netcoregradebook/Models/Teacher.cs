using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace netcoregradebook.Models
{
    public class Teacher
    {   
        [Key]
        public int TeacherId { get; set; }
        public string FullName { get; set; }
    }
}
