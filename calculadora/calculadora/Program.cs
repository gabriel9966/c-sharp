﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a calculadora");

            Console.WriteLine("Digite o primeiro número");
            int n1 = int.Parse(Console.ReadLine());//parse converte String em int

            Console.WriteLine("Digite o segundo número");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a operação (+,-,*,/,%)");
            String operacao = Console.ReadLine();

            if (operacao == "+")
            {
                Console.WriteLine("O resutado é " + (n1 + n2));
            }
            else if (operacao == "-")
            {
                Console.WriteLine("O resutado é " + (n1 - n2));
            }
            else if (operacao == "*")
            {
                Console.WriteLine("O resutado é " + (n1 * n2));
            }
            else if (operacao == "/")
            {
                Console.WriteLine("O resutado é " + (n1 / n2));
            }else if (operacao == "%")
            {
                Console.WriteLine("O resutado é " + (n1 % n2));
            }
            else
            {
                Console.WriteLine("Operação invalida");
            }
        }
    }
}
