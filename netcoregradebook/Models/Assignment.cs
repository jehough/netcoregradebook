using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace netcoregradebook.Models
{
    public class Assignment
    {
        [Key]
        [Required]
        public int AssignmentId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime Due { get; set; }
        [Required]
        public int MaxPoints { get; set; }


        
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
