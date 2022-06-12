﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    internal class Dog : Animal, IActions
    {

        public Dog() { }

        public override string GetInfo(Animal animal)
        {
            return animal.Name + " --- Hunger level: " + hunger.Level + "  Thirst level: " + thirst.Level + "  Happines level: " + happiness.Level +
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
            
            if (drinkType == "water")
            {
                thirst.Level = 100;
                this.thirst.GiveDrink(drinkType);
            }
            else if (drinkType == "milk")
            {
                if(thirst.Level >= 30) 
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
