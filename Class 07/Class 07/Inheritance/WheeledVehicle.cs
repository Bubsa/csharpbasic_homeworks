using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class WheeledVehicle : Vehicle
    {
        // public int Id { get; set; } Ako mu napravis hover ke vidis deka pishuva deka nema potreba da go imas ova property poso vekje go nasleduvas

        public int Wheels { get; set; }

        public WheeledVehicle(int id, string model, string type, int wheels)
            : base(id, model,type)
        {
            Wheels = wheels;

        }

        public WheeledVehicle(string model)
            : base (10, model, "Type")
        {
            
        }
    }
}
