namespace VaniaTrabalho
{
    partial class Teladelogin
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
            this.BLogin = new System.Windows.Forms.Button();
            this.Bsair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TSenha = new System.Windows.Forms.TextBox();
            this.TUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BLogin
            // 
            this.BLogin.Location = new System.Drawing.Point(22, 113);
            this.BLogin.Name = "BLogin";
            this.BLogin.Size = new System.Drawing.Size(160, 55);
            this.BLogin.TabIndex = 0;
            this.BLogin.Text = "Login";
            this.BLogin.UseVisualStyleBackColor = true;
            this.BLogin.Click += new System.EventHandler(this.BLogin_Click);
            // 
            // Bsair
            // 
            this.Bsair.Location = new System.Drawing.Point(188, 113);
            this.Bsair.Name = "Bsair";
            this.Bsair.Size = new System.Drawing.Size(160, 55);
            this.Bsair.TabIndex = 1;
            this.Bsair.Text = "Sair";
            this.Bsair.UseVisualStyleBackColor = true;
            this.Bsair.Click += new System.EventHandler(this.Bsair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // TSenha
            // 
            this.TSenha.Location = new System.Drawing.Point(22, 78);
            this.TSenha.Name = "TSenha";
            this.TSenha.PasswordChar = '*';
            this.TSenha.Size = new System.Drawing.Size(326, 20);
            this.TSenha.TabIndex = 4;
            this.TSenha.TextChanged += new System.EventHandler(this.TSenha_TextChanged);
            // 
            // TUsuario
            // 
            this.TUsuario.Location = new System.Drawing.Point(22, 39);
            this.TUsuario.Name = "TUsuario";
            this.TUsuario.Size = new System.Drawing.Size(326, 20);
            this.TUsuario.TabIndex = 5;
            this.TUsuario.TextChanged += new System.EventHandler(this.TUsuario_TextChanged);
            // 
            // Teladelogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 179);
            this.Controls.Add(this.TUsuario);
            this.Controls.Add(this.TSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bsair);
            this.Controls.Add(this.BLogin);
            this.Name = "Teladelogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BLogin;
        private System.Windows.Forms.Button Bsair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TSenha;
        private System.Windows.Forms.TextBox TUsuario;
    }
}

