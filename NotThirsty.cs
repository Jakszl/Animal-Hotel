using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    internal class NotThirsty : ThirstState
    {
        
        public override void GiveDrink(string drinkType)
        {
            Console.WriteLine("You cannot give me more drink!");
        }
    }
}
