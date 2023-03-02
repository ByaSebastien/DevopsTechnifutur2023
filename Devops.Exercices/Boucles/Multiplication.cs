using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Exercices.Boucles
{
    public class Multiplication : ICommand
    {
        public string Name => "Tables de multiplication";

        public void Execute()
        {
            for (int nb = 1; nb <= 5; nb++)
            {
                for (int mult = 1; mult <= 10; mult++)
                {
                    Console.WriteLine($"{nb} * {mult} = {nb * mult}");
                }
                Console.WriteLine("____________________________________");
            }
        }
    }
}
