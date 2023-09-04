using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Colecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            string[] nomes = new string[3] ;
            nomes[0] = "Gabriel";
            nomes[1] = "Lucas";
            nomes[2] = "Felipe";
            List<string> listaGenerica = new List<string>() ;
            listaGenerica.Add("Roberto");
            listaGenerica[0] = "Beatriz";
            listaGenerica.Add("Júlio");
            //lista.Items.Add(listaGenerica[0]);
            listaGenerica.AddRange(nomes);//adiciona todos da lista nomes

            /*if (listaGenerica.Remove("Beatriz"))
            {
                MessageBox.Show("Beatriz removida");
            }
            else
            {
                MessageBox.Show("Não foi possível remover");
               
            }*/
            /* if (listaGenerica.Contains("Lucas"))
             {
                 MessageBox.Show("Contém Lucas");
             }*/

            /*MessageBox.Show("O número de elementos é :"+ listaGenerica.Count);
            listaGenerica.Sort();//vai organizar de maneira alfabética*/

            //MessageBox.Show("O índice de Gabriel é :" + listaGenerica.IndexOf("Gabriel"));
            //listaGenerica.RemoveAt(1);//remove o índice 1
            //remove() = remove o valor passado 
            foreach(string nome in listaGenerica) 
            {
                lista.Items.Add(nome);
            }
            
        }

        private void btnHashSet_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            HashSet<string> veiculos = new HashSet<string>();//não aceita itens repetidos
            veiculos.Add("Mustang");
            veiculos.Add("Celta");
            veiculos.Add("Spin");
            veiculos.Add("Fiesta");
            veiculos.Add("911");


            /*if (veiculos.Add("Mustang"))
            {
                MessageBox.Show("Veículo adicionado");
            }
            else
            {
                MessageBox.Show("Veículo não adicionado");
            }

            if (veiculos.Contains("Celta"))
            {
                MessageBox.Show("Contém o celta");
            }
            else
            {
                MessageBox.Show("Não contém");
            }
            veiculos.Remove("Spin");

            MessageBox.Show(veiculos.Count.ToString());//conta todos os elementos
            */
            //MessageBox.Show(veiculos.First());
            //MessageBox.Show(veiculos.Last());
            foreach(string veiculo in veiculos)
            {
                lista.Items.Add(veiculo);
            }
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            Dictionary<int,string> alunos = new Dictionary<int, string>();
            alunos.Add(1, "Gabriel");
            alunos.Add(2, "João");
            alunos.Add(3, "Kauan");
            alunos.Add(4, "Lucas");
            alunos.Remove(1);
            //lista.Items.Clear();

            KeyValuePair<int,string> primeiro = alunos.First();
            MessageBox.Show("Primeiro item :" + primeiro.Value);
            ;
            if (alunos.ContainsKey(3))
            {
                MessageBox.Show("Contém");
            }else
            {
                MessageBox.Show("Não contém ");
            }

            foreach(KeyValuePair<int,string> item in alunos)//tipo específico
            {
                lista.Items.Add(item.Key + " = "+item.Value);
            }
        }

        private void btnSortedList_Click(object sender, EventArgs e)
        {
            //Lista ordenada (chave , valor), com base na chave
            SortedList<int, string> alunos = new SortedList<int, string>();
            alunos.Add(1, "Gabriel");
            alunos.Add(0, "Lucas");
            alunos.Add(3, "Larissa");
            alunos.Add(2, "Rafaela");
            lista.Items.Clear();
            alunos.Remove(2);
            foreach(var i in alunos)
            {
                lista.Items.Add(i);
            }

        }

        private void btnSortedDictionary_Click(object sender, EventArgs e)
        {
            SortedDictionary<int,string> nomes = new SortedDictionary<int,string>();
            nomes.Add(1, "Gabriel");
            nomes.Add(5, "Lucas");
            nomes.Add(8, "Livia");
            nomes.Add(3, "Roberto");
            nomes.Add(6, "Roberto");

            MessageBox.Show(nomes.Count.ToString());
            lista.Items.Clear();
            foreach(var i in nomes)
            {
                lista.Items.Add(i);
            }
        }

        private void sortedSet_Click(object sender, EventArgs e)
        {
            SortedSet<string> ss = new SortedSet<string>()//não aceita repetido e é classificada em ordem alfabético
            {
                "Gabriel","Arthur","Flávio","Beatriz","Danny"
            };
            lista.Items.Clear();
            ;

            if (!ss.Add("Arthur"))//! negação
            {
                MessageBox.Show("Não pode repetir elementos");
            }

            MessageBox.Show("Primeiro elemento :" + ss.ElementAt(0));

            foreach(var i in ss)
            {
                lista.Items.Add(i);
            }
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            Queue<string> fila  = new Queue<string>();
            fila.Enqueue("Gabriel");
            fila.Enqueue("Felipe");
            fila.Enqueue("Lucas");

            MessageBox.Show(fila.Count.ToString());
            lista.Items.Clear();

            MessageBox.Show(fila.Dequeue().ToString());//retorna e remove o primeiro da fila

            foreach (var i in fila)
            {
                lista.Items.Add(i);
            }

            MessageBox.Show(fila.Peek().ToString());//primeiro elemento da fila, mas não remove

            
        }

        private void btnStack_Click(object sender, EventArgs e)
        {
            lista.Items.Clear ();
            Stack<string> pilha = new Stack<string>();

            pilha.Push("Gabriel");//vai inserir no topo da pilha
            pilha.Push("Felipe");
            pilha.Push("Lucas");

            MessageBox.Show(pilha.Count.ToString());

            foreach (var item in pilha)
            {
                lista.Items.Add(item);
            }

            MessageBox.Show(pilha.Peek().ToString());//retorna o elemento no topo
            // pop , apresenta e remove o elemento
        }
    }
}
