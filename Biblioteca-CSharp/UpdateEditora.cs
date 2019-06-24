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
    public partial class UpdateEditora : Form
    {
        private Editora editora { get; set; }
        private int id { get; set; }
        public UpdateEditora(Editora editora, int id)
        {
            this.editora = editora;
            this.id = id;
            InitializeComponent();
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
                "UPDATE EDITORA SET NOME=@NOME, CNPJ=@CNPJ, EMAIL=@EMAIL, RESPONSAVEL=@RESPONSAVEL, TELEFONE=@TELEFONE " +
                    "WHERE ID = @ID", conn);

            comm.Parameters.Add("@ID", System.Data.SqlDbType.Int);
            comm.Parameters["@ID"].Value = id;

            comm.Parameters.Add("@NOME", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@NOME"].Value = tbNome.Text;

            comm.Parameters.Add("@CNPJ"  , System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CNPJ"].Value = tbCNPJ.Text;

            comm.Parameters.Add("@EMAIL", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@EMAIL"].Value = tbEmail.Text;

            comm.Parameters.Add("@RESPONSAVEL", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@RESPONSAVEL"].Value = tbResponsavel.Text;

            comm.Parameters.Add("@TELEFONE", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@TELEFONE"].Value = tbTelefone.Text;

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
                    editora.eDITORATableAdapter.Fill(editora.bibliotecaDataSet.EDITORA);
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

            comm = new SqlCommand( "SELECT * FROM EDITORA WHERE ID=@ID", conn);

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
                        tbNome.Text = reader["NOME"].ToString();
                        tbCNPJ.Text = reader["CNPJ"].ToString();
                        tbEmail.Text = reader["EMAIL"].ToString();
                        tbResponsavel.Text = reader["RESPONSAVEL"].ToString();
                        tbTelefone.Text = reader["TELEFONE"].ToString();
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
