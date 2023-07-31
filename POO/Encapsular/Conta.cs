using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsular
{
    internal class Conta
    {
        public string nome;
        public double saldo;
        private double taxa = 0.05;//taxa 5%

        public void Sacar(double valor)
        {
            if (valor <= this.saldo)
            {
                valor += (valor * taxa);
                 this.saldo -= valor;
                Console.WriteLine("Trensação efetudada com sucesso");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente, transação negada");
                
            }
        }

        public void Depositar(double valor) 
        {
            if ( valor > 0)
            {
                this.saldo += valor;
            }
            else
            {
                Console.WriteLine("Valor invalido");
            }
            
            
        }
    }
}
