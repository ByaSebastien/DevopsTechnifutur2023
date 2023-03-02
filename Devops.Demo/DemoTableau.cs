using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Demo
{
    public class DemoTableau : ICommand
    {
        public string Name => "Demo Tableau";

        public void Execute()
        {
            //int[] tab1Dimension = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] tab1Dimension;

            int taille = int.Parse(Console.ReadLine());

            tab1Dimension = new int[taille];

            for (int i = 0; i < tab1Dimension.Length; i++)
            {
                tab1Dimension[i] = i;
            }
            for (int i = 0; i < tab1Dimension.Length; i++)
            {
                Console.Write(tab1Dimension[i] + ",");
            }
            Console.WriteLine();
            //int[,] tab2Dimensions = { { 0, 1, 2, 3, 4 }, { 5, 6, 7, 8, 9 } };
            int[,] tab2Dimensions = new int[2, 5];
            int cpt = 0;
            for (int i = 0; i < tab2Dimensions.GetLength(0); i++)
            {
                for (int j = 0; j < tab2Dimensions.GetLength(1); j++)
                {
                    tab2Dimensions[i, j] = cpt++;
                }
            }
            for (int i = 0; i < tab2Dimensions.GetLength(0); i++)
            {
                for (int j = 0; j < tab2Dimensions.GetLength(1); j++)
                {
                    Console.Write(tab2Dimensions[i, j] + ",");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int[][] tabTest = new int[2][];
            tabTest[0] = new int[] { 3, 4, 5 };
            tabTest[1] = new int[] { 6, 7, 8, 5 };
            foreach (var item in tabTest)
            {
                foreach (var item1 in item)
                {
                    Console.WriteLine(item1);
                }
            }
        }
    }
}
