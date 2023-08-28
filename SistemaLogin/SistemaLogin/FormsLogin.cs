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
    public partial class FormsLogin : Form
    {

        public static bool cancelar = false;

        public FormsLogin()
        {
            InitializeComponent();
        }

        private void FormsLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            

            if (CadastroUsuarios.Login(txtUsuario.Text,txtSenha.Text))
            {
                Close();
            }
            else
            {
                MessageBox.Show("Acesso negado!");
                txtUsuario.Text = "";
                txtSenha.Text = "";
                txtUsuario.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
            cancelar = true;
        }
    }
}
