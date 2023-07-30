using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 1;
            int soma = num1 + num2;

            Console.WriteLine(num1);
            Console.WriteLine(num2);

            for(int i = 0; i < 98; i++) {

                Console.WriteLine(soma);
                num1 = num2;
                num2 = soma;
                soma = num1 + num2;
                


            }

        }
    }
}
