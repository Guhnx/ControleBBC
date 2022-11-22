namespace VaniaTrabalho
{
    partial class TelaADM
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
            this.Bcadastraraluno = new System.Windows.Forms.Button();
            this.Bcontrolealunos = new System.Windows.Forms.Button();
            this.Bcontrolebiblioteca = new System.Windows.Forms.Button();
            this.Bsair = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bcadastraraluno
            // 
            this.Bcadastraraluno.Location = new System.Drawing.Point(20, 22);
            this.Bcadastraraluno.Name = "Bcadastraraluno";
            this.Bcadastraraluno.Size = new System.Drawing.Size(133, 57);
            this.Bcadastraraluno.TabIndex = 0;
            this.Bcadastraraluno.Text = "Cadastrar Aluno";
            this.Bcadastraraluno.UseVisualStyleBackColor = true;
            this.Bcadastraraluno.Click += new System.EventHandler(this.Bcadastraraluno_Click);
            // 
            // Bcontrolealunos
            // 
            this.Bcontrolealunos.Location = new System.Drawing.Point(170, 22);
            this.Bcontrolealunos.Name = "Bcontrolealunos";
            this.Bcontrolealunos.Size = new System.Drawing.Size(133, 57);
            this.Bcontrolealunos.TabIndex = 1;
            this.Bcontrolealunos.Text = "Controle Alunos";
            this.Bcontrolealunos.UseVisualStyleBackColor = true;
            this.Bcontrolealunos.Click += new System.EventHandler(this.Bcontrolealunos_Click);
            // 
            // Bcontrolebiblioteca
            // 
            this.Bcontrolebiblioteca.Location = new System.Drawing.Point(20, 99);
            this.Bcontrolebiblioteca.Name = "Bcontrolebiblioteca";
            this.Bcontrolebiblioteca.Size = new System.Drawing.Size(133, 57);
            this.Bcontrolebiblioteca.TabIndex = 2;
            this.Bcontrolebiblioteca.Text = "Controle Biblioteca";
            this.Bcontrolebiblioteca.UseVisualStyleBackColor = true;
            this.Bcontrolebiblioteca.Click += new System.EventHandler(this.Bcontrolebiblioteca_Click);
            // 
            // Bsair
            // 
            this.Bsair.Location = new System.Drawing.Point(117, 184);
            this.Bsair.Name = "Bsair";
            this.Bsair.Size = new System.Drawing.Size(98, 25);
            this.Bsair.TabIndex = 3;
            this.Bsair.Text = "Sair";
            this.Bsair.UseVisualStyleBackColor = true;
            this.Bsair.Click += new System.EventHandler(this.Bsair_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 57);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cadastrar livros";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelaADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 221);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Bsair);
            this.Controls.Add(this.Bcontrolebiblioteca);
            this.Controls.Add(this.Bcontrolealunos);
            this.Controls.Add(this.Bcadastraraluno);
            this.Name = "TelaADM";
            this.Text = "TelaADM";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bcadastraraluno;
        private System.Windows.Forms.Button Bcontrolealunos;
        private System.Windows.Forms.Button Bcontrolebiblioteca;
        private System.Windows.Forms.Button Bsair;
        private System.Windows.Forms.Button button1;
    }
}