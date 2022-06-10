using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    internal class Housing
    {
        private HousingState housingState = null;

        public int Cleanliness { get; set; }

        public Housing(HousingState housingState)
        {
            this.TransitionTo(housingState);
        }

        public void TransitionTo(HousingState housingState)
        {
            this.housingState = housingState;
            this.housingState.SetHousing(this);
        }

        public void Clear()
        {
            this.housingState.Clear();
        }
    }
}
