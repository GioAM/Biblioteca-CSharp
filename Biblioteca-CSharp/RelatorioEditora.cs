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
    public partial class RelatorioEditora : Form
    {
        public RelatorioEditora()
        {
            InitializeComponent();
        }

        private void RelatorioEditora_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BibliotecaDataSet.EDITORA' table. You can move, or remove it, as needed.
            this.EDITORATableAdapter.Fill(this.BibliotecaDataSet.EDITORA);

            this.reportViewer1.RefreshReport();
        }
    }
}
