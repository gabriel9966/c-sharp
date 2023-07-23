using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicarMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz1 = new int[2, 3];
            int[,] matriz2 = new int[3, 2];
            int[,] resultante = new int[2, 2];
            

            Console.WriteLine("Numere a matriz");
            for (int i = 0; i < matriz1.GetLength(0); i++)//linha
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)//coluna
                {
                    Console.WriteLine("Diga o numero da posição " + "linha " + i + ", coluna " + j);
                    matriz1[i, j] = int.Parse(Console.ReadLine());
                }

            }
            Console.WriteLine("Matriz\n");
            for (int i = 0; i < matriz1.GetLength(0); i++)//getlength retorna o tamanho da primeira dimensão , linha
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)////getlength retorna o tamanho da segunda dimensão , coluna
                
                {

                        Console.Write("[" + matriz1[i, j] + "]");
                }
                
                Console.WriteLine();
                
            }

            Console.WriteLine("Numere a matriz2 ");
            for (int l = 0; l < matriz2.GetLength(0); l++)
            {
                for (int p = 0; p < matriz2.GetLength(1); p++)
                {
                    Console.WriteLine("Diga o numero da posição " + "linha " + l + ", coluna " + p);
                    matriz2[l, p] = int.Parse(Console.ReadLine());
                }

            }
            Console.WriteLine("\nMatriz2 \n");
            for (int e = 0; e < matriz2.GetLength(0); e++)//getlength retorna o tamanho da primeira dimensão , linha
            {
                for (int f = 0; f < matriz2.GetLength(1); f++)////getlength retorna o tamanho da segunda dimensão , coluna
                {
                    
                        Console.Write("[" + matriz2[e, f] + "]");
                   
                }

                Console.WriteLine();

            }



            resultante[0, 0] = (matriz1[0, 0] * matriz2[0, 0]) + (matriz1[0, 1] * matriz2[1, 0]) + (matriz1[0, 2] * matriz2[2, 0]);
            resultante[0, 1] = (matriz1[0, 0] * matriz2[0, 1]) + (matriz1[0, 1] * matriz2[1, 1]) + (matriz1[0, 2] * matriz2[2, 1]);
            resultante[1, 0] = (matriz1[1, 0] * matriz2[0, 0]) + (matriz1[1, 1] * matriz2[1, 0]) + (matriz1[1, 2] * matriz2[2, 0]);
            resultante[1, 1] = (matriz1[1, 0] * matriz2[0, 1]) + (matriz1[1, 1] * matriz2[1, 1]) + (matriz1[1, 2] * matriz2[2, 1]);
            Console.WriteLine("\nresultante\n");
            for(int v = 0; v < resultante.GetLength(0); v++)
            {
                for(int v2 = 0;v2 < resultante.GetLength(1); v2++)
                {
                    Console.Write("["+resultante[v, v2]+"]");
                }
                Console.WriteLine();
            }


        }

    }
}   

