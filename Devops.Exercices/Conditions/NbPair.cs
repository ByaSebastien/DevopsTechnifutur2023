using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Exercices.Conditions
{
    public class NbPair : ICommand
    {
        public string Name => "Nombre pair";

        public void Execute()
        {
            int nb = int.Parse(Console.ReadLine());

            if (nb / 2 + nb / 2 == nb)
            {
                Console.WriteLine("Pair");
            }
            else
            {
                Console.WriteLine("Impair");
            }

            ////ternaire
            Console.WriteLine((nb / 2 + nb / 2 == nb) ? "Pair" : "Impair");

            //Bonne methode
            Console.WriteLine((nb % 2 == 0) ? "Pair" : "Impair");
        }
    }
}
