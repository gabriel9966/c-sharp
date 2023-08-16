using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            #region contains/toString
            //contains
            /*string texto = "Este tipo de variável é alfanumerica";
            bool valor = texto.Contains("tipo");
            if (valor)
            {
                label1.Text = "Contém";
            }
            else
            {
                label1.Text = "Não contém";
            }*/
            /*
            int num = 58384;
            bool res = true;
            string numero = res.ToString();//converte para string
            
            label1.Text = numero;
            */
            #endregion

            #region upper/lower
            /*
            string nome = "Gabriel";
            string nomeM = nome.ToUpper();
            label1.Text = nome.ToLower();
            */
            #endregion

            #region indexOf
            /*
            string nome = "Gabriel Souza Souza";
            //int index = nome.IndexOf('a',2);//letra , posição a partir , retorna a pocição 
            int index = nome.LastIndexOf("Souza");//a última ocorrência
            label1.Text = Convert.ToString(index);
            */
            #endregion

            #region insert / replace 
            /*
            string nome = "Gabriel Souza";

            //string nomeFinal = nome.Insert(7, " Antonio de");
            string nomeFinal = nome.Replace("Souza", "Antonio de Souza.") ;//substituir
            nomeFinal = nomeFinal.Replace('a', 'n');
            label1.Text = nomeFinal;    */
            #endregion

            #region length / subString
            /*
            string nome = "Gabriel Souza";
            int nCaracteres = nome.Length;//tamanho da string
            //label1.Text =  nCaracteres.ToString();

            string parte = nome.Substring(0, 7);//índice que começa , comprimento
            label1.Text = parte;    
            */
            #endregion

            #region split
            //dividir
            /*
            string nomes = "Gabriel Carla Lucas Larisa Caio Eduardo";
            char[] separador = { ' ' };
            string[] resultado = nomes.Split(separador);
            label1.Text = "";
            foreach(string n in resultado)
            {
                label1.Text += n +"\n";
            }
            
            */
            #endregion
        }
    }
}
