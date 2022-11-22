using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VaniaTrabalho
{
    public partial class CadastroLivro : Form
    {

        Livro[] livros = new Livro[20];
        int cont = 0;
       Controle_biblioteca controle_biblioteca = new Controle_biblioteca();

        public CadastroLivro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            livros[cont] = new Livro(Tb_Nomelivro.Text, Tb_editora.Text, Tb_Autor.Text, int.Parse(Tb_codigo.Text), int.Parse(Tb_Volume.Text), Mt_Anolançamento.Text);
            cont++;
            //string pessoa = (Tidcliente.Text, TNome.Text, maskedTextBox1.Text, comboBox1.Text, textBox1.Text, int.Parse(maskedTextBox2.Text), textBox2.Text, textBox3.Text);
            TelaADM.c3.insereDadoss(Tb_Nomelivro.Text, Tb_editora.Text, Tb_Autor.Text, int.Parse(Tb_codigo.Text), int.Parse(Tb_Volume.Text), Mt_Anolançamento.Text);
            MessageBox.Show("Cadastro efetuado");
        }
    }
}
