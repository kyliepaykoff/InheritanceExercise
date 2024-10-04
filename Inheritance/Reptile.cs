using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile() 
        { 
            IsAlive = true;
            Age = 11;
            LegCount = 4;
            LandSeaAir = "Sea";
        
        
        
        }

        public bool IsColdBlooded { get; set; } 
        public bool IsScaly { get; set; }
        public string Habitat { get; set; }
        public string HerbOmniCarni { get; set; }
    }
}
