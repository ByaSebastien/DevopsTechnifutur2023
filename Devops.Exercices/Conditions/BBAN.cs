using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Exercices.Conditions
{
    public class BBAN : ICommand
    {
        public string Name => "BBAN";

        public void Execute()
        {
            string compte1 = "970000000097";
            string compte2 = "000000014245";
            string compte3 = "000000014246";

            string compte = compte2;

            long tenFirst = long.Parse(compte.Substring(0, 10));
            int twoLast = int.Parse(compte.Substring(10, 2));

            int modulo = (int)(tenFirst % 97);

            //Ternaire
            Console.WriteLine(twoLast == ((modulo == 0)? 97 : modulo) ? "OK" : "KO");

            //Condition normale
            if(modulo == 0 && twoLast == 97) 
            {
                Console.WriteLine("OK");
            }
            else if(twoLast == modulo)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("KO");
            }

            //Mix lisible
            if(twoLast == ((modulo == 0) ? 97 : modulo))
                Console.WriteLine("OK");
            else
                Console.WriteLine("KO");
        }
    }
}
