using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{//classes abstratas sevem apenas para serem herdadas, não podem ser instânciadas
    internal abstract class Veiculo
    {
        public string Cor { get; set; }
        public string Marca { get; set; }

        public abstract void Acelerar();//Métodos abstract não tem corpo,devem ser implementados nas classes que herdam


        public abstract void Parar();
        




    }
}
