using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Demo
{
    public class DemoStructure : ICommand
    {
        public string Name => "Demo structures";

        public void Execute()
        {
            Pokemon pikachu = new Pokemon("Pikachu");
            Pokemon ratata = new Pokemon("Ratata");

            Console.WriteLine(ratata.Stat.Pv);
            Console.WriteLine("____________________");
            pikachu.Parle();
            pikachu.Info();
            ratata.Parle();
            ratata.Info();
            ratata.Stat.Pv -= (pikachu.Stat.Atk - ratata.Stat.Def) <= 0 ? 1 : pikachu.Stat.Atk - ratata.Stat.Def;
            ratata.aMal();
            Console.WriteLine("____________________");
            Console.WriteLine(ratata.Stat.Pv);

        }
    }
    public struct Pokemon
    {
        public string Name;
        public Stat Stat;
        
        public Pokemon(string name)
        {
            Random rn = new Random();
            Name = name;
            Stat = new Stat(rn.Next(1,20), rn.Next(1,10), rn.Next(1,10), rn.Next(1,20));
        }

        public void Parle()
        {
            Console.WriteLine($"{Name} {Name}");
        }

        public void aMal()
        {
            Console.WriteLine(Name.Substring(0,2) + "...");
        }

        public void Info()
        {
            Console.WriteLine($"Pv : {Stat.Pv}\n" +
                              $"Atk : {Stat.Atk}\n" +
                              $"Def : {Stat.Def}\n" +
                              $"Vit : {Stat.Vit}");
        }
    }
    public struct Stat
    {
        public int Pv;
        public int Atk;
        public int Def;
        public int Vit;

        public Stat(int pv, int atk, int def, int vit)
        {
            Pv = pv;
            Atk = atk;
            Def = def;
            Vit = vit;
        }
    }
}
