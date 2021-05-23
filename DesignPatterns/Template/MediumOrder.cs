using DesignPatterns.Facade.Menus;

namespace DesignPatterns.Template
{
    public class MediumOrder : Order
    {
        public MediumOrder(Menu menu) : base(menu)
        {

        }
        protected override bool WantCola()
        {
            return true;
        }

        protected override bool WantFanta()
        {
            return false;
        }

        protected override bool WantWater()
        {
            return false;
        }
    }
}
