using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_POO.src.Entities
{
    public class Ninja : Hero
    {
        
        public Ninja(string Name, string Level , string HeroType, string Hp , string Mp)
        {
         this.Name = Name;
         this.Level = Level;
         this.HeroType = HeroType;
         this.Hp = Hp;
         this.Mp = Mp;

        }

        public override string Attack()
        {
            return this.Name +  Level +  HeroType + Hp + Mp + "Atacou com sua estrela da morte  (-.-) <- ☼☼☼ ☼ ☼ ";
        }
    
    }
}