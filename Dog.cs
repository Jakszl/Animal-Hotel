using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    internal class Dog : Animal, IActions
    {

        public Dog(string aName, string aType) 
        {
            Name = aName;
            Type = aType;
        }

        public override string GetInfo(Animal animal)
        {
            return animal.Name + " " + animal.Type + " --- Hunger level: " + hunger.Level + "  Thirst level: " + thirst.Level + "  Happines level: " + happiness.Level +
                "  Housing cleanliness: " + housing.Cleanliness;
        }

        public override void Feed(string foodType)
        {
            
            if (foodType == "dogfood")
            {
                hunger.Level = 100;
                this.hunger.Feed(foodType);               
            }
            else if (foodType == "catfood")
            {
                if (hunger.Level >= 50) 
                { 
                    hunger.Level = 100;
                    this.hunger.Feed(foodType);
                }
                else 
                {
                    hunger.Level += 50;
                    this.hunger.Feed(foodType);
                }    
            }
            else if (foodType == "rabbitfood")
            {
                if (hunger.Level >= 90)
                {
                    hunger.Level = 100;
                    this.hunger.Feed(foodType);
                }
                else
                {
                    hunger.Level += 10;
                    this.hunger.Feed(foodType);
                }
            }
        }

        public override void GiveDrink(string drinkType)
        {
            
            if (drinkType == "water")
            {
                thirst.Level = 100;
                this.thirst.GiveDrink(drinkType);
            }
            else if (drinkType == "milk")
            {
                if(thirst.Level >= 70) 
                { 
                    thirst.Level = 100;
                    this.thirst.GiveDrink(drinkType);
                }
                else
                {
                    thirst.Level += 30;
                    this.thirst.GiveDrink(drinkType);
                }
            }
        }

        public override void Play(string toyType)
        {
            
            if (toyType == "bone")
            {
                happiness.Level = 100;
                this.happiness.Play(toyType);
            }
            else if (toyType == "ball")
            {
                if(happiness.Level >= 30) 
                { 
                    happiness.Level = 100;
                    this.happiness.Play(toyType);
                }
                else
                {
                    happiness.Level += 70;
                    this.happiness.Play(toyType);
                }
            }
            else if (toyType == "rabbitsteether")
            {
                if (happiness.Level >= 70)
                {
                    happiness.Level = 100;
                    this.happiness.Play(toyType);
                }
                else
                {
                    happiness.Level += 30;
                    this.happiness.Play(toyType);
                }
            }
        }

        public override void Clear()
        {
            housing.Cleanliness = 100;
            this.housing.Clear();
        }
    }
}
