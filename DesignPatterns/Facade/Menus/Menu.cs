using DesignPatterns.Factory_Method;
using System.Collections.Generic;
using System;

namespace DesignPatterns.Facade.Menus
{
    public abstract class Menu
    {
        protected Menu()
        {
            this.Drinks = new List<Drink>();
            this.Burgers = new List<Burger>();
        }

        public List<Drink> Drinks { get; set; }

        public List<Burger> Burgers { get; set; }

        public override string ToString()
        {
            Console.WriteLine("\nBurgers:");
            foreach (var burger in this.Burgers)
            {
                Console.Write($"{burger.GetType().Name}\n");
            }

            Console.WriteLine($"\nDrinks:");
            foreach (var drink in this.Drinks)
            {
                Console.Write($"{drink.GetType().Name}\n");
            }
            Console.WriteLine();
            return "";
        }
    }
}
