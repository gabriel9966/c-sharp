using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Carro : Veiculo//herança
    { //atributos começam com letra minúscula , propriedades começam com letra maiúscula
        
        public int VelocidadeMaxima { get; set; }

        public void LigarMotor()
        {
            Console.WriteLine("Motor ligado");
        }
        //override = sobre escrevendo método abstrato
        public override void Acelerar()
        {
            Console.WriteLine("Acelerando o carro");
        }
        public override void Parar()
        {
            Console.WriteLine("Parando carro");
        }



    }
}
