using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetosoConstrutor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Gabriel","Souza",2005);

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.sobreNome);
            
            Console.WriteLine(p1.idade);
            Console.WriteLine(p1.anoNascimento);

        }
    }
}
