using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeidaGeralPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Da um nome para o console
            Console.Title = "# Média Geral dos Alunos #";

            Console.WriteLine("Quantos alunos? ");
            int nAlunos = int.Parse(Console.ReadLine());

            Aluno[] alunos = new Aluno[nAlunos];

            for(int i = 0; i < alunos.Length; i++)
            {
                Console.Clear();
                Console.WriteLine("Aluno #" + (i + 1) + "Nome..: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Aluno #" + (i + 1) + "QTD Provas: ");
                int provas = int.Parse(Console.ReadLine());

                alunos[i] = new Aluno(nome, provas);

                Console.WriteLine("Insira as notas do aluno " + nome);
                alunos[i].InserirNotas();
            }

            Console.Clear() ;

            double mediaGeral = 0;

            foreach(Aluno aluno in alunos)//para cada
            {
                Console.WriteLine("Aluno :" + aluno.Nome);
                Console.WriteLine("Média :" + aluno.Media);

                mediaGeral += aluno.Media;
            }
            double resultadoFinal = mediaGeral / alunos.Length;

            Console.WriteLine("Média geral dos alunos:" + resultadoFinal);

        }   
    }
}
