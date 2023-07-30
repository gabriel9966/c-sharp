using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaCondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altura = 0;
            double peso = 0;
            double imc = 0;

            Console.WriteLine("Digite sua altura em cm:");
            altura = double.Parse(Console.ReadLine())/100;//de centrimetros para metros
            Console.WriteLine("Digite seu peso:");
            peso = double.Parse(Console.ReadLine());
            imc = peso / (altura * altura);
            Console.WriteLine(imc);

            if(imc <= 18.5){
                Console.WriteLine("Abaixo do peso");
            }else if (imc >= 18.6 && imc <= 24.9)
            {
                Console.WriteLine("Peso ideal");
            }else if(imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine("Acima do peso");
            }else if(imc >= 30 && imc <= 34.9)
            {
                Console.WriteLine("Obesidade 1");
            }else if (imc >= 35 && imc <= 39.9)
            {
                Console.WriteLine("Obesidade 2(Severa)");
            }
            else
            {
                Console.WriteLine("Obesidade mórbida");
            }

            //operador ternário// condição ? true : false
            int i = 7;
            string mensagem ="";
            mensagem = i > 5 ? "Maior que 5 " : "Menor que 5";
            Console.WriteLine(mensagem);


           



        }
    }
}
