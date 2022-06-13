using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AnimalHotel
{
    internal class Functions
    {
        public int MaxTime { get; set; }
        public int MaxDays { get; set; }
        public bool AfterDay { get; set; } = false;

        public string RemoveLettersFromString(string str)
        {
            str = Regex.Replace(str, "[^.0-9]", "");
            return str;
        }

        public bool CheckTime(DateTime start, DateTime end, TimeSpan ts)
        {
            end = DateTime.Now;
            ts = (end - start);
            if (ts.TotalMilliseconds >= MaxTime)
                AfterDay = true;
            return AfterDay;
        }

        public bool CheckIfStringContainsDigit(string str)
        {
            bool containsInt = str.Any(char.IsDigit);
            return containsInt;
        }

        public bool CheckString(string str)
        {
            bool isStringOkay = false;
            if(str == "" || str.Length > 1 || !CheckIfStringContainsDigit(str))
            {
                Console.WriteLine("You have choosen wrong action! Please try again\n");
                isStringOkay = true;
            }
            return isStringOkay;
        }

        public bool CheckIfPetIsValid(int choice, int petsNumber)
        {
            bool isValid = false;
            if(choice > petsNumber || choice <= 0)
            {
                Console.WriteLine("This pet doesn't exist! Please try again and choose another one!");
                isValid = true;
            }
            return isValid;
        }
    }
}
