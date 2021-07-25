using HastaneRandevuSistemi.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemi.Models
{
    public class Patient : Person
    {
        public DateTime BirthDate { get; set; }
        public DateTime DeathDate { get; set; }
        public Gender Gender { get; set; }
    }
}
