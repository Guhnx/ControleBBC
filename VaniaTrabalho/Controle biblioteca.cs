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
    public partial class Controle_biblioteca : Form
    {
        public Controle_biblioteca()
        {
            InitializeComponent();
        }

        public void insereDadoss(string n, string e, string a, int c, int v, string an)
        {
            DataGridViewRow linha = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            linha.Cells[0].Value = n;
            linha.Cells[1].Value = e;
            linha.Cells[2].Value = a;
            linha.Cells[3].Value = c;
            linha.Cells[4].Value = v;
            linha.Cells[5].Value = an;
            dataGridView1.Rows.Add(linha);
        }

        private void Bt_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
