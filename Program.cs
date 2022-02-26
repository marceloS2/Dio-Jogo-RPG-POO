using RPG_POO.src.Entities;
using static System.Console;

namespace RPG_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Knigth Arus = new Knigth("Arus " , " Level 50 " , "Knight", " hp1500 ", " Mp700 ");
            Wizard Jenica = new Wizard("Jenica ", "Level 50 " ,  " White Wizard ", " Hp700 ", " Mp1200 ");
            Ninja Wedge = new Ninja ("Wedeg ", "Level 50 " ," Ninja ", "Hp1200 ", "Mp600 " );
            Wizard Topapa = new Wizard  ("Topapa ", "Level 50 " , " Dark Wizard " , "Mp400 ", "Hp700 ");
            
            
            WriteLine(Topapa.DarkAttack());
            WriteLine(Wedge.Attack());
            WriteLine(Arus.Attack());
            WriteLine(Jenica.Attack());
        }
    }
}
