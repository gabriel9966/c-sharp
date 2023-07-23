using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em celcius que vc deseja converter");
            double temperatura = int.Parse(Console.ReadLine());

            double fahrenheit = (temperatura * 9 / 5) + 32;
            double kelvin = temperatura + 273.15;

            Console.WriteLine("Temperatura em Fahrenheit: " + fahrenheit);
            Console.WriteLine("Temperatura em Kelvin: " + kelvin);
        }
    }
}
