using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Demo
{
    public class DemoEnums : ICommand
    {
        public string Name => "Demo enums";

        public void Execute()
        {
            Permis permi = Permis.B;
            string p1 = permi.ToString(); // TypeEnum => string : ToString()
            Permis p2 = Enum.Parse<Permis>(p1);// string => Type Permis : Enum.Parse<TypeEnum>()
            int nb = (int)permi;// TypeEnum => int : cast (int)
            Permis p3 = (Permis)nb;// int => TypeEnum : cast (TypeEnum)
            Console.WriteLine(permi);
            Console.WriteLine((int)permi);

            foreach (Permis p in Enum.GetValues<Permis>())
            {
                Permis test = p;
            }
            Console.WriteLine("______________________________________________________");
            permi = Permis.A | Permis.E | Permis.C;
            if(permi.HasFlag(Permis.A))
                Console.WriteLine("Permis A");
            if (permi.HasFlag(Permis.B))
                Console.WriteLine("Permis B");
            if (permi.HasFlag(Permis.C))
                Console.WriteLine("Permis C");
            if (permi.HasFlag(Permis.D))
                Console.WriteLine("Permis D");
            if (permi.HasFlag(Permis.E))
                Console.WriteLine("Permis E");
        }
    }
    public enum Permis
    {
        A = 1,
        B = 2,
        C = 4,
        D = 8,
        E = 16,
        F = 32,
    }

    //  1  0  1  0  1
    // 16  8  4  2  1
}
