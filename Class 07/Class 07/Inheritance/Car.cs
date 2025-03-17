using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Car : WheeledVehicle
    {
        public int Doors { get; set; }
        public string Color { get; set; }

        public PetrolType PetrolType { get; set; }
        public Car(string model, string type, int wheels, string color, PetrolType petrol)
            : base(1, model, type, wheels)
        {
            Color = color;
            Doors = 5;
        }

        public override void Drive()
        {
            base.Drive();
        }
    }
}
