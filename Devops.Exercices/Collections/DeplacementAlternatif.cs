using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Exercices.Collections
{
    public class DeplacementAlternatif : ICommand
    {
        public string Name => "Déplacement alternatif";

        public void Execute()
        {
            const int TAILLE = 20;
            int posX = TAILLE - 2;
            int posY = 1;
            string map = "########################################\n" +
                         "#                                      #\n" +
                         "#                                      #\n" +
                         "#                                      #\n" +
                         "#                                      #\n" +
                         "#                                      #\n" +
                         "#                                      #\n" +
                         "#                                      #\n" +
                         "#                                      #\n" +
                         "#                                      #\n" +
                         "#                                      #\n" +
                         "#                                      #\n" +
                         "#                                      #\n" +
                         "#                                      #\n" +
                         "#                                      #\n" +
                         "#                                      #\n" +
                         "#                                      #\n" +
                         "#                                      #\n" +
                         "#                                      #\n" +
                         "########################################\n";
            Console.WriteLine(map);
            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            do
            {
                Console.SetCursorPosition(posY * 2, posX);
                Console.WriteLine("☻");
                bool isActive = false;
                while (!Console.KeyAvailable)
                {
                    Console.SetCursorPosition(0, TAILLE + 1);
                    Console.WriteLine(isActive ? "☺" : " ");
                    isActive = !isActive;
                    Thread.Sleep(200);
                }
                cki = Console.ReadKey(true);
                switch (cki.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (posX > 1)
                        {
                            Console.Beep();
                            Console.SetCursorPosition(posY * 2, posX);
                            Console.WriteLine(" ");
                            posX--;
                            Console.SetCursorPosition(posY * 2, posX);
                            Console.WriteLine("☻");
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (posX < TAILLE - 2)
                        {
                            Console.Beep();
                            Console.SetCursorPosition(posY * 2, posX);
                            Console.WriteLine(" ");
                            posX++;
                            Console.SetCursorPosition(posY * 2, posX);
                            Console.WriteLine("☻");
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (posY > 1)
                        {
                            Console.Beep();
                            Console.SetCursorPosition(posY * 2, posX);
                            Console.WriteLine(" ");
                            posY--;
                            Console.SetCursorPosition(posY * 2, posX);
                            Console.WriteLine("☻");
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (posY < TAILLE - 2)
                        {
                            Console.Beep();
                            Console.SetCursorPosition(posY * 2, posX);
                            Console.WriteLine(" ");
                            posY++;
                            Console.SetCursorPosition(posY * 2, posX);
                            Console.WriteLine("☻");
                        }
                        break;
                }
            } while (cki.Key != ConsoleKey.Escape);
        }
    }
}
