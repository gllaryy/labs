namespace RestaurantSystem
{
    public class Program
    {
        static void Main()
        {
            Restaurant restaurant = new Restaurant();

            restaurant.AddToMenu(new Dish("Солянка", 110, "Перше"));
            restaurant.AddToMenu(new Dish("Вареники з капустою", 90, "Друге"));
            restaurant.AddToMenu(new Dish("Цезар", 140, "Салат"));
            restaurant.AddToMenu(new Drinks("Кава", 55, 200, false));
            restaurant.AddToMenu(new Drinks("Вино", 150, 500, true));
            restaurant.AddToMenu(new Drinks("Молочний коктель", 100, 300, false));

            restaurant.PrintMenu();

            Order order = restaurant.CreateOrder(12);
            Console.WriteLine($"\n---Створено замовлення для столика №{order.TableNumber}. ID = {order.Id}---");

            order.AddItem(restaurant.Menu[0]);
            Console.WriteLine("Додано позицію: " + restaurant.Menu[0].Name);
            order.AddItem(restaurant.Menu[2]);
            Console.WriteLine("Додано позицію: " + restaurant.Menu[2].Name);
            order.AddItem(restaurant.Menu[4]);
            Console.WriteLine("Додано позицію: " + restaurant.Menu[4].Name);

            Console.WriteLine("Сума замовлення: " + order.GetTotal() + " грн");


            Console.WriteLine("Статус замовлення: " + order.Status);

            order.ChangeStatus(OrderStatus.InProgress);
            Console.WriteLine("> Змінено статус: " + order.Status);

            order.ChangeStatus(OrderStatus.Ready);
            Console.WriteLine("> Змінено статус: " + order.Status);

            order.ChangeStatus(OrderStatus.Paid);
            Console.WriteLine("> Змінено статус: " + order.Status);

            Console.WriteLine("\n--- Напої у замовленні ---");
            foreach (var item in order.GetItems())
            {
                if (item is Drinks drink)
                {
                    string alcoholText;
                    if (drink.IsAlcoholic)
                    {
                        alcoholText = "алкогольний";
                    }
                    else
                    {
                        alcoholText = "без алкоголю";
                    }
                    Console.WriteLine($"Напій: {drink.Name}, обʼєм: {drink.VolumeMl} мл, {alcoholText}");
                }
            }

            Order order2= restaurant.CreateOrder(3);
            Console.WriteLine($"\n---Створено замовлення для столика №{order.TableNumber}. ID = {order.Id}---");
            order.AddItem(restaurant.Menu[1]);
            Console.WriteLine("Додано позицію: " + restaurant.Menu[1].Name);
            order.AddItem(restaurant.Menu[5]);
            Console.WriteLine("Додано позицію: " + restaurant.Menu[5].Name);

            Console.WriteLine("Сума замовлення: " + order.GetTotal() + " грн");


            Console.WriteLine("Статус замовлення: " + order.Status);

            order.ChangeStatus(OrderStatus.InProgress);
            Console.WriteLine("> Змінено статус: " + order.Status);

            order.ChangeStatus(OrderStatus.Ready);
            Console.WriteLine("> Змінено статус: " + order.Status);

            order.ChangeStatus(OrderStatus.Paid);
            Console.WriteLine("> Змінено статус: " + order.Status);

            Console.WriteLine("\n--- Напої у замовленні ---");
            foreach (var item in order.GetItems())
            {
                if (item is Drinks drink)
                {
                    string alcoholText;
                    if (drink.IsAlcoholic)
                    {
                        alcoholText = "алкогольний";
                    }
                    else
                    {
                        alcoholText = "без алкоголю";
                    }
                    Console.WriteLine($"Напій: {drink.Name}, обʼєм: {drink.VolumeMl} мл, {alcoholText}");
                }
            }


            restaurant.PrintOrders();
        }
      
    }
}
