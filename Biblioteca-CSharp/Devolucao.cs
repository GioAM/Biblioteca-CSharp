using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_CSharp
{
    public partial class Devolucao : Form
    {
        public Devolucao()
        {
            InitializeComponent();
        }

        private void Devolucao_Load(object sender, EventArgs e)
        {
            this.dataTable5TableAdapter.Fill(this.bibliotecaDataSet.DataTable5);

        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            NewDevolucao dev = new NewDevolucao(this);
            dev.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btDelete_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            idToModify.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RelatorioDevolucao rel = new RelatorioDevolucao();
            rel.Show();

        }
    }
}
