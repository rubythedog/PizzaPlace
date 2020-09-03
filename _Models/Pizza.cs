﻿using System;

namespace PizzaPlace.Models
{
    public enum Spiciness
    {
        None,
        Spicy,
        Hot
    }

    public class Pizza
    {
        public Pizza(int id, string name, decimal price,
            Spiciness spiciness)
        {
            this.Id = id;
            this.Name = name ?? throw new ArgumentNullException(nameof(name), "A pizza needs a name!");
            this.Price = price;
            this.Spiciness = spiciness;
        }
        public int Id { get; }
        public string Name { get; }
        public decimal Price { get; }
        public Spiciness Spiciness { get; }
    }
}