using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaPlace.Models;

namespace PizzaPlace.Pages
{
    public partial class PizzaOrder
    {

        // ***************************************************************************************************
        // Properties
        // ***************************************************************************************************


        protected State pizzaPlace_state { get; } = new State()
        {
            menu = new Menu
            {
                available_pizzas = new List<Pizza>
                {
                    new Pizza(1, "Pepperoni", 8.99M, Spiciness.Spicy ),
                    new Pizza(2, "Margarita", 7.99M, Spiciness.None ),
                    new Pizza(3, "Diabolo", 9.99M, Spiciness.Hot )
                }
            }
        };

        // ***************************************************************************************************
        // Methods
        // ***************************************************************************************************
        protected string PizzaPlace_SpicinessImage(Spiciness spiciness)
        {
            return $"images/{spiciness.ToString().ToLower()}.png";
        }


        // ***************************************************************************************************
        //EventHandlers
        // ***************************************************************************************************


        protected void PizzaPlace_AddToShoppingCart(Pizza pizza)
        {
            Console.WriteLine($"Added pizza {pizza.Name}");
            pizzaPlace_state.shoppingCart.Add(pizza.Id);
        }

        protected void RemoveFromBasket(int pos)
        {
            Console.WriteLine($"Removing pizza at pos {pos}");
            pizzaPlace_state.shoppingCart.RemoveAt(pos);
        }


        protected void PlaceOrder()
        {
            Console.WriteLine("Placing order");
        }

    }
}
