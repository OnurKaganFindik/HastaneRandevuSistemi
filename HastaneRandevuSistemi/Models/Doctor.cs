using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemi.Models
{
    public class Doctor : Person
    {
        public string Title { get; set; }
        public string Profession { get; set; }
        public int DepartmentId { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}
