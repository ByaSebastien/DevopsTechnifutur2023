using Logique;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Exercices.Collections
{
    public class NbPremierCollection : ICommand
    {
        public string Name => "Nombres premier avec collection";

        public void Execute()
        {
            ArrayList arrayList = new ArrayList();
            DateTime start = DateTime.Now;
            int limit;
            do
            {
                Console.Write("Quantième nombre premier : ");
            } while (!int.TryParse(Console.ReadLine(), out limit) || limit <= 1);
            int potentialPrime = 3;
            while(potentialPrime <= limit)
            {
                bool isPrime = true;
                int sqrt = (int)Math.Sqrt(potentialPrime);
                for (int div = 2; div <= sqrt && isPrime; div++)
                {
                    if (potentialPrime % div == 0)
                        isPrime = false;
                }
                if (isPrime)
                    arrayList.Add(potentialPrime);
                potentialPrime += 2;
            }
            foreach (int i in arrayList)
            {
                Console.Write(i + " | ");
            }
            Console.WriteLine();
            Console.WriteLine("Temps : " + (DateTime.Now - start).TotalSeconds);
        }
    }
}
