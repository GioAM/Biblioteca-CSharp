namespace Biblioteca_CSharp
{
    partial class NewBook
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
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.tbAno = new System.Windows.Forms.MaskedTextBox();
            this.tbEdicao = new System.Windows.Forms.MaskedTextBox();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbAno = new System.Windows.Forms.Label();
            this.lbEdicao = new System.Windows.Forms.Label();
            this.lbAutor = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.tbCategoria = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.errorNome = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorAutor = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEdicao = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorQuantidade = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCategoria = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEdicao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCategoria);
            this.groupBox1.Controls.Add(this.cbCategoria);
            this.groupBox1.Controls.Add(this.tbQuantidade);
            this.groupBox1.Controls.Add(this.lbQuantidade);
            this.groupBox1.Controls.Add(this.tbAno);
            this.groupBox1.Controls.Add(this.tbEdicao);
            this.groupBox1.Controls.Add(this.tbAutor);
            this.groupBox1.Controls.Add(this.tbNome);
            this.groupBox1.Controls.Add(this.lbAno);
            this.groupBox1.Controls.Add(this.lbEdicao);
            this.groupBox1.Controls.Add(this.lbAutor);
            this.groupBox1.Controls.Add(this.lbNome);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 143);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados ";
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Location = new System.Drawing.Point(98, 107);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(100, 20);
            this.tbQuantidade.TabIndex = 10;
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Location = new System.Drawing.Point(27, 107);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lbQuantidade.TabIndex = 9;
            this.lbQuantidade.Text = "Quantidade";
            // 
            // tbAno
            // 
            this.tbAno.Location = new System.Drawing.Point(326, 69);
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(100, 20);
            this.tbAno.TabIndex = 6;
            // 
            // tbEdicao
            // 
            this.tbEdicao.Location = new System.Drawing.Point(98, 69);
            this.tbEdicao.Name = "tbEdicao";
            this.tbEdicao.Size = new System.Drawing.Size(100, 20);
            this.tbEdicao.TabIndex = 5;
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(326, 31);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(100, 20);
            this.tbAutor.TabIndex = 4;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(98, 31);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(100, 20);
            this.tbNome.TabIndex = 1;
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.Location = new System.Drawing.Point(254, 72);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(26, 13);
            this.lbAno.TabIndex = 3;
            this.lbAno.Text = "Ano";
            // 
            // lbEdicao
            // 
            this.lbEdicao.AutoSize = true;
            this.lbEdicao.Location = new System.Drawing.Point(27, 69);
            this.lbEdicao.Name = "lbEdicao";
            this.lbEdicao.Size = new System.Drawing.Size(40, 13);
            this.lbEdicao.TabIndex = 2;
            this.lbEdicao.Text = "Edição";
            // 
            // lbAutor
            // 
            this.lbAutor.AutoSize = true;
            this.lbAutor.Location = new System.Drawing.Point(255, 31);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(32, 13);
            this.lbAutor.TabIndex = 1;
            this.lbAutor.Text = "Autor";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(26, 31);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(326, 106);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbCategoria.TabIndex = 11;
            // 
            // tbCategoria
            // 
            this.tbCategoria.AutoSize = true;
            this.tbCategoria.Location = new System.Drawing.Point(254, 107);
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.Size = new System.Drawing.Size(52, 13);
            this.tbCategoria.TabIndex = 12;
            this.tbCategoria.Text = "Categoria";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(389, 161);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(122, 33);
            this.btSalvar.TabIndex = 2;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // errorNome
            // 
            this.errorNome.ContainerControl = this;
            // 
            // errorAutor
            // 
            this.errorAutor.ContainerControl = this;
            // 
            // errorEdicao
            // 
            this.errorEdicao.ContainerControl = this;
            // 
            // errorQuantidade
            // 
            this.errorQuantidade.ContainerControl = this;
            // 
            // errorCategoria
            // 
            this.errorCategoria.ContainerControl = this;
            // 
            // NewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 206);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewBook";
            this.Text = "Novo Livro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEdicao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.MaskedTextBox tbAno;
        private System.Windows.Forms.MaskedTextBox tbEdicao;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.Label lbEdicao;
        private System.Windows.Forms.Label lbAutor;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label tbCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.ErrorProvider errorNome;
        private System.Windows.Forms.ErrorProvider errorAutor;
        private System.Windows.Forms.ErrorProvider errorEdicao;
        private System.Windows.Forms.ErrorProvider errorQuantidade;
        private System.Windows.Forms.ErrorProvider errorCategoria;
    }
}