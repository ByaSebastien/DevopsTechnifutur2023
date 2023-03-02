using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Exercices.Boucles
{
    public class Incrementation : ICommand
    {
        public string Name => "Test incrémentation";

        public void Execute()
        {
            //for(double nb = 0.0 ; nb <= 20.0 ; nb += 0.1)
            //{
            //    Console.WriteLine(nb);
            //}
            for (decimal nb = 0.0M; nb <= 20.0M; nb += 0.1M)
            {
                Console.WriteLine(nb);
            }
        }
    }
}
