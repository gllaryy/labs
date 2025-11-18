using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class Order 
    {
        private static int _lastorderId = 100;
        public int Id { get; private set; }
        public int TableNumber { get; private set; }
        public OrderStatus Status { get; private set; }

        private List<MenuItem> _items;

        public Order (int table)
        {
            Id = ++_lastorderId;
            TableNumber = table;
            Status = OrderStatus.New;
            _items = new List<MenuItem>();
        }

        public void AddItem(MenuItem item)
        {
            _items.Add(item);
        }

        public decimal GetTotal()
        {
            decimal sum = 0;
            foreach (var item in _items)
            {
                sum += item.Price;
            }
            return sum;
        }

        public void ChangeStatus(OrderStatus newStatus)
        {
            Status = newStatus;
        }

        public List<MenuItem> GetItems()
        {
            return _items;
        }

        public override string ToString()
        {
            return $"ID: {Id} | Стіл: {TableNumber} | Статус: {Status} | Сума: {GetTotal()} грн";
        }
    }
}
