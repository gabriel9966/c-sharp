using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metodos mt = new Metodos();
            mt.Ola("Gabriel",12);
            double soma = mt.Soma(8.5, 7.3);
            Console.WriteLine(soma);
            int a = 5;
            int b = 22;
            mt.AumentarValor(a);
            mt.AumentarRef(ref b);//altera a referência
            //Console.WriteLine("Valor de a :" + a);
            //Console.WriteLine("Valor de b :" + b);
            //Console.WriteLine(mt.NomeCompleto("Gabriel", "Souza"));
            //Console.WriteLine(mt.caracter('a'));
            //Console.WriteLine("Valor de Pi :" + mt.Pi());
            Console.WriteLine(mt.Comparar("Gabriel", "Gabriel"));
            Console.WriteLine(mt.Comparar(5,5));
            

            
        }
    }
}
