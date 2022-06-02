using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.Models
{
    public class Toppings
    {
        public int Id { get; set; }

        public Product? Product { get; set; }
        public int? Qty { get; set; }


        public decimal Calories { get; set; }
        public string? AlerganInformation { get; set; }
        public bool? IsActive { get; set; }


    }
}
