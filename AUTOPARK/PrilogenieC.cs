using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace AUTOPARK
{
    public partial class PrilogenieC : Form
    {
        private readonly BindingSource _bindingHead = new BindingSource();
        private readonly BindingSource _bindingDannie = new BindingSource();

        public PrilogenieC(DateTime dateStart, DateTime dateEnd, int auto, char type)
        {
            InitializeComponent();
            var tableHead2 = new AutoparkDBTableAdapters.HeaderJournalTableAdapter();
            _bindingHead.DataSource = tableHead2.GetDataByAutoAndDate(dateStart, dateEnd, auto);

            var tableHead1 = new AutoparkDBTableAdapters.DanieJournalTableAdapter();
            switch (type)
            {
                case 'Л':
                    _bindingDannie.DataSource = tableHead1.GetDataByAutoAndDateLegk(dateStart, dateEnd, auto);
                    break;
                case 'Г':
                    _bindingDannie.DataSource = tableHead1.GetDataByAutoAndDate(dateStart, dateEnd, auto);
                    break;
            }
        }
        private void PrilogenieC_Load(object sender, EventArgs e)
        {

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Head2", _bindingHead));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Head1", _bindingDannie));
            reportViewer1.RefreshReport();
        }
    }
}
