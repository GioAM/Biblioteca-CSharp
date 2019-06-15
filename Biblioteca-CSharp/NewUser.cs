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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
            tbSenha.PasswordChar = '*';
            tbEstado.MaxLength = 2;
        }

        private void lbNome_Click(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlCommand commandAddress;
            bool isOperationOk = true;

            string connectionString = Properties.Settings.Default.BibliotecaConnectionString;

            connection = new SqlConnection(connectionString);

            commandAddress = new SqlCommand(
                "INSERT INTO ENDERECO (NUMERO, RUA, COMPLEMENTO, CEP, CIDADE, ESTADO, PAIS, BAIRRO)" +
                "VALUES (@NUMERO, @RUA, @COMPLEMENTO, @CEP, @CIDADE, @ESTADO, @PAIS, @BAIRRO) ", connection);

            command = new SqlCommand("INSERT INTO USUARIO (NOME, CPF, IDADE, TELEFONE, ATIVO, EMAIL, FUNCIONARIO, LOGIN, SENHA, ID_ENDERECO) VALUES" +
                    "(@NOME, @CPF, @IDADE, @TELEFONE, @ATIVO, @EMAIL, @FUNCIONARIO, @LOGIN, @SENHA, @ID_ENDERECO)", connection);
            try {
                isOperationOk = true;
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
                    paisError.SetError(tbPais, "País é um campo obrigatório!");
                    isOperationOk = false;
                }
                else
                {
                    commandAddress.Parameters.Add("@PAIS", System.Data.SqlDbType.NVarChar);
                    commandAddress.Parameters["@PAIS"].Value = tbPais.Text;
                    paisError.SetError(tbPais, "");
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
                    errorName.SetError(tbNome, "Nome é um campo obrigatório!");
                    isOperationOk = false;
                }
                else
                {
                    command.Parameters.Add("@NOME", System.Data.SqlDbType.NVarChar);
                    command.Parameters["@NOME"].Value = tbNome.Text;
                    errorName.SetError(tbNome, "");
                }
                Console.WriteLine(tbCPF.Text);
                if (String.IsNullOrEmpty(tbCPF.Text) || tbCPF.Text.Equals("   .   .   -"))
                {
                    errorProvider1.SetError(tbCPF, "CPF é um campo obrigatório!");
                    isOperationOk = false;
                }
                else
                {
                    command.Parameters.Add("@CPF", System.Data.SqlDbType.NVarChar);
                    command.Parameters["@CPF"].Value = tbCPF.Text;
                    errorProvider1.SetError(tbCPF, "");
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
                Console.WriteLine(tbTelefone.Text);
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
                command.Parameters["@FUNCIONARIO"].Value = Convert.ToInt32( cbIsAdminUser.Checked);

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
                else{
                    command.Parameters.Add("@LOGIN", System.Data.SqlDbType.NVarChar);
                    command.Parameters["@LOGIN"].Value = "";
                    command.Parameters.Add("@SENHA", System.Data.SqlDbType.NVarChar);
                    command.Parameters["@SENHA"].Value = "";
                }

                if (isOperationOk)
                {
                    connection.Open();
                    commandAddress.ExecuteNonQuery();

                    command.Parameters.Add("@ID_ENDERECO", System.Data.SqlDbType.Int);
                    command.Parameters["@ID_ENDERECO"].Value = Convert.ToInt32(getId());

                    command.ExecuteNonQuery();
                    MessageBox.Show("Usuário Cadastrado com sucesso!", "Cadastro Válido", MessageBoxButtons.OK);
                    this.Close();
             
                }

            } catch (Exception error)
            {
                isOperationOk = false;
                MessageBox.Show(error.Message, "Campos Incorretos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

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
            if(IsCpf(tbCPF.Text) == false)
            {
                errorProvider1.SetError(tbCPF, "CPF Inválido!");
                tbCPF.Focus();
            }
            else
            {
                errorProvider1.SetError(tbCPF, "");
            }
        }
        public string getId()
        {
            string codigo = "";
            string connectionString = Properties.Settings.Default.BibliotecaConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            string sql = "SELECT max(ID) AS 'ID' FROM ENDERECO";
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                codigo = reader["ID"].ToString();
            }
            conn.Close();
            return codigo;
        }
        private void cbIsAdminUser_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsAdminUser.Checked)
            {
                gbAcess.Visible = true;
            }
            else{
                gbAcess.Visible = false;
            }
        }

        private void tbBairro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
