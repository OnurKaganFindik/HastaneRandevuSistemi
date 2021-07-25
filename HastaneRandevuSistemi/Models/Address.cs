using HastaneRandevuSistemi.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemi.Models
{
    class Address:Person    
    {
        public string AdressLine { get; set; }
        public string StreetName { get; set; }
        public string HouseName { get; set; }
        public int FlatNumber { get; set; }
        public string District { get; set; }
        public string CityOrTown { get; set; }
        public string Country { get; set; }
        public Guid PostalCode { get; set; }
        public string URL { get; set; }
        public CountryCode MyProperty { get; set; }

    }
}
 