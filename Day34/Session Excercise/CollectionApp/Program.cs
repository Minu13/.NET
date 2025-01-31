using CollectionApp.Models;
using System.Collections;

namespace CollectionApp
{
     class Program
    {
        static void Main(string[] args)
        {
            var basket = new ArrayList();
            basket.Add(new OrderItem(1, "Milk", 30, 3));
            basket.Add(new OrderItem(2, "Biscut", 10, 3));
            basket.Add(new OrderItem(3, "Pen", 20, 4));
            basket.Add(new OrderItem(4, "Pencil", 30, 5));

            PrintBasketDetails(basket);


        }

        private static void PrintBasketDetails(ArrayList basket)
        {
            double totalCost = 0;
            foreach (var item in basket)
            {
                OrderItem orderItem = (OrderItem)item;
                Console.WriteLine($"Name is {orderItem.Name} quantity is {orderItem.Quantity} Unit Price is {orderItem.UnitPrice} ");
                totalCost += orderItem.LineItemcost;

            }
            Console.WriteLine("Amount to payed is : "+totalCost);
        }
    }
}
