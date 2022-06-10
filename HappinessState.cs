using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    internal abstract class HappinessState
    {
        protected Happiness happiness;

        public void SetHappiness(Happiness happiness)
        {
            this.happiness = happiness;
        }

        public abstract void Play(string toyType);
    }
}
