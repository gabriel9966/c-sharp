using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("oi");
            int idade = 20;
            int maior = 18;
//bloco region serve para organizar código
            #region primeiro bloco
            if (idade >= maior) {
                Console.WriteLine("Pode entrar");
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }
            #endregion
            /*
             comentario
             */
            Console.ReadKey();// ele para o programa e espera o usuario aperta qualquer tecla para continuar
            Console.WriteLine("fim");
            int o = 10;
        }
    }
}
