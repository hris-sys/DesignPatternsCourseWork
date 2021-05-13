using DesignPatterns.Facade.Menus;

namespace DesignPatterns.Template
{
    public class BigOrder : Order
    {
        public BigOrder(Menu menu) : base(menu)
        {

        }
        protected override bool WantCola()
        {
            return true;
        }

        protected override bool WantWater()
        {
            return true;
        }
        
    }
}
