using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    internal class Matematica
    {
        public void Somar(int num1 , int num2)
        {
            Console.WriteLine("A soma da :" + (num1 + num2));
        }

        public void Subtrair(int num1, int num2)
        {
            Console.WriteLine("A subtração da :" + (num1 - num2));
        }

        public void Multiplicacao(int num1, int num2)
        {
            Console.WriteLine("A multiplicação da :" + (num1 * num2));
        }

        public void Divisao(int num1, int num2)
        {
            Console.WriteLine("A divisão da :" + (num1 / num2));
        }
    }
}
