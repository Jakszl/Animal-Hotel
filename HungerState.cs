using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    internal abstract class HungerState
    {
        protected Hunger hunger;

        public void SetHunger(Hunger hunger)
        {
            this.hunger = hunger;
        }

        public abstract void Feed(string foodType);
    }
}
