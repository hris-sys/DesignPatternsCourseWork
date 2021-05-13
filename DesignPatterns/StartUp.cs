namespace DesignPatterns
{
    using DesignPatterns.Facade.Restaurants;
    using DesignPatterns.Factory_Method;
    using DesignPatterns.Factory_Method.Burgers;
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var mcdonalds = new McDonalds();
            var hesburger = new Hesburger();

            var menuMc = mcdonalds.CreateBigMenu();
            var menuHes = hesburger.CreateMediumMenu();

            Console.WriteLine(hesburger.GetType().Name);
            Console.WriteLine(new string('-', 10));
            menuHes.Burgers.ForEach(bur => Console.WriteLine(bur.GetType().Name));
            menuHes.Drinks.ForEach(drink => Console.WriteLine(drink.GetType().Name));

            Console.WriteLine();
            Console.WriteLine(mcdonalds.GetType().Name);
            Console.WriteLine(new string('-', 10));
            menuMc.Burgers.ForEach(bur => Console.WriteLine(bur.GetType().Name));
            menuMc.Drinks.ForEach(drink => Console.WriteLine(drink.GetType().Name));
        }
    }
}
