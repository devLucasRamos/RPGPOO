using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGPOO.Entities
{
    internal class Arus
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }

        public Arus(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }
    }
}
