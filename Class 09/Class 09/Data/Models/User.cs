using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class User: Base_entity
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; } // Go stavame date time za da imame referenca koga sme rodeni za da ne morame da stavame int
        
        public int CardNumber { get; set; } // Card number moze da bide koristen kao Username
        public bool IsSubscriptionExpired { get; set; }
        public DateTime SubscriptionExpiredTime { get; set; } // Ova e za edno pole da imas za koga ti istekuva
    }
}
