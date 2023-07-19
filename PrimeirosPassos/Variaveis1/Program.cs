using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis1
{
    internal class Program
    {

        enum Notas
        {
            min = 10,
            med = 20,
            max = 30
        }

        /*
         
Uma struct em C# é uma estrutura de dados que permite agrupar diferentes tipos de dados relacionados em um único objeto.
Ela é usada para criar tipos de valor personalizados, onde os dados são armazenados diretamente no objeto em vez
de serem referenciados., são estruturas de dados personalizados.
         */
        struct Pessoa
        {
            public String name;
            public int idade;
            public double altura;

        }
        static void Main(string[] args)
        {
            //"Variáveis numericas inteiras
            #region numeros inteiros
            //integral assinado
            sbyte s = 10;// -128 a 127, 8bits
            short s2 = 20; // -32768 a 32767, 16bits
            int s3 = 30;// -2.147.483.648 a 2.147.483.547, 32bits
            long s4 = 40;//-9.223.372.036.854.775.808 a 9.223.372.036.854.775.807, 64bits

            //integral sem sinal
            byte s5 = 10;// 0 a 255, 8bits
            ushort s6 = 20;// 0 a 65.535, 16bits
            uint s7 = 30;// 0 a 4.294.967.295, 32bits
            ulong s8 = 40;// 0 a 18.446.744.073.709.551.615, 64bits
            #endregion

            //tipos numericos reais 
            #region numeros reais
            float real = 10.6f;//32bits, precisa ter o f
            double real2 = 35600.99;//64bits
            decimal real3 = 75000.66m;//128bits    
            #endregion

            //caractere
            char ch = 'a';//precisa ser com ''

            //boolean

            bool boo = true;
            bool boo2 = false;

            //string
            String nome = "gabriel";//valor padrao null
            //Console.WriteLine(nome);

            //var 
            var nomee = "Gabriel.";//pode ser alterada , mais tem que ser do mesmo tipo
            nomee = "Lucas";
            
            //Console.WriteLine(nomee);

            //object, é a base de todos os objetos, classe base
            object ob = null;

            //contantes, não pode ser alterado
            const int constante = 50;
            //Console.WriteLine(constante);

            //enumerações, conjunto de constantes nomeadas
            Notas nt = Notas.min;
            int valor = (int)Notas.min;
            Console.WriteLine(valor);

            //struct
            /*
             Nesse exemplo, ao atribuir objetoClasse1 a objetoClasse2, ambas as variáveis se referem ao mesmo objeto na memória.
            Portanto, qualquer alteração no objeto através de uma variável afetará o objeto acessado pela outra variável.

            Por outro lado, ao atribuir objetoStruct1 a objetoStruct2,
            uma cópia separada do valor da struct é feita. Alterações em objetoStruct2 não afetarão objetoStruct1,
            pois eles são cópias independentes.
             
             struct é por valor e não por referencia 
             */
            Pessoa pessoa = new Pessoa();
            pessoa.altura = 1.78;
            Console.WriteLine(pessoa.altura);
            pessoa.altura = 1.80;
            Console.WriteLine(pessoa.altura);
            Pessoa pessoa1 = new Pessoa();
            pessoa1.altura = 10;







        }
    }
}
