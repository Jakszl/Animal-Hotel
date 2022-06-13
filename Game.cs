using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Text.RegularExpressions;

namespace AnimalHotel
{
    internal class Game
    {

        private Functions functions = new Functions();
        //private bool afterDay = false;
        private int dayCount = 0;
        private bool allPetsAlive = true;
        //private int maxDays = 3;
        //private int maxTime = 60000;

        

        public string NextDay(List<Animal> pets)
        {
            Console.WriteLine("\n         Day has ended! Prepare for next day!");
            Console.WriteLine("Checking state of every animal...");
            foreach(var animal in pets)
            {
                animal.hunger.Level -= 50;
                animal.hunger.TransitionTo(new Hungry());
                animal.thirst.Level -= 50;
                animal.thirst.TransitionTo(new Thirsty());
                animal.happiness.Level -= 50;
                animal.happiness.TransitionTo(new Sad());
                animal.housing.Cleanliness -= 50;
                animal.housing.TransitionTo(new Dirty());
            }
            Thread.Sleep(4000);
            functions.AfterDay = false;
            dayCount++;
            return "Next day!";  
        }


        public bool CheckNeeds(List<Animal> pets)
        {
            foreach(var animal in pets)
            {
                if (animal.hunger.Level <= 0)
                    allPetsAlive = false;
                if (animal.thirst.Level <= 0)
                    allPetsAlive = false;
                if (animal.happiness.Level <= 0)
                    allPetsAlive = false;
                if (animal.housing.Cleanliness <= 0)
                    allPetsAlive = false;
            }
            return allPetsAlive;
        }

        public void Menu(List<Animal> pets)
        {
            Console.WriteLine("Welcome to the Animal Hotel Game!\n");
            Console.WriteLine("Choose your difficult level:");
            Console.WriteLine("1. Easy --- 1 pet");
            Console.WriteLine("2. Medium --- 2 pets");
            Console.WriteLine("3. Hard --- 3 pets");

            string choiceStr = Console.ReadLine();
            while (functions.CheckString(choiceStr))
            {
                choiceStr = Console.ReadLine();
            }
            char choice = char.Parse(choiceStr);

            while(choice != '1' && choice != '2' && choice != '3' )
            {
                Console.Write("You have choosen bad difficut level! Please try again\n");
                choiceStr = Console.ReadLine();
                choice = char.Parse(choiceStr);
            }

            switch(choice)
            {
                case '1':
                    var dog = new Dog("Ares", "Dog");
                    pets.Add(dog);
                    functions.MaxTime = 30000;
                    functions.MaxDays = 3;
                    break;
                case '2':
                    var dog1 = new Dog("Ares", "Dog");
                    var cat1 = new Cat("Kicia", "Cat");
                    pets.Add(dog1);
                    pets.Add(cat1);
                    functions.MaxTime = 60000;
                    functions.MaxDays = 4;
                    break;
                case '3':
                    var dog3 = new Dog("Ares", "Dog");
                    var cat3 = new Cat("Kicia", "Cat");
                    var rabbit2 = new Rabbit("Andrzej", "Rabbit");
                    pets.Add(dog3);
                    pets.Add(cat3);
                    pets.Add(rabbit2);
                    functions.MaxTime = 90000;
                    functions.MaxDays = 5;
                    break;
            }

            //---------------------------------------------------------------------------------------------------------------------------------------//



            Console.WriteLine("                     Prepare for start!");
            Console.WriteLine("         Here is list of all pets you need to take care\n\n");

            int petsNumber = pets.Count;
            for(int i = 0; i < petsNumber; i++)
            {
                Console.WriteLine(i+1 + ". " + pets[i].GetInfo(pets[i]));
            }
            Console.WriteLine("\n         Press any button when you are ready to start!");
            Console.ReadLine();
            
            TimeSpan ts = new TimeSpan();

            do
            {
                DateTime start = DateTime.Now;
                DateTime end = DateTime.Now;
                while (!functions.CheckTime(start, end, ts))
                {
                    Console.WriteLine("\nChoose your what do you want to do: ");
                    Console.WriteLine("1 -- Feed");
                    Console.WriteLine("2 -- Give drink");
                    Console.WriteLine("3 -- Play");
                    Console.WriteLine("4 -- Clean housing");
                    Console.WriteLine("5 -- Get info about all pets");

                    functions.CheckTime(start, end, ts);
                    choiceStr = Console.ReadLine();
                    while (functions.CheckString(choiceStr))
                    {
                        choiceStr = Console.ReadLine();
                    }

                    choice = char.Parse(choiceStr);
                    functions.CheckTime(start, end, ts);

                    while (choice != '1' && choice != '2' && choice != '3' && choice != '4' && choice != '5')
                    {
                        Console.Write("You have choosen wrong action! Please try again\n");
                        choiceStr = Console.ReadLine();
                        choice = char.Parse(choiceStr);
                    }
                    functions.CheckTime(start, end, ts);
                    switch (choice)
                    {
                        case '1':
                            Console.WriteLine("Choose which number of animal you want to feed");
                            choiceStr = Console.ReadLine();
                            while (functions.CheckString(choiceStr))
                            {
                                choiceStr = Console.ReadLine();
                            }
                            int choice1 = int.Parse(functions.RemoveLettersFromString(choiceStr));
                            while(functions.CheckIfPetIsValid(choice1, petsNumber))
                            {
                                choiceStr = Console.ReadLine();
                                choice1 = int.Parse(functions.RemoveLettersFromString(choiceStr));
                            }
                            Console.WriteLine("Write type of food you want to give to animal: ");
                            Console.WriteLine("Avaliable types of food: dogfood ; catfood ; rabbitfood");
                            string foodType = Console.ReadLine();
                            pets[choice1 - 1].Feed(foodType);
                            functions.CheckTime(start, end, ts);
                            break;


                        case '2':
                            Console.WriteLine("Choose which number of animal you want to give drink");
                            choiceStr = Console.ReadLine();
                            while (functions.CheckString(choiceStr))
                            {
                                choiceStr = Console.ReadLine();
                            }
                            int choice2 = int.Parse(functions.RemoveLettersFromString(choiceStr));
                            while (functions.CheckIfPetIsValid(choice2, petsNumber))
                            {
                                choiceStr = Console.ReadLine();
                                choice2 = int.Parse(functions.RemoveLettersFromString(choiceStr));
                            }
                            Console.WriteLine("Write type of food you want to give to animal: ");
                            Console.WriteLine("Avaliable types of food: water ; milk");
                            string drinkType = Console.ReadLine();
                            pets[choice2 - 1].GiveDrink(drinkType);
                            functions.CheckTime(start, end, ts);
                            break;


                        case '3':
                            Console.WriteLine("Choose which number of animal you want to play with");
                            choiceStr = Console.ReadLine();
                            while (functions.CheckString(choiceStr))
                            {
                                choiceStr = Console.ReadLine();
                            }
                            int choice3 = int.Parse(functions.RemoveLettersFromString(choiceStr));
                            while (functions.CheckIfPetIsValid(choice3, petsNumber))
                            {
                                choiceStr = Console.ReadLine();
                                choice3 = int.Parse(functions.RemoveLettersFromString(choiceStr));
                            }
                            Console.WriteLine("Write type of toy you want to play with animal: ");
                            Console.WriteLine("Avaliable types of toys: bone ; ball ; rabbitsteether");
                            string toyType = Console.ReadLine();
                            pets[choice3 - 1].Play(toyType);
                            functions.CheckTime(start, end, ts);
                            break;


                        case '4':
                            Console.WriteLine("Choose which number of animal's housing you want to clear");
                            choiceStr = Console.ReadLine();
                            while (functions.CheckString(choiceStr))
                            {
                                choiceStr = Console.ReadLine();
                            }
                            int choice4 = int.Parse(functions.RemoveLettersFromString(choiceStr));
                            while (functions.CheckIfPetIsValid(choice4, petsNumber))
                            {
                                choiceStr = Console.ReadLine();
                                choice4 = int.Parse(functions.RemoveLettersFromString(choiceStr));
                            }
                            pets[choice4 - 1].Clear();
                            functions.CheckTime(start, end, ts);
                            break;


                        case '5':
                            for (int i = 0; i < petsNumber; i++)
                            {
                                Console.WriteLine(i + 1 + ". " + pets[i].GetInfo(pets[i]));
                            }
                            functions.CheckTime(start, end, ts);
                            break;
                    }
                    functions.CheckTime(start, end, ts);
                }
                NextDay(pets);
                if (dayCount == functions.MaxDays)
                    break;
            } while (CheckNeeds(pets));

            if(dayCount == functions.MaxDays)
            {
                Console.WriteLine("\n ************************You have won!************************");
                Console.WriteLine("Congratulations you managed to take care of your animals!");
            }
            else
            {
                Console.WriteLine("\n ************************You have lost!************************");
                Console.WriteLine("Unfortunately you didn't managed to take care of your animals!");
            } 
        }
    }
}
