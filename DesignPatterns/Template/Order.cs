using DesignPatterns.Facade.Menus;
using DesignPatterns.Factory_Method;
using DesignPatterns.Factory_Method.Drinks;
using System.Collections.Generic;
using System;
using System.Diagnostics;

namespace DesignPatterns.Template
{
    public abstract class Order
    {
        protected Order(Menu menu)
        {
            this.Menu = menu;
            this.Burgers = menu.Burgers;
        }

        protected List<Burger> Burgers { get; set; }

        protected Menu Menu { get; set; }

        protected abstract bool WantWater();

        protected abstract bool WantCola();

        protected abstract bool WantFanta();

        public void MakeOrder()
        {
            Console.WriteLine("Finalyzing order...");

            if (WantWater())
            {
                this.Menu.Drinks.Add(new Water());
            }

            if (WantFanta())
            {
                this.Menu.Drinks.Add(new Fanta());
            }

            if (WantCola())
            {
                this.Menu.Drinks.Add(new CocaCola());
            }
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine($"Order finalyzed! Enjoy");

            this.Menu.ToString();
        }

        public void AddExtraBurger(Burger burger)
        {
            this.Burgers.Add(burger);
        }

        public void RemoveBurger(Burger burger)
        {
            foreach (Burger item in this.Burgers)
            {
                if (item.GetType().FullName == burger.GetType().FullName)
                {
                    this.Burgers.Remove(item);
                    return;
                }
            }
            Console.WriteLine("Such burger doesn't exist in the order...");
        }

    }
}
