using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Biblioteca_CSharp
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btUsuario_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Login login = new Login(this);
            login.ShowDialog();
        }

        private void btLivros_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.Show();
        }

        private void btCategoria_Click(object sender, EventArgs e)
        {
            Editora cat = new Editora();
            cat.Show();
        }

        private void btLocacao_Click(object sender, EventArgs e)
        {
            Locacao locacao = new Locacao();
            locacao.Show();
        }

        private void btDevolucao_Click(object sender, EventArgs e)
        {
            Devolucao dev = new Devolucao();
            dev.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
