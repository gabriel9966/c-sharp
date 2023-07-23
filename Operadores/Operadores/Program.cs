using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // + - * / %
            //ordem de precedência (), * / , + -
            // incremento ++ , decremento --

            int num = 10;
            while (num < 40) {
                Console.WriteLine(num);
                num++;


            }
            Console.WriteLine("\n\n");
            while (num <= 0)
            {
                Console.WriteLine(num);
                num--;
                
            }

            int numm = 10;

            //Console.WriteLine("\n"+numm--);//O valor de 'numm'  é atribuído a 'result' e, em seguida, 'a' é decrementado para .
            Console.WriteLine("\n" + --numm); //O valor de 'numm' é decrementado para  e, em seguida, atribuído


            //concatenação
            String nome = "Gabriel";
            String sobreNome = "Souza";
            String nomeCompleto = nome + sobreNome;
            Console.WriteLine(nomeCompleto);
            // usar sempre + , quando uma dase variáveis é String
            Console.WriteLine(10 + ""+20+""+40);

            //ooperadores de atribuição
            
            for(int i = 0; i < 10; i++)
            {//Após a execução do bloco de código, a etapa de iteração é executada. 
                Console.WriteLine(i);
               
            }

            int num1 = 10;

            //num1 += 5;
            //num1 -= 2;
            //num1 *= 3;
            //num1 /= 2;
            //num1 %= 3;
            

            Console.WriteLine("Valor de num1 :"+num1);

            String nomi = "Gabriel";
            nomi += " Souza";
            Console.WriteLine(nomi);


            //operadores de igualdade

            if (num1 == 10)
            {
                Console.WriteLine("num1 == 10");
            }if (nomi != "GabrielSouza")
            {
                Console.WriteLine("Nome diferente!!"+nomi);
            }

            bool m = 100 == 50;
            Console.WriteLine(m);
            bool l = 100 != 50;
            Console.WriteLine(l);


            //operadores relacionais
            // < , > , <= , >=
            //operadores lógicos || = ou , && = e

        }
    }
}
