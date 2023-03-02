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
            tab1 = FillTab(tab1);
            tab2 = FillTab(tab2);
            ShowTab(tab1); 
            ShowTab(tab2);
        }
        public int[,] FillTab(int[,] tab)
        {
            int cpt = 1;
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    tab[i, j] = cpt++;
                }
            }
            return tab;
        }
        public int[] FillTab(int[] tab)
        {
            int cpt = 1;
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                tab[i] = cpt++;
            }
            return tab;
        }
        public void ShowTab(int[,] tab)
        {
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    Console.Write(tab[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void ShowTab(int[] tab)
        {
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                Console.Write(tab[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
