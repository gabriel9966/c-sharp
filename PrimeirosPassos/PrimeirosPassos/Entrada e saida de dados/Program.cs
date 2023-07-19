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
            int num2 = int.Parse(Console.ReadLine());//O método Parse() é usado para converter uma representação
                                                     //de string de um tipo de dados em um valor do tipo correspondente.
            int total = num + num2;
            Console.WriteLine("A soma dos numeros deu:"+total);
            #endregion

            
            #region inverter nomes
            String nome1,nome2,nome3,nome4,auxiliar;

            Console.WriteLine("Digite o nome #1:");
            nome1 = Console.ReadLine();
            Console.WriteLine("Digite o nome #2");
            nome2 = Console.ReadLine();
            Console.WriteLine("Digite o nome #3");
            nome3 = Console.ReadLine();
            Console.WriteLine("Digite o nome #4");
            nome4 = Console.ReadLine();

            

            auxiliar = nome1;
            nome1 = nome4;
            nome4 = auxiliar;

            auxiliar = nome2;
            nome2 = nome3;
            nome3= auxiliar;

            Console.WriteLine();
            Console.WriteLine("Nomes de maneira invertida");
            Console.WriteLine(nome1);
            Console.WriteLine(nome2);
            Console.WriteLine(nome3);
            Console.WriteLine(nome4);

            #endregion



        }
    }
}
