using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace AUTOPARK
{
    public partial class OtchetJournal : Form
    {
        private readonly BindingSource _bindingHead = new BindingSource();
        private readonly BindingSource _bindingDannie = new BindingSource();

        public OtchetJournal(DateTime dateStart, DateTime dateEnd, int auto, char type)
        {
            InitializeComponent();
            var tableHead = new AutoparkDBTableAdapters.HeaderJournalTableAdapter();
            _bindingHead.DataSource = tableHead.GetDataByAutoAndDate(dateStart, dateEnd, auto);

            var tableBody = new AutoparkDBTableAdapters.DanieJournalTableAdapter();
            switch (type)
            {
                case 'Л':
                    _bindingDannie.DataSource = tableBody.GetDataByAutoAndDateLegk(dateStart, dateEnd, auto);
                    break;
                case 'Г':
                    _bindingDannie.DataSource = tableBody.GetDataByAutoAndDate(dateStart, dateEnd, auto);
                    break;
            }
        }

        private void OtchetJournal_Load(object sender, EventArgs e)
        {
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Head", _bindingHead));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Body", _bindingDannie));

            reportViewer.RefreshReport();
        }
    }
}
