using System;

namespace AnimalHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //hunger.Feed("beniz");

            var dog = new Dog();
            var cat = new Cat();
            dog.Name = "Azor";
            cat.Name = "Kicia";

            //dog.hunger.Feed("karm");
            //dog.GiveDrink("wate");

            
            Console.WriteLine(cat.GetInfo(cat));

            cat.GiveDrink("water");
            Console.WriteLine(cat.GetInfo(cat));
            cat.GiveDrink("water");
            Console.WriteLine(cat.GetInfo(cat));
            cat.GiveDrink("water");

        }
    }
}
