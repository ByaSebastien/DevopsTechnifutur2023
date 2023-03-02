using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Exercices.Variables
{
    public class Addition : ICommand
    {
        public string Name => "Addition";

        public void Execute()
        {
            int a;
            int b;
            bool isValid;

            //Parse
            //Crash si l'utilisateur ne rentre pas un nombre
            Console.WriteLine("Nombre 1 : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nombre 2 : ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {a + b}");

            //TryParse
            //Ne crash pas si l'utilisateur ne rentre pas un nombre
            Console.WriteLine("Nombre 1 : ");
            isValid = int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Nombre 2 : ");
            isValid = int.TryParse(Console.ReadLine(), out b);
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
    }
}
