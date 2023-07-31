using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    internal class Teste
    {
        private string nome;
        public string SobreNome { get; } = "Souza";
        private int idade;
        
        //get , set
        public string Nome
        {
            get
            {
                return this.nome;
            }
            set { 
            this.nome = value;
            }
        }

       //propriedades
        public int Idade
        {
            get { 
            return idade;}
            set
            {
                if(value < 18)
                {
                    Console.WriteLine("Idade não pode ser menor que 18");
                }
                else
                {
                    idade = value;
                }
            }
        }


        public void Apresentar()
        {
            if (nome != "") {
                Console.WriteLine("Bom dia:"+this.nome);
            }
        }
    }
}
