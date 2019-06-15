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
    public partial class Login : Form
    {
        Dashboard db;

        public Login(Dashboard _db)
        {
            InitializeComponent();
            db = _db;
            db.Visible = false;
            tbPassword.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataReader reader;

            string connectionString = Properties.Settings.Default.BibliotecaConnectionString;

            connection = new SqlConnection(connectionString);

            command = new SqlCommand("SELECT SENHA FROM USUARIO WHERE LOGIN = @LOGIN ", connection);

            command.Parameters.Add("@LOGIN", System.Data.SqlDbType.NVarChar);
            command.Parameters["@LOGIN"].Value = tbUsername.Text;

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

                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    if (reader["SENHA"].ToString().Equals(tbPassword.Text))
                    {
                        db.Visible = true;
                        this.Close();
                    }
                    else
                    {
                        errorProvider2.SetError(tbUsername, "Usuário ou Senha inválidos!");
                    }
                }
                else
                {
                    errorProvider2.SetError(tbUsername, "Usuário ou Senha inválidos!");
                }
                reader.Close();

            }catch(Exception error)
            {
                MessageBox.Show(error.Message, "Falha no Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
