using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Demo
{
    public class DemoBoucles : ICommand
    {
        public string Name => "Démo boucles";

        public void Execute()
        {
            int cpt = 0;

            while (cpt < 10)
            {
                Console.WriteLine(cpt++);
            }
            Console.WriteLine("________________________________");
            do
            {
                Console.WriteLine(cpt++);
            } while (cpt < 10);
            Console.WriteLine("________________________________");
            int cpt2;
            for (cpt = 0,cpt2 = 9; cpt < 10; cpt++,cpt2--)
            {
                Console.WriteLine($"{cpt} : {cpt2}");
            }
            Console.WriteLine("________________________________");
            string s = "0123456789";
            foreach (char c in s)
            {
                Console.WriteLine(c);
            }

            //Entrée untilisateur
            int choix;
            do
            {
                Console.WriteLine("1, 2 ou 3");
            } while (!int.TryParse(Console.ReadLine(), out choix) || choix < 1 || choix > 3);
        }
    }
}
