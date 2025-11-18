using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class Restaurant
    {
        public List<MenuItem> Menu = new List<MenuItem>();
        public List<Order> Orders = new List<Order>();

        public void AddToMenu(MenuItem item)
        {
            Menu.Add(item);
        }

        public void PrintMenu()
        {
            Console.WriteLine("\n--- МЕНЮ РЕСТОРАНУ ---");
            int i = 1;

            foreach(var item in Menu)
            {
                Console.WriteLine($"{i}. {item.GetInfo()}");
                i++;
            }

            Console.WriteLine("----------------------");
        }


        public Order CreateOrder(int table)
        {
            Order order = new Order(table);
            Orders.Add(order);
            return order;
        }

        public void PrintOrders()
        {
            Console.WriteLine("\n--- УСІ ЗАМОВЛЕННЯ ---");

            foreach(var order in Orders)
            {
                Console.WriteLine(order);
            }
        }
    }
}
