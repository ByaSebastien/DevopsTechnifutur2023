using Logique;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Exercices.Boucles
{
    public class NbPremier : ICommand
    {
        public string Name => "Nombres premiers";

        public void Execute()
        {
            DateTime start = DateTime.Now;
            int limit;
            do
            {
                Console.Write("Quantième nombre premier : ");
            }while(!int.TryParse(Console.ReadLine(), out limit) || limit <= 1);
            for (int cpt = 1,potentialPrime = 3; cpt < limit; potentialPrime += 2)
            {
                bool isPrime = true;
                int sqrt = (int)Math.Sqrt(potentialPrime);
                for (int div = 2; div <= sqrt  && isPrime; div++) 
                {
                    if(potentialPrime % div == 0)
                        isPrime = false;
                }
                if (isPrime)
                    cpt++;
                if(cpt == limit)
                {
                    Console.WriteLine(potentialPrime);
                }
            }
            Console.WriteLine((DateTime.Now - start).TotalSeconds);
        }
    }
}
