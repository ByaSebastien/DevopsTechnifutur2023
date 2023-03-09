using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Exercices.Methodes
{
    public class Temperature : ICommand
    {
        public string Name => "Convertisseur F° <-> C°";

        public void Execute()
        {
            Celsius c;
            Fahrenheit f;
            c.Temperature = 50;
            f.Temperature = 90;

            Console.WriteLine($"{c.Temperature} °C => {Math.Round(c.ToFahrenheit(),2)} °F");
            Console.WriteLine($"{f.Temperature} °F => {f.ToCelsius().Temperature.ToString("F2")} °C");
        }
    }
    public struct Fahrenheit
    {
        public double Temperature;
        public Celsius ToCelsius()
        {
            Celsius c;
            c.Temperature = (Temperature - 32) * 5 / 9;
            return c;
        }
    }
    public struct Celsius
    {
        public double Temperature;
        public double ToFahrenheit()
        {
            return Temperature * 9 / 5 + 32;
        }
    }
}
