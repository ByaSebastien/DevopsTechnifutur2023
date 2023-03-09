using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Demo
{
    public class DemoMethodes : ICommand
    {
        public string Name => "Demo méthodes";

        public void Execute()
        {
            Console.WriteLine("Taille : ");
            int taille = int.Parse(Console.ReadLine());
            int[] tab1 = new int[taille];
            int[,] tab2 = new int[taille, taille];
            FillTab(tab1);
            ShowTab(tab1);
            tab1[2] = 5;
            ShowTab(tab1);
            tab1[6] = 8;
            ShowTab(tab1);
            tab1[0] = 20;
            ShowTab(tab1);
        }

        private void FillTab(int[] tab1)
        {
            int cpt = 1;
            for (int i = 0; i < tab1.Length; i++)
            {
                tab1[i] = cpt++;
            }
        }

        private static void ShowTab(int[] tab1)
        {
            for (int i = 0; i < tab1.Length; i++)
            {
                Console.Write(tab1[i] + " | ");
            }
            Console.WriteLine();
        }
    }
}
