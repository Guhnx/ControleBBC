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
    public partial class ControleAlunos : Form
    {
        public ControleAlunos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void insereDados(string i, string n, string c, string e, string c1, string ce, string u, string s)
        {
            DataGridViewRow linha = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            linha.Cells[0].Value = i;
            linha.Cells[1].Value = n;
            linha.Cells[2].Value = c;
            linha.Cells[3].Value = e;
            linha.Cells[4].Value = c1;
            linha.Cells[5].Value = ce;
            linha.Cells[6].Value = u;
            linha.Cells[7].Value = s;
            dataGridView1.Rows.Add(linha);
        }

        private void Bt_sair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
