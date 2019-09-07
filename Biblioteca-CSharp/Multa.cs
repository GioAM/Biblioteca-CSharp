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
    public partial class Multa : Form
    {
        public Multa()
        {
            InitializeComponent();
        }

        private void Multa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet.DataTable6' table. You can move, or remove it, as needed.
            this.dataTable6TableAdapter.Fill(this.bibliotecaDataSet.DataTable6);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
             
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idToModify.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            idUser.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
            tbMulta.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(idToModify.Text) || !String.IsNullOrEmpty(idUser.Text))
            {
                SqlConnection conn;
                SqlCommand commMulta, commUser;
                SqlCommand commItem;
                SqlDataReader reader;
                bool bIsOperationOK = true;

                string connectionString = Properties.Settings.Default.BibliotecaConnectionString;

                conn = new SqlConnection(connectionString);

                commMulta = new SqlCommand("UPDATE MULTA SET PAGO=@PAGO " +
                    "WHERE ID=@ID", conn);
                commUser = new SqlCommand("UPDATE USUARIO SET ATIVO=@ATIVO, MULTA=@MULTA " +
                   "WHERE ID=@ID", conn);
                commMulta.Parameters.Add("@ID", System.Data.SqlDbType.Int);
                commMulta.Parameters["@ID"].Value = Convert.ToInt32(idToModify.Text);
                commUser.Parameters.Add("@ID", System.Data.SqlDbType.Int);
                commUser.Parameters["@ID"].Value = Convert.ToInt32(idUser.Text);

                commItem = new SqlCommand("SELECT * FROM USUARIO WHERE ID=@ID", conn);
                commItem.Parameters.Add("@ID", System.Data.SqlDbType.Int);
                commItem.Parameters["@ID"].Value = Convert.ToInt32(idUser.Text);
              
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    bIsOperationOK = false;
                    MessageBox.Show(error.Message,
                        "Erro ao abrir conexão com o Banco de Dados",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                double multaUsuario = 0;

                reader = commItem.ExecuteReader();
                if (reader.Read())
                {
                    multaUsuario = Convert.ToDouble(reader["MULTA"].ToString());
                }
                reader.Close();
                double multaTotal = multaUsuario - Convert.ToDouble(tbMulta.Text);
                commMulta.Parameters.Add("@PAGO", System.Data.SqlDbType.Int);
                if (multaTotal <= 0)
                { 
                    commMulta.Parameters["@PAGO"].Value = 1;

                    commUser.Parameters.Add("@ATIVO", System.Data.SqlDbType.Int);
                    commUser.Parameters["@ATIVO"].Value = 1;

                    commUser.Parameters.Add("@MULTA", System.Data.SqlDbType.Float);
                    commUser.Parameters["@MULTA"].Value = 0.0;
                }
                else
                {
                    commMulta.Parameters["@PAGO"].Value = 0;

                    commUser.Parameters.Add("@ATIVO", System.Data.SqlDbType.Int);
                    commUser.Parameters["@ATIVO"].Value = 0;

                    commUser.Parameters.Add("@MULTA", System.Data.SqlDbType.Float);
                    commUser.Parameters["@MULTA"].Value = multaTotal;
                }
                try

                {
                    commMulta.ExecuteNonQuery();
                    commUser.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    bIsOperationOK = false;
                    MessageBox.Show(error.Message,
                        "Erro ao executar comando SQL",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            try
            {
            }
            catch { }
            finally
            {

                conn.Close();

                if (bIsOperationOK == true)
                {
                    MessageBox.Show("Multa Paga!",
                        "Banco de Dados",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.dataTable6TableAdapter.Fill(this.bibliotecaDataSet.DataTable6);
            }
            }
            else
            {
                MessageBox.Show("Nenhuma Multa selecionada. Selecione uma linha para pagar!", "Comando Inválido", MessageBoxButtons.OK);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RelatorioMultas rel = new RelatorioMultas();
            rel.Show();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(idToModify.Text) || !String.IsNullOrEmpty(idUser.Text) )
            {
                DialogResult dialogResult = MessageBox.Show("Deseja excluir registro " + idToModify.Text + " ?", "Alerta", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlConnection conn;
                    SqlCommand comm;
                    bool bIsOperationOK = true;

                    string connectionString = Properties.Settings.Default.BibliotecaConnectionString;


                    conn = new SqlConnection(connectionString);

                    comm = new SqlCommand("DELETE FROM MULTA WHERE ID = @Codigo", conn);

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
                        this.dataTable6TableAdapter.Fill(this.bibliotecaDataSet.DataTable6);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhuma Multa selecionada. Selecione uma linha para deletar!", "Comando Inválido", MessageBoxButtons.OK);
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(idToModify.Text) || !String.IsNullOrEmpty(idUser.Text))
            {
                UpdateMulta multa = new UpdateMulta(Convert.ToInt32(idToModify.Text), Convert.ToInt32(idUser.Text), this);
                multa.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nenhuma multa selecionada. Selecione uma linha para alterar!", "Comando Inválido", MessageBoxButtons.OK);
            }

        }
    }
}
