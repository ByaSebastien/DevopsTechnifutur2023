using Logique;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Exercices.Collections
{
    internal class NbPremierCollectionGenerique : ICommand
    {
        public string Name => "Nombres premiers avec collection generique";

        public void Execute()
        {
            List<int> primes = new List<int>();
            primes.Add(2);
            DateTime start = DateTime.Now;
            int limit;
            do
            {
                Console.Write("Quantième nombre premier : ");
            } while (!int.TryParse(Console.ReadLine(), out limit) || limit <= 1);
            for (int potentialPrime = 3; primes.Count < limit; potentialPrime += 2)
            {
                bool isPrime = true;
                int sqrt = (int)Math.Sqrt(potentialPrime);
                for (int i = 0; primes[i] <= sqrt && isPrime; i++)
                {
                    if (potentialPrime % primes[i] == 0)
                        isPrime = false;
                }
                if (isPrime)
                    primes.Add(potentialPrime);
            }
            foreach (int i in primes)
            {
                Console.Write((i == primes.Last()) ? i : i + " | ");
            }
            Console.WriteLine();
            Console.WriteLine("Temps : " + (DateTime.Now - start).TotalSeconds);
        }
    }
}
