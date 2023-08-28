using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label_BoasVindas_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormsLogin f = new FormsLogin();
            //f.ShowDialog();//ShowDialog():
            //Exibe um formulário como uma
            //janela modal, bloqueando o código até
            //que o formulário seja fechado.,,

            while (CadastroUsuarios.UsuarioLogado == null) 
            {
                Visible = false;
                f.ShowDialog();

                if(FormsLogin.cancelar == true)
                {
                    Application.Exit();
                    return;
                }
            }
            label_BoasVindas.Text = "Bem vindo(a) "+CadastroUsuarios.UsuarioLogado.Nome;
            Visible = true;
        }
    }
}
