namespace Biblioteca_CSharp
{
    partial class NewDevolucao
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
            this.multa = new System.Windows.Forms.TextBox();
            this.cbLocacao = new System.Windows.Forms.ComboBox();
            this.lOCACAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet = new Biblioteca_CSharp.BibliotecaDataSet();
            this.devolucao = new System.Windows.Forms.DateTimePicker();
            this.lbAno = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMulta = new System.Windows.Forms.Label();
            this.lOCACAOTableAdapter = new Biblioteca_CSharp.BibliotecaDataSetTableAdapters.LOCACAOTableAdapter();
            this.validade = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lOCACAOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOCACAOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOCACAOBindingSource1)).BeginInit();
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
            this.groupBox1.Controls.Add(this.validade);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.multa);
            this.groupBox1.Controls.Add(this.cbLocacao);
            this.groupBox1.Controls.Add(this.devolucao);
            this.groupBox1.Controls.Add(this.lbAno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbMulta);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 101);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados ";
            // 
            // multa
            // 
            this.multa.Enabled = false;
            this.multa.Location = new System.Drawing.Point(75, 61);
            this.multa.Name = "multa";
            this.multa.Size = new System.Drawing.Size(121, 20);
            this.multa.TabIndex = 17;
            // 
            // cbLocacao
            // 
            this.cbLocacao.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lOCACAOBindingSource1, "ID", true));
            this.cbLocacao.DataSource = this.lOCACAOBindingSource;
            this.cbLocacao.DisplayMember = "ID";
            this.cbLocacao.FormattingEnabled = true;
            this.cbLocacao.Location = new System.Drawing.Point(75, 31);
            this.cbLocacao.Name = "cbLocacao";
            this.cbLocacao.Size = new System.Drawing.Size(121, 21);
            this.cbLocacao.TabIndex = 16;
            this.cbLocacao.ValueMember = "ID";
            this.cbLocacao.SelectedIndexChanged += new System.EventHandler(this.cbUsuario_SelectedIndexChanged);
            // 
            // lOCACAOBindingSource
            // 
            this.lOCACAOBindingSource.DataMember = "LOCACAO";
            this.lOCACAOBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // devolucao
            // 
            this.devolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.devolucao.Location = new System.Drawing.Point(280, 61);
            this.devolucao.Name = "devolucao";
            this.devolucao.Size = new System.Drawing.Size(121, 20);
            this.devolucao.TabIndex = 14;
            this.devolucao.Value = new System.DateTime(2019, 6, 21, 0, 0, 0, 0);
            this.devolucao.ValueChanged += new System.EventHandler(this.devolucao_ValueChanged);
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.Location = new System.Drawing.Point(215, 67);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(59, 13);
            this.lbAno.TabIndex = 3;
            this.lbAno.Text = "Devolução";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Locação";
            // 
            // lbMulta
            // 
            this.lbMulta.AutoSize = true;
            this.lbMulta.Location = new System.Drawing.Point(10, 64);
            this.lbMulta.Name = "lbMulta";
            this.lbMulta.Size = new System.Drawing.Size(33, 13);
            this.lbMulta.TabIndex = 2;
            this.lbMulta.Text = "Multa";
            // 
            // lOCACAOTableAdapter
            // 
            this.lOCACAOTableAdapter.ClearBeforeFill = true;
            // 
            // validade
            // 
            this.validade.Enabled = false;
            this.validade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.validade.Location = new System.Drawing.Point(280, 32);
            this.validade.Name = "validade";
            this.validade.Size = new System.Drawing.Size(121, 20);
            this.validade.TabIndex = 19;
            this.validade.Value = new System.DateTime(2019, 6, 21, 0, 0, 0, 0);
            this.validade.ValueChanged += new System.EventHandler(this.validade_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Validade";
            // 
            // lOCACAOBindingSource1
            // 
            this.lOCACAOBindingSource1.DataMember = "LOCACAO";
            this.lOCACAOBindingSource1.DataSource = this.bibliotecaDataSet;
            // 
            // NewDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 176);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewDevolucao";
            this.Text = "NewDevolucao";
            this.Load += new System.EventHandler(this.NewDevolucao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOCACAOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOCACAOBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbLocacao;
        private System.Windows.Forms.DateTimePicker devolucao;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMulta;
        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource lOCACAOBindingSource;
        private BibliotecaDataSetTableAdapters.LOCACAOTableAdapter lOCACAOTableAdapter;
        private System.Windows.Forms.TextBox multa;
        private System.Windows.Forms.DateTimePicker validade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource lOCACAOBindingSource1;
    }
}