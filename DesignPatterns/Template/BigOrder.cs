using DesignPatterns.Facade.Menus;

namespace DesignPatterns.Template
{
    public class BigOrder : Order
    {
        public BigOrder(Menu menu) : base(menu)
        {

        }
        //maybe can enforce big menus to have 1 drink allowed?
        protected override bool WantCola()
        {
            return true;
        }

        protected override bool WantFanta()
        {
            return true;
        }

        protected override bool WantWater()
        {
            return true;
        }
        
    }
}
