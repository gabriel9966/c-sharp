using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            while(a <= 10)
            {
                
                Console.WriteLine(a);
                a++;

            }
            Console.WriteLine("\n------------------\n");
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            //for each , executa a cada iteração na coleção
            string[] nomes = { "Gabriel", "Lucas", "Luis", "Murilo" };
            foreach(string s in nomes)
            {
                
                Console.WriteLine(s);
            }
            

        }
    }
}
