using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    internal class Happiness
    {
        private HappinessState happinessState = null;

        public int Level { get; set; }
        public string ToyType { get; set; }

        public Happiness(HappinessState happinessState)
        {
            this.TransitionTo(happinessState);
        }

        public void TransitionTo(HappinessState happinessState)
        {
            this.happinessState = happinessState;
            this.happinessState.SetHappiness(this);
        }

        public void Play(string toyType)
        {
            this.happinessState.Play(toyType);
        }
    }
}
