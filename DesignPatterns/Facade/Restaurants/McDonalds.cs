using DesignPatterns.Facade.Menus;
using DesignPatterns.Factory_Method.Burgers;
using DesignPatterns.Factory_Method.Drinks;
using System;

namespace DesignPatterns.Facade.Restaurants
{
    public class McDonalds : Restaurant
    {
        public override Menu CreateBigMenu(params string[] arg)
        {
            var bigMenu = new Menu();


            //command pattern
            bigMenu.Burgers.Add(new BigMac());
            bigMenu.Burgers.Add(new Hamburger());
            bigMenu.Burgers.Add(new Cheeseburger());
            bigMenu.Drinks.Add(new CocaCola());
            bigMenu.Drinks.Add(new Fanta());

            return bigMenu;
        }

        public override Menu CreateKidsMenu()
        {
            var kidsMenu = new Menu();

            kidsMenu.Burgers.Add(new Cheeseburger());
            kidsMenu.Drinks.Add(new Water());

            return kidsMenu;
        }

        public override Menu CreateMediumMenu()
        {
            var mediumMenu = new Menu();

            mediumMenu.Burgers.Add(new Hamburger());
            mediumMenu.Burgers.Add(new Cheeseburger());
            mediumMenu.Drinks.Add(new CocaCola());
            mediumMenu.Drinks.Add(new Fanta());

            return mediumMenu;
        }
    }
}
