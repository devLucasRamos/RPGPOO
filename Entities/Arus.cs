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

        public override string ToString() { 
            return $"nome: {this.Name} level: {this.Level} classe: {this.HeroType}";
        }
        public string Attack()
        {
            return $"{this.Name} Atacou com sua Espada!";
        }
    }
}
