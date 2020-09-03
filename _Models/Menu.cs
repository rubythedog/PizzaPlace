using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Models
{
    public class Menu
    {
        public List<Pizza> available_pizzas { get; set; } = new List<Pizza>();

        public Pizza GetPizza(int id)
        {
            return available_pizzas.SingleOrDefault(pizza => pizza.Id == id);
        }
    }
}
