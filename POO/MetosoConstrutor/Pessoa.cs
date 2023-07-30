using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MetosoConstrutor
{
    internal class Pessoa
    {
        //Construtor


        public Pessoa() 
        {
            this.nome = "Desconhecido";
            this.sobreNome = "Nenhum";
        }
        //sobrecargar, overloading
        public Pessoa(string nome)
        {
            this.nome = nome;
            

        }
        
        public Pessoa(string nome, string sobreNome) 
        {
            this.nome = nome;
            this.sobreNome = sobreNome;
            
        }
        public Pessoa(string nome, string sobreNome, int anoNascimento,int idade)
        {
            this.nome = nome;
            this.sobreNome = sobreNome;
            this.anoNascimento = anoNascimento;
            this.idade = idade;

        }

        public Pessoa(string nome, string sobreNome, int anoNascimento )
        {
            this.nome = nome;
            this.sobreNome = sobreNome;
            this.anoNascimento = anoNascimento;
            this.idade = CalculaIdade(anoNascimento);

        }

        //this ,  é uma referência para o objeto atual em que um método está sendo chamado.
        public string nome;
        public string sobreNome;
        public int anoNascimento;
        public int idade;

        public int CalculaIdade (int anoNascimento)
        {
            return (2023 - anoNascimento);
        }

        

    }
}
