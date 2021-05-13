using DesignPatterns.Factory_Method.Foundational_Ingredients;
using DesignPatterns.Factory_Method.Meats;
using DesignPatterns.Factory_Method.Sauces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory_Method.Burgers
{
    public class Hamburger : Burger
    {
        public override void CreateBurger()
        {
            this.Ingredients.Add(new Bun());
            this.Ingredients.Add(new BeefPatty());
            this.Ingredients.Add(new Ketchup());
            this.Ingredients.Add(new Onion());
            this.Ingredients.Add(new Pickle());
            this.Ingredients.Add(new Bun());
        }
    }
}
