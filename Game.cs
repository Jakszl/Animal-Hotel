using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AnimalHotel
{
    internal class Game
    {

        private List<Animal> pets;


        public bool Time()
        {
            bool afterDay = false;
            for(int i = 0; i >= 10; i++)
            {
                Thread.Sleep(1000);  
            }
            afterDay = true;
            return afterDay;
        }

        public string NextDay(List<Animal> pets)
        {
            if (Time())
            {
                Console.WriteLine("Day has ended! Prepare for next day!");
                foreach(var animal in pets)
                {
                    animal.hunger.Level -= 30;
                    animal.hunger.TransitionTo(new Hungry());
                    animal.thirst.Level -= 30;
                    animal.thirst.TransitionTo(new Thirsty());
                    animal.happiness.Level -= 30;
                    animal.happiness.TransitionTo(new Sad());
                    animal.housing.Cleanliness -= 30;
                    animal.housing.TransitionTo(new Dirty());
                }
            }
            Thread.Sleep(4000);
            return "Next day!";  
        }


        public void Menu(List<Animal> pets)
        {
            
            Console.WriteLine("Choose your difficult level");
            Console.WriteLine("1. Easy - 3 pets");
            Console.WriteLine("2. Medium - 5 pets");
            Console.WriteLine("3. Hard - 7 pets");

            char choice = Console.ReadKey();
            switch(choice)
            {
                case '1':
                    {
                        
                    }
                    
            }
        }
    }
}
