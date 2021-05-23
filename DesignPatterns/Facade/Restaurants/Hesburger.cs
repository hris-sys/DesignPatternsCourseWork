using DesignPatterns.Facade.Menus;

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
