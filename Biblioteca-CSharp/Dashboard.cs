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
            SqlConnection connection;
            SqlCommand commandBooks;
            SqlCommand commandCategory;
            SqlCommand commandDevolution;
            SqlCommand commandUser;
            SqlDataReader reader;
            SqlCommand commandMulta;
            SqlCommand  commandLocacao;

            string connectionString = Properties.Settings.Default.BibliotecaConnectionString;

            connection = new SqlConnection(connectionString);

            commandUser = new SqlCommand("SELECT COUNT(*) AS 'TOTAL' FROM USUARIO", connection);
            commandBooks = new SqlCommand("SELECT COUNT(*) AS 'TOTAL' FROM LIVRO", connection);
            commandCategory = new SqlCommand("SELECT COUNT(*) AS 'TOTAL' FROM CATEGORIA", connection);
            commandLocacao = new SqlCommand("SELECT COUNT(*) AS 'TOTAL' FROM DEVOLUCAO", connection);
            commandMulta = new SqlCommand("SELECT COUNT(*) AS 'TOTAL' FROM DEVOLUCAO", connection);

            try
            {
                try
                {
                    connection.Open();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Falha ao conectar o Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reader = commandUser.ExecuteReader();
                if (reader.Read())
                {
                    btUsuario.Text = reader["TOTAL"].ToString() + " Usuário(s)! ";
                }
                reader.Close();

                reader = commandBooks.ExecuteReader();
                if (reader.Read())
                {
                    btLivros.Text = reader["TOTAL"].ToString() + " Livro(s)! ";
                }
                reader.Close();

                reader = commandCategory.ExecuteReader();
                if (reader.Read())
                {
                    btCategoria.Text = reader["TOTAL"].ToString() + " Categoria(s)! ";
                }
                reader.Close();

                reader = commandLocacao.ExecuteReader();
                if (reader.Read())
                {
                    btLocacao.Text = reader["TOTAL"].ToString() + " Locação(ões)! ";
                }

                reader = commandLocacao.ExecuteReader();
                if (reader.Read())
                {
                    btLocacao.Text = reader["TOTAL"].ToString() + " Locação(ões)! ";
                }

                reader.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "E", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
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
            Category cat = new Category();
            cat.Show();
        }
    }
}
