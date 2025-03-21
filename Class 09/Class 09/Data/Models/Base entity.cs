using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Base_entity
    {
        public int Id { get; set; } // Ovie dve gi zemame poso se zaednicki propertinja
        public DateTime CreatedOn { get; set; }
        public Base_entity() // Ova go praime da gi nasleduvaat dvete klasi
        {
            CreatedOn = DateTime.Now;
        }
    }
}
