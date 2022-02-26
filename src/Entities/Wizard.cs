using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_POO.src.Entities
{
    public class Wizard : Hero
    {
       
       public Wizard(string Name, string Level, string HeroType, string Hp, string Mp)
       {
           this.Name = Name;
           this.Level = Level;
           this.HeroType = HeroType;
           this.Hp = Hp;
           this.Mp = Mp;
       }

       
        public override string Attack()
        {
           return this.Name +  Level +  HeroType + Hp + Mp +  " Lançou Magia(õ.õ) c===<o ☼☼☼ ";
    

        }
        
        public  string DarkAttack()
        {
            return this.Name +  Level +  HeroType + Hp + Mp +  " Lançou super magia (@,@) c===<o ☼♠◊ ";
        }
        public string Attack(int Bonus)
        {
            if(Bonus >6)
            {
              return this.Name +  " Lançou Magia Super Efeiva com Bonus de  " + Bonus;
            }
             else
            {
             return this.Name +   " Lançou uma magia com Força fraca com bonus de " + Bonus;
            }
        }
    
    
    
    
    }
}