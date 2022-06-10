using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    internal interface ICheckType
    {
        public virtual bool CheckType(string type) { return true; }
    }
}
