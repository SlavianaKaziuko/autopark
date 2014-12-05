using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Data;
namespace AUTOPARK
{
    public partial class PutevoiListGruzavogo : Form
    {
        private readonly BindingSource _bindingAuto = new BindingSource();
        private readonly BindingSource _bindingVoditel = new BindingSource();
        private readonly BindingSource _bindingDannie = new BindingSource();
        private readonly BindingSource _bindingDanniel = new BindingSource();
        private readonly int _number;
        private readonly int _idauto;
        private readonly int _idvod;
        private readonly DateTime _date;
        private readonly bool _modeIsNew; ////true - add, false - update
        private int _idviezd;
        private int _idvozvrahenie;
        private int PutevoiId { get; set; }

        public PutevoiListGruzavogo()
        {
            InitializeComponent();

            _modeIsNew = true;
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
            _bindingVoditel.DataSource = tablel.GetData();
            if (_bindingVoditel.Count == 0)
            {
                throw new Exception("Пожалуйста, заполните справочник \"Личный состав\"");
            }
            cbTabelniiNomer.DataSource = _bindingVoditel;
            cbTabelniiNomer.DisplayMember = "табельный_номер";
            cbTabelniiNomer.ValueMember = "табельный_номер";
            var tablePutevoi = new AutoparkDBTableAdapters.PutevieGruzovieTableAdapter();
            //var newLegkNumber = tablePutevoi.GetNewLegkNumber();
            //if (newLegkNumber != null)
            //    txtNumber.Text = newLegkNumber.Value.ToString(CultureInfo.InvariantCulture);
            _date = DateTime.Today;
        }

        public PutevoiListGruzavogo(int id)
        {
            InitializeComponent();

            _modeIsNew = false;
            PutevoiId = id;
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
            _bindingVoditel.DataSource = tablel.GetData();
            if (_bindingVoditel.Count == 0)
            {
                throw new Exception("Пожалуйста, заполните справочник \"Личный состав\"");
            }
            cbTabelniiNomer.DataSource = _bindingVoditel;
            cbTabelniiNomer.DisplayMember = "табельный_номер";
            cbTabelniiNomer.ValueMember = "табельный_номер";

            var tableDannie = new AutoparkDBTableAdapters.PutevieGruzovieTableAdapter();
            _bindingDannie.DataSource = tableDannie.GetData();
            _bindingDannie.Filter = "[ID_Путевого листа] = " + PutevoiId;
            dgvZadanieVoditelu.DataSource = _bindingDannie;



            var dataGridViewColumn = dgvZadanieVoditelu.Columns["ID_Путевого листа"];
            if (dataGridViewColumn != null)
                dataGridViewColumn.Visible = false;
            dataGridViewColumn = dgvZadanieVoditelu.Columns["id_Данных"];
            if (dataGridViewColumn != null)
                dataGridViewColumn.Visible = false;
            var tablePutevoi = new AutoparkDBTableAdapters.TablePutevieGruzovieTableAdapter();
            var res = tablePutevoi.GetDataByID(id).ToList();
            _number = res[0].Номер_путевого_листа;
            _idauto = res[0].ID_Автомобиля;
            _date = res[0].Дата_путевого_листа;
            _idvod = res[0].ID_Водителя;
            txtNumber.Text = _number.ToString(CultureInfo.InvariantCulture);

            var tableZadanie = new AutoparkDBTableAdapters.ZadanieVoditelTableAdapter();

            cbZnak.SelectedItem = _bindingAuto[_bindingAuto.Find("ID", _idauto)];
            cbTabelniiNomer.SelectedItem = _bindingVoditel.Find("табельный_номер", _idvod);
            dtpHapka.Value = _date;

            var tableDanniel = new AutoparkDBTableAdapters.PutevieGruzovieTableAdapter();
            _bindingDannie.DataSource = tableDanniel.GetData();
            _bindingDannie.Filter = "[ID_Путевого листа] = " + PutevoiId;
            dgvZapravkaTCM.DataSource = _bindingDanniel;

             dataGridViewColumn = dgvZapravkaTCM.Columns["ID_Путевого листа"];
            if (dataGridViewColumn != null)
                dataGridViewColumn.Visible = false;
            dataGridViewColumn = dgvZapravkaTCM.Columns["ID_Заправка ТСМ"];
            if (dataGridViewColumn != null)
                dataGridViewColumn.Visible = false;


        }

        private void cbZnak_SelectedValueChanged(object sender, EventArgs e)               //  Комбобок cbZnak  (Автомобиль)
        {
            ////Вытягивание из таблицы binding строку,затем преобразовываем в тип данных DataRowView,
            ////вытягивание из массива данных(Row) и затем вытягивание ячейки 1 (ItemArray[1])
            txtGaraz.Text = ((DataRowView)_bindingAuto[cbZnak.SelectedIndex]).Row.ItemArray[3].ToString();
            txtMarka.Text = ((DataRowView)_bindingAuto[cbZnak.SelectedIndex]).Row.ItemArray[4].ToString();
        }

        private void cbTabelniiNomer_SelectedValueChanger(object sender, EventArgs e)           //  Комбобок cbTabelniiNomer  (Автомобиль)
        {
            ////Вытягивание из таблицы binding строку,затем преобразовываем в тип данных DataRowView,
            ////вытягивание из массива данных(Row) и затем вытягивание ячейки 1 (ItemArray[1])
            var zapis = ((DataRowView) _bindingVoditel[cbTabelniiNomer.SelectedIndex]).Row.ItemArray;
            // Выбирает инициалы.т.е первую букву в фамилии и имени.
            txtImia.Text = zapis[1] + @" " +
                           (zapis[2].ToString().Length > 1 ? zapis[2].ToString().Substring(0, 1) + @". " : "") +   
                           (zapis[3].ToString().Length > 1 ? zapis[3].ToString().Substring(0, 1) + @". " : "");
        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_modeIsNew)
            {
                
            }
            else
            {
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            var f1 = new OtchetGruzavogo(PutevoiId);
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
            Environment.Exit(0); //Полный выход из программы если нажимаем на дверку в Путевых листах грузового авто
        }

       
    }
}
