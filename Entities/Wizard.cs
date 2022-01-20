using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGPOO.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType) : base(name, level, heroType)
        {
        }

        public override string Attack()
        {
            return $"{this.Name} Lançou sua Magia!";
        }
        public string Attack(int Bonus)
        {
            return $"{this.Name} Lançou sua Magia com o bonus de ataque de {Bonus}!";
        }
    }
}
