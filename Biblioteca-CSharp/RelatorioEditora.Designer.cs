namespace Biblioteca_CSharp
{
    partial class RelatorioEditora
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BibliotecaDataSet = new Biblioteca_CSharp.BibliotecaDataSet();
            this.EDITORABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EDITORATableAdapter = new Biblioteca_CSharp.BibliotecaDataSetTableAdapters.EDITORATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EDITORABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EDITORABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Biblioteca_CSharp.ReportEditora.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1370, 726);
            this.reportViewer1.TabIndex = 0;
            // 
            // BibliotecaDataSet
            // 
            this.BibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.BibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EDITORABindingSource
            // 
            this.EDITORABindingSource.DataMember = "EDITORA";
            this.EDITORABindingSource.DataSource = this.BibliotecaDataSet;
            // 
            // EDITORATableAdapter
            // 
            this.EDITORATableAdapter.ClearBeforeFill = true;
            // 
            // RelatorioEditora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 726);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelatorioEditora";
            this.Text = "Relatorio de Editora";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RelatorioEditora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EDITORABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EDITORABindingSource;
        private BibliotecaDataSet BibliotecaDataSet;
        private BibliotecaDataSetTableAdapters.EDITORATableAdapter EDITORATableAdapter;
    }
}