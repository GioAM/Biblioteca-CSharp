using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;

namespace Biblioteca_CSharp
{
    public partial class NewEditora : Form
    {
        private Editora editora { get; set; }
        public NewEditora(Editora editora)
        {
            InitializeComponent();
            this.editora = editora;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            bool bIsOperationOK = true;

            string connectionString = Properties.Settings.Default.BibliotecaConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
                "INSERT INTO EDITORA (NOME, CNPJ, TELEFONE, RESPONSAVEL, EMAIL) " +
                "VALUES (@NOME, @CNPJ, @TELEFONE, @RESPONSAVEL, @EMAIL)", conn);


            // Add command parameters
            comm.Parameters.Add("@NOME", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@NOME"].Value = tbNome.Text;

            comm.Parameters.Add("@CNPJ", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CNPJ"].Value = tbCNPJ.Text;

            comm.Parameters.Add("@TELEFONE", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@TELEFONE"].Value = tbTelefone.Text;

            comm.Parameters.Add("@RESPONSAVEL", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@RESPONSAVEL"].Value = tbResponsavel.Text;

            comm.Parameters.Add("@EMAIL", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@EMAIL"].Value = tbEmail.Text;
            try
            {
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
                    MessageBox.Show("Registro Cadastrado!", "Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    editora.eDITORATableAdapter.Fill(editora.bibliotecaDataSet.EDITORA);
                    this.Close();
                }
            }
        }
    }
}
