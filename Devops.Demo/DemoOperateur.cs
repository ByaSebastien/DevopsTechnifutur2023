using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Demo
{
    public class DemoOperateur : ICommand
    {
        public string Name => "Demo opérateur";

        public void Execute()
        {
            int nb = 5;
            Console.WriteLine(nb++); //5
            Console.WriteLine(nb);   //6
            Console.WriteLine(++nb); //7
            nb += 3;
            Console.WriteLine(nb);   //10
            nb *= 2;
            Console.WriteLine(nb);   //20
            nb /= 4;
            Console.WriteLine(nb);   //5

            string status = (nb == 5) ? "Nb vaut 5" : "Nb ne vaut pas 5";
            Console.WriteLine(status); //Nb vaut 5

            string? a = "Coucou";
            string? b = "toto";
            string? c = null;

            //Prend la permiere valeur non null
            string result = a ?? b ?? c ?? "A , B et C sont null";
            Console.WriteLine(result);
        }
    }
}
