using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    internal class Sad : HappinessState
    {
        public override void Play(string toyType)
        {
            if(toyType != null)
            {
                if(happiness.Level >= 100)
                    this.happiness.TransitionTo(new Happy());
            }
        }
    }
}
