using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_06
{
    internal class Plane // NIKOGASH NE SE STAVA LOOPS VO KONSTRUKTOR
    {
        public Plane()
        {
            Console.WriteLine("Im CONSTRUCOTR");
        }

        public Plane(string name)
        {
            Name = name;
            SeatCapacity = 1000;
            Type = "Airbus";
            CanFly = false;
        }

        public Plane(string name, int seats, string type, string color, bool canFly) // Konstruktorot (vo zavisnost od toa koi i kolku parametri ke mu stavish) 
            // e toa sho im zadava vrednost. Obichno se default/null vrednost. Koga ke otides da go instancirash samiot objekt togas gi stavas vrednostite od konstruktorot.
            // Vo glavniot program kaj sho gi instancirash treba da gi stavas
        {
            Name = name;
            SeatCapacity = seats;
            Type = type;
            CanFly = canFly;
            Color = color;
        }

        public string Name { get; set; }
        public int SeatCapacity { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public bool CanFly { get; set; }
    }
}
