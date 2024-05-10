using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    internal class Player
    {
        internal int CurrentHitPoints { get; set; }
        internal int MaximumHitPoints { get; set; }
        internal int Gold { get; set; }
        internal int ExperiencePoints { get; set; }
        internal int Level { get; set; }
    }
}
