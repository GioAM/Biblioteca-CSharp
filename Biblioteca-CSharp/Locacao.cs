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
    public partial class Locacao : Form
    {
        public Locacao()
        {
            InitializeComponent();
        }

        private void Locacao_Load(object sender, EventArgs e)
        {
            this.dataTable4TableAdapter.Fill(this.bibliotecaDataSet.DataTable4);
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            NewLocacao locacao = new NewLocacao(this);
            locacao.ShowDialog();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(idToModify.Text) && !String.IsNullOrEmpty(idToModifyItem.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Deseja excluir registro " + idToModify.Text + " ?", "Alerta", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlConnection conn;
                    SqlCommand comm;
                    SqlCommand comm_item;
                    bool bIsOperationOK = true;

                    string connectionString = Properties.Settings.Default.BibliotecaConnectionString;


                    conn = new SqlConnection(connectionString);

                    comm = new SqlCommand("DELETE FROM LOCACAO WHERE ID = @Codigo", conn);
                    comm_item = new SqlCommand("DELETE FROM ITEM_LOCACAO WHERE ID = @Codigo", conn);

                    comm.Parameters.Add("@Codigo", System.Data.SqlDbType.Int);
                    comm.Parameters["@Codigo"].Value = Convert.ToInt32(idToModify.Text);

                    comm_item.Parameters.Add("@Codigo", System.Data.SqlDbType.Int);
                    comm_item.Parameters["@Codigo"].Value = Convert.ToInt32(idToModifyItem.Text);

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
                            comm_item.ExecuteNonQuery();
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
                        this.dataTable4TableAdapter.Fill(this.bibliotecaDataSet.DataTable4);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhum usuário selecionado. Selecione uma linha para deletar!", "Comando Inválido", MessageBoxButtons.OK);
            }
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            idToModifyItem.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            idToModify.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(idToModify.Text) && !String.IsNullOrEmpty(idToModifyItem.Text))
            {
                UpdateLocacao loc = new UpdateLocacao(this, Convert.ToInt32(idToModify.Text), Convert.ToInt32(idToModifyItem.Text));
                loc.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nenhum usuário selecionado. Selecione uma linha para alterar!", "Comando Inválido", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RelatorioLocacao rel = new RelatorioLocacao();
            rel.Show();
        }
    }
}