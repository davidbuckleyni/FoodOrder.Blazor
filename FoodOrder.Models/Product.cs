using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.Models
{
    public class Product
    {
        public int Id { get; set; }

        public int? Category { get; set; }

        public string? Description { get; set; }

       public List<Ingredients>? Ingredients { get;set;}


        public List<Toppings>? Toppings { get; set; }
    }
}
