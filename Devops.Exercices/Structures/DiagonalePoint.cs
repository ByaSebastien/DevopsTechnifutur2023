using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Exercices.Structures
{
    public class DiagonalePoint : ICommand
    {
        public string Name => "Diagonale de point X - Y";

        public void Execute()
        {
            Point?[,] points = new Point?[5, 5];
            for (int i = 0; i < points.GetLength(0); i++)
            {
                points[i, i] = new Point(i + 1, i + 1);
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < points.GetLength(0); i++)
            {
                for (int j = 0; j < points.GetLength(1); j++)
                {
                    //if (points[i, j] is null)
                    //    Console.Write(new string(' ', 13));
                    //else
                    //    Console.Write(points[i, j]?.X);
                    //Console.Write(points[i, j] is null ? new string(' ', 13) : points[i, j]);
                    sb.Append(points[i, j] is null ? new string(' ', 13) : points[i, j]);
                }
                //Console.WriteLine();
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString());
        }
    }
    public struct Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X;
        public int Y;

        public override string ToString()
        {
            return $"X : {X} - Y : {Y}";
        }
    }

    public struct Fahrenheit
    {
        public double Temperature;
    }
    public struct Celsius
    {
        public double Temperature;
    }
}
