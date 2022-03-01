using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Football.Models
{
    public class StaffMember
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string ManagementPosition { get; set; }
        public string Description { get; set; }
        public string PhotoPath { get; set; }
    }
}
