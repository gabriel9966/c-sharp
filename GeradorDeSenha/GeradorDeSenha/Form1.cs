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
                    senha += (numeros[rd.Next(0,numeros.Count)]);
                    
                }
            }
            

            if (b > 0)
            {
                for (int i = 0; i < b; i++)
                {
                    senha += (letras[rd.Next(0,letras.Count)]);
                }
            }
            

            if (c > 0)
            {
                for (int i = 0; i < c; i++)
                {
                    senha += (caracteres[rd.Next(0,caracteres.Count)]);
                }
            }
            

            if (senha != "")
            {
                label1.Text = senha;
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            senha = "";
            if (checkBoxL.Checked == true || checkBoxC.Checked == true || checkBoxN.Checked == true)
            {
                
                if (checkBoxC.Checked == true)
                {
                    try
                    {
                        if (int.Parse(txtNcaracteres.Text) > 0)
                        {
                            gerar(0, 0, int.Parse(txtNcaracteres.Text));
                        }
                        else
                        {
                            MessageBox.Show("Coloque um número inteiro e positivo");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Coloque um número inteiro e positivo");
                    };

                   
                    
                }

                if(checkBoxL.Checked == true)
                {
                    try
                    {
                        if (int.Parse(txtNLetras.Text) > 0)
                        {
                            gerar(0, int.Parse(txtNLetras.Text), 0);
                        }
                        else
                        {
                            MessageBox.Show("Coloque um número inteiro e positivo");
                        }
                    }
                    
                    catch (Exception ex)
                    {
                        MessageBox.Show("Coloque um número inteiro e positivo");
                    };
                }
                

                if (checkBoxN.Checked == true)
                {
                    try
                    {
                        if (int.Parse(txtNnumeros.Text) > 0)
                        {
                            gerar(int.Parse(txtNnumeros.Text), 0, 0);
                        }
                        else
                        {
                            MessageBox.Show("Coloque um número inteiro e positivo");

                        }
                    }
                    
                    catch(Exception ex)
                    {
                        MessageBox.Show("Coloque um número inteiro e positivo");
                    };
                }
            }
            else
            {
                MessageBox.Show("Marque pelo menos um Tipo ");
            }



            
        }
        // Limpa as caixas de texto
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
