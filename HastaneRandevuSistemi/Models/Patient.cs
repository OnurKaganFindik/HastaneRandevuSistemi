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
        public Gender Gender { get; set; }
        public List<Appointment> Appointments { get; set; }

    }
}
