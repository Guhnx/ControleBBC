using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VaniaTrabalho
{
    public partial class Teladelogin : Form
    {
        public Teladelogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Bsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            {

                
                StreamReader sr = new StreamReader ("Dados.txt");//caminho do seu arquivo txt
                string usuario = sr.ReadLine(); //vai ler a primeira linha onde está o usuario
                string senha = sr.ReadLine(); //vai ler a segunda linha onde está a senha
                if (TUsuario.Text == usuario && TSenha.Text == senha)
                {
                    MessageBox.Show("Login realizado com sucesso!");
                    TelaADM tadm = new TelaADM();
                    tadm.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos!");
                }

            }


        }

        public void TUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        public void TSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
