using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Motorcycle: WheeledVehicle
    {
        public string Color { get; set; }

        public Motorcycle()
            :base ("Yamaha")
        {
            
        }

        public override void Drive()
        {
            Console.WriteLine("Im driving a motorcycle");
        }
    }
}
