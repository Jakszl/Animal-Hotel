using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    internal abstract class Animal
    {
        
        public Hunger hunger = new Hunger(new Hungry());
        public Thirst thirst = new Thirst(new Thirsty());
        public Happiness happiness = new Happiness(new Sad());
        public Housing housing = new Housing(new Dirty());

        public string Name { get; set; }
        public abstract string GetInfo(Animal animal);

        public abstract void Feed(string foodType);
        public abstract void GiveDrink(string drinkType);
        public abstract void Play(string toyType);
        public abstract void Clear();
    }
}
