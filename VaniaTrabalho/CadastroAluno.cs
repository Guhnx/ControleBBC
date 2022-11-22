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
    public partial class CadastroAluno : Form
    {

        Pessoa[] pessoas = new Pessoa[20];
        int cont = 0;
        ControleAlunos controleAlunos = new ControleAlunos();


        public CadastroAluno()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BCadastrar_Click(object sender, EventArgs e)
        {
            pessoas[cont] = new Pessoa(Tidcliente.Text, TNome.Text, Tcpf.Text,
                Cestado.Text, Tcidade.Text,Tcelular.Text, 
                Tusuario.Text, Tsenha.Text);
            cont++;
            //string pessoa = (Tidcliente.Text, TNome.Text, maskedTextBox1.Text, comboBox1.Text, textBox1.Text, int.Parse(maskedTextBox2.Text), textBox2.Text, textBox3.Text);
            TelaADM.c2.insereDados(Tidcliente.Text, TNome.Text, Tcpf.Text, Cestado.Text, Tcidade.Text, Tcelular.Text, Tusuario.Text, Tsenha.Text);
            MessageBox.Show("Cadastro efetuado");
            limpar();
        }

        void limpar()
        {
            Tidcliente.Clear();
            TNome.Clear();
            Tcpf.Clear();
            Tcidade.Clear();
            Tcelular.Clear();
            Tusuario.Clear();
            Tsenha.Clear();

        }

        private void Tidcliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void TNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
