using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    internal abstract class ThirstState
    {
        protected Thirst thirst;

        public void SetThirst(Thirst thirst)
        {
            this.thirst = thirst;
        }

        public abstract void GiveDrink(string drinkType);
    }
}
