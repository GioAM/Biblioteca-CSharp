namespace Biblioteca_CSharp
{
    partial class UpdateLocacao
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
            this.btSalvar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.cbLivro = new System.Windows.Forms.ComboBox();
            this.vencimento = new System.Windows.Forms.DateTimePicker();
            this.data = new System.Windows.Forms.DateTimePicker();
            this.lbAno = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbEdicao = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(336, 119);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(122, 33);
            this.btSalvar.TabIndex = 5;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbUsuario);
            this.groupBox1.Controls.Add(this.cbLivro);
            this.groupBox1.Controls.Add(this.vencimento);
            this.groupBox1.Controls.Add(this.data);
            this.groupBox1.Controls.Add(this.lbAno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbEdicao);
            this.groupBox1.Controls.Add(this.lbNome);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 101);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados ";
            // 
            // cbUsuario
            // 
            this.cbUsuario.DisplayMember = "NOME";
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(75, 31);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(121, 21);
            this.cbUsuario.TabIndex = 16;
            this.cbUsuario.ValueMember = "ID";
            // 
            // cbLivro
            // 
            this.cbLivro.DisplayMember = "NOME";
            this.cbLivro.FormattingEnabled = true;
            this.cbLivro.Location = new System.Drawing.Point(283, 30);
            this.cbLivro.Name = "cbLivro";
            this.cbLivro.Size = new System.Drawing.Size(121, 21);
            this.cbLivro.TabIndex = 15;
            this.cbLivro.ValueMember = "ID";
            // 
            // vencimento
            // 
            this.vencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.vencimento.Location = new System.Drawing.Point(283, 57);
            this.vencimento.Name = "vencimento";
            this.vencimento.Size = new System.Drawing.Size(121, 20);
            this.vencimento.TabIndex = 14;
            this.vencimento.Value = new System.DateTime(2019, 6, 21, 0, 0, 0, 0);
            // 
            // data
            // 
            this.data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data.Location = new System.Drawing.Point(75, 57);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(121, 20);
            this.data.TabIndex = 13;
            this.data.Value = new System.DateTime(2019, 6, 21, 0, 0, 0, 0);
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.Location = new System.Drawing.Point(218, 63);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(59, 13);
            this.lbAno.TabIndex = 3;
            this.lbAno.Text = "Devolução";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Livro";
            // 
            // lbEdicao
            // 
            this.lbEdicao.AutoSize = true;
            this.lbEdicao.Location = new System.Drawing.Point(10, 57);
            this.lbEdicao.Name = "lbEdicao";
            this.lbEdicao.Size = new System.Drawing.Size(30, 13);
            this.lbEdicao.TabIndex = 2;
            this.lbEdicao.Text = "Data";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(10, 31);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(43, 13);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Usuário";
            // 
            // UpdateLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 163);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.groupBox1);
            this.Name = "UpdateLocacao";
            this.Text = "UpdateLocacao";
            this.Load += new System.EventHandler(this.UpdateLocacao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.ComboBox cbLivro;
        private System.Windows.Forms.DateTimePicker vencimento;
        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbEdicao;
        private System.Windows.Forms.Label lbNome;
    }
}