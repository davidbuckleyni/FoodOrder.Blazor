using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.Models
{
    public class Menus
    {
        public int Id { get; set; }

        public bool? IsBreakFastMenu { get; set; }

        public bool? IsBreakLunchMenu { get; set; }

        public bool? IsBreakEveningMenu { get; set; }

        public List<MenuItems> MenuItems { get; set; }





    }
}
