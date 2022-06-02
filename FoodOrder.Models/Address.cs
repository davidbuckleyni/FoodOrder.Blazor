using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.Models
{
    public class Address
    {
        public int Id { get; set; }

        public string? AddressLine1 { get; set; }

        public string? AddressLine2 { get; set; }

        public string? AddressLine3 { get; set; }

        public string? AddressLine4 { get; set; }

        public string? AddressLine5 { get; set; }

        public int? Town { get; set; }

        public int? City { get; set; }
        public string? PostCode { get; set; }

        public int? CountryCode { get; set; }
        public string? MobileNumber { get; set; }

    }
}
