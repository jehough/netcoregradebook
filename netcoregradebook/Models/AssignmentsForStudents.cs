using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoregradebook.Models
{
    public class AssignmentsForStudents
    {
        public int Grade { get; set; }

        public int UserId { get; set; }
        public int AssignmentId { get; set; }

        public AppUser AppUser { get; set; }
        public Assignment Assignment { get; set; }
    }
}
