using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    internal class Cat : Animal
    {
        public Cat() { }

        public override string GetInfo(Animal animal)
        {
            return animal.Name + " --- Hunger level: " + hunger.Level + "  Thirst level: " + thirst.Level + "  Happines level: " + happiness.Level +
                "  Housing cleanliness: " + housing.Cleanliness;
        }

        public override void Feed(string foodType)
        {

            if (foodType == "catfood")
            {
                hunger.Level = 100;
                this.hunger.Feed(foodType);
                //this.hunger.TransitionTo(new Full());
            }
            else if (foodType == "dogfood")
            {
                hunger.Level += 70;
                this.hunger.Feed(foodType);
                //this.hunger.TransitionTo(new Full());
            }
        }

        public override void GiveDrink(string drinkType)
        {

            if (drinkType == "milk")
            {
                thirst.Level = 100;
                this.thirst.GiveDrink(drinkType);
                //this.thirst.TransitionTo(new NotThirsty());
            }
            else if (drinkType == "water")
            {
                thirst.Level += 70;
                this.thirst.GiveDrink(drinkType);
                //this.thirst.TransitionTo(new NotThirsty());
            }
        }

        public override void Play(string toyType)
        {

            if (toyType == "ball")
            {
                happiness.Level = 100;
                this.happiness.Play(toyType);
                //this.happiness.TransitionTo(new Happy());
            }
            else if (toyType == "bone")
            {
                happiness.Level += 50;
                this.happiness.Play(toyType);
                //this.happiness.TransitionTo(new Happy());
            }
        }

        public override void Clear()
        {
            housing.Cleanliness = 100;
            this.housing.Clear();
        }
    }
}
