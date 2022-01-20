using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGPOO.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string heroType) : base(name, level, heroType)
        {
        }
        public string Attack(int Bonus)
        {
            return $"{this.Name} Cortou o Inimigo com o bonus de ataque de {Bonus}!";
        }
    }
}
