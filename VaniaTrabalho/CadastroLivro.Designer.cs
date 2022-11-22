namespace VaniaTrabalho
{
    partial class CadastroLivro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Tb_Nomelivro = new System.Windows.Forms.TextBox();
            this.Tb_editora = new System.Windows.Forms.TextBox();
            this.Tb_Autor = new System.Windows.Forms.TextBox();
            this.Tb_codigo = new System.Windows.Forms.TextBox();
            this.Tb_Volume = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Mt_Anolançamento = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Livro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ano lançamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Editora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Volume";
            // 
            // Tb_Nomelivro
            // 
            this.Tb_Nomelivro.Location = new System.Drawing.Point(12, 39);
            this.Tb_Nomelivro.Name = "Tb_Nomelivro";
            this.Tb_Nomelivro.Size = new System.Drawing.Size(245, 20);
            this.Tb_Nomelivro.TabIndex = 6;
            // 
            // Tb_editora
            // 
            this.Tb_editora.Location = new System.Drawing.Point(12, 76);
            this.Tb_editora.Name = "Tb_editora";
            this.Tb_editora.Size = new System.Drawing.Size(245, 20);
            this.Tb_editora.TabIndex = 7;
            // 
            // Tb_Autor
            // 
            this.Tb_Autor.Location = new System.Drawing.Point(12, 113);
            this.Tb_Autor.Name = "Tb_Autor";
            this.Tb_Autor.Size = new System.Drawing.Size(245, 20);
            this.Tb_Autor.TabIndex = 8;
            // 
            // Tb_codigo
            // 
            this.Tb_codigo.Location = new System.Drawing.Point(12, 150);
            this.Tb_codigo.Name = "Tb_codigo";
            this.Tb_codigo.Size = new System.Drawing.Size(245, 20);
            this.Tb_codigo.TabIndex = 9;
            // 
            // Tb_Volume
            // 
            this.Tb_Volume.Location = new System.Drawing.Point(12, 187);
            this.Tb_Volume.Name = "Tb_Volume";
            this.Tb_Volume.Size = new System.Drawing.Size(245, 20);
            this.Tb_Volume.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Mt_Anolançamento
            // 
            this.Mt_Anolançamento.Location = new System.Drawing.Point(12, 224);
            this.Mt_Anolançamento.Mask = "00/00/0000";
            this.Mt_Anolançamento.Name = "Mt_Anolançamento";
            this.Mt_Anolançamento.Size = new System.Drawing.Size(100, 20);
            this.Mt_Anolançamento.TabIndex = 14;
            this.Mt_Anolançamento.ValidatingType = typeof(System.DateTime);
            // 
            // CadastroLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 309);
            this.Controls.Add(this.Mt_Anolançamento);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tb_Volume);
            this.Controls.Add(this.Tb_codigo);
            this.Controls.Add(this.Tb_Autor);
            this.Controls.Add(this.Tb_editora);
            this.Controls.Add(this.Tb_Nomelivro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroLivro";
            this.Text = "CadastroLivro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Tb_Nomelivro;
        private System.Windows.Forms.TextBox Tb_editora;
        private System.Windows.Forms.TextBox Tb_Autor;
        private System.Windows.Forms.TextBox Tb_codigo;
        private System.Windows.Forms.TextBox Tb_Volume;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox Mt_Anolançamento;
    }
}