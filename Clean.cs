using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    internal class Clean : HousingState
    {
        public override void Clear()
        {
            Console.WriteLine("You cannot clear my housing more!");
        }
    }
}
