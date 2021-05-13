using DesignPatterns.Factory_Method.Burgers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade.Menus
{
    public class BigMenu : Menu
    {
        public BigMenu()
        {
            this.Burgers.Add(new Cheeseburger());
            this.Burgers.Add(new BigMac());
            this.Burgers.Add(new Hamburger());
        }
    }
}
