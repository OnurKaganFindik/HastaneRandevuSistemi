using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemi.Models
{
    public class Appointment
    {
      
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }

    }
}
