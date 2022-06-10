using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    internal class Full : HungerState
    {
        public override void Feed(string foodType)
        {
            Console.WriteLine("You cannot feed me more!");
        }
    }
}
