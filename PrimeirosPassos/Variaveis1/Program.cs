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

        enum notas
        {
            min = 10,
            med = 20,
            max = 30
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
            notas nt = notas.min;

            

         
        }
    }
}
