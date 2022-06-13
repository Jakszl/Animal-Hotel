using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    internal class Cat : Animal, IActions
    {
        public Cat(string aName, string aType) 
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

            if (foodType == "catfood")
            {
                hunger.Level = 100;
                this.hunger.Feed(foodType);
            }
            else if (foodType == "dogfood")
            {
                if (hunger.Level >= 30)
                {
                    hunger.Level = 100;
                    this.hunger.Feed(foodType);
                }
                else
                {
                    hunger.Level += 70;
                    this.hunger.Feed(foodType);
                }
            }
            else if (foodType == "rabbitfood")
            {
                if (hunger.Level >= 70)
                {
                    hunger.Level = 100;
                    this.hunger.Feed(foodType);
                }
                else
                {
                    hunger.Level += 30;
                    this.hunger.Feed(foodType);
                }
            }
        }

        public override void GiveDrink(string drinkType)
        {

            if (drinkType == "milk")
            {
                thirst.Level = 100;
                this.thirst.GiveDrink(drinkType);
            }
            else if (drinkType == "water")
            {
                if (thirst.Level >= 30)
                {
                    thirst.Level = 100;
                    this.thirst.GiveDrink(drinkType);
                }
                else
                {
                    thirst.Level += 70;
                    this.thirst.GiveDrink(drinkType);
                }
            }
        }

        public override void Play(string toyType)
        {

            if (toyType == "ball")
            {
                happiness.Level = 100;
                this.happiness.Play(toyType);
            }
            else if (toyType == "bone")
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
            else if (toyType == "rabbitsteether")
            {
                if (happiness.Level >= 30)
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
        }

        public override void Clear()
        {
            housing.Cleanliness = 100;
            this.housing.Clear();
        }
    }
}
