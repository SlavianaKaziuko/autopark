using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


namespace AUTOPARK
{
    public partial class PrilogenieL : Form
    {
        private readonly BindingSource _bindingHead = new BindingSource();
        private readonly BindingSource _bindingDannie = new BindingSource();

        public PrilogenieL(DateTime dateStart, DateTime dateEnd, int auto, char type)
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

        private void PrilogenieL_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Head", _bindingHead));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Body", _bindingDannie));

            reportViewer1.RefreshReport();
        }
    }
}
