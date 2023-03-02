using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Demo
{
    public class DemoConditions : ICommand
    {
        public string Name => "Demo Conditions";

        public void Execute()
        {
            //If else
            int age;
            string nom;
            Console.Write("Nom : ");
            nom = Console.ReadLine();
            Console.Write("Age : ");
            //If(Un seul + Bloc de code (obligatoire)
            //Else if (optionnel et tant qu'on veut)
            //Else (optionnel et un seul)
            if (int.TryParse(Console.ReadLine(), out age))
            {
                if (age >= 18)
                {
                    Console.WriteLine($"Bienvenue {nom}.");
                }
                //Pas besoin de reevaluer si age < 18 (premiere condition a renvoyé faux)
                else if (age >= 12)
                {
                    Console.WriteLine($"Tu es encore un peu trop jeune {nom}.");
                }
                else if (age >= 10)
                {
                    Console.WriteLine($"Tu es a peine ado {nom}.");
                }
                //Si aucune condition n'a renvoyé vrai
                else
                {
                    Console.WriteLine("Autorisation parentale requise.");
                }
            }
            else
            {
                Console.WriteLine("Valeur incorrect.");
            }
            //c'est ici que les differents chemin du programme se rejoignent
            Console.WriteLine("Au revoir!");
            //Switch
            int choix;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1 : Citron");
            sb.AppendLine("2 : Orange");
            sb.AppendLine("3 : Butternut");
            sb.AppendLine("4 : Potiron");
            sb.AppendLine("5 : Tomate");
            Console.WriteLine(sb.ToString());
            if(int.TryParse(Console.ReadLine(),out choix))
            {
                switch (choix)
                {
                    case 1:
                        Console.WriteLine("🍋Les citrons coutent 2€/kg.🍋");
                        break;
                    case 2:
                        Console.WriteLine("Les oranges coutent 1.5€/kg.");
                        break;
                    case 3:
                    case 4:
                        Console.WriteLine("Les cucurbitacé coutent 3€/kg.");
                        break ;
                    case 5:
                        Console.WriteLine("Les tomates coutent 2.5€/kg.");
                        break;
                    default:
                        Console.WriteLine("Choix non valide.");
                        break;                        
                }
            }
            else
            {
                Console.WriteLine("Valeur incorrect.");
            }
            //c'est ici que les differents chemin du programme se rejoignent
            Console.WriteLine("Au revoir! 🫡");
        }
    }
}
