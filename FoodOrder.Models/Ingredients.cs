using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.Models
{
    public  class Ingredients
    {
        public int Id { get; set; }

        public string? ToppingName { get; set; }

        public int? DefaultQty { get; set; }

        public bool? ExtraAvaiable { get; set; }

        public decimal? Calories { get; set; }

        public int? Category { get; set; }

        public string? Description { get; set; }


        public int? Qty { get; set; }
        public decimal? Price { get; set; }
    }
}
