using DesignPatterns.Facade.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template
{
    public class SmallOrder : Order
    {
        public SmallOrder(Menu menu) : base(menu)
        {

        }

        protected override bool WantCola()
        {
            return false;
        }

        protected override bool WantWater()
        {
            return true;
        }
    }
}
