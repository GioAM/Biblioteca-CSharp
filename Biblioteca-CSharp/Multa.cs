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
    public partial class Multa : Form
    {
        public Multa()
        {
            InitializeComponent();
        }

        private void Multa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet.DataTable6' table. You can move, or remove it, as needed.
            this.dataTable6TableAdapter.Fill(this.bibliotecaDataSet.DataTable6);
            // TODO: This line of code loads data into the 'bibliotecaDataSet.DataTable6' table. You can move, or remove it, as needed.
            this.dataTable6TableAdapter.Fill(this.bibliotecaDataSet.DataTable6);


        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
             
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idToModify.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RelatorioMultas rel = new RelatorioMultas();
            rel.Show();
        }
    }
}
