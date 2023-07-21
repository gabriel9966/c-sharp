using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            // quando forçamos a conversão com ()
            double bmb = 98.9;
            int a;
            a = (int)bmb;
            Console.WriteLine(a);

            ushort uss = 100;
            byte uss2 /*= uss*/;// não aceita ushort, ushort é 16bits
            Console.WriteLine();

            int inteiro = 300000000;
            byte intei = (byte)inteiro;
            Console.WriteLine(intei);
            //implicita
            float n = 0f;//32bits
            double o = n;//64bits
            int i = 29;
            double ii = i;

            float l = 9f;//32bits
            int ll = (int)l;



            #endregion

            #region parse
            //trasnforma uma cadeia de caracteres (String) em número, padrão correspondente
            //parse faz a conversão de string
            String txtNum = "1985";
            int numeral = int.Parse(txtNum);//converou para int
                                            // int numeral2 = (int)txtNum;
                                            //Console.WriteLine(numeral);


            String txtNum2 = "1234,99";
            double dbtxt = double.Parse(txtNum2);
            double dbb =199.99;
            Console.WriteLine(dbtxt);


            #endregion


            #region convert
            //converte quarquer tipo de dado para qualquer tipo de dado

            String texto = Convert.ToString(99.990);
            Console.WriteLine(texto);

            int aaaa = Convert.ToInt32(67.99);
            Console.WriteLine(aaaa);

            double ann = Convert.ToDouble(true);
            Console.WriteLine(ann);

            Object ob = 99.0;
            Console.WriteLine(ob) ;

            bool myBoolValue = true;
            int myIntValue = Convert.ToInt32(false);


            Console.WriteLine(myIntValue) ;

            double dbbb = Convert.ToDouble("9");//so da para converter string numerica, nao letras e palavras, nao aceita char
            Console.WriteLine(dbbb) ;

            int innnnt = Convert.ToInt32('a');
            Console.WriteLine(innnnt) ;
            

            #endregion

        }
    }
}
