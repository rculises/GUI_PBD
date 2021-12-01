
namespace GUI_PBD
{
    partial class rEmpresa
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
            this.PBDDataSet = new GUI_PBD.PBDDataSet();
            this.EmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmpresaTableAdapter = new GUI_PBD.PBDDataSetTableAdapters.EmpresaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpresaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsDatos";
            reportDataSource1.Value = this.EmpresaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI_PBD.rptEmpresa.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(646, 496);
            this.reportViewer1.TabIndex = 0;
            // 
            // PBDDataSet
            // 
            this.PBDDataSet.DataSetName = "PBDDataSet";
            this.PBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EmpresaBindingSource
            // 
            this.EmpresaBindingSource.DataMember = "Empresa";
            this.EmpresaBindingSource.DataSource = this.PBDDataSet;
            // 
            // EmpresaTableAdapter
            // 
            this.EmpresaTableAdapter.ClearBeforeFill = true;
            // 
            // rEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 496);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de empresas";
            this.Load += new System.EventHandler(this.rEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpresaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EmpresaBindingSource;
        private PBDDataSet PBDDataSet;
        private PBDDataSetTableAdapters.EmpresaTableAdapter EmpresaTableAdapter;
    }
}