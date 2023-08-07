using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public abstract class Forma
    {
        public int x { get; private set; }
        public int y { get; private set; }
        public int Altura { get; private set; }
        public int Largura { get; private set; }
        public int Raio { get; private set; }

        //virtual = pode ser sobre escrito
        public virtual void Desenhar()
        {
            Console.WriteLine("Preparando para desenhar");
        }

        public virtual void Area()
        {
            double area = Largura * Altura;
            Console.WriteLine("Area é : " + area);

        }

    }

    public class Circulo : Forma 
    {
        public override void Desenhar()
        {
            base.Desenhar();//executa o método da classe base
            Console.WriteLine("Desenhando um circulo");
        }

        public override void Area()
        {
            double area = 3.14 * (Raio * Raio);
            Console.WriteLine("Area do circulo é : " + area); 
            
        }

        
    }

    public class Retangulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();//executa o método da classe base
            Console.WriteLine("Desenhando um Retangulo");
        }

        public override void Area()
        {
            double area = Largura * Altura;
            Console.WriteLine("Area do retangulo é : " + area);

        }
    }
}
