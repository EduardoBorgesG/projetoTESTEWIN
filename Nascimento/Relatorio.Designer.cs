namespace projetoTESTEWIN.Nascimento
{
    partial class frmRelatorio
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
            this.nascimentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetowinDataSet1 = new projetoTESTEWIN.projetowinDataSet1();
            this.nascimentoDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.nascimentoDataTableAdapter = new projetoTESTEWIN.projetowinDataSet1TableAdapters.NascimentoDataTableAdapter();
            this.nascimentoDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nascimentoDataBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.nascimentoTableAdapter = new projetoTESTEWIN.projetowinDataSet1TableAdapters.nascimentoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nascimentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetowinDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nascimentoDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nascimentoDataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nascimentoDataBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // nascimentoBindingSource
            // 
            this.nascimentoBindingSource.DataMember = "nascimento";
            this.nascimentoBindingSource.DataSource = this.projetowinDataSet1;
            // 
            // projetowinDataSet1
            // 
            this.projetowinDataSet1.DataSetName = "projetowinDataSet1";
            this.projetowinDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nascimentoDataBindingSource
            // 
            this.nascimentoDataBindingSource.DataMember = "NascimentoData";
            this.nascimentoDataBindingSource.DataSource = this.projetowinDataSet1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetNascimento";
            reportDataSource1.Value = this.nascimentoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "projetoTESTEWIN.Nascimento.RelatorioN.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(973, 567);
            this.reportViewer1.TabIndex = 0;
            // 
            // nascimentoDataTableAdapter
            // 
            this.nascimentoDataTableAdapter.ClearBeforeFill = true;
            // 
            // nascimentoDataBindingSource1
            // 
            this.nascimentoDataBindingSource1.DataMember = "NascimentoData";
            this.nascimentoDataBindingSource1.DataSource = this.projetowinDataSet1;
            // 
            // nascimentoDataBindingSource2
            // 
            this.nascimentoDataBindingSource2.DataMember = "NascimentoData";
            this.nascimentoDataBindingSource2.DataSource = this.projetowinDataSet1;
            // 
            // nascimentoTableAdapter
            // 
            this.nascimentoTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 567);
            this.Controls.Add(this.reportViewer1);
            this.MinimizeBox = false;
            this.Name = "frmRelatorio";
            this.Text = "Relatório de Nascimento";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nascimentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetowinDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nascimentoDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nascimentoDataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nascimentoDataBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource nascimentoDataBindingSource;
        private projetowinDataSet1 projetowinDataSet1;
        private projetowinDataSet1TableAdapters.NascimentoDataTableAdapter nascimentoDataTableAdapter;
        private System.Windows.Forms.BindingSource nascimentoDataBindingSource1;
        private System.Windows.Forms.BindingSource nascimentoDataBindingSource2;
        private System.Windows.Forms.BindingSource nascimentoBindingSource;
        private projetowinDataSet1TableAdapters.nascimentoTableAdapter nascimentoTableAdapter;
    }
}