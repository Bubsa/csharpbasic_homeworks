using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_06
{
    public class Dog
    {
        public Dog(string name, string race, string color)
        {
            Name = name;
            Race = race;
            Color = color;
        }

        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }

        public string EatMethod()
        {
            return "The dog is now eating";
        }

        public string PlayMethod()
        {
            return "The dog is now playing";
        }

        public string ChaseTail()
        {
            return "The dog is now chasing its tail";
        }




    }
}
