using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGPOO.Entities
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }

        public Hero(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }

        public override string ToString() { 
            return $"Nome: {this.Name}, Level: {this.Level}, Classe: {this.HeroType}";
        }
        public virtual string Attack()
        {
            return $"{this.Name} Atacou com sua Espada!";
        }
    }
}
