namespace Biblioteca_CSharp
{
    partial class UpdateDevolucao
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
            this.cbLocacao = new System.Windows.Forms.ComboBox();
            this.devolucao = new System.Windows.Forms.DateTimePicker();
            this.lbAno = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bibliotecaDataSet = new Biblioteca_CSharp.BibliotecaDataSet();
            this.lOCACAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOCACAOTableAdapter = new Biblioteca_CSharp.BibliotecaDataSetTableAdapters.LOCACAOTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOCACAOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(336, 84);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(122, 33);
            this.btSalvar.TabIndex = 7;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbLocacao);
            this.groupBox1.Controls.Add(this.devolucao);
            this.groupBox1.Controls.Add(this.lbAno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 66);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados ";
            // 
            // cbLocacao
            // 
            this.cbLocacao.DataSource = this.lOCACAOBindingSource;
            this.cbLocacao.DisplayMember = "ID";
            this.cbLocacao.FormattingEnabled = true;
            this.cbLocacao.Location = new System.Drawing.Point(75, 31);
            this.cbLocacao.Name = "cbLocacao";
            this.cbLocacao.Size = new System.Drawing.Size(121, 21);
            this.cbLocacao.TabIndex = 16;
            this.cbLocacao.ValueMember = "ID";
            // 
            // devolucao
            // 
            this.devolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.devolucao.Location = new System.Drawing.Point(280, 33);
            this.devolucao.Name = "devolucao";
            this.devolucao.Size = new System.Drawing.Size(121, 20);
            this.devolucao.TabIndex = 14;
            this.devolucao.Value = new System.DateTime(2019, 6, 21, 0, 0, 0, 0);
            this.devolucao.ValueChanged += new System.EventHandler(this.devolucao_ValueChanged);
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.Location = new System.Drawing.Point(202, 39);
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
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOCACAOBindingSource
            // 
            this.lOCACAOBindingSource.DataMember = "LOCACAO";
            this.lOCACAOBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // lOCACAOTableAdapter
            // 
            this.lOCACAOTableAdapter.ClearBeforeFill = true;
            // 
            // UpdateDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 124);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.groupBox1);
            this.Name = "UpdateDevolucao";
            this.Text = "Alterar Devolucao";
            this.Load += new System.EventHandler(this.UpdateDevolucao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOCACAOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbLocacao;
        private System.Windows.Forms.DateTimePicker devolucao;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.Label label3;
        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource lOCACAOBindingSource;
        private BibliotecaDataSetTableAdapters.LOCACAOTableAdapter lOCACAOTableAdapter;
    }
}