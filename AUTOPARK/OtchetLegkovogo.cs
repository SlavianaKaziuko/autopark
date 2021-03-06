﻿using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace AUTOPARK
{
    public partial class OtchetLegkovogo : Form
    {
        private readonly BindingSource _bindingHead = new BindingSource();
        private readonly BindingSource _bindingDannie = new BindingSource();
        private int PutevoiId { get; set; }

        public OtchetLegkovogo(int id)
        {
            InitializeComponent();
             PutevoiId = id;

            var tablePutevoi = new AutoparkDBTableAdapters.PutevieLegkovieTableAdapter();
            _bindingHead.DataSource = tablePutevoi.GetDataByID(PutevoiId);

            var table = new AutoparkDBTableAdapters.PutListLegkovogoDannieTableAdapter();
            _bindingDannie.DataSource = table.GetDataById(PutevoiId);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Body", _bindingDannie));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ReportHead", _bindingHead));
            
            reportViewer1.RefreshReport();
        }

    }
}
