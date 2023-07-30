using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermoThis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Acessar ac = new Acessar();
            Console.WriteLine(ac.Login("abc123"));
        }
    }
}
