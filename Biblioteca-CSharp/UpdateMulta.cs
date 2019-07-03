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
    public partial class UpdateMulta : Form
    {
        private int id;
        private int idUsuario;
        private Multa multa;
        public UpdateMulta(int id, int idUsuario, Multa multa)
        {
            InitializeComponent();
            this.multa = multa;
            this.id = id;
            this.idUsuario = idUsuario;
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
                "UPDATE MULTA SET ID_USUARIO=@ID_USUARIO, ID_DEVOLUCAO=@ID_DEVOLUCAO, VALOR=@VALOR, PAGO=@PAGO " +
                    "WHERE ID = @ID", conn);

            comm.Parameters.Add("@ID", System.Data.SqlDbType.Int);
            comm.Parameters["@ID"].Value = id;

            comm.Parameters.Add("@ID_USUARIO", System.Data.SqlDbType.Int);
            comm.Parameters["@ID_USUARIO"].Value = Convert.ToInt32(cbUsuario.SelectedValue);

            comm.Parameters.Add("@ID_DEVOLUCAO", System.Data.SqlDbType.Int);
            comm.Parameters["@ID_DEVOLUCAO"].Value = Convert.ToInt32(cbDevolucao.SelectedValue);

            comm.Parameters.Add("@VALOR", System.Data.SqlDbType.Float);
            comm.Parameters["@VALOR"].Value = Convert.ToDouble(valor.Text);

            comm.Parameters.Add("@PAGO", System.Data.SqlDbType.Int);
            comm.Parameters["@PAGO"].Value = Convert.ToInt32(cbPago.SelectedValue);

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
                    this.Close();
                }
                multa.dataTable6TableAdapter.Fill(multa.bibliotecaDataSet.DataTable6);
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
                "SELECT * FROM MULTA WHERE ID=@ID", conn);

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
                        valor.Text= reader["VALOR"].ToString();
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

        private void UpdateMulta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet.DEVOLUCAO' table. You can move, or remove it, as needed.
            this.dEVOLUCAOTableAdapter.Fill(this.bibliotecaDataSet.DEVOLUCAO);
            // TODO: This line of code loads data into the 'bibliotecaDataSet.USUARIO' table. You can move, or remove it, as needed.
            this.uSUARIOTableAdapter.Fill(this.bibliotecaDataSet.USUARIO);

        }
    }
}
