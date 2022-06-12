using System;
using System.Threading;

namespace AnimalHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //hunger.Feed("beniz");

            var dog = new Dog();
            var cat = new Cat();
            var rabbit = new Rabbit();
            dog.Name = "Azor";
            cat.Name = "Kicia";
            rabbit.Name = "Ferdek";


            Timer t = new Timer(DayTimer, null, 0, 20);

            DayTimer();


        }

        private static void DayTimer(Object o)
        {
            Console.WriteLine("Timer: "+DateTime.Now);
        }
    }
}
