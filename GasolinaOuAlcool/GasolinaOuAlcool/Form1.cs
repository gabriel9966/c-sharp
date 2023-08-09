using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasolinaOuAlcool
{
    public partial class Form1 : Form
    {
        private double gasolinaPreco;
        private double alcoolPreco;
        private double razao;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                gasolinaPreco = double.Parse(textBox1.Text);
                alcoolPreco = double.Parse(textBox2.Text);

            }catch(Exception ex)
            {
                erro.Text = "Coloque valores válidos";
            }
            
            
            razao =   alcoolPreco/gasolinaPreco;
            label4.Text = razao.ToString();

            Console.WriteLine("Gasolina: " + gasolinaPreco);
            Console.WriteLine("Álcool: " + alcoolPreco);
            Console.WriteLine("Razão: " + razao);

            if (razao < 0.7)
            {
                label3.Text = "Alcool";
            }
            else
            {
                label3.Text = "Gasolina";
            }

        }
    }
}
