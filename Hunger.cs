using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    internal class Hunger
    {
        private HungerState hungerState = null;

        public int Level { get; set; }
        public string FoodType { get; set; }

        public Hunger(HungerState hungerState)
        {
            this.TransitionTo(hungerState);
        }

        public void TransitionTo(HungerState hungerState)
        {
            this.hungerState = hungerState;
            this.hungerState.SetHunger(this);
        }

        public void Feed(string foodType)
        {
            this.hungerState.Feed(foodType);
        }
    }
}
