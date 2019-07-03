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
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }

        private void btNewBook_Click(object sender, EventArgs e)
        {
            NewBook newBook = new NewBook(this);
            newBook.ShowDialog();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet.DataTable3' table. You can move, or remove it, as needed.
            this.dataTable3TableAdapter.Fill(this.bibliotecaDataSet.DataTable3);

        }

        private void btNewBook_Click_1(object sender, EventArgs e)
        {
            NewBook nBook = new NewBook(this);
            nBook.Show();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(idToModify.Text))
            {
                UpdateBook book = new UpdateBook(Convert.ToInt32(idToModify.Text), this);
                book.Show();
            }
            else
            {
                MessageBox.Show("Nenhum livro selecionado. Selecione uma linha para alterar!", "Comando Inválido", MessageBoxButtons.OK);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idToModify.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(idToModify.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Deseja excluir registro " + idToModify.Text + " ?", "Alerta", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlConnection conn;
                    SqlCommand comm;
                    bool bIsOperationOK = true;

                    string connectionString = Properties.Settings.Default.BibliotecaConnectionString;


                    conn = new SqlConnection(connectionString);

                    comm = new SqlCommand("DELETE FROM LIVRO WHERE ID = @Codigo", conn);
                    comm.Parameters.Add("@Codigo", System.Data.SqlDbType.Int);
                    comm.Parameters["@Codigo"].Value = Convert.ToInt32(idToModify.Text);

                    try
                    {
                        try
                        {
                            // Abre a Conexão com o BD
                            conn.Open();
                        }
                        catch (Exception error)
                        {
                            bIsOperationOK = false;
                            MessageBox.Show(error.Message, "Erro ao abrir conexão com o Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        try
                        {
                            comm.ExecuteNonQuery();
                        }
                        catch (Exception error)
                        {
                            bIsOperationOK = false;
                            MessageBox.Show(error.Message,
                                "Erro ao executar comando SQL",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch { }
                    finally
                    {
                        // Fecha a Conexão com o BD
                        conn.Close();

                        if (bIsOperationOK == true)
                        {
                            // Chama Função que atualiza os dados no DataGridView
                            MessageBox.Show("Registro Excluído!", "Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.dataTable3TableAdapter.Fill(this.bibliotecaDataSet.DataTable3);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhum livro selecionado. Selecione uma linha para deletar!", "Comando Inválido", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RelatorioLivros rel = new RelatorioLivros();
            rel.Show();
        }
    }
}
