using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public abstract class MenuItem
    {
        private string _name;
        private decimal _price;

        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }

        public decimal Price
        {
            get { return _price; }
            private set { _price = value; }
        }

        public MenuItem(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public abstract string GetInfo();
    }
}
