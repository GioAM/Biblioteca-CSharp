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
    public partial class Devolucao : Form
    {
        public Devolucao()
        {
            InitializeComponent();
        }

        private void Devolucao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet.DataTable5' table. You can move, or remove it, as needed.
            this.dataTable5TableAdapter.Fill(this.bibliotecaDataSet.DataTable5);

        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            NewDevolucao dev = new NewDevolucao(this);
            dev.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(idToModify.Text) )
            {
                DialogResult dialogResult = MessageBox.Show("Deseja excluir registro " + idToModify.Text + " ?", "Alerta", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlConnection conn;
                    SqlCommand comm;
                    bool bIsOperationOK = true;

                    string connectionString = Properties.Settings.Default.BibliotecaConnectionString;


                    conn = new SqlConnection(connectionString);

                    comm = new SqlCommand("DELETE FROM DEVOLUCAO WHERE ID = @Codigo", conn);

                    comm.Parameters.Add("@Codigo", System.Data.SqlDbType.Int);
                    comm.Parameters["@Codigo"].Value = Convert.ToInt32(idToModify.Text);

                    try
                    {
                        try
                        {
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
                        conn.Close();

                        if (bIsOperationOK == true)
                        {
                            MessageBox.Show("Registro Excluído!", "Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        this.dataTable5TableAdapter.Fill(this.bibliotecaDataSet.DataTable5);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhuma devolução selecionada. Selecione uma linha para deletar!", "Comando Inválido", MessageBoxButtons.OK);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            idToModify.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(idToModify.Text))
            {
                UpdateDevolucao del = new UpdateDevolucao(this, Convert.ToInt32(idToModify.Text));
                del.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nenhuma devolução selecionada. Selecione uma linha para alterar!", "Comando Inválido", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RelatorioDevolucao rel = new RelatorioDevolucao();
            rel.Show();

        }

        private void idToModify_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
