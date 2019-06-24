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
    public partial class UpdateLocacao : Form
    {
        private Locacao locacao { get; set; }
        private int idLocacao { get; set; }
        private int idItemLocacao { get; set; }
        public UpdateLocacao(Locacao locacao, int idLocacao, int idItemLocacao)
        {
            this.locacao = locacao;
            this.idItemLocacao = idItemLocacao;
            this.idLocacao = idLocacao;
            InitializeComponent();
            getData();
        }

        private void UpdateLocacao_Load(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            bool bIsOperationOK = true;

            string connectionString = Properties.Settings.Default.BibliotecaConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand("UPDATE LOCACAO SET DATA=@DATA, VENCIMENTO=@VENCIMENTO, ID_USUARIO=@ID_USUARIO " +
                    "WHERE ID = @ID", conn);
            comm = new SqlCommand("UPDATE ITEM_LOCACAO SET ID_LIVRO=@ID_LIVRO " +
                    "WHERE ID = @ID", conn);

            comm.Parameters.Add("@ID", System.Data.SqlDbType.Int);
            comm.Parameters["@ID"].Value = idLocacao;

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
                    MessageBox.Show("Registro Cadastrado!", "Banco de Dados",MessageBoxButtons.OK, MessageBoxIcon.Information);

                    locacao.dataTable4TableAdapter.Fill(locacao.bibliotecaDataSet.DataTable4);
                    this.Close();
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

            comm = new SqlCommand("SELECT * FROM LOCACAO WHERE ID=@ID", conn);

            comm.Parameters.Add("@ID", System.Data.SqlDbType.Int);
            comm.Parameters["@ID"].Value = idLocacao;

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
                        data.Value = Convert.ToDateTime(reader["DATA"].ToString());
                        vencimento.Value = Convert.ToDateTime(reader["VENCIMENTO"].ToString());
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
    }
}
