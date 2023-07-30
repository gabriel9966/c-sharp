using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Metodos
    {
        //Método Simples
        public void Ola()
        {
            Console.WriteLine("Ola mundo!");
        }

        //Método com parâmetro
        public double Soma(double x,double y)
        {
            return x + y;
        }

        //Passagem de parâmetro por valor,Nesse caso, o parâmetro valor é passado para o método
        //AumentarValor por valor. Isso significa que, quando o método é chamado, uma cópia do
        //valor da variável original é passada para o parâmetro valor. Todas as operações dentro do
        //método são realizadas com essa cópia local da variável, e quaisquer alterações feitas no
        //parâmetro não afetarão a variável original fora do método. Após a execução do método,
        //a variável original permanecerá inalterada.
        public void AumentarValor(int valor)
        {
            valor += 10;
            Console.WriteLine("Valor final  :"+valor);
        }
        //Passagem de valor por referência,No método AumentarRef, o parâmetro valor é passado por referência usando
        //a palavra-chave ref. Isso permite que a variável original seja diretamente afetada pelas operações dentro
        //do método. Qualquer alteração feita no parâmetro valor afetará diretamente a variável original fora do método.
        public void AumentarRef(ref int valor)//tudo afetara a variável real, da outra classe
        {
            valor += 10;
            Console.WriteLine("Ref final :" + valor);

        }
        //métodos com retorno
        public string NomeCompleto (string nome,string sobreNome)
        {
            return nome +" "+ sobreNome;
        }
        public int Caracter (char caracter)
        {
            return caracter;
        }
        public double Pi()
        {
            return 3.1415;
        }

        //sobrecarga de métodos
        //A sobrecarga de métodos em C# (method overloading)
        //é uma característica que permite definir múltiplas versões de um método
        //com o mesmo nome, mas com diferentes parâmetros.
        public void Ola(string nome)
        {
            Console.WriteLine("Ola "+nome);
        }
        public void Ola(string nome, int hora)
        {
            string mensagem = hora < 12 ? "Ola bom dia " + nome : "Ola boa tarde " + nome;
            Console.WriteLine(mensagem);
        }

        public bool Comparar(string txt1,string txt2)
        {
            return txt1 == txt2;
        }
        public bool Comparar(int num1, int num2)
        {
            return num1 == num2;
        }

    }
}
