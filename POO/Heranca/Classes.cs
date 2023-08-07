using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
     class Humano
    {
       // o virtual é um método normal, mas que permite sobreEscrita, ele é chamado pela instância
        public virtual void Olhos()
        {
            Console.WriteLine("Humano olhos");
        }
        public virtual void Cabelo()
        {
            Console.WriteLine("Humano cabelo");
        }

    }

    class Pessoa : Humano 
    {   //Sealed A partir daqui o método não pode mais ser modificado, ele continuara herdando , mas não pode ser modificado
        public sealed override void Olhos()
        {
            Console.WriteLine("Pessoa olhos");
        }
        public sealed override void Cabelo()
        {
            Console.WriteLine("Pessoa cabelo");
        }

    }

    class Homem : Pessoa
    {//não pode ser rescrito aqui
        /*public override void Olhos()
        {
            Console.WriteLine("Homem olhos");
        }*/
        /*public override void Cabelo()
        {
            Console.WriteLine("Homem cabelo");
        }*/
    }
}
