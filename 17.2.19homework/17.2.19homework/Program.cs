using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._2._19homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Flash flash = new Flash(300, "flash", 25);
            SpiderMan spider = new SpiderMan(180, "spider", 28);
            SuperMan super = new SuperMan(50, 29, "super");
            ISuperHero[] superHeroes = { flash, spider, super };
          

        }

        static void ActivateHero(ISuperHero super)
        {
            super.ActiveSuperPowers();
        }

        static void IdentifyHero(ISuperHero super)
        {
            if (super is SuperMan)
            {
                Console.WriteLine("Superman detected");
            }
            else if (super is SpiderMan)
            {
                Console.WriteLine("Spiderman is detected");
            }
            else
                Console.WriteLine("Flash is detected");
        }
        static void GetMoreHeroData(ISuperHero super)
        {
            Flash F = super as Flash;
            if (F != null)
            {
                Console.WriteLine(F.Voltage);
            }
            SuperMan S = super as SuperMan;
            if (S != null)
            {
                Console.WriteLine(S.WebLeft);
            }
            SpiderMan P = super as SpiderMan;
            if (P != null)
            {
                Console.WriteLine(P.Speed);
            }
        }
    } 
}
