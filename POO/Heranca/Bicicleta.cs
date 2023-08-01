using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{//sealed não permite a classe ser herdada
    internal sealed class Bicicleta : Veiculo
    {
        public void Pedalar()
        {
            Console.WriteLine("Pedalou");
        }
        ////override = sobre escrevendo método abstrato
        public override void Acelerar()
        {
            Console.WriteLine("Acelerando a bicicleta");
        }

        public override void Parar()
        {
            Console.WriteLine("Parando bicicleta");
        }

    }
}
