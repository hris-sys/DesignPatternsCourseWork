using DesignPatterns.Facade.Menus;

namespace DesignPatterns.Facade.Restaurants
{
    public abstract class Restaurant
    {
        public abstract Menu CreateKidsMenu();

        public abstract Menu CreateMediumMenu();

        //maybe make the command pattern list the arg before sending them to the menu creation
        public abstract Menu CreateBigMenu(params string[] arg);
    }
}
