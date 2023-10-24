using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesImportantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Mensagem");
            ////DialogResult resultado = MessageBox.Show("Mensagem"+18,"Titulo da Menssagem",MessageBoxButtons.OKCancel); 

            ////if(resultado == DialogResult.OK)
            ////{
            ////    lbResultado.Text = "OK";
            ////}
            ////else
            ////{
            ////    lbResultado.Text = "Apertou em cancelar";
            ////}
            
            //MessageBox.Show("Mensagem","Titulo",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            Random r = new Random(5);

            lbResultado.Text = r.Next(10,51).ToString();
        }
    }
}
