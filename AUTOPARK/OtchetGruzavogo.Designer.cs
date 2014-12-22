namespace AUTOPARK
{
    partial class OtchetGruzavogo
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtchetGruzavogo));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AutoparkDB = new AUTOPARK.AutoparkDB();
            this.Подвижной_составBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PodvijnoiTableAdapter = new AUTOPARK.AutoparkDBTableAdapters.PodvijnoiTableAdapter();
            this.Задание_водителюBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ZadanieVoditelTableAdapter = new AUTOPARK.AutoparkDBTableAdapters.ZadanieVoditelTableAdapter();
            this.Личный_составBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LichniiTableAdapter = new AUTOPARK.AutoparkDBTableAdapters.LichniiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AutoparkDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Подвижной_составBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Задание_водителюBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Личный_составBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = null;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = null;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = null;
            reportDataSource4.Name = "DataSet5";
            reportDataSource4.Value = null;
            reportDataSource5.Name = "DataSet6";
            reportDataSource5.Value = null;
            reportDataSource6.Name = "DataSet4";
            reportDataSource6.Value = null;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AUTOPARK.ReportGruz.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(892, 420);
            this.reportViewer1.TabIndex = 0;
            // 
            // AutoparkDB
            // 
            this.AutoparkDB.DataSetName = "AutoparkDB";
            this.AutoparkDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Подвижной_составBindingSource
            // 
            this.Подвижной_составBindingSource.DataMember = "Подвижной состав";
            this.Подвижной_составBindingSource.DataSource = this.AutoparkDB;
            // 
            // PodvijnoiTableAdapter
            // 
            this.PodvijnoiTableAdapter.ClearBeforeFill = true;
            // 
            // Задание_водителюBindingSource
            // 
            this.Задание_водителюBindingSource.DataMember = "Задание водителю";
            this.Задание_водителюBindingSource.DataSource = this.AutoparkDB;
            // 
            // ZadanieVoditelTableAdapter
            // 
            this.ZadanieVoditelTableAdapter.ClearBeforeFill = true;
            // 
            // Личный_составBindingSource
            // 
            this.Личный_составBindingSource.DataMember = "Личный состав";
            this.Личный_составBindingSource.DataSource = this.AutoparkDB;
            // 
            // LichniiTableAdapter
            // 
            this.LichniiTableAdapter.ClearBeforeFill = true;
            // 
            // OtchetGruzavogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 420);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OtchetGruzavogo";
            this.Text = "Отчет Грузового авто";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AutoparkDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Подвижной_составBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Задание_водителюBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Личный_составBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private AutoparkDB AutoparkDB;
        private System.Windows.Forms.BindingSource Подвижной_составBindingSource;
        private AutoparkDBTableAdapters.PodvijnoiTableAdapter PodvijnoiTableAdapter;
        private System.Windows.Forms.BindingSource Задание_водителюBindingSource;
        private AutoparkDBTableAdapters.ZadanieVoditelTableAdapter ZadanieVoditelTableAdapter;
        private System.Windows.Forms.BindingSource Личный_составBindingSource;
        private AutoparkDBTableAdapters.LichniiTableAdapter LichniiTableAdapter;
    }
}