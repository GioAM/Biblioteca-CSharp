namespace Biblioteca_CSharp
{
    partial class UpdateBook
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
            this.btSalvar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbAno = new System.Windows.Forms.MaskedTextBox();
            this.tbEdicao = new System.Windows.Forms.MaskedTextBox();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbAno = new System.Windows.Forms.Label();
            this.lbEdicao = new System.Windows.Forms.Label();
            this.lbAutor = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.errorAutor = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNome = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEdicao = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorQuantidade = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbEditora = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bibliotecaDataSet = new Biblioteca_CSharp.BibliotecaDataSet();
            this.eDITORABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eDITORATableAdapter = new Biblioteca_CSharp.BibliotecaDataSetTableAdapters.EDITORATableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorAutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEdicao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDITORABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(389, 161);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(122, 33);
            this.btSalvar.TabIndex = 4;
            this.btSalvar.Text = "Alterar Livro";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbEditora);
            this.groupBox1.Controls.Add(this.label1);
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
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados ";
            // 
            // tbAno
            // 
            this.tbAno.Location = new System.Drawing.Point(326, 69);
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(116, 20);
            this.tbAno.TabIndex = 6;
            // 
            // tbEdicao
            // 
            this.tbEdicao.Location = new System.Drawing.Point(98, 69);
            this.tbEdicao.Name = "tbEdicao";
            this.tbEdicao.Size = new System.Drawing.Size(121, 20);
            this.tbEdicao.TabIndex = 5;
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(326, 31);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(116, 20);
            this.tbAutor.TabIndex = 4;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(98, 31);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(121, 20);
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
            // errorAutor
            // 
            this.errorAutor.ContainerControl = this;
            // 
            // errorNome
            // 
            this.errorNome.ContainerControl = this;
            // 
            // errorEdicao
            // 
            this.errorEdicao.ContainerControl = this;
            // 
            // errorQuantidade
            // 
            this.errorQuantidade.ContainerControl = this;
            // 
            // cbEditora
            // 
            this.cbEditora.DataSource = this.eDITORABindingSource;
            this.cbEditora.DisplayMember = "NOME";
            this.cbEditora.FormattingEnabled = true;
            this.cbEditora.Location = new System.Drawing.Point(98, 116);
            this.cbEditora.Name = "cbEditora";
            this.cbEditora.Size = new System.Drawing.Size(121, 21);
            this.cbEditora.TabIndex = 14;
            this.cbEditora.ValueMember = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Editora";
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eDITORABindingSource
            // 
            this.eDITORABindingSource.DataMember = "EDITORA";
            this.eDITORABindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // eDITORATableAdapter
            // 
            this.eDITORATableAdapter.ClearBeforeFill = true;
            // 
            // UpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 208);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.groupBox1);
            this.Name = "UpdateBook";
            this.Text = "Alterar Livro";
            this.Load += new System.EventHandler(this.UpdateBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorAutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEdicao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDITORABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox tbAno;
        private System.Windows.Forms.MaskedTextBox tbEdicao;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.Label lbEdicao;
        private System.Windows.Forms.Label lbAutor;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.ErrorProvider errorAutor;
        private System.Windows.Forms.ErrorProvider errorNome;
        private System.Windows.Forms.ErrorProvider errorEdicao;
        private System.Windows.Forms.ErrorProvider errorQuantidade;
        private System.Windows.Forms.ComboBox cbEditora;
        private System.Windows.Forms.Label label1;
        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource eDITORABindingSource;
        private BibliotecaDataSetTableAdapters.EDITORATableAdapter eDITORATableAdapter;
    }
}