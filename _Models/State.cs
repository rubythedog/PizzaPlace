using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Models
{
    public class State
    {
        public Menu menu { get; set; } = new Menu();

        public ShoppingCart shoppingCart { get; set; } = new ShoppingCart();

        public UI_Preferences ui_preferences { get; set; } = new UI_Preferences();
    }
}
