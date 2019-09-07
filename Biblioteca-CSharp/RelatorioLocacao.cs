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
    public partial class RelatorioLocacao : Form
    {
        public RelatorioLocacao()
        {
            InitializeComponent();
        }

        private void RelatorioLocacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BibliotecaDataSet.DataTable4' table. You can move, or remove it, as needed.
            this.DataTable4TableAdapter.Fill(this.BibliotecaDataSet.DataTable4);

            this.reportViewer1.RefreshReport();
        }
    }
}
