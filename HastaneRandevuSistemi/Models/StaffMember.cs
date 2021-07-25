using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemi.Models
{
    public class StaffMember:Person
    {
        public string Department { get; set; }
        public char Grade { get; set; }
    }
}
