using DesignPatterns.Factory_Method.Burgers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade.Menus
{
    public class KidsMenu : Menu
    {
        public KidsMenu()
        {
            this.Burgers.Add(new Cheeseburger());
        }
    }
}
