using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrada_e_saida_de_dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Entrada e saida(dados)
            //saída
            //Console.Write(",");
            //Console.WriteLine("oi");
            //Console.Write(",\n");

            //Console.ReadKey();
            //Entrada
            //int idadeee = Console.Read(); captura o código de um digito
            //Console.WriteLine(idadeee);

            //scanner de String
            //String nome = Console.ReadLine();//readline tem retorno do tipo String
            // Console.WriteLine(nome);

            Console.WriteLine("Digite um numero:");
            int num = int.Parse(Console.ReadLine());//faz a leitura de numeros inteiros
            Console.WriteLine("Digete outro numero:");
            int num2 = int.Parse(Console.ReadLine());
            int total = num + num2;
            Console.WriteLine("A soma dos numeros deu:"+total);
            #endregion





        }
    }
}
