using DesignPatterns.Facade.Menus;
using DesignPatterns.Factory_Method.Burgers;
using DesignPatterns.Factory_Method.Drinks;

namespace DesignPatterns.Facade.Restaurants
{
    public class Hesburger : Restaurant
    {
        public override Menu CreateBigMenu()
        {
            var bigMenu = new BigMenu();

            //cola,water

            return bigMenu;
        }

        public override Menu CreateKidsMenu()
        {
            var kidsMenu = new KidsMenu();

            //water

            return kidsMenu;
        }

        public override Menu CreateMediumMenu()
        {
            var mediumMenu = new MediumMenu();

            //cola + fanta

            return mediumMenu;
        }
    }
}
