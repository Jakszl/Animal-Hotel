using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    internal class Thirst
    {
        private ThirstState thirstState = null;

        public int Level { get; set; }
        public string DrinkType { get; set; }

        public Thirst (ThirstState thirstState)
        {
            this.TransitionTo(thirstState);
        }

        public void TransitionTo(ThirstState thirstState)
        {
            this.thirstState = thirstState;
            this.thirstState.SetThirst(this);
        }

        public void GiveDrink(string drinkType)
        {
            this.thirstState.GiveDrink(drinkType);
        }
    }
}
