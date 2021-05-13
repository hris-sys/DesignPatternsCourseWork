using DesignPatterns.Facade.Menus;
using DesignPatterns.Factory_Method.Burgers;
using DesignPatterns.Factory_Method.Drinks;

namespace DesignPatterns.Facade.Restaurants
{
    public class Hesburger : Restaurant
    {
        public override Menu CreateBigMenu(params string[] arg)
        {
            var bigMenu = new Menu();

            bigMenu.Burgers.Add(new Cheeseburger());
            bigMenu.Burgers.Add(new BigMac());
            bigMenu.Drinks.Add(new CocaCola());

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
            mediumMenu.Drinks.Add(new CocaCola());
            mediumMenu.Drinks.Add(new Fanta());

            return mediumMenu;
        }
    }
}
