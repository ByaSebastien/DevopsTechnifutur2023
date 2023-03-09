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
            FillTab(tab2);
            ShowTab(tab1);
            Console.WriteLine("_____________________________________________");
            ShowTab(tab2);
            Console.WriteLine("_____________________________________________");
            int nb = 5;
            Console.WriteLine(nb);
            ChangeValue(ref nb);
            Console.WriteLine(nb);
            Console.WriteLine("_____________________________________________");
            ChangeValue(tab1);
            ShowTab(tab1);
            Console.WriteLine(Addition(2, 6, 5, 7, 8, 9, 7));
            Console.WriteLine(estDivisible(5));
            Console.WriteLine(estDivisible(6, 3));
        }
        public bool estDivisible(int nb,int div = 2)
        {
            return nb% div == 0;
        }
        public int Addition(params int[] tab)
        {
            int somme = 0;
            foreach (int nb in tab)
            {
                somme += nb;
            }
            return somme;
        }
        public void ChangeValue(ref int i)
        {
            i += 10;
        }
        public void ChangeValue(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] += 10;
            }    
        }
        private void FillTab(int[] tab)
        {
            int cpt = 1;
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = cpt++;
            }
        }
        private void FillTab(int[,] tab)
        {
            int cpt = 1;
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    tab[i, j] = cpt++;
                }
            }
        }

        private static void ShowTab(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + " | ");
            }
            Console.WriteLine();
        }
        private static void ShowTab(int[,] tab)
        {
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    Console.Write(tab[i, j] + " | ");
                }
                Console.WriteLine();
            }
        }
    }
}
