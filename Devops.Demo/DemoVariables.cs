using System.Text;
using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Demo
{
    public class DemoVariables : ICommand
    {
        public string Name => "Demo variables";

        public void Execute()
        {
            //déclaration de variable

            int myInt = 5;
            float myFloat = 3.14F;
            double myDouble = 5.32;
            decimal myDecimal = 14.30M;
            bool myBool = false;
            string myString = "Hello world!";
            // variable nullable
            int? myNullableInt = null;

            //ecrire dans la console
            Console.WriteLine(myString);
            Console.Write(myString + "\n");

            //lire depuis la console
            string name;
            int age;
            Console.WriteLine("Nom : ");
            name = Console.ReadLine();
            Console.WriteLine("Age : ");
            age = int.Parse(Console.ReadLine());
            //bool isValid = int.TryParse(Console.ReadLine(),out age);

            //concatenation
            Console.WriteLine("Bonjour " + name + " tu as " + age + " ans");
            Console.WriteLine("Bonjour {0} tu as {1} ans", name, age);
            Console.WriteLine($"Bonjour {name} tu as {age} ans");
            StringBuilder sb = new StringBuilder();
            sb.Append("Bonjour ");
            sb.Append(name);
            sb.Append(" tu as ");
            sb.Append(age);
            sb.Append(" ans");
            Console.WriteLine(sb.ToString());

            //cast
            int nb1 = 2, nb2 = 5;
            int resultatEntier = nb2 / nb1;
            float resultatReel = (float)nb2 / nb1;

            Console.WriteLine(resultatEntier);
            Console.WriteLine(resultatReel);
        }
    }
}
