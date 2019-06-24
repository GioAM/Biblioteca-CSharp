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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewUser user = new NewUser(this);
            user.ShowDialog();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.bibliotecaDataSet.DataTable1);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

                    comm = new SqlCommand("DELETE FROM USUARIO WHERE ID = @Codigo", conn);
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
                            this.dataTable1TableAdapter.Fill(this.bibliotecaDataSet.DataTable1);
                        }
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
            idToModify.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(idToModify.Text))
            {
                UpdateUser user = new UpdateUser(Convert.ToInt32(idToModify.Text), this);
                user.Show();
            }
            else
            {
                MessageBox.Show("Nenhum usuário selecionado. Selecione uma linha para alterar!", "Comando Inválido", MessageBoxButtons.OK);
            }
        }
    }
}
