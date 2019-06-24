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
    public partial class UpdateUser : Form
    {
        private int IdUser { get; set; }
        private String CpfUser { get; set; }
        private Users user { get; set; }

        public UpdateUser(int id, Users user)
        {  
            InitializeComponent();
            getData(id);
            IdUser = id;
            tbSenha.PasswordChar = '*';
            tbEstado.MaxLength = 2;
            this.user = user; 
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand command;
            SqlCommand commandAddress;
            SqlCommand commandIdEndereco;
            SqlDataReader reader;
            bool isOperationOk = true;

            string connectionString = Properties.Settings.Default.BibliotecaConnectionString;
            conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
            }
            catch (Exception error)
            {
                isOperationOk = false;
                MessageBox.Show(error.Message,
                    "Erro ao abrir conexão com o Banco de Dados",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            command = new SqlCommand("UPDATE USUARIO SET NOME=@NOME, CPF=@CPF, IDADE=@IDADE, TELEFONE=@TELEFONE, " +
                "ATIVO=@ATIVO, EMAIL=@EMAIL, FUNCIONARIO=@FUNCIONARIO, LOGIN=@LOGIN, SENHA=@SENHA " +
                "WHERE ID=@ID", conn);
            commandAddress = new SqlCommand("UPDATE ENDERECO SET NUMERO=@NUMERO, RUA=@RUA, COMPLEMENTO=@COMPLEMENTO, " +
                "CEP=@CEP, CIDADE=@CIDADE, ESTADO=@ESTADO, PAIS=@PAIS, BAIRRO=@BAIRRO " +
                   "WHERE ID=@ID", conn);

            commandIdEndereco = new SqlCommand("SELECT ID_ENDERECO FROM USUARIO WHERE ID=@ID", conn);
            commandIdEndereco.Parameters.Add("@ID", System.Data.SqlDbType.Int);
            commandIdEndereco.Parameters["@ID"].Value = IdUser;

            reader = commandIdEndereco.ExecuteReader();
            if (reader.Read())
            {
                commandAddress.Parameters.Add("@ID", System.Data.SqlDbType.Int);
                commandAddress.Parameters["@ID"].Value = Convert.ToInt32(reader["ID_ENDERECO"].ToString());
            }
            reader.Close();

            command.Parameters.Add("@ID", System.Data.SqlDbType.Int);
            command.Parameters["@ID"].Value = IdUser;

            isOperationOk  = true;
            if (String.IsNullOrEmpty(tbNumero.Text))
            {
                errorNumero.SetError(tbNumero, "Número é um campo obrigatório!");
                isOperationOk = false;
            }
            else
            {
                commandAddress.Parameters.Add("@NUMERO", System.Data.SqlDbType.Int);
                commandAddress.Parameters["@NUMERO"].Value = Convert.ToInt32(tbNumero.Text);
                errorNumero.SetError(tbNumero, "");
            }

            if (String.IsNullOrEmpty(tbRua.Text))
            {
                errorRua.SetError(tbRua, "Rua é um campo obrigatório!");
                isOperationOk = false;
            }
            else
            {
                commandAddress.Parameters.Add("@RUA", System.Data.SqlDbType.NVarChar);
                commandAddress.Parameters["@RUA"].Value = tbRua.Text;
                errorRua.SetError(tbRua, "");
            }

            commandAddress.Parameters.Add("@COMPLEMENTO", System.Data.SqlDbType.NVarChar);
            commandAddress.Parameters["@COMPLEMENTO"].Value = tbComplemento.Text;

            if (String.IsNullOrEmpty(tbCEP.Text) || tbCEP.Text.Equals("     -"))
            {
                errorCEP.SetError(tbCEP, "CEP é um campo obrigatório!");
                isOperationOk = false;
            }
            else
            {
                commandAddress.Parameters.Add("@CEP", System.Data.SqlDbType.NVarChar);
                commandAddress.Parameters["@CEP"].Value = tbCEP.Text;
                errorCEP.SetError(tbCEP, "");
            }

            if (String.IsNullOrEmpty(tbCidade.Text))
            {
                errorCidade.SetError(tbCidade, "Cidade é um campo obrigatório!");
                isOperationOk = false;
            }
            else
            {
                commandAddress.Parameters.Add("@CIDADE", System.Data.SqlDbType.NVarChar);
                commandAddress.Parameters["@CIDADE"].Value = tbCidade.Text;
                errorCidade.SetError(tbCidade, "");
            }

            if (String.IsNullOrEmpty(tbEstado.Text))
            {
                errorEstado.SetError(tbEstado, "Estado é um campo obrigatório!");
                isOperationOk = false;
            }
            else
            {
                commandAddress.Parameters.Add("@ESTADO", System.Data.SqlDbType.NVarChar);
                commandAddress.Parameters["@ESTADO"].Value = tbEstado.Text;
                errorEstado.SetError(tbEstado, "");
            }

            if (String.IsNullOrEmpty(tbPais.Text))
            {
                errorPais.SetError(tbPais, "País é um campo obrigatório!");
                isOperationOk = false;
            }
            else
            {
                commandAddress.Parameters.Add("@PAIS", System.Data.SqlDbType.NVarChar);
                commandAddress.Parameters["@PAIS"].Value = tbPais.Text;
                errorPais.SetError(tbPais, "");
            }

            if (String.IsNullOrEmpty(tbBairro.Text))
            {
                errorBairro.SetError(tbBairro, "Bairro é um campo obrigatório!");
                isOperationOk = false;
            }
            else
            {
                commandAddress.Parameters.Add("@BAIRRO", System.Data.SqlDbType.NVarChar);
                commandAddress.Parameters["@BAIRRO"].Value = tbBairro.Text;
                errorBairro.SetError(tbBairro, "");
            }

            if (String.IsNullOrEmpty(tbNome.Text))
            {
                errorNome.SetError(tbNome, "Nome é um campo obrigatório!");
                isOperationOk = false;
            }
            else
            {
                command.Parameters.Add("@NOME", System.Data.SqlDbType.NVarChar);
                command.Parameters["@NOME"].Value = tbNome.Text;
                errorNome.SetError(tbNome, "");
            }
            if (String.IsNullOrEmpty(tbCPF.Text) || tbCPF.Text.Equals("   .   .   -"))
            {
                errorCPF.SetError(tbCPF, "CPF é um campo obrigatório!");
                isOperationOk = false;
            }
            else
            {
                command.Parameters.Add("@CPF", System.Data.SqlDbType.NVarChar);
                command.Parameters["@CPF"].Value = tbCPF.Text;
                errorCPF.SetError(tbCPF, "");
            }

            if (String.IsNullOrEmpty(tbIdade.Text))
            {
                errorIdade.SetError(tbIdade, "Idade é um campo obrigatório!");
                isOperationOk = false;
            }
            else
            {
                command.Parameters.Add("@IDADE", System.Data.SqlDbType.Int);
                command.Parameters["@IDADE"].Value = Convert.ToInt32(tbIdade.Text);
                errorIdade.SetError(tbIdade, "");
            }

            if (String.IsNullOrEmpty(tbEmail.Text))
            {
                errorEmail.SetError(tbEmail, "E-mail é um campo obrigatório!");
                isOperationOk = false;
            }
            else
            {
                command.Parameters.Add("@EMAIL", System.Data.SqlDbType.NVarChar);
                command.Parameters["@EMAIL"].Value = tbEmail.Text;
                errorEmail.SetError(tbEmail, "");
            }
            if (String.IsNullOrEmpty(tbTelefone.Text) || tbTelefone.Text.Equals("(  )     -"))
            {
                errorTelefone.SetError(tbTelefone, "Telefone é um campo obrigatório!");
                isOperationOk = false;
            }
            else
            {
                command.Parameters.Add("@TELEFONE", System.Data.SqlDbType.NVarChar);
                command.Parameters["@TELEFONE"].Value = tbTelefone.Text;
                errorTelefone.SetError(tbTelefone, "");
            }

            command.Parameters.Add("@ATIVO", System.Data.SqlDbType.Int);
            command.Parameters["@ATIVO"].Value = Convert.ToInt32(cbUserEnable.Checked);

            command.Parameters.Add("@FUNCIONARIO", System.Data.SqlDbType.Int);
            command.Parameters["@FUNCIONARIO"].Value = Convert.ToInt32(cbIsAdminUser.Checked);

            if (cbIsAdminUser.Checked)
            {
                if (String.IsNullOrEmpty(tbLogin.Text))
                {
                    errorLogin.SetError(tbLogin, "O campo login é obrigatório para usuários administradores!");
                    isOperationOk = false;
                }
                else
                {
                    command.Parameters.Add("@LOGIN", System.Data.SqlDbType.NVarChar);
                    command.Parameters["@LOGIN"].Value = tbLogin.Text;
                    errorLogin.SetError(tbLogin, "");
                }

                if (String.IsNullOrEmpty(tbSenha.Text))
                {
                    errorSenha.SetError(tbSenha, "O campo senha é obrigatório para usuários administradores!");
                    isOperationOk = false;
                }
                else
                {
                    command.Parameters.Add("@SENHA", System.Data.SqlDbType.NVarChar);
                    command.Parameters["@SENHA"].Value = tbSenha.Text;
                    errorSenha.SetError(tbSenha, "");
                }
            }
            else
            {
                command.Parameters.Add("@LOGIN", System.Data.SqlDbType.NVarChar);
                command.Parameters["@LOGIN"].Value = "";
                command.Parameters.Add("@SENHA", System.Data.SqlDbType.NVarChar);
                command.Parameters["@SENHA"].Value = "";
            }
            if (isOperationOk)
            {
                try
                {
                    try
                    {
                        command.ExecuteNonQuery();
                        commandAddress.ExecuteNonQuery();
                    }
                    catch (Exception error)
                    {
                        isOperationOk = false;
                        MessageBox.Show(error.Message,
                            "Erro ao executar comando SQL",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch { }
                finally
                {
                    conn.Close();

                    if (isOperationOk == true)
                    {
                        MessageBox.Show("Registro Alterado!", "Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        user.dataTable1TableAdapter.Fill(user.bibliotecaDataSet.DataTable1);
                        this.Close();
                    }
                }
            }
        }
        private void getData(int id)
        {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;
            Console.WriteLine("iAd = " + id);
            string connectionString = Properties.Settings.Default.BibliotecaConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
                "SELECT USUARIO.NOME, USUARIO.CPF, USUARIO.IDADE, USUARIO.TELEFONE, USUARIO.ID_ENDERECO, USUARIO.ATIVO, USUARIO.MULTA, USUARIO.EMAIL, USUARIO.FUNCIONARIO, USUARIO.LOGIN," +
                "USUARIO.SENHA, ENDERECO.* FROM USUARIO " +
                "INNER JOIN ENDERECO ON USUARIO.ID_ENDERECO = ENDERECO.ID " +
                "WHERE USUARIO.ID = @ID ", conn);

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
                        tbNome.Text = reader["NOME"].ToString();
                        tbIdade.Text = reader["IDADE"].ToString();
                        tbEmail.Text = reader["EMAIL"].ToString();
                        tbCPF.Text = reader["CPF"].ToString();
                        CpfUser = reader["CPF"].ToString();
                        tbTelefone.Text = reader["TELEFONE"].ToString();
                        tbLogin.Text = reader["LOGIN"].ToString();
                        tbSenha.Text = reader["SENHA"].ToString();

                        tbRua.Text = reader["RUA"].ToString();
                        tbNumero.Text = reader["NUMERO"].ToString();
                        tbEstado.Text = reader["ESTADO"].ToString();
                        tbComplemento.Text = reader["COMPLEMENTO"].ToString();
                        tbPais.Text = reader["PAIS"].ToString();
                        tbCidade.Text = reader["CIDADE"].ToString();
                        tbCEP.Text = reader["CEP"].ToString();
                        tbBairro.Text = reader["BAIRRO"].ToString();
                        cbIsAdminUser.Checked = Convert.ToBoolean(reader["FUNCIONARIO"]);
                        isAdmin();
                        cbUserEnable.Checked = Convert.ToBoolean(reader["ATIVO"]);
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
        private void isAdmin()
        {
            if (cbIsAdminUser.Checked)
            {
                gbAcess.Visible = true;
            }
            else
            {
                gbAcess.Visible = false;
            }
        }
        private void cbIsAdminUser_CheckedChanged_1(object sender, EventArgs e)
        {
            isAdmin();
        }
        public static bool IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

        private void tbCPF_Validated(object sender, EventArgs e)
        {
            if (IsCpf(tbCPF.Text) == false)
            {
                errorCPF.SetError(tbCPF, "CPF Inválido!");
                tbCPF.Focus();
            }
            else if (isUniqueCPF() && !CpfUser.Equals(tbCPF.Text))
            {
                errorCPF.SetError(tbCPF, "CPF já cadastrado!");
                tbCPF.Focus();
            }
            else
            {
                errorCPF.SetError(tbCPF, "");
            }
        }
        public Boolean isUniqueCPF()
        {
            SqlConnection connection;
            SqlCommand commandCPF;
            SqlDataReader reader;
            int numberCPF = 0;

            string connectionString = Properties.Settings.Default.BibliotecaConnectionString;

            connection = new SqlConnection(connectionString);

            commandCPF = new SqlCommand("SELECT COUNT(*) AS 'TOTAL' FROM USUARIO WHERE CPF=@CPF", connection);

            commandCPF.Parameters.Add("@CPF", System.Data.SqlDbType.NVarChar);
            commandCPF.Parameters["@CPF"].Value = tbCPF.Text;

            try
            {
                try
                {
                    connection.Open();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Falha ao conectar o Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reader = commandCPF.ExecuteReader();
                if (reader.Read())
                {
                    numberCPF = Convert.ToInt32(reader["TOTAL"]);
                }
                reader.Close();
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
            return numberCPF > 0;
        }
    }
}
