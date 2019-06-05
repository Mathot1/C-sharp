using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktory_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "Jacek");
            var order = new Order();
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            customer.Id = 10;
            customer.Name = "hoi";
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}
