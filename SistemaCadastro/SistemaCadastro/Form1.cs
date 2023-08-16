using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class Form1 : Form
    {
        List<Pessoa> pessoas;//lista dinamica
        public Form1()
        {
            InitializeComponent();
            pessoas = new List<Pessoa>();
            //Combo box
            comboEC.Items.Add("Casado");
            comboEC.Items.Add("Solteiro");
            comboEC.Items.Add("Viuvo");
            comboEC.Items.Add("Separado");
            comboEC.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtData.Text = "";
            comboEC.SelectedIndex = 0;
            checkCasa.Checked = false;
            checkCarro.Checked = false;
            radioM.Checked = true;
            radioF.Checked = false;
            radioO.Checked = false;
            txtNome.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int indice = Lista.SelectedIndex;
            pessoas.RemoveAt(indice);
            Listar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        #region cadastrar
        {
            int index = -1;

            foreach(var pessoa in pessoas)
            {
                if (pessoa.Nome == txtNome.Text)
                {
                    index = pessoas.IndexOf(pessoa);//acha o index da variável passada
                }
            }

            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha o campo nome");
                txtNome.Focus();
                return;//vai finalizar o método 
            }
            
            if (txtTelefone.Text == "(00) 00000-0000")
            {
                MessageBox.Show("Preencha o campo telefone");
                txtTelefone.Focus();
                return;
            }

            char sexo;

            if (radioM.Checked)
            {
                sexo = 'M';
            } else if (radioF.Checked)
            {
                sexo = 'F';
            }
            else
            {
                sexo = 'O';
            }

            Pessoa p = new Pessoa();
            p.Nome = txtNome.Text;
            p.Telefone = txtTelefone.Text;
            p.DataNascimento = txtData.Text;
            p.EstadoCivil = comboEC.SelectedItem.ToString();
            p.CasaPropria = checkCasa.Checked;
            p.Veiculo = checkCarro.Checked;
            p.Sexo = sexo;

            if (index < 0)
            {
                pessoas.Add(p);
            }
            else
            {
                pessoas[index] = p;
            }

            btnLimpar_Click(btnLimpar, EventArgs.Empty);

            Listar();

        }
        #endregion

        private void Listar()
        {
            Lista.Items.Clear();

            foreach(var pessoa in pessoas)
            {
                Lista.Items.Add(pessoa.Nome);
            }
        }

        private void Lista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Pessoa p = pessoas[Lista.SelectedIndex];
            txtNome.Text = p.Nome;
            txtTelefone.Text = p.Telefone;  
            txtData.Text = p.DataNascimento;
            comboEC.SelectedItem = p.EstadoCivil;
            checkCasa.Checked = p.CasaPropria;
            checkCarro.Checked = p.Veiculo;
            
            if(p.Sexo == 'M')
            {
                radioM.Checked = true;
            } else if (p.Sexo == 'F')
            {
                radioF.Checked = true;
            }
            else
            {
                radioO.Checked = true;
            }
        }
    }
}
