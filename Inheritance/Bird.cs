﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            IsAlive = true;
            LegCount = 2;
            Age = 35;
            LandSeaAir = "Land";
        
        
        
        
        
        }

        public string Name { get; set; }
        public bool CanFly { get; set; }
        public double WingSpan { get; set; }
        public bool DoMigrate { get; set; }



    }
}
