using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace netcoregradebook.Models
{
    public class AppUserModel : IdentityUser
    {   
        [Key]
        public int StudentId { set; get; }
        public string FullName { set; get; }
    }
}
