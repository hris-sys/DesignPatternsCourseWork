using System.Collections.Generic;

namespace DesignPatterns.Factory_Method
{
    public abstract class Burger
    {
        protected Burger()
        {
            this.Ingredients = new List<Ingredient>();
            this.CreateBurger();
        }

        public List<Ingredient> Ingredients { get; set; }

        public abstract void CreateBurger();

    }
}
