using HastaneRandevuSistemi.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemi.Models
{
   public class Telecommunication:Person
    {
        public CommunicationType CommunicationType { get; set; }
        public int AreaCode { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

    }
}
