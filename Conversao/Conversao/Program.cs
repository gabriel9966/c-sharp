using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region conversão implicita
            byte by = 100;//8bits
            ushort us = by;//16bits

            float fl = 1250.99f;
            double db = fl;
            fl = by;

            Console.WriteLine(fl);
            char ch = 'c';
            int numero = ch;//código do c
                            //Console.WriteLine(numero);
            #endregion




            #region conversão explicita

            double bmb = 98.9;
            int a;
            a = (int)bmb;
            Console.WriteLine(a);

            ushort uss = 100;
            byte uss2 /*= uss*/;// não aceita ushort, ushort é 16bits
            Console.WriteLine();




            #endregion

        }
    }
}
