using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

            var table = new AutoparkDBTableAdapters.PutListLegkovogoDannieTableAdapter();
            _bindingDannie.DataSource = table.GetDataWithCalculating(PutevoiId);

            var tablePutevoi = new AutoparkDBTableAdapters.PutevieLegkovieTableAdapter();
            _bindingHead.DataSource = tablePutevoi.GetDataByID(PutevoiId);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Body", _bindingDannie));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ReportHead", _bindingHead));
            
            reportViewer1.RefreshReport();
        }

    }
}
