using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            HashSet<string> hashSet = new HashSet<string>();//não aceita itens repetidos
        }
    }
}
