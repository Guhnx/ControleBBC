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
    public partial class TelaADM : Form
    {

        
        public static ControleAlunos c2 = new ControleAlunos();
        public static Controle_biblioteca c3 = new Controle_biblioteca();

        public TelaADM()
        {
            InitializeComponent();
        }

        private void Bsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Bcadastraraluno_Click(object sender, EventArgs e)
        {
            CadastroAluno c1 = new CadastroAluno();
            c1.Show();
        }

        private void Bcontrolealunos_Click(object sender, EventArgs e)
        {
            TelaADM.c2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroLivro cadastrol = new CadastroLivro();
            cadastrol.Show();
        }

        private void Bcontrolebiblioteca_Click(object sender, EventArgs e)
        {
            Controle_biblioteca controlebibli = new Controle_biblioteca();
            controlebibli.Show();
        }
    }
}
