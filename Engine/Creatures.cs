using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Creatures
    {
        public Creatures(int currentHitPoints, int maximumHitPoints)
        {
            CurrentHitPoints = currentHitPoints;
            MaximumHitPoints = maximumHitPoints;
        }
        public int MaximumHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }
    }
}
