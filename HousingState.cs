using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    internal abstract class HousingState
    {
        protected Housing housing;

        public void SetHousing(Housing housing)
        {
            this.housing = housing;
        }

        public abstract void Clear();
    }
}
