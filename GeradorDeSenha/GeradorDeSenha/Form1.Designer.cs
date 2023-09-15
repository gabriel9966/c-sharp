namespace GeradorDeSenha
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txtNLetras = new System.Windows.Forms.TextBox();
            this.txtNnumeros = new System.Windows.Forms.TextBox();
            this.txtNcaracteres = new System.Windows.Forms.TextBox();
            this.checkBoxL = new System.Windows.Forms.CheckBox();
            this.checkBoxN = new System.Windows.Forms.CheckBox();
            this.checkBoxC = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Location = new System.Drawing.Point(247, 279);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gerar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNLetras
            // 
            this.txtNLetras.Location = new System.Drawing.Point(137, 113);
            this.txtNLetras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNLetras.Name = "txtNLetras";
            this.txtNLetras.Size = new System.Drawing.Size(76, 20);
            this.txtNLetras.TabIndex = 1;
            this.txtNLetras.Text = "N Letras";
            this.txtNLetras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNnumeros
            // 
            this.txtNnumeros.Location = new System.Drawing.Point(137, 149);
            this.txtNnumeros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNnumeros.Name = "txtNnumeros";
            this.txtNnumeros.Size = new System.Drawing.Size(76, 20);
            this.txtNnumeros.TabIndex = 2;
            this.txtNnumeros.Text = "N Números";
            this.txtNnumeros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNcaracteres
            // 
            this.txtNcaracteres.Location = new System.Drawing.Point(137, 190);
            this.txtNcaracteres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNcaracteres.Name = "txtNcaracteres";
            this.txtNcaracteres.Size = new System.Drawing.Size(76, 20);
            this.txtNcaracteres.TabIndex = 3;
            this.txtNcaracteres.Text = "N caracter esp";
            this.txtNcaracteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkBoxL
            // 
            this.checkBoxL.AutoSize = true;
            this.checkBoxL.Location = new System.Drawing.Point(226, 113);
            this.checkBoxL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxL.Name = "checkBoxL";
            this.checkBoxL.Size = new System.Drawing.Size(55, 17);
            this.checkBoxL.TabIndex = 4;
            this.checkBoxL.Text = "Letras";
            this.checkBoxL.UseVisualStyleBackColor = true;
            this.checkBoxL.CheckedChanged += new System.EventHandler(this.checkBoxL_CheckedChanged);
            // 
            // checkBoxN
            // 
            this.checkBoxN.AutoSize = true;
            this.checkBoxN.Location = new System.Drawing.Point(226, 150);
            this.checkBoxN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxN.Name = "checkBoxN";
            this.checkBoxN.Size = new System.Drawing.Size(68, 17);
            this.checkBoxN.TabIndex = 5;
            this.checkBoxN.Text = "Numeros";
            this.checkBoxN.UseVisualStyleBackColor = true;
            this.checkBoxN.CheckedChanged += new System.EventHandler(this.checkBoxN_CheckedChanged);
            // 
            // checkBoxC
            // 
            this.checkBoxC.AutoSize = true;
            this.checkBoxC.Location = new System.Drawing.Point(226, 192);
            this.checkBoxC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxC.Name = "checkBoxC";
            this.checkBoxC.Size = new System.Drawing.Size(125, 17);
            this.checkBoxC.TabIndex = 6;
            this.checkBoxC.Text = "Caracteres Especiais";
            this.checkBoxC.UseVisualStyleBackColor = true;
            this.checkBoxC.CheckedChanged += new System.EventHandler(this.checkBoxC_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Senha gerada";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxC);
            this.Controls.Add(this.checkBoxN);
            this.Controls.Add(this.checkBoxL);
            this.Controls.Add(this.txtNcaracteres);
            this.Controls.Add(this.txtNnumeros);
            this.Controls.Add(this.txtNLetras);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Gerador De Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNLetras;
        private System.Windows.Forms.TextBox txtNnumeros;
        private System.Windows.Forms.TextBox txtNcaracteres;
        private System.Windows.Forms.CheckBox checkBoxL;
        private System.Windows.Forms.CheckBox checkBoxN;
        private System.Windows.Forms.CheckBox checkBoxC;
        private System.Windows.Forms.Label label1;
    }
}

