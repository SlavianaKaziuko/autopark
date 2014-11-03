namespace AUTOPARK
{
    partial class Form1
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
            this.AutoparkDB = new AUTOPARK.AutoparkDB();
            this.Данные_Путевой_лист_легкового_автоBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PutListLegkovogoDannieTableAdapter = new AUTOPARK.AutoparkDBTableAdapters.PutListLegkovogoDannieTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AutoparkDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Данные_Путевой_лист_легкового_автоBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Данные_Путевой_лист_легкового_автоBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AUTOPARK.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(766, 349);
            this.reportViewer1.TabIndex = 0;
            // 
            // AutoparkDB
            // 
            this.AutoparkDB.DataSetName = "AutoparkDB";
            this.AutoparkDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Данные_Путевой_лист_легкового_автоBindingSource
            // 
            this.Данные_Путевой_лист_легкового_автоBindingSource.DataMember = "Данные Путевой лист легкового авто";
            this.Данные_Путевой_лист_легкового_автоBindingSource.DataSource = this.AutoparkDB;
            // 
            // PutListLegkovogoDannieTableAdapter
            // 
            this.PutListLegkovogoDannieTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 351);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AutoparkDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Данные_Путевой_лист_легкового_автоBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Данные_Путевой_лист_легкового_автоBindingSource;
        private AutoparkDB AutoparkDB;
        private AutoparkDBTableAdapters.PutListLegkovogoDannieTableAdapter PutListLegkovogoDannieTableAdapter;
    }
}