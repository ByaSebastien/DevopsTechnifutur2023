using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Exercices.Collections
{
    public class DeplacementTableau2D : ICommand
    {
        public string Name => "Déplacement dans un tableau 2D";

        public void Execute()
        {
            const int TAILLE = 20;
            string[,] map = new string[TAILLE, TAILLE];
            int posX = TAILLE - 2;
            int posY = 1;
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (i == 0 || j == 0 || i == TAILLE - 1 || j == TAILLE - 1)
                        map[i, j] = "#";
                    else
                        map[i, j] = " ";
                }
            }
            map[posX, posY] = "☻";
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write("{0,-2}", map[i, j]);
                }
                Console.WriteLine();
            }
            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            do
            {
                bool isActive = false;
                while (!Console.KeyAvailable)
                {
                    Console.SetCursorPosition(TAILLE + 1, TAILLE + 1);
                    Console.WriteLine(isActive ? "☺":" ") ;
                    isActive = !isActive;
                    Thread.Sleep(200);
                }
                cki = Console.ReadKey(true);
                switch (cki.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (posX > 1)
                        {
                            Console.SetCursorPosition(posY * 2, posX);
                            Console.WriteLine(" ");
                            map[posX, posY] = " ";
                            posX--;
                            map[posX, posY] = "☻";
                            Console.SetCursorPosition(posY * 2, posX);
                            Console.WriteLine("☻");
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (posX < TAILLE - 2)
                        {
                            Console.SetCursorPosition(posY * 2, posX);
                            Console.WriteLine(" ");
                            map[posX, posY] = " ";
                            posX++;
                            map[posX, posY] = "☻";
                            Console.SetCursorPosition(posY * 2, posX);
                            Console.WriteLine("☻");
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (posY > 1)
                        {
                            Console.SetCursorPosition(posY * 2, posX);
                            Console.WriteLine(" ");
                            map[posX, posY] = " ";
                            posY--;
                            map[posX, posY] = "☻";
                            Console.SetCursorPosition(posY * 2, posX);
                            Console.WriteLine("☻");
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (posY < TAILLE - 2)
                        {
                            Console.SetCursorPosition(posY * 2, posX);
                            Console.WriteLine(" ");
                            map[posX, posY] = " ";
                            posY++;
                            map[posX, posY] = "☻";
                            Console.SetCursorPosition(posY * 2, posX);
                            Console.WriteLine("☻");
                        }
                        break;
                }
            } while (cki.Key != ConsoleKey.Escape);
        }
    }
}
