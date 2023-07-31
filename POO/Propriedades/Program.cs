using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teste teste = new Teste();
            teste.Nome = "Gabriel";
            Console.WriteLine(teste.Nome);
            Console.WriteLine(teste.SobreNome);


        }
    }
}
