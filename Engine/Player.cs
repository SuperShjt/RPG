using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player:Creatures
    {
        private string _name;
    
        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
        public List<Inventory> InvItems { get;set; }
        public List<PlayerQuest> PlayerQuests { get; set; }
        public Player(int currentHitPoints, int maximumHitPoints, int gold, int experiencePoints, int level) : base(currentHitPoints, maximumHitPoints)
        {
            Gold = gold;
            ExperiencePoints = experiencePoints;
            Level = level;
            _name = "Howk";
            InvItems = new List<Inventory>();
            PlayerQuests = new List<PlayerQuest>();
        }
    }
}
