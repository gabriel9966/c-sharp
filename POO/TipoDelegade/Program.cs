using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    internal class Program
    {
        //delegate é armazena referncia a  metodos
        delegate void Operacao(int n1, int n2);
            

        static void Main(string[] args)
        {
            Matematica m = new Matematica();

            Operacao op = null;
            op += m.Somar;
            op += m.Subtrair;
            op += m.Divisao;
            op += m.Multiplicacao;
            op(10, 5);
        }
    }
}
