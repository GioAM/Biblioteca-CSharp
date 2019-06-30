namespace Biblioteca_CSharp
{
    partial class RelatorioDevolucao
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
            this.DataTable5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable5TableAdapter = new Biblioteca_CSharp.BibliotecaDataSetTableAdapters.DataTable5TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable5BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable5BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Biblioteca_CSharp.ReportDevolucao.rdlc";
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
            // DataTable5BindingSource
            // 
            this.DataTable5BindingSource.DataMember = "DataTable5";
            this.DataTable5BindingSource.DataSource = this.BibliotecaDataSet;
            // 
            // DataTable5TableAdapter
            // 
            this.DataTable5TableAdapter.ClearBeforeFill = true;
            // 
            // RelatorioDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 726);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelatorioDevolucao";
            this.Text = "Relatorio de Devolucao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RelatorioDevolucao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable5BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable5BindingSource;
        private BibliotecaDataSet BibliotecaDataSet;
        private BibliotecaDataSetTableAdapters.DataTable5TableAdapter DataTable5TableAdapter;
    }
}