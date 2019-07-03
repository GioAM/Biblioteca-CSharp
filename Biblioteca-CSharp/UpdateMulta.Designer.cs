namespace Biblioteca_CSharp
{
    partial class UpdateMulta
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
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.lbAno = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDevolucao = new System.Windows.Forms.ComboBox();
            this.bibliotecaDataSet = new Biblioteca_CSharp.BibliotecaDataSet();
            this.uSUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSUARIOTableAdapter = new Biblioteca_CSharp.BibliotecaDataSetTableAdapters.USUARIOTableAdapter();
            this.dEVOLUCAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dEVOLUCAOTableAdapter = new Biblioteca_CSharp.BibliotecaDataSetTableAdapters.DEVOLUCAOTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPago = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.valor = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEVOLUCAOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(336, 107);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(122, 33);
            this.btSalvar.TabIndex = 9;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.valor);
            this.groupBox1.Controls.Add(this.cbPago);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbDevolucao);
            this.groupBox1.Controls.Add(this.cbUsuario);
            this.groupBox1.Controls.Add(this.lbAno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 89);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados ";
            // 
            // cbUsuario
            // 
            this.cbUsuario.DataSource = this.uSUARIOBindingSource;
            this.cbUsuario.DisplayMember = "NOME";
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(59, 46);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(121, 21);
            this.cbUsuario.TabIndex = 16;
            this.cbUsuario.ValueMember = "ID";
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.Location = new System.Drawing.Point(222, 49);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(59, 13);
            this.lbAno.TabIndex = 3;
            this.lbAno.Text = "Devolução";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Usuário";
            // 
            // cbDevolucao
            // 
            this.cbDevolucao.DataSource = this.dEVOLUCAOBindingSource;
            this.cbDevolucao.DisplayMember = "ID";
            this.cbDevolucao.FormattingEnabled = true;
            this.cbDevolucao.Location = new System.Drawing.Point(287, 46);
            this.cbDevolucao.Name = "cbDevolucao";
            this.cbDevolucao.Size = new System.Drawing.Size(121, 21);
            this.cbDevolucao.TabIndex = 17;
            this.cbDevolucao.ValueMember = "ID";
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSUARIOBindingSource
            // 
            this.uSUARIOBindingSource.DataMember = "USUARIO";
            this.uSUARIOBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // uSUARIOTableAdapter
            // 
            this.uSUARIOTableAdapter.ClearBeforeFill = true;
            // 
            // dEVOLUCAOBindingSource
            // 
            this.dEVOLUCAOBindingSource.DataMember = "DEVOLUCAO";
            this.dEVOLUCAOBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // dEVOLUCAOTableAdapter
            // 
            this.dEVOLUCAOTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Valor";
            // 
            // cbPago
            // 
            this.cbPago.FormattingEnabled = true;
            this.cbPago.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbPago.Location = new System.Drawing.Point(287, 19);
            this.cbPago.Name = "cbPago";
            this.cbPago.Size = new System.Drawing.Size(121, 21);
            this.cbPago.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Pago";
            // 
            // valor
            // 
            this.valor.Location = new System.Drawing.Point(59, 20);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(121, 20);
            this.valor.TabIndex = 21;
            // 
            // UpdateMulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 150);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.groupBox1);
            this.Name = "UpdateMulta";
            this.Text = "UpdateMulta";
            this.Load += new System.EventHandler(this.UpdateMulta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEVOLUCAOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDevolucao;
        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource uSUARIOBindingSource;
        private BibliotecaDataSetTableAdapters.USUARIOTableAdapter uSUARIOTableAdapter;
        private System.Windows.Forms.BindingSource dEVOLUCAOBindingSource;
        private BibliotecaDataSetTableAdapters.DEVOLUCAOTableAdapter dEVOLUCAOTableAdapter;
        private System.Windows.Forms.TextBox valor;
        private System.Windows.Forms.ComboBox cbPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}