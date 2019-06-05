using System.Collections.Generic;
namespace Konstruktory_2
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()//default constructor
        {
            Orders = new List<Order>();
        }
        public Customer(int id):this()
        {
            //:this() odwoluje sie do pustego defaultowego constructora
            this.Id = id;
        }
        public Customer(int id, string name) : this(id)
        {//:this(id) odwoluje sie do constructora z id
            this.Name = name;
        }
        
    }
}
