namespace Biblioteca_CSharp
{
    partial class NewUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbIsAdminUser = new System.Windows.Forms.CheckBox();
            this.cbUserEnable = new System.Windows.Forms.CheckBox();
            this.tbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.tbCPF = new System.Windows.Forms.MaskedTextBox();
            this.tbIdade = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.lbIdade = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.tbEstado = new System.Windows.Forms.TextBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.lbPais = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.lbCidade = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.tbCEP = new System.Windows.Forms.MaskedTextBox();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.tbRua = new System.Windows.Forms.TextBox();
            this.lbCEP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbBairro = new System.Windows.Forms.Label();
            this.lbRua = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.tbComplemento = new System.Windows.Forms.TextBox();
            this.lbComplemento = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.lbEmail);
            this.groupBox1.Controls.Add(this.cbIsAdminUser);
            this.groupBox1.Controls.Add(this.cbUserEnable);
            this.groupBox1.Controls.Add(this.tbTelefone);
            this.groupBox1.Controls.Add(this.tbCPF);
            this.groupBox1.Controls.Add(this.tbIdade);
            this.groupBox1.Controls.Add(this.tbNome);
            this.groupBox1.Controls.Add(this.lbTelefone);
            this.groupBox1.Controls.Add(this.lbCPF);
            this.groupBox1.Controls.Add(this.lbIdade);
            this.groupBox1.Controls.Add(this.lbNome);
            this.groupBox1.Location = new System.Drawing.Point(43, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados no Usuário";
            // 
            // cbIsAdminUser
            // 
            this.cbIsAdminUser.AutoSize = true;
            this.cbIsAdminUser.Location = new System.Drawing.Point(345, 110);
            this.cbIsAdminUser.Name = "cbIsAdminUser";
            this.cbIsAdminUser.Size = new System.Drawing.Size(81, 17);
            this.cbIsAdminUser.TabIndex = 8;
            this.cbIsAdminUser.Text = "Funcionário";
            this.cbIsAdminUser.UseVisualStyleBackColor = true;
            this.cbIsAdminUser.CheckedChanged += new System.EventHandler(this.cbIsAdminUser_CheckedChanged);
            // 
            // cbUserEnable
            // 
            this.cbUserEnable.AutoSize = true;
            this.cbUserEnable.Location = new System.Drawing.Point(276, 110);
            this.cbUserEnable.Name = "cbUserEnable";
            this.cbUserEnable.Size = new System.Drawing.Size(50, 17);
            this.cbUserEnable.TabIndex = 7;
            this.cbUserEnable.Text = "Ativo";
            this.cbUserEnable.UseVisualStyleBackColor = true;
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(326, 69);
            this.tbTelefone.Mask = "(00)00000-0000";
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(100, 20);
            this.tbTelefone.TabIndex = 6;
            // 
            // tbCPF
            // 
            this.tbCPF.Location = new System.Drawing.Point(98, 69);
            this.tbCPF.Mask = "000,000,000-00";
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(100, 20);
            this.tbCPF.TabIndex = 5;
            this.tbCPF.Validated += new System.EventHandler(this.tbCPF_Validated);
            // 
            // tbIdade
            // 
            this.tbIdade.Location = new System.Drawing.Point(326, 31);
            this.tbIdade.Name = "tbIdade";
            this.tbIdade.Size = new System.Drawing.Size(100, 20);
            this.tbIdade.TabIndex = 4;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(98, 31);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(100, 20);
            this.tbNome.TabIndex = 1;
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(254, 72);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(49, 13);
            this.lbTelefone.TabIndex = 3;
            this.lbTelefone.Text = "Telefone";
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Location = new System.Drawing.Point(27, 69);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(27, 13);
            this.lbCPF.TabIndex = 2;
            this.lbCPF.Text = "CPF";
            // 
            // lbIdade
            // 
            this.lbIdade.AutoSize = true;
            this.lbIdade.Location = new System.Drawing.Point(255, 31);
            this.lbIdade.Name = "lbIdade";
            this.lbIdade.Size = new System.Drawing.Size(34, 13);
            this.lbIdade.TabIndex = 1;
            this.lbIdade.Text = "Idade";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(26, 31);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome";
            this.lbNome.Click += new System.EventHandler(this.lbNome_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(219, 432);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(150, 36);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Adicionar";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbComplemento);
            this.groupBox2.Controls.Add(this.lbComplemento);
            this.groupBox2.Controls.Add(this.tbPais);
            this.groupBox2.Controls.Add(this.tbEstado);
            this.groupBox2.Controls.Add(this.tbCidade);
            this.groupBox2.Controls.Add(this.lbPais);
            this.groupBox2.Controls.Add(this.lbEstado);
            this.groupBox2.Controls.Add(this.lbCidade);
            this.groupBox2.Controls.Add(this.tbNumero);
            this.groupBox2.Controls.Add(this.tbCEP);
            this.groupBox2.Controls.Add(this.tbBairro);
            this.groupBox2.Controls.Add(this.tbRua);
            this.groupBox2.Controls.Add(this.lbCEP);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbBairro);
            this.groupBox2.Controls.Add(this.lbRua);
            this.groupBox2.Location = new System.Drawing.Point(43, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 164);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do Endereço";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tbPais
            // 
            this.tbPais.Location = new System.Drawing.Point(306, 120);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(100, 20);
            this.tbPais.TabIndex = 13;
            // 
            // tbEstado
            // 
            this.tbEstado.Location = new System.Drawing.Point(306, 95);
            this.tbEstado.Name = "tbEstado";
            this.tbEstado.Size = new System.Drawing.Size(100, 20);
            this.tbEstado.TabIndex = 12;
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(306, 63);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(100, 20);
            this.tbCidade.TabIndex = 9;
            // 
            // lbPais
            // 
            this.lbPais.AutoSize = true;
            this.lbPais.Location = new System.Drawing.Point(235, 123);
            this.lbPais.Name = "lbPais";
            this.lbPais.Size = new System.Drawing.Size(29, 13);
            this.lbPais.TabIndex = 11;
            this.lbPais.Text = "País";
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(235, 95);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(40, 13);
            this.lbEstado.TabIndex = 10;
            this.lbEstado.Text = "Estado";
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Location = new System.Drawing.Point(234, 63);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(40, 13);
            this.lbCidade.TabIndex = 8;
            this.lbCidade.Text = "Cidade";
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(98, 88);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(100, 20);
            this.tbNumero.TabIndex = 7;
            // 
            // tbCEP
            // 
            this.tbCEP.Location = new System.Drawing.Point(98, 117);
            this.tbCEP.Mask = "000000-000";
            this.tbCEP.Name = "tbCEP";
            this.tbCEP.Size = new System.Drawing.Size(100, 20);
            this.tbCEP.TabIndex = 6;
            // 
            // tbBairro
            // 
            this.tbBairro.Location = new System.Drawing.Point(98, 63);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(100, 20);
            this.tbBairro.TabIndex = 4;
            // 
            // tbRua
            // 
            this.tbRua.Location = new System.Drawing.Point(98, 31);
            this.tbRua.Name = "tbRua";
            this.tbRua.Size = new System.Drawing.Size(100, 20);
            this.tbRua.TabIndex = 1;
            // 
            // lbCEP
            // 
            this.lbCEP.AutoSize = true;
            this.lbCEP.Location = new System.Drawing.Point(26, 120);
            this.lbCEP.Name = "lbCEP";
            this.lbCEP.Size = new System.Drawing.Size(28, 13);
            this.lbCEP.TabIndex = 3;
            this.lbCEP.Text = "CEP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número";
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(27, 63);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(34, 13);
            this.lbBairro.TabIndex = 1;
            this.lbBairro.Text = "Bairro";
            // 
            // lbRua
            // 
            this.lbRua.AutoSize = true;
            this.lbRua.Location = new System.Drawing.Point(26, 31);
            this.lbRua.Name = "lbRua";
            this.lbRua.Size = new System.Drawing.Size(27, 13);
            this.lbRua.TabIndex = 0;
            this.lbRua.Text = "Rua";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(98, 107);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 10;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(27, 107);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 9;
            this.lbEmail.Text = "Email";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbSenha);
            this.groupBox3.Controls.Add(this.tbLogin);
            this.groupBox3.Controls.Add(this.lbSenha);
            this.groupBox3.Controls.Add(this.lbLogin);
            this.groupBox3.Location = new System.Drawing.Point(43, 346);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(499, 80);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados de Acesso";
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(306, 35);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(100, 20);
            this.tbSenha.TabIndex = 17;
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(234, 35);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(38, 13);
            this.lbSenha.TabIndex = 16;
            this.lbSenha.Text = "Senha";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(98, 35);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(100, 20);
            this.tbLogin.TabIndex = 15;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(26, 35);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(33, 13);
            this.lbLogin.TabIndex = 14;
            this.lbLogin.Text = "Login";
            // 
            // tbComplemento
            // 
            this.tbComplemento.Location = new System.Drawing.Point(306, 31);
            this.tbComplemento.Name = "tbComplemento";
            this.tbComplemento.Size = new System.Drawing.Size(100, 20);
            this.tbComplemento.TabIndex = 15;
            // 
            // lbComplemento
            // 
            this.lbComplemento.AutoSize = true;
            this.lbComplemento.Location = new System.Drawing.Point(234, 31);
            this.lbComplemento.Name = "lbComplemento";
            this.lbComplemento.Size = new System.Drawing.Size(71, 13);
            this.lbComplemento.TabIndex = 14;
            this.lbComplemento.Text = "Complemento";
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 480);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewUser";
            this.Text = "Novo Usuário";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.Label lbIdade;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.MaskedTextBox tbTelefone;
        private System.Windows.Forms.MaskedTextBox tbCPF;
        private System.Windows.Forms.TextBox tbIdade;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox tbCEP;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.TextBox tbRua;
        private System.Windows.Forms.Label lbCEP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label lbRua;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.TextBox tbEstado;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.Label lbPais;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox cbIsAdminUser;
        private System.Windows.Forms.CheckBox cbUserEnable;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.TextBox tbComplemento;
        private System.Windows.Forms.Label lbComplemento;
    }
}