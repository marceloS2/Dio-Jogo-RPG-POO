using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_POO.src.Entities
{
   
   
    public abstract class Hero
    {
      public Hero(string Name, string Level, string HeroType, string Hp, string Mp)
   {
     this.Name = Name;
     this.Level = Level;
     this.HeroType = HeroType;
     this.Hp = Hp;
     this.Mp = Mp;
   }
     
     public Hero()
     {

     }
       public string Name;
       public string Level;
       public string HeroType;
       public string Hp;
       public string Mp;
       


       public override string ToString()
       {   
         
         return this.Name + " " + this.Level + " " +this.HeroType+ "  " +this.Hp+ " " +this.Mp;
          
       }    
       
        public virtual string Attack()
        {

          return this.Name + Level +  HeroType + Hp + Mp +  "  Atacou com sua Espada (ò,ò) c╬══>";
        }
   
   
   
   
   
    }
}