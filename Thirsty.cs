using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    internal class Thirsty : ThirstState
    {
        public override void GiveDrink(string drinkType)
        {
            if (drinkType != null)
            {
                if(thirst.Level >= 100)
                    this.thirst.TransitionTo(new NotThirsty());
            }
        }
    }
}
