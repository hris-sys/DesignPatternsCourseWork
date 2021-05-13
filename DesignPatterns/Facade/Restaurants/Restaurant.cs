using DesignPatterns.Facade.Menus;

namespace DesignPatterns.Facade.Restaurants
{
    public abstract class Restaurant
    {
        public abstract Menu CreateKidsMenu();

        public abstract Menu CreateMediumMenu();

        public abstract Menu CreateBigMenu();
    }
}
