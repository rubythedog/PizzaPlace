using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Models
{
    public class ShoppingCart
    {
        public Customer customer { get; set; } = new Customer();
        public List<int> orders { get; set; } = new List<int>();

        public bool HasPaid { get; set; } = false;
    

        public void Add(int pizzaId)
        {
            orders.Add(pizzaId);
        }

        public void RemoveAt(int index)
        {
            orders.RemoveAt(index);
        }
    }
}
