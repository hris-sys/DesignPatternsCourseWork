using DesignPatterns.Factory_Method;
using System.Collections.Generic;

namespace DesignPatterns.Facade.Menus
{
    public class Menu
    {
        public Menu()
        {
            this.Drinks = new List<Drink>();
            this.Burgers = new List<Burger>();
        }

        public List<Drink> Drinks { get; set; }

        public List<Burger> Burgers { get; set; }
    }
}
