using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    internal class Happy : HappinessState
    {
        public override void Play(string toyType)
        {
            Console.WriteLine("You cannot play more with me!");
        }
    }
}
