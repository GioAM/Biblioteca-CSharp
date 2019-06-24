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
    public partial class UpdateBook : Form
    {
        private int idBook;
        private Books book;
        public UpdateBook(int idBook, Books book)
        {
            InitializeComponent();
            this.idBook = idBook;
            this.book = book;
            getData();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand command;
            bool isOperationOk = true;

            string connectionString = Properties.Settings.Default.BibliotecaConnectionString;
            conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
            }
            catch (Exception error)
            {
                isOperationOk = false;
                MessageBox.Show(error.Message,
                    "Erro ao abrir conexão com o Banco de Dados",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            command = new SqlCommand("UPDATE LIVRO SET NOME=@NOME, AUTOR=@AUTOR, EDICAO=@EDICAO, ANO=@ANO, ID_EDITORA=@ID_EDITORA " +
                "WHERE ID=@ID", conn);

            command.Parameters.Add("@ID", System.Data.SqlDbType.Int);
            command.Parameters["@ID"].Value = idBook;

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
                command.Parameters["@EDICAO"].Value = tbEdicao.Text;
                errorEdicao.SetError(tbEdicao, "");
            }

            command.Parameters.Add("@ANO", System.Data.SqlDbType.Int);
            command.Parameters["@ANO"].Value = Convert.ToInt32(tbAno.Text);

            command.Parameters.Add("@ID_EDITORA", System.Data.SqlDbType.Int);
            command.Parameters["@ID_EDITORA"].Value = Convert.ToInt32(cbEditora.SelectedValue);
            Console.WriteLine(cbEditora.SelectedValue);

            if (isOperationOk)
            {
                try
                {
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception error)
                    {
                        isOperationOk = false;
                        MessageBox.Show(error.Message,
                            "Erro ao executar comando SQL",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch { }
                finally
                {
                    conn.Close();

                    if (isOperationOk == true)
                    {
                        MessageBox.Show("Registro Alterado!", "Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        book.dataTable3TableAdapter.Fill(book.bibliotecaDataSet.DataTable3);
                        this.Close();
                    }
                }
            }
        }
        private void getData()
        {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;
            string connectionString = Properties.Settings.Default.BibliotecaConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
                "SELECT * FROM LIVRO WHERE ID=@ID", conn);

            // Recupera o registro do banco de dados a partir da chave primária 'Codigo'
            comm.Parameters.Add("@ID", System.Data.SqlDbType.Int);
            comm.Parameters["@ID"].Value = idBook;

            try
            {
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao abrir conexão com o Banco de Dados",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try
                {
                    reader = comm.ExecuteReader();
                    if (reader.Read())
                    {
                        tbNome.Text = reader["NOME"].ToString();
                        tbAno.Text = reader["ANO"].ToString();
                        tbEdicao.Text = reader["EDICAO"].ToString();
                        tbAutor.Text = reader["AUTOR"].ToString();
                        cbEditora.SelectedValue = "ROCCO";
                    }
                    reader.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Erro ao executar comando SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch { }
            finally
            {
                conn.Close();
            }

        }

        private void UpdateBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet.EDITORA' table. You can move, or remove it, as needed.
            this.eDITORATableAdapter.Fill(this.bibliotecaDataSet.EDITORA);

        }
    }
}
