using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    internal class Animal : IActions
    {
        
        public Hunger hunger = new Hunger(new Hungry());
        public Thirst thirst = new Thirst(new Thirsty());
        public Happiness happiness = new Happiness(new Sad());
        public Housing housing = new Housing(new Dirty());

        public string Name { get; set; }
        public string Type { get; set; }

        public virtual void Clear()
        {
            throw new NotImplementedException();
        }

        public virtual void Feed(string foodType)
        {
            throw new NotImplementedException();
        }

        public virtual string GetInfo(Animal animal)
        {
            throw new NotImplementedException();
        }

        public virtual void GiveDrink(string drinkType)
        {
            throw new NotImplementedException();
        }

        public virtual void Play(string toyType)
        {
            throw new NotImplementedException();
        }
        /*

        public abstract string GetInfo(Animal animal);
        public abstract void Feed(string foodType);
        public abstract void GiveDrink(string drinkType);
        public abstract void Play(string toyType);
        public abstract void Clear();
        */
    }
}
