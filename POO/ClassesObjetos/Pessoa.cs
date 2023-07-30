using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Pessoa
    {

        private string nome;
        private int idade;
        private int anoNascimento;
        private string sobreNome;
        private double altura;
        private double peso;

        #region nome
        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        #endregion

        #region idade
        public int GetIdade() 
        {
            return idade;
        }

        public void SetIdade(int idade) 
        {
            this.idade = idade;
        }
        #endregion

        #region anoNascimento
        public int GetAnoNascimento()
        {
            return anoNascimento;
        }
        public void SetAnoNascimento(int anoNascimento)
        {
            this.anoNascimento = anoNascimento;
        }
        #endregion

        #region sobreNome
        public string GetSobreNome()
        {
            return sobreNome;
        }
        public void SetSobreNome(string sobreNome)
        {
            this.sobreNome = sobreNome;
        }

        #endregion

        #region altura
        public double GetAltura()
        {
            return altura;
        }
        public void SetAltura(double altura)
        {
            this.altura = altura;
        }

        #endregion

        #region peso
        public double GetPeso()
        {
            return peso;
        }
        public void SetPeso(double peso)
        {
            this.peso = peso;
        }
        #endregion
    }
}
