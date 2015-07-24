namespace AUTOPARK
{
    partial class PrilogenieC
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AutoparkDB = new AUTOPARK.AutoparkDB();
            this.DanieJournalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DanieJournalTableAdapter = new AUTOPARK.AutoparkDBTableAdapters.DanieJournalTableAdapter();
            this.HeaderJournalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HeaderJournalTableAdapter = new AUTOPARK.AutoparkDBTableAdapters.HeaderJournalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AutoparkDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DanieJournalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderJournalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Head1";
            reportDataSource1.Value = this.DanieJournalBindingSource;
            reportDataSource2.Name = "Head2";
            reportDataSource2.Value = this.HeaderJournalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AUTOPARK.ReportPrilogenieC.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(779, 378);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.UseWaitCursor = true;
            // 
            // AutoparkDB
            // 
            this.AutoparkDB.DataSetName = "AutoparkDB";
            this.AutoparkDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DanieJournalBindingSource
            // 
            this.DanieJournalBindingSource.DataMember = "DanieJournal";
            this.DanieJournalBindingSource.DataSource = this.AutoparkDB;
            // 
            // DanieJournalTableAdapter
            // 
            this.DanieJournalTableAdapter.ClearBeforeFill = true;
            // 
            // HeaderJournalBindingSource
            // 
            this.HeaderJournalBindingSource.DataMember = "HeaderJournal";
            this.HeaderJournalBindingSource.DataSource = this.AutoparkDB;
            // 
            // HeaderJournalTableAdapter
            // 
            this.HeaderJournalTableAdapter.ClearBeforeFill = true;
            // 
            // PrilogenieC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 378);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PrilogenieC";
            this.Text = "Приложение С";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.PrilogenieC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AutoparkDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DanieJournalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderJournalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DanieJournalBindingSource;
        private AutoparkDB AutoparkDB;
        private System.Windows.Forms.BindingSource HeaderJournalBindingSource;
        private AutoparkDBTableAdapters.DanieJournalTableAdapter DanieJournalTableAdapter;
        private AutoparkDBTableAdapters.HeaderJournalTableAdapter HeaderJournalTableAdapter;
    }
}