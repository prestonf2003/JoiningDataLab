using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoiningDataLab
{
     class Order
    {
        public string CustomerName { get; set; }
        public string Item { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Order(string CustomerName, string Item, decimal Price, int Quantity)
        {
            this.CustomerName = CustomerName;
            this.Item = Item;
            this.Price = Price;
            this.Quantity = Quantity;
        }
        public void PrintInfo(Order Current, string Customer)
        {
            Console.WriteLine(Customer);
            Console.WriteLine("Item Price Quantity: \n");
            Console.WriteLine($"{Current.Item} {Current.Price} {Current.Quantity}");
        }
   
    }
   
}
