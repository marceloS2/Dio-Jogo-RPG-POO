using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_POO.src.Entities
{
    public class Knigth : Hero
   {

    public Knigth(string Name, string Level, string HeroType, string Hp, string Mp)
    {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
        this.Hp = Hp;
        this.Mp = Mp;
    }


   }
}