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
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }

        private void btNewBook_Click(object sender, EventArgs e)
        {
            NewBook newBook = new NewBook();
            newBook.Show();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet.USUARIO' table. You can move, or remove it, as needed.
            

        }
    }
}
