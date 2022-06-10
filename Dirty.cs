using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    internal class Dirty : HousingState
    {
        public override void Clear()
        {
            if(housing.Cleanliness >= 100)
                this.housing.TransitionTo(new Clean());
        }
    }
}
