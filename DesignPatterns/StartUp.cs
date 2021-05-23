namespace DesignPatterns
{
    using DesignPatterns.Factory_Method.Burgers;
    using DesignPatterns.Template;
    using Facade.Restaurants;


    using System;

    public class StartUp
    {
        public static void Main()
        {
            var brg = new BigMac();
            var mcdonalds = new McDonalds();
            var hesburger = new Hesburger();

            var menuMc = mcdonalds.CreateBigMenu();
            var menuHes = hesburger.CreateMediumMenu();

            var mediumOrder = new SmallOrder(menuMc);
            mediumOrder.MakeOrder();

            //scenario 1
            // create a mcDonalds or Hesburger
            // create a specified menu from the restaurant mcD.createSomeMenu()
            // create an order -> can contain extra water, fanta, extra burger or remove a burger
            //finalize the order
        }
    }
}
