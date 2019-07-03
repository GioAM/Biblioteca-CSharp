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
    public partial class NewDevolucao : Form
    {
        private double multaTotal;
        private int usuario;
        private Devolucao devolucaoForm;

        public NewDevolucao(Devolucao devolucaoForm)
        {
            InitializeComponent();
            this.devolucaoForm = devolucaoForm;
            multaTotal = 0;
            devolucao.Value = DateTime.Today;
        }

        private void NewDevolucao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet.LOCACAO' table. You can move, or remove it, as needed.
            this.lOCACAOTableAdapter.Fill(this.bibliotecaDataSet.LOCACAO);

        }

        private void cbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateMulta();
        }
        private void updateMulta()
        {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;
            int dias = 0;
            string connectionString = Properties.Settings.Default.BibliotecaConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
                "SELECT * FROM LOCACAO WHERE ID=@ID", conn);

            comm.Parameters.Add("@ID", System.Data.SqlDbType.Int);
            comm.Parameters["@ID"].Value = Convert.ToInt32(cbLocacao.SelectedValue);

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
                        validade.Value = Convert.ToDateTime(reader["VENCIMENTO"]);
                        dias = Convert.ToInt32(devolucao.Value.Subtract(validade.Value).TotalDays);
                        usuario = Convert.ToInt32(reader["ID_USUARIO"]);
                    }
                    reader.Close();
                    Console.WriteLine(dias);
                    if(dias > 0)
                    {
                        multaTotal = Math.Round(1 *(Math.Pow(1.01, dias)),2);
                        multa.Text = Convert.ToString(multaTotal);
                        multa.Enabled = true;
                    }
                    else
                    {
                        multaTotal = 0;
                        multa.Text = Convert.ToString(multaTotal);
                        multa.Enabled = false;
                    }
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
            updateMulta();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            SqlCommand commItem;
            SqlCommand commUser, commMulta;
            SqlDataReader reader;
            bool bIsOperationOK = true;

            string connectionString = Properties.Settings.Default.BibliotecaConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand("INSERT INTO DEVOLUCAO (ID_LOCACAO , DATA) " +
                "VALUES (@ID_LOCACAO, @DATA)", conn);
            

            comm.Parameters.Add("@ID_LOCACAO", System.Data.SqlDbType.Int);
            comm.Parameters["@ID_LOCACAO"].Value = Convert.ToInt32(cbLocacao.SelectedValue);

            comm.Parameters.Add("@DATA", System.Data.SqlDbType.Date);
            comm.Parameters["@DATA"].Value = devolucao.Value;


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
                if (multaTotal > 0)
                {
                    commItem = new SqlCommand("INSERT INTO MULTA (VALOR, ID_DEVOLUCAO , ID_USUARIO, PAGO) " +
                    "VALUES (@VALOR, @ID_DEVOLUCAO, @ID_USUARIO, @PAGO)", conn);

                    commItem.Parameters.Add("@VALOR", System.Data.SqlDbType.Float);
                    commItem.Parameters["@VALOR"].Value = multaTotal;

                    commItem.Parameters.Add("@ID_DEVOLUCAO", System.Data.SqlDbType.Int);
                    commItem.Parameters["@ID_DEVOLUCAO"].Value = getId();

                    commItem.Parameters.Add("@ID_USUARIO", System.Data.SqlDbType.Int);
                    commItem.Parameters["@ID_USUARIO"].Value = usuario;

                    commItem.Parameters.Add("@PAGO", System.Data.SqlDbType.Int);
                    commItem.Parameters["@PAGO"].Value = 0;

                    commMulta = new SqlCommand("SELECT * FROM USUARIO WHERE ID=@ID", conn);
                    commMulta.Parameters.Add("@ID", System.Data.SqlDbType.Int);
                    commMulta.Parameters["@ID"].Value = usuario;
                    double multaUsuario = 0;

                    reader = commMulta.ExecuteReader();
                    if (reader.Read())
                    {
                        multaUsuario = Convert.ToDouble(reader["MULTA"]);
                    }

                    reader.Close();
                    commUser = new SqlCommand("UPDATE USUARIO SET MULTA=@MULTA, ATIVO=0 WHERE ID=@ID", conn);

                    commUser.Parameters.Add("@MULTA", System.Data.SqlDbType.Float);
                    commUser.Parameters["@MULTA"].Value = multaTotal + multaUsuario;

                    commUser.Parameters.Add("@ID", System.Data.SqlDbType.Int);
                    commUser.Parameters["@ID"].Value = usuario;

                    try
                    {
                        commItem.ExecuteNonQuery();
                        commUser.ExecuteNonQuery();
                    }
                    catch (Exception error)
                    {
                        bIsOperationOK = false;
                        MessageBox.Show(error.Message,
                            "Erro ao executar comando SQL",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch { }
            finally
            {
                conn.Close();
                devolucaoForm.dataTable5TableAdapter.Fill(devolucaoForm.bibliotecaDataSet.DataTable5);
                if (bIsOperationOK == true)
                {
                    MessageBox.Show("Registro Cadastrado!", "Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
        public int getId()
        {
            string codigo = "";
            string connectionString = Properties.Settings.Default.BibliotecaConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            string sql = "SELECT max(ID) AS 'ID' FROM DEVOLUCAO";
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                codigo = reader["ID"].ToString();
            }
            reader.Close();
            conn.Close();
            return Convert.ToInt32(codigo);
        }

        private void validade_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
