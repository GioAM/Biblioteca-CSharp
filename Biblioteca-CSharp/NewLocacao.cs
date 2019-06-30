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
    public partial class NewLocacao : Form
    {
        private Locacao locacao;
        public NewLocacao(Locacao locacao)
        {
            this.locacao = locacao;
            InitializeComponent();
        }
        private void btSalvar_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            SqlCommand commItem;
            bool bIsOperationOK = true;

            string connectionString = Properties.Settings.Default.BibliotecaConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand( "INSERT INTO LOCACAO (ID_USUARIO , DATA, VENCIMENTO) " +
                "VALUES (@ID_USUARIO, @DATA, @VENCIMENTO)", conn);
            commItem = new SqlCommand("INSERT INTO ITEM_LOCACAO (ID_LOCACAO, ID_LIVRO) " +
                "VALUES (@ID_LOCACAO, @ID_LIVRO)", conn);

            comm.Parameters.Add("@ID_USUARIO", System.Data.SqlDbType.Int);
            comm.Parameters["@ID_USUARIO"].Value = Convert.ToInt32(cbUsuario.SelectedValue);

            comm.Parameters.Add("@DATA", System.Data.SqlDbType.Date);
            comm.Parameters["@DATA"].Value = data.Value;

            comm.Parameters.Add("@VENCIMENTO", System.Data.SqlDbType.Date);
            comm.Parameters["@VENCIMENTO"].Value = vencimento.Value;

            commItem.Parameters.Add("@ID_LOCACAO", System.Data.SqlDbType.Int);
            commItem.Parameters["@ID_LOCACAO"].Value = Convert.ToInt32(getId());

            commItem.Parameters.Add("@ID_LIVRO", System.Data.SqlDbType.Int);
            commItem.Parameters["@ID_LIVRO"].Value = Convert.ToInt32(cbLivro.SelectedValue);

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
                    commItem.ExecuteNonQuery();
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
                    locacao.dataTable4TableAdapter.Fill(locacao.bibliotecaDataSet.DataTable4);
                    this.Close();
                }
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.uSUARIOTableAdapter.FillBy(this.bibliotecaDataSet.USUARIO);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        public string getId()
        {
            string codigo = "";
            string connectionString = Properties.Settings.Default.BibliotecaConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            string sql = "SELECT max(ID) AS 'ID' FROM LOCACAO";
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                codigo = reader["ID"].ToString();
            }
            Console.WriteLine(codigo);
            conn.Close();
            return codigo;
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.uSUARIOTableAdapter.FillBy1(this.bibliotecaDataSet.USUARIO);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void NewLocacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet.LIVRO' table. You can move, or remove it, as needed.
            this.lIVROTableAdapter.Fill(this.bibliotecaDataSet.LIVRO);
            // TODO: This line of code loads data into the 'bibliotecaDataSet.USUARIO' table. You can move, or remove it, as needed.
            this.uSUARIOTableAdapter.Fill(this.bibliotecaDataSet.USUARIO);

        }
    }
}
