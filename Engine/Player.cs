﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player:Creatures
    {
        
        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
    }
}
