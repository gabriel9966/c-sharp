using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Estaticas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Somar(int n1, int n2)
            {
                Console.WriteLine(n1 + n2);
            }
            Somar(5, 6);
            BomDia();

            Matematica.taxa = 10;
            
            Console.WriteLine(Matematica.Adicionar(10));

            Pessoa.maiorIdade = 40;
            Console.WriteLine(Pessoa.CalcularIdade(20));
            Console.WriteLine(Pessoa.maiorIdade);
        }

        public static void BomDia()
        {
            Console.WriteLine("Bom dia");
        }

        
    }
}
