using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    internal interface IActions
    {
        public string GetInfo(Animal animal);
        public void Feed(string foodType);
        public void GiveDrink(string drinkType);
        public void Play(string toyType);
        public void Clear();
    }
}
