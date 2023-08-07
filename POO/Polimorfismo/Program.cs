using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Forma f = new Forma();
            Forma r = new Retangulo();
            Forma c = new Circulo();

            Console.WriteLine("Retangulo");
            r.Desenhar();
            Console.WriteLine("Circulo");
            c.Desenhar();
        }
    }
}
