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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource10 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource11 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource12 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.viewЛичныйСоставBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoparkDB = new AUTOPARK.AutoparkDB();
            this.viewЗаданиеВодителю1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewЗаправкаТСМBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.autoparkDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewДвижениеТСМBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.viewПодвижнойСоставBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewРаботаВодителяИАвтоBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.view_Задание_водителю1TableAdapter = new AUTOPARK.AutoparkDBTableAdapters.View_Задание_водителю1TableAdapter();
            this.view_Личный_составTableAdapter = new AUTOPARK.AutoparkDBTableAdapters.View_Личный_составTableAdapter();
            this.viewДвижениеТСМBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_Движение__ТСМTableAdapter = new AUTOPARK.AutoparkDBTableAdapters.View_Движение__ТСМTableAdapter();
            this.viewРаботаВодителяИАвтоBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_Работа_водителя_и_автоTableAdapter = new AUTOPARK.AutoparkDBTableAdapters.View_Работа_водителя_и_автоTableAdapter();
            this.view_Подвижной_составTableAdapter = new AUTOPARK.AutoparkDBTableAdapters.View_Подвижной_составTableAdapter();
            this.viewЗаправкаТСМBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_Заправка_ТСМTableAdapter = new AUTOPARK.AutoparkDBTableAdapters.View_Заправка_ТСМTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.viewЛичныйСоставBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoparkDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewЗаданиеВодителю1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewЗаправкаТСМBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoparkDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewДвижениеТСМBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewПодвижнойСоставBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewРаботаВодителяИАвтоBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewДвижениеТСМBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewРаботаВодителяИАвтоBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewЗаправкаТСМBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // viewЛичныйСоставBindingSource
            // 
            this.viewЛичныйСоставBindingSource.DataMember = "View_Личный состав";
            this.viewЛичныйСоставBindingSource.DataSource = this.autoparkDB;
            // 
            // autoparkDB
            // 
            this.autoparkDB.DataSetName = "AutoparkDB";
            this.autoparkDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewЗаданиеВодителю1BindingSource
            // 
            this.viewЗаданиеВодителю1BindingSource.DataMember = "View_Задание водителю1";
            this.viewЗаданиеВодителю1BindingSource.DataSource = this.autoparkDB;
            // 
            // viewЗаправкаТСМBindingSource1
            // 
            this.viewЗаправкаТСМBindingSource1.DataMember = "View_Заправка ТСМ";
            this.viewЗаправкаТСМBindingSource1.DataSource = this.autoparkDBBindingSource;
            // 
            // autoparkDBBindingSource
            // 
            this.autoparkDBBindingSource.DataSource = this.autoparkDB;
            this.autoparkDBBindingSource.Position = 0;
            // 
            // viewДвижениеТСМBindingSource1
            // 
            this.viewДвижениеТСМBindingSource1.DataMember = "View_Движение  ТСМ";
            this.viewДвижениеТСМBindingSource1.DataSource = this.autoparkDBBindingSource;
            // 
            // viewПодвижнойСоставBindingSource
            // 
            this.viewПодвижнойСоставBindingSource.DataMember = "View_Подвижной состав";
            this.viewПодвижнойСоставBindingSource.DataSource = this.autoparkDBBindingSource;
            // 
            // viewРаботаВодителяИАвтоBindingSource1
            // 
            this.viewРаботаВодителяИАвтоBindingSource1.DataMember = "View_Работа водителя и авто";
            this.viewРаботаВодителяИАвтоBindingSource1.DataSource = this.autoparkDBBindingSource;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource7.Name = "DataSet1";
            reportDataSource7.Value = this.viewЛичныйСоставBindingSource;
            reportDataSource8.Name = "DataSet2";
            reportDataSource8.Value = this.viewЗаданиеВодителю1BindingSource;
            reportDataSource9.Name = "DataSet3";
            reportDataSource9.Value = this.viewЗаправкаТСМBindingSource1;
            reportDataSource10.Name = "DataSet5";
            reportDataSource10.Value = this.viewДвижениеТСМBindingSource1;
            reportDataSource11.Name = "DataSet6";
            reportDataSource11.Value = this.viewПодвижнойСоставBindingSource;
            reportDataSource12.Name = "DataSet4";
            reportDataSource12.Value = this.viewРаботаВодителяИАвтоBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource9);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource10);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource11);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource12);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AUTOPARK.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(675, 298);
            this.reportViewer1.TabIndex = 0;
            // 
            // view_Задание_водителю1TableAdapter
            // 
            this.view_Задание_водителю1TableAdapter.ClearBeforeFill = true;
            // 
            // view_Личный_составTableAdapter
            // 
            this.view_Личный_составTableAdapter.ClearBeforeFill = true;
            // 
            // viewДвижениеТСМBindingSource
            // 
            this.viewДвижениеТСМBindingSource.DataMember = "View_Движение  ТСМ";
            this.viewДвижениеТСМBindingSource.DataSource = this.autoparkDBBindingSource;
            // 
            // view_Движение__ТСМTableAdapter
            // 
            this.view_Движение__ТСМTableAdapter.ClearBeforeFill = true;
            // 
            // viewРаботаВодителяИАвтоBindingSource
            // 
            this.viewРаботаВодителяИАвтоBindingSource.DataMember = "View_Работа водителя и авто";
            this.viewРаботаВодителяИАвтоBindingSource.DataSource = this.autoparkDBBindingSource;
            // 
            // view_Работа_водителя_и_автоTableAdapter
            // 
            this.view_Работа_водителя_и_автоTableAdapter.ClearBeforeFill = true;
            // 
            // view_Подвижной_составTableAdapter
            // 
            this.view_Подвижной_составTableAdapter.ClearBeforeFill = true;
            // 
            // viewЗаправкаТСМBindingSource
            // 
            this.viewЗаправкаТСМBindingSource.DataMember = "View_Заправка ТСМ";
            this.viewЗаправкаТСМBindingSource.DataSource = this.autoparkDBBindingSource;
            // 
            // view_Заправка_ТСМTableAdapter
            // 
            this.view_Заправка_ТСМTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(675, 298);
            this.reportViewer2.TabIndex = 1;
            // 
            // OtchetGruzavogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 298);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "OtchetGruzavogo";
            this.Text = "Отчет Грузового авто";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewЛичныйСоставBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoparkDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewЗаданиеВодителю1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewЗаправкаТСМBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoparkDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewДвижениеТСМBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewПодвижнойСоставBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewРаботаВодителяИАвтоBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewДвижениеТСМBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewРаботаВодителяИАвтоBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewЗаправкаТСМBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private AutoparkDB autoparkDB;
        private System.Windows.Forms.BindingSource autoparkDBBindingSource;
        private System.Windows.Forms.BindingSource viewЗаданиеВодителю1BindingSource;
        private AutoparkDBTableAdapters.View_Задание_водителю1TableAdapter view_Задание_водителю1TableAdapter;
        private System.Windows.Forms.BindingSource viewЛичныйСоставBindingSource;
        private AutoparkDBTableAdapters.View_Личный_составTableAdapter view_Личный_составTableAdapter;
        private System.Windows.Forms.BindingSource viewДвижениеТСМBindingSource;
        private AutoparkDBTableAdapters.View_Движение__ТСМTableAdapter view_Движение__ТСМTableAdapter;
        private System.Windows.Forms.BindingSource viewРаботаВодителяИАвтоBindingSource;
        private AutoparkDBTableAdapters.View_Работа_водителя_и_автоTableAdapter view_Работа_водителя_и_автоTableAdapter;
        private System.Windows.Forms.BindingSource viewПодвижнойСоставBindingSource;
        private AutoparkDBTableAdapters.View_Подвижной_составTableAdapter view_Подвижной_составTableAdapter;
        private System.Windows.Forms.BindingSource viewЗаправкаТСМBindingSource;
        private AutoparkDBTableAdapters.View_Заправка_ТСМTableAdapter view_Заправка_ТСМTableAdapter;
        private System.Windows.Forms.BindingSource viewЗаправкаТСМBindingSource1;
        private System.Windows.Forms.BindingSource viewДвижениеТСМBindingSource1;
        private System.Windows.Forms.BindingSource viewРаботаВодителяИАвтоBindingSource1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
    }
}