using System;
using System.Windows.Forms;

namespace AUTOPARK
{
    public partial class PutevoiListGruzavogo : Form
    {
        private readonly BindingSource _bindingAuto = new BindingSource();
        private readonly BindingSource _bidingVoditel = new BindingSource();
       private readonly BindingSource _bindingDannie = new BindingSource();
        private readonly string _number;
        private readonly int _idauto;
        private readonly int _idvod;
        private readonly DateTime _dateStart;
        private readonly DateTime _dateEnd;
        private readonly bool _modeIsNew; ////true - add, false - update
        private int PutevoiId { get; set; }



        public PutevoiListGruzavogo()
        {
            InitializeComponent();
        }

        public PutevoiListGruzavogo(int id)
        {
            InitializeComponent();

            var tablep = new AutoparkDBTableAdapters.PodvijnoiTableAdapter();
            _bindingAuto.DataSource = tablep.GetData();
            if (_bindingAuto.Count == 0)
            {
                throw new Exception("Пожалуйста, заполните справочник \"Подвижной состав\"");
            }
            cbZnak.DataSource = _bindingAuto;
            cbZnak.DisplayMember = "Гос_номер";
            cbZnak.ValueMember = "ID";


            var tablel = new AutoparkDBTableAdapters.LichniiTableAdapter();
            _bidingVoditel.DataSource = tablel.GetData();
            if (_bidingVoditel.Count == 0)
            {
                throw new Exception("Пожалуйста, заполните справочник \"Личный состав\"");
            }
            cbTabelniiNomer.DataSource = _bidingVoditel;
            cbTabelniiNomer.DisplayMember = "табельный_номер";
            cbTabelniiNomer.ValueMember = "табельный_номер";
           var tablePutevoi = new AutoparkDBTableAdapters.PutevieGruzovieTableAdapter();
             //var newLegkNumber = tablePutevoi.GetNewLegkNumber();
            //if (newLegkNumber != null)
            //    txtNumber.Text = newLegkNumber.Value.ToString(CultureInfo.InvariantCulture);
            _dateStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            _dateEnd = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);
        }

       

         public PutevoiListGruzavogo(int id)
        {
            InitializeComponent();

             _modeIsNew=false;
             PutevoiId=id;
             var tablep = new AutoparkDBTableAdapters.PodvijnoiTableAdapter();
             _bindingAuto.DataSource = tablep.GetData();
             if (_bindingAuto.Count ==0)
             {
             throw new Exception("Пожалуйста, заполните справочник \"Подвижной состав\"");
             }
             cbZnak.DataSource = _bindingAuto;
             cbZnak.DisplayMember = "Гос_номер";
             cbZnak.ValueMember = "ID";

              var tablel = new AutoparkDBTableAdapters.LichniiTableAdapter();
            _bidingVoditel.DataSource = tablel.GetData();
            if (_bidingVoditel.Count == 0)
            {
                throw new Exception("Пожалуйста, заполните справочник \"Личный состав\"");
            }
            cbTabelniiNomer.DataSource = _bidingVoditel;
            cbTabelniiNomer.DisplayMember = "табельный_номер";
            cbTabelniiNomer.ValueMember = "табельный_номер";

             var tableDannie = new AutoparkDBTableAdapters.PutevieGruzovieTableAdapter
            _bindingDannie.DataSource = tableDannie.GetData();
            _bindingDannie.Filter = "[ID_Путевого листа] = " + PutevoiId;
            dgvZadanieVoditelu.DataSource = _bindingDannie;



              var dataGridViewColumn = dgvZadanieVoditelu.Columns["ID_Путевого листа"];
            if (dataGridViewColumn != null)
                dataGridViewColumn.Visible = false;
            dataGridViewColumn = dgvZadanieVoditelu.Columns["id_Данных"];
            if (dataGridViewColumn != null)
                dataGridViewColumn.Visible = false;
            var tablePutevoi = new AutoparkDB.TablePutevieGruzovieTableAdapter();
            var res = tablePutevoi.QueryGetDataByID(id).ToList();
            _number = res[0].Номер_путевого_листа;
            _idauto = res[0].ID_Автомобиля;
            _date  = res [0].Дата_путевого_листа;
            _idvod = res[0].ID_Водителя;
            _idviezd = res[0].ID_Работа_водителя_и_авто_выезд;
            _idvozvrahenie = res[0].ID_Работа_водителя_и_авто_возвращение;
            txtNumber.Text = _number;
            cbNomerAuto.SelectedItem = _bindingAuto[_bindingAuto.Find("ID", _idauto)];
            cbVodUdostoverenie.SelectedItem = _bindingVoditel[_bindingVoditel.Find("табельный_номер", _idvod)];
            dtpStart.Value = _dateStart;
            dtpEnd.Value = _dateEnd;

        }









 }

       private void PutevoiListGruzavogo_Load(object sender, EventArgs e)
        {
        }

      private void txtMarka_TextChanged(object sender, EventArgs e)
       {
        }

       private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void lblKolichestvo_Click(object sender, EventArgs e)
        {
        }

        private void lblPriVozvrachenii_Click(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            var f1 = new OtchetGruzavogo();
            f1.Show();
        } 

        private void tsmiToMenu_Click(object sender, EventArgs e)
        {
            var form = new Menu(); ////создание экземпляра формы Menu
            Hide(); //// скрытие текущей формы
            form.ShowDialog(); //// открытие формы Menu
            Close(); //// закрытие текущей формы
        }

        private void tsmiExitApplication_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);  //Полный выход из программы если нажимаем на дверку в Путевых листах грузового авто
        }
    }
}
