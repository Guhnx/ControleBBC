namespace VaniaTrabalho
{
    partial class CadastroAluno
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Tidcliente = new System.Windows.Forms.TextBox();
            this.TNome = new System.Windows.Forms.TextBox();
            this.Tcpf = new System.Windows.Forms.MaskedTextBox();
            this.Tcelular = new System.Windows.Forms.MaskedTextBox();
            this.Cestado = new System.Windows.Forms.ComboBox();
            this.Tcidade = new System.Windows.Forms.TextBox();
            this.Tusuario = new System.Windows.Forms.TextBox();
            this.Tsenha = new System.Windows.Forms.TextBox();
            this.BCadastrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID_Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cidade";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Celular";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Usuario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Senha";
            // 
            // Tidcliente
            // 
            this.Tidcliente.Location = new System.Drawing.Point(27, 41);
            this.Tidcliente.Name = "Tidcliente";
            this.Tidcliente.Size = new System.Drawing.Size(280, 20);
            this.Tidcliente.TabIndex = 8;
            this.Tidcliente.TextChanged += new System.EventHandler(this.Tidcliente_TextChanged);
            // 
            // TNome
            // 
            this.TNome.Location = new System.Drawing.Point(27, 80);
            this.TNome.Name = "TNome";
            this.TNome.Size = new System.Drawing.Size(280, 20);
            this.TNome.TabIndex = 9;
            this.TNome.TextChanged += new System.EventHandler(this.TNome_TextChanged);
            // 
            // Tcpf
            // 
            this.Tcpf.Location = new System.Drawing.Point(27, 123);
            this.Tcpf.Mask = "000.000.000-00";
            this.Tcpf.Name = "Tcpf";
            this.Tcpf.Size = new System.Drawing.Size(280, 20);
            this.Tcpf.TabIndex = 10;
            this.Tcpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // Tcelular
            // 
            this.Tcelular.Location = new System.Drawing.Point(27, 244);
            this.Tcelular.Mask = "(00)00000-0000";
            this.Tcelular.Name = "Tcelular";
            this.Tcelular.Size = new System.Drawing.Size(280, 20);
            this.Tcelular.TabIndex = 11;
            this.Tcelular.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // Cestado
            // 
            this.Cestado.FormattingEnabled = true;
            this.Cestado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.Cestado.Location = new System.Drawing.Point(27, 162);
            this.Cestado.Name = "Cestado";
            this.Cestado.Size = new System.Drawing.Size(121, 21);
            this.Cestado.TabIndex = 12;
            this.Cestado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Tcidade
            // 
            this.Tcidade.Location = new System.Drawing.Point(27, 205);
            this.Tcidade.Name = "Tcidade";
            this.Tcidade.Size = new System.Drawing.Size(280, 20);
            this.Tcidade.TabIndex = 13;
            this.Tcidade.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Tusuario
            // 
            this.Tusuario.Location = new System.Drawing.Point(27, 287);
            this.Tusuario.Name = "Tusuario";
            this.Tusuario.Size = new System.Drawing.Size(280, 20);
            this.Tusuario.TabIndex = 14;
            this.Tusuario.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Tsenha
            // 
            this.Tsenha.Location = new System.Drawing.Point(27, 335);
            this.Tsenha.Name = "Tsenha";
            this.Tsenha.PasswordChar = '•';
            this.Tsenha.Size = new System.Drawing.Size(280, 20);
            this.Tsenha.TabIndex = 15;
            this.Tsenha.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // BCadastrar
            // 
            this.BCadastrar.Location = new System.Drawing.Point(85, 389);
            this.BCadastrar.Name = "BCadastrar";
            this.BCadastrar.Size = new System.Drawing.Size(82, 23);
            this.BCadastrar.TabIndex = 16;
            this.BCadastrar.Text = "CADASTRAR";
            this.BCadastrar.UseVisualStyleBackColor = true;
            this.BCadastrar.Click += new System.EventHandler(this.BCadastrar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "VOLTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 424);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BCadastrar);
            this.Controls.Add(this.Tsenha);
            this.Controls.Add(this.Tusuario);
            this.Controls.Add(this.Tcidade);
            this.Controls.Add(this.Cestado);
            this.Controls.Add(this.Tcelular);
            this.Controls.Add(this.Tcpf);
            this.Controls.Add(this.TNome);
            this.Controls.Add(this.Tidcliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroAluno";
            this.Text = "CadastroAluno";
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Tidcliente;
        private System.Windows.Forms.TextBox TNome;
        private System.Windows.Forms.MaskedTextBox Tcpf;
        private System.Windows.Forms.MaskedTextBox Tcelular;
        private System.Windows.Forms.ComboBox Cestado;
        private System.Windows.Forms.TextBox Tcidade;
        private System.Windows.Forms.TextBox Tusuario;
        private System.Windows.Forms.TextBox Tsenha;
        private System.Windows.Forms.Button BCadastrar;
        private System.Windows.Forms.Button button1;
    }
}