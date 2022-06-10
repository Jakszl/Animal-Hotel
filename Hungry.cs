using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    internal class Hungry : HungerState
    {

        public override void Feed(string foodType)
        {
            if(foodType != null) 
            { 
                if(hunger.Level >= 100)
                    this.hunger.TransitionTo(new Full());
            }
        }
    }
}
