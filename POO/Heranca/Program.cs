using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro cr = new Carro();
            //Veiculo v = new Veiculo();
            Bicicleta bc = new Bicicleta();
            cr.Acelerar();
            bc.Acelerar();
            cr.Parar();
            bc.Parar();

            //Console.ReadKey();

        }
    }
}
