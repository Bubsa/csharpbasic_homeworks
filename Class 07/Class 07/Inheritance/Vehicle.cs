using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }

        public Vehicle(int id, string model, string type)
        {
            Id = id;
            Model = model;
            Type = type;
        }

        public virtual void Drive()
        {
            Console.WriteLine("I'm driving");
        }
    }
}
