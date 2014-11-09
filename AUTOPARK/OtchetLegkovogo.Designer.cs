namespace AUTOPARK
{
    partial class OtchetLegkovogo
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
            this.данныеПутевойЛистЛегковогоАвтоBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoparkDB = new AUTOPARK.AutoparkDB();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.putListLegkovogoDannieTableAdapter = new AUTOPARK.AutoparkDBTableAdapters.PutListLegkovogoDannieTableAdapter();
            this.данныеПутевойЛистЛегковогоАвтоBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.данныеПутевойЛистЛегковогоАвтоBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoparkDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.данныеПутевойЛистЛегковогоАвтоBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // данныеПутевойЛистЛегковогоАвтоBindingSource
            // 
            this.данныеПутевойЛистЛегковогоАвтоBindingSource.DataMember = "Данные Путевой лист легкового авто";
            this.данныеПутевойЛистЛегковогоАвтоBindingSource.DataSource = this.autoparkDB;
            // 
            // autoparkDB
            // 
            this.autoparkDB.DataSetName = "AutoparkDB";
            this.autoparkDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.данныеПутевойЛистЛегковогоАвтоBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.данныеПутевойЛистЛегковогоАвтоBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AUTOPARK.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(690, 394);
            this.reportViewer1.TabIndex = 0;
            // 
            // putListLegkovogoDannieTableAdapter
            // 
            this.putListLegkovogoDannieTableAdapter.ClearBeforeFill = true;
            // 
            // данныеПутевойЛистЛегковогоАвтоBindingSource1
            // 
            this.данныеПутевойЛистЛегковогоАвтоBindingSource1.DataMember = "Данные Путевой лист легкового авто";
            this.данныеПутевойЛистЛегковогоАвтоBindingSource1.DataSource = this.autoparkDB;
            // 
            // OtchetLegkovogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 394);
            this.Controls.Add(this.reportViewer1);
            this.Name = "OtchetLegkovogo";
            this.Text = "Отчет Легкового Авто";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.данныеПутевойЛистЛегковогоАвтоBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoparkDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.данныеПутевойЛистЛегковогоАвтоBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AutoparkDB autoparkDB;
        private System.Windows.Forms.BindingSource данныеПутевойЛистЛегковогоАвтоBindingSource;
        private AutoparkDBTableAdapters.PutListLegkovogoDannieTableAdapter putListLegkovogoDannieTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource данныеПутевойЛистЛегковогоАвтоBindingSource1;

    }
}