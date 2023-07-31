using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();
            c.saldo = 100;
            c.Depositar(50);
            c.Sacar(10);
            Console.WriteLine(c.saldo);
        }
    }
}
