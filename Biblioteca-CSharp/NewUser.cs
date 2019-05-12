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
                "INSERT INTO ENDERECO (NUMERO, RUA, COMPLEMENTO, CEP, CIDADE, ESTADO, PAIS)" +
                "VALUES (@NUMERO, @RUA, @COMPLEMENTO, @CEP, @CIDADE, @ESTADO, @PAIS) ", connection);
            try {
                commandAddress.Parameters.Add("@NUMERO", System.Data.SqlDbType.Int);
                commandAddress.Parameters["@NUMERO"].Value = Convert.ToInt32(tbNumero.Text);

                commandAddress.Parameters.Add("@RUA", System.Data.SqlDbType.NVarChar);
                commandAddress.Parameters["@RUA"].Value = tbRua.Text;

                commandAddress.Parameters.Add("@COMPLEMENTO", System.Data.SqlDbType.NVarChar);
                commandAddress.Parameters["@COMPLEMENTO"].Value = tbComplemento.Text;

                commandAddress.Parameters.Add("@CEP", System.Data.SqlDbType.NVarChar);
                commandAddress.Parameters["@CEP"].Value = tbCEP.Text;

                commandAddress.Parameters.Add("@CIDADE", System.Data.SqlDbType.NVarChar);
                commandAddress.Parameters["@CIDADE"].Value = tbCidade.Text;

                commandAddress.Parameters.Add("@ESTADO", System.Data.SqlDbType.NVarChar);
                commandAddress.Parameters["@ESTADO"].Value = tbEstado.Text;

                commandAddress.Parameters.Add("@PAIS", System.Data.SqlDbType.NVarChar);
                commandAddress.Parameters["@PAIS"].Value = tbPais.Text;

            } catch (Exception error)
            {
                isOperationOk = false;
                MessageBox.Show(error.Message, "Campos Incorretos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }

            command = new SqlCommand(
                "INSERT INTO USUARIO (NOME, CPF, IDADE, TELEFONE, ATIVO, EMAIL, FUNCIONARIO, LOGIN, SENHA)"    
            );
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

        private void cbIsAdminUser_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
