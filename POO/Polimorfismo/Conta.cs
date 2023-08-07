using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class CaixaEletronico : IConta
    {
        public string Usuario { get ; set ; }

        public void Depositar()
        {
            
        }

        public void Sacar()
        {
            
        }

        public void Saldo()
        {
            
        }
    }
    //I padrao para falar que é uma interface
    interface IConta
    {
        string Usuario { get; set; }//propriedade

        void Depositar();
        void Sacar();
        void Saldo();
    }

}
