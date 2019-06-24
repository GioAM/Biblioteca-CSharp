namespace Biblioteca_CSharp
{
    partial class Books
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
            this.btNewBook = new System.Windows.Forms.Button();
            this.idToModify = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUTORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDICAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDITORADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet = new Biblioteca_CSharp.BibliotecaDataSet();
            this.dataTable3TableAdapter = new Biblioteca_CSharp.BibliotecaDataSetTableAdapters.DataTable3TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btDelete
            // 
            this.btDelete.CausesValidation = false;
            this.btDelete.Location = new System.Drawing.Point(1113, 627);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(245, 62);
            this.btDelete.TabIndex = 9;
            this.btDelete.Text = "Deletar Livro";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.CausesValidation = false;
            this.btUpdate.Location = new System.Drawing.Point(831, 627);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(245, 62);
            this.btUpdate.TabIndex = 8;
            this.btUpdate.Text = "Alterar Livro";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btNewBook
            // 
            this.btNewBook.CausesValidation = false;
            this.btNewBook.Location = new System.Drawing.Point(558, 627);
            this.btNewBook.Name = "btNewBook";
            this.btNewBook.Size = new System.Drawing.Size(245, 62);
            this.btNewBook.TabIndex = 7;
            this.btNewBook.Text = "Novo Livro";
            this.btNewBook.UseVisualStyleBackColor = true;
            this.btNewBook.Click += new System.EventHandler(this.btNewBook_Click_1);
            // 
            // idToModify
            // 
            this.idToModify.Location = new System.Drawing.Point(1134, 83);
            this.idToModify.Name = "idToModify";
            this.idToModify.Size = new System.Drawing.Size(100, 20);
            this.idToModify.TabIndex = 11;
            this.idToModify.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nOMEDataGridViewTextBoxColumn,
            this.aUTORDataGridViewTextBoxColumn,
            this.eDICAODataGridViewTextBoxColumn,
            this.aNODataGridViewTextBoxColumn,
            this.eDITORADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTable3BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(410, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 593);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // aUTORDataGridViewTextBoxColumn
            // 
            this.aUTORDataGridViewTextBoxColumn.DataPropertyName = "AUTOR";
            this.aUTORDataGridViewTextBoxColumn.HeaderText = "AUTOR";
            this.aUTORDataGridViewTextBoxColumn.Name = "aUTORDataGridViewTextBoxColumn";
            // 
            // eDICAODataGridViewTextBoxColumn
            // 
            this.eDICAODataGridViewTextBoxColumn.DataPropertyName = "EDICAO";
            this.eDICAODataGridViewTextBoxColumn.HeaderText = "EDICAO";
            this.eDICAODataGridViewTextBoxColumn.Name = "eDICAODataGridViewTextBoxColumn";
            // 
            // aNODataGridViewTextBoxColumn
            // 
            this.aNODataGridViewTextBoxColumn.DataPropertyName = "ANO";
            this.aNODataGridViewTextBoxColumn.HeaderText = "ANO";
            this.aNODataGridViewTextBoxColumn.Name = "aNODataGridViewTextBoxColumn";
            // 
            // eDITORADataGridViewTextBoxColumn
            // 
            this.eDITORADataGridViewTextBoxColumn.DataPropertyName = "EDITORA";
            this.eDITORADataGridViewTextBoxColumn.HeaderText = "EDITORA";
            this.eDITORADataGridViewTextBoxColumn.Name = "eDITORADataGridViewTextBoxColumn";
            // 
            // dataTable3BindingSource
            // 
            this.dataTable3BindingSource.DataMember = "DataTable3";
            this.dataTable3BindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable3TableAdapter
            // 
            this.dataTable3TableAdapter.ClearBeforeFill = true;
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 701);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.idToModify);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btNewBook);
            this.Name = "Books";
            this.Text = "Livros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btNewBook;
        private System.Windows.Forms.TextBox idToModify;
        private System.Windows.Forms.DataGridView dataGridView1;
        public BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource dataTable3BindingSource;
        public BibliotecaDataSetTableAdapters.DataTable3TableAdapter dataTable3TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUTORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDICAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDITORADataGridViewTextBoxColumn;
    }
}