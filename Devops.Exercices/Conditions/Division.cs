using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Exercices.Conditions
{
    public class Division : ICommand
    {
        public string Name => "Division";

        public void Execute()
        {
            int x = 5; int y = 2;

            Console.WriteLine($"Division entière : {x / y}\n" +
                              $"Division réel : {(float)x / y}\n" +
                              $"Module : {x % y}");
        }
    }
}
