using DesignPatterns.Facade.Menus;
using DesignPatterns.Factory_Method;
using DesignPatterns.Factory_Method.Drinks;
using System.Collections.Generic;

namespace DesignPatterns.Template
{
    public abstract class Order
    {
        protected List<Burger> _burgers;

        protected Order(Menu menu)
        {
            this.Menu = menu;
            this._burgers = new List<Burger>();
        }
        protected Menu Menu { get; set; }

        protected abstract bool WantWater();

        protected abstract bool WantCola();

        protected abstract bool WantFanta();


        protected void MakeOrder()
        {
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

            if (_burgers.Count > 0)
            {
                this.Menu.Burgers.AddRange(_burgers);
            }
        }

        //ToDo: Test whether burgers will get added after creation of some menu in the facade
        //and finish the implementation
        public void AddExtraBurger(Burger burger)
        {
            this._burgers.Add(burger);
        }

    }
}
