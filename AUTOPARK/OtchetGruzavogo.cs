using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace AUTOPARK
{
    public partial class OtchetGruzavogo : Form
    {
        private readonly BindingSource _bindingHead = new BindingSource();
        private readonly BindingSource _bindingAuto = new BindingSource();
        private readonly BindingSource _bindingVoditel = new BindingSource();
        private readonly BindingSource _bindingDannie = new BindingSource();
        private readonly BindingSource _bindingZadanie = new BindingSource();
        private readonly BindingSource _bindingDannieZapr = new BindingSource();

        private int PutevoiId { get; set; }

        public OtchetGruzavogo(int id)
        {
            InitializeComponent();
            PutevoiId = id;
            
            var tablePutevoi = new AutoparkDBTableAdapters.TablePutevieGruzovieTableAdapter();
            _bindingHead.DataSource = tablePutevoi.GetDataByID(PutevoiId);
            var res = tablePutevoi.GetDataByID(id).ToList();
            var idauto = res[0].ID_Автомобиля;
            var idvod = res[0].ID_Водителя;

            var tablep = new AutoparkDBTableAdapters.PodvijnoiTableAdapter();
            _bindingAuto.DataSource = tablep.GetDataByID(idauto);

            var tablel = new AutoparkDBTableAdapters.LichniiTableAdapter();
            _bindingVoditel.DataSource = tablel.GetDataByID(idvod);

            var tableDannie = new AutoparkDBTableAdapters.PutevieGruzovieTableAdapter();
            _bindingDannie.DataSource = tableDannie.GetData();
            _bindingDannie.Filter = "[ID_Путевого листа] = " + PutevoiId;

            var tableZadanie = new AutoparkDBTableAdapters.ZadanieVoditelTableAdapter();
            _bindingZadanie.DataSource = tableZadanie.GetDataByPutevoiId(PutevoiId);

            var tableZapr = new AutoparkDBTableAdapters.ZapravkaTCMTableAdapter();
            _bindingDannieZapr.DataSource = tableZapr.GetDataByPutevoiID(PutevoiId);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ReportHead", _bindingHead));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DannieAuto", _bindingAuto));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Voditel", _bindingVoditel));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ZadanieVoditel", _bindingZadanie));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ZapravkaTCM", _bindingDannieZapr));
            reportViewer1.RefreshReport();
        }
    }
}
