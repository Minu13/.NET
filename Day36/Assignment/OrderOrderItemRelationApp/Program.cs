using OrderOrderItemRelationApp.Models;

namespace OrderOrderItemRelationApp
{
    internal class Program
    {
        static void Main(string[] args)

        {
            CaseStudy1();
        }

        private static void CaseStudy1()
        {
            Order order1 = new Order(1001, "Maya", DateTime.Now);
            order1.AddItem(new OrderItem { ItemId = 1, ItemName = "Book", Price = 50, Quantity = 5 });
            order1.AddItem(new OrderItem { ItemId = 2, ItemName = "Pen", Price = 10, Quantity = 3 });

            PrintDetails(order1);
        }

        private static void PrintDetails(Order order)
        {
            Console.WriteLine($"Order ID: {order.OrderId}, Customer Name: {order.CustomerName}, Order Date: {order.OrderDate}");

            Console.WriteLine("Items:");
            foreach (OrderItem item in order.OrderItems)
            {
                Console.WriteLine($"  Item ID: {item.ItemId}, Item Name: {item.ItemName}, Price: {item.Price}, Quantity: {item.Quantity}, Total Price: {item.TotalPrice}");
            }

            Console.WriteLine($"Total Amount: {order.TotalAmount}");
        }
    }
}

