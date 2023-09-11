using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeSenha
{
    public partial class Form1 : Form
    {

        List<char> numeros = new List<char>
            {
            '0', '1', '2', '3' , '4' , '5' , '6' , '7' , '8' , '9'
        };
        List<char> letras = new List<char>
            {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
            'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
            'u', 'v', 'w', 'x', 'y', 'z'
        };
        List<char> caracteres = new List<char>
            {
            '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+', '-', '=', '[', ']', '{', '}', ';', ':', '<', '>', '?', '/', '|'
        };
        private string senha = "";
        Random rd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void gerar (int a = 0, int b = 0 , int c = 0)
        {
            //Números a
            //Letras b
            //Caracteres c

            if (a > 0)
            {
                for(int i = 0; i < a; i++)
                {
                    senha.Append(numeros[rd.Next(numeros.Count)]);
                    
                }
            }
            else
            {
                MessageBox.Show("Coloque um valor positivo");
            }

            if (b > 0)
            {
                for (int i = 0; i < a; i++)
                {
                    senha.Append(letras[rd.Next(letras.Count)]);
                }
            }
            else
            {
                MessageBox.Show("Coloque um valor positivo");
            }

            if (c > 0)
            {
                for (int i = 0; i < a; i++)
                {
                    senha.Append(caracteres[rd.Next(caracteres.Count)]);
                }
            }
            else
            {
                MessageBox.Show("Coloque um valor positivo");
            }

            if (senha != "")
            {
                label1.Text = senha;
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {

            if(checkBoxN.Checked == true)
            {
                
                gerar(int.Parse(txtNnumeros.Text));
            }

            if(checkBoxC.Checked == true) 
            {
                
                gerar(0,int.Parse(txtNcaracteres.Text));
            }

            if (checkBoxL.Checked == true )
            {
                
                gerar(0,0,int.Parse(txtNLetras.Text));
            }

            if (checkBoxC.Checked == false && checkBoxL.Checked == false && checkBoxN.Checked == false)
            {
                MessageBox.Show("Marque pelo menos uma opção!");
            }

            
        }

        private void checkBoxL_CheckedChanged(object sender, EventArgs e)
        {
            txtNLetras.Clear();
        }

        private void checkBoxN_CheckedChanged(object sender, EventArgs e)
        {
            txtNnumeros.Clear();
        }

        private void checkBoxC_CheckedChanged(object sender, EventArgs e)
        {
            txtNcaracteres.Clear();
        }
    }
}
