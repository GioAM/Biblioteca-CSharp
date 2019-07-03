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
    public partial class UpdateDevolucao : Form
    {
        private Devolucao deve;
        private int id;

        public UpdateDevolucao(Devolucao devolucao, int id)
        {
            InitializeComponent();
            this.deve = devolucao;
            this.id = id;
            getData();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            bool bIsOperationOK = true;

            string connectionString = Properties.Settings.Default.BibliotecaConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
                "UPDATE DEVOLUCAO SET DATA=@DATA, ID_LOCACAO=@ID_LOCACAO " +
                    "WHERE ID = @ID", conn);

            comm.Parameters.Add("@ID", System.Data.SqlDbType.Int);
            comm.Parameters["@ID"].Value = id;

            comm.Parameters.Add("@DATA", System.Data.SqlDbType.DateTime);
            comm.Parameters["@DATA"].Value = devolucao.Value;

            comm.Parameters.Add("@ID_LOCACAO", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@ID_LOCACAO"].Value = cbLocacao.SelectedValue;

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
                    MessageBox.Show(error.Message,
                        "Erro ao abrir conexão com o Banco de Dados",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try
                {
                    // Executa o Commando SQL
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
                    MessageBox.Show("Registro Cadastrado!",
                        "Banco de Dados",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    deve.dataTable5TableAdapter.Fill(deve.bibliotecaDataSet.DataTable5);
                    this.Close();
                }
            }
        }
        public void getData()
        {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;
            string connectionString = Properties.Settings.Default.BibliotecaConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
                "SELECT * FROM DEVOLUCAO WHERE ID=@ID", conn);

            // Recupera o registro do banco de dados a partir da chave primária 'Codigo'
            comm.Parameters.Add("@ID", System.Data.SqlDbType.Int);
            comm.Parameters["@ID"].Value = id;

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
                        devolucao.Value = Convert.ToDateTime(reader["DATA"]);
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

        private void devolucao_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UpdateDevolucao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet.LOCACAO' table. You can move, or remove it, as needed.
            this.lOCACAOTableAdapter.Fill(this.bibliotecaDataSet.LOCACAO);

        }
    }
}
