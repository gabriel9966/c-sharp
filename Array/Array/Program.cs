using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vetor , array unidimensional

            int[] numeros = new int[5];//serve para alocação de memória
            numeros[0] = 1;
            numeros[1] = 2;
            numeros[2] = 3;
            numeros[3] = 4;
            numeros[4] = 5;
            for (int i = 0; i < numeros.Length; i++)
            {
                //Console.WriteLine(numeros[i]);
            }

            string[] mome = { "gabriel", "paulo", "lucas" };//ista de inicialização de array

            //matriz = array bi-dimencional
            int[,] numeros2 = new int[2, 3];//[,] diz que é uma matriz bidimensional , [linha,coluna] //
            numeros2[0, 1] = 1;
            numeros2[1, 2] = 2;

            Console.WriteLine(numeros2[1, 2]);
            //lista ja iniciada
            string[,] nomes =
            {
                {"a","b","c"},
                {"d","e","f"},
                {"g","h","i"}
            };
            Console.WriteLine(nomes[0, 2]);

            //multiplicação de matriz
                

        }
    }
}
