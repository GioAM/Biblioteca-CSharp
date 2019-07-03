namespace Biblioteca_CSharp
{
    partial class Multa
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
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAGODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDEVOLUCAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet = new Biblioteca_CSharp.BibliotecaDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.idToModify = new System.Windows.Forms.TextBox();
            this.dataTable6TableAdapter = new Biblioteca_CSharp.BibliotecaDataSetTableAdapters.DataTable6TableAdapter();
            this.idUser = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tbMulta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btDelete
            // 
            this.btDelete.CausesValidation = false;
            this.btDelete.Location = new System.Drawing.Point(1113, 627);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(245, 62);
            this.btDelete.TabIndex = 12;
            this.btDelete.Text = "Excluir Multa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.CausesValidation = false;
            this.btUpdate.Location = new System.Drawing.Point(831, 627);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(245, 62);
            this.btUpdate.TabIndex = 11;
            this.btUpdate.Text = "Alterar Multa";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nOMEDataGridViewTextBoxColumn,
            this.vALORDataGridViewTextBoxColumn,
            this.pAGODataGridViewTextBoxColumn,
            this.iDDEVOLUCAODataGridViewTextBoxColumn,
            this.uSUARIOIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTable6BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(417, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 609);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMEDataGridViewTextBoxColumn
            // 
            this.nOMEDataGridViewTextBoxColumn.DataPropertyName = "NOME";
            this.nOMEDataGridViewTextBoxColumn.HeaderText = "NOME";
            this.nOMEDataGridViewTextBoxColumn.Name = "nOMEDataGridViewTextBoxColumn";
            // 
            // vALORDataGridViewTextBoxColumn
            // 
            this.vALORDataGridViewTextBoxColumn.DataPropertyName = "VALOR";
            this.vALORDataGridViewTextBoxColumn.HeaderText = "VALOR";
            this.vALORDataGridViewTextBoxColumn.Name = "vALORDataGridViewTextBoxColumn";
            // 
            // pAGODataGridViewTextBoxColumn
            // 
            this.pAGODataGridViewTextBoxColumn.DataPropertyName = "PAGO";
            this.pAGODataGridViewTextBoxColumn.HeaderText = "PAGO";
            this.pAGODataGridViewTextBoxColumn.Name = "pAGODataGridViewTextBoxColumn";
            // 
            // iDDEVOLUCAODataGridViewTextBoxColumn
            // 
            this.iDDEVOLUCAODataGridViewTextBoxColumn.DataPropertyName = "ID_DEVOLUCAO";
            this.iDDEVOLUCAODataGridViewTextBoxColumn.HeaderText = "ID_DEVOLUCAO";
            this.iDDEVOLUCAODataGridViewTextBoxColumn.Name = "iDDEVOLUCAODataGridViewTextBoxColumn";
            // 
            // uSUARIOIDDataGridViewTextBoxColumn
            // 
            this.uSUARIOIDDataGridViewTextBoxColumn.DataPropertyName = "USUARIO_ID";
            this.uSUARIOIDDataGridViewTextBoxColumn.HeaderText = "USUARIO_ID";
            this.uSUARIOIDDataGridViewTextBoxColumn.Name = "uSUARIOIDDataGridViewTextBoxColumn";
            this.uSUARIOIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataTable6BindingSource
            // 
            this.dataTable6BindingSource.DataMember = "DataTable6";
            this.dataTable6BindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.CausesValidation = false;
            this.button1.Location = new System.Drawing.Point(558, 627);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 62);
            this.button1.TabIndex = 14;
            this.button1.Text = "Pagar Multa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idToModify
            // 
            this.idToModify.Location = new System.Drawing.Point(64, 435);
            this.idToModify.Name = "idToModify";
            this.idToModify.Size = new System.Drawing.Size(100, 20);
            this.idToModify.TabIndex = 15;
            this.idToModify.Visible = false;
            // 
            // dataTable6TableAdapter
            // 
            this.dataTable6TableAdapter.ClearBeforeFill = true;
            // 
            // idUser
            // 
            this.idUser.Location = new System.Drawing.Point(64, 461);
            this.idUser.Name = "idUser";
            this.idUser.Size = new System.Drawing.Size(100, 20);
            this.idUser.TabIndex = 16;
            this.idUser.Visible = false;
            // 
            // button2
            // 
            this.button2.CausesValidation = false;
            this.button2.Location = new System.Drawing.Point(12, 627);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 62);
            this.button2.TabIndex = 17;
            this.button2.Text = "Relatórios";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbMulta
            // 
            this.tbMulta.Location = new System.Drawing.Point(64, 487);
            this.tbMulta.Name = "tbMulta";
            this.tbMulta.Size = new System.Drawing.Size(100, 20);
            this.tbMulta.TabIndex = 18;
            this.tbMulta.Visible = false;
            // 
            // Multa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1370, 726);
            this.Controls.Add(this.tbMulta);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.idUser);
            this.Controls.Add(this.idToModify);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Name = "Multa";
            this.Text = "Multa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Multa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox idToModify;
        public BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource dataTable6BindingSource;
        public BibliotecaDataSetTableAdapters.DataTable6TableAdapter dataTable6TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAGODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDEVOLUCAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUARIOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox idUser;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbMulta;
    }
}