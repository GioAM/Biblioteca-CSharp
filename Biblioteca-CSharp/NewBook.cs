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
    public partial class NewBook : Form
    {
        public NewBook()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            SqlConnection connection;
            SqlCommand command;
            bool isOperationOk = true;

            string connectionString = Properties.Settings.Default.BibliotecaConnectionString;

            connection = new SqlConnection(connectionString);

            command = new SqlCommand(
                "INSERT INTO LIVRO (NOME, AUTOR, EDICAO, ANO, QUANTIDADE)" +
                "VALUES (@NOME, @AUTOR, @EDICAO, @ANO, @QUANTIDADE) ", connection);

            try
            {
                isOperationOk = true;
                if (String.IsNullOrEmpty(tbNome.Text))
                {
                    errorNome.SetError(tbNome, "Nome é um campo obrigatório!");
                    isOperationOk = false;
                }
                else
                {
                    command.Parameters.Add("@NOME", System.Data.SqlDbType.NVarChar);
                    command.Parameters["@NOME"].Value = tbNome.Text;
                    errorNome.SetError(tbNome, "");
                }

                if (String.IsNullOrEmpty(tbAutor.Text))
                {
                    errorAutor.SetError(tbAutor, "Autor é um campo obrigatório!");
                    isOperationOk = false;
                }
                else
                {
                    command.Parameters.Add("@AUTOR", System.Data.SqlDbType.NVarChar);
                    command.Parameters["@AUTOR"].Value = tbAutor.Text;
                    errorAutor.SetError(tbAutor, "");
                }

                if (String.IsNullOrEmpty(tbEdicao.Text))
                {
                    errorEdicao.SetError(tbEdicao, "Edição é um campo obrigatório!");
                    isOperationOk = false;
                }
                else
                {
                    command.Parameters.Add("@EDICAO", System.Data.SqlDbType.NVarChar);
                    command.Parameters["@EDICAO"].Value = tbAutor.Text;
                    errorEdicao.SetError(tbEdicao, "");
                }

                command.Parameters.Add("@ANO", System.Data.SqlDbType.Int);
                command.Parameters["@ANO"].Value = Convert.ToInt32(tbAno.Text);

                if (String.IsNullOrEmpty(tbQuantidade.Text))
                {
                    errorQuantidade.SetError(tbQuantidade, "Quantidade é um campo obrigatório!");
                    isOperationOk = false;
                }
                else
                {
                    command.Parameters.Add("@QUANTIDADE", System.Data.SqlDbType.Int);
                    command.Parameters["@QUANTIDADE"].Value = Convert.ToInt32(tbQuantidade.Text);
                    errorQuantidade.SetError(tbQuantidade, "");
                }

                if (isOperationOk)
                {
                    connection.Open();

                    command.ExecuteNonQuery();
                    MessageBox.Show("Livro Cadastrado com sucesso!", "Cadastro Válido", MessageBoxButtons.OK);
                    this.Close();

                }
            }
            catch (Exception error)
            {
                isOperationOk = false;
                MessageBox.Show(error.Message, "Campos Incorretos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
