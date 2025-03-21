using Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Movie: Base_entity
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public string Language { get; set; }
        public bool IsAvailable  { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Length { get; set; } // Dolzina vo minuti
        public int AgeRestriction { get; set; }
        public int Quantity { get; set; }

    }
}
