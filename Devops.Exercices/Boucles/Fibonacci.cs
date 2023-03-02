using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Exercices.Boucles
{
    internal class Fibonacci : ICommand
    {
        public string Name => "Fibonacci";

        public void Execute()
        {
            int first = 0; 
            int second = 1;

            Console.WriteLine(first);
            Console.WriteLine(second);

            for(int i = 2; i < 25;i++)
            {
                int current = first + second;
                Console.WriteLine(current);
                first = second; 
                second = current;
            }
        }
    }
}
