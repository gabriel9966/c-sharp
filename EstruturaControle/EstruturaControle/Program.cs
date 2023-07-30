using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaControle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region Switch case
            int i = 6;
            switch (i) {
                case 0:
                    Console.WriteLine("0");
                    break;
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                case 3:
                    Console.WriteLine("3");
                    break;
                case 4:
                    Console.WriteLine("4");
                    break;
                case 5://opção combinada um ou outro serve
                case 6:
                    Console.WriteLine("5 ou 6");
                    break;
                default:
                    Console.WriteLine("Nenhum");
                    break;
                
            }

        #endregion

        //goto ,Ele permite que o fluxo de execução de um programa pule para uma etiqueta específica dentro do código
            inicio://label
            Console.WriteLine("Escolha opção:");
            int op = int.Parse(Console.ReadLine());
            int valor = 0;

            switch (op)
            {
                default:
                    goto inicio;//volta pro inicio, pro label
                    
                case 1:
                    valor += 100;
                    break;
                case 2:
                    valor += 50;
                    goto case 1;//muda o fluxo , volta pro 1
                    
            }
            Console.WriteLine(valor);

        }
    }
}
