using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Exercices.Boucles
{
    public class Factoriel : ICommand
    {
        public string Name => "Factoriel";

        public void Execute()
        {
            int nb;

            do
            {
                Console.WriteLine("Nombre : ");
            }while(!int.TryParse(Console.ReadLine(), out nb) || nb <= 0);

            int result = nb--;
            while(nb > 1)
            {
                result *= nb--;
            }
            Console.WriteLine(result);
        }
    }
}
