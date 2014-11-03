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
            this.View_Данные_путевой_лист_легкового_автоBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoparkDB = new AUTOPARK.AutoparkDB();
            this.данныеПутевойЛистЛегковогоАвтоBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.putListLegkovogoDannieTableAdapter = new AUTOPARK.AutoparkDBTableAdapters.PutListLegkovogoDannieTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.View_Данные_путевой_лист_легкового_автоTableAdapter = new AUTOPARK.AutoparkDBTableAdapters.View_Данные_путевой_лист_легкового_автоTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.View_Данные_путевой_лист_легкового_автоBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoparkDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.данныеПутевойЛистЛегковогоАвтоBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // View_Данные_путевой_лист_легкового_автоBindingSource
            // 
            this.View_Данные_путевой_лист_легкового_автоBindingSource.DataMember = "View_Данные путевой лист легкового авто";
            this.View_Данные_путевой_лист_легкового_автоBindingSource.DataSource = this.autoparkDB;
            // 
            // autoparkDB
            // 
            this.autoparkDB.DataSetName = "AutoparkDB";
            this.autoparkDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // данныеПутевойЛистЛегковогоАвтоBindingSource
            // 
            this.данныеПутевойЛистЛегковогоАвтоBindingSource.DataMember = "Данные Путевой лист легкового авто";
            this.данныеПутевойЛистЛегковогоАвтоBindingSource.DataSource = this.autoparkDB;
            // 
            // putListLegkovogoDannieTableAdapter
            // 
            this.putListLegkovogoDannieTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.View_Данные_путевой_лист_легкового_автоBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AUTOPARK.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(690, 394);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // View_Данные_путевой_лист_легкового_автоTableAdapter
            // 
            this.View_Данные_путевой_лист_легкового_автоTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.View_Данные_путевой_лист_легкового_автоBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoparkDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.данныеПутевойЛистЛегковогоАвтоBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AutoparkDB autoparkDB;
        private System.Windows.Forms.BindingSource данныеПутевойЛистЛегковогоАвтоBindingSource;
        private AutoparkDBTableAdapters.PutListLegkovogoDannieTableAdapter putListLegkovogoDannieTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource View_Данные_путевой_лист_легкового_автоBindingSource;
        private AutoparkDBTableAdapters.View_Данные_путевой_лист_легкового_автоTableAdapter View_Данные_путевой_лист_легкового_автоTableAdapter;

    }
}