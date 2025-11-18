using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class Dish : MenuItem
    {
        public string Category { get; private set; }

        public Dish(string name, decimal price, string category) : base (name, price)
        {
            Category = category;
        }

        public override string GetInfo()
        {
            return $"{Name} ({Category}) -- {Price} грн";
        }

    }
}
