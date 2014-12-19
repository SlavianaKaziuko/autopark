using System;
using System.Collections.Generic;
using System.Drawing;
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
        private readonly BindingSource _bindingOtdel = new BindingSource();
        private readonly BindingSource _bindingZadanie = new BindingSource();
        private readonly BindingSource _bindingZapravka = new BindingSource();
        private readonly List<AutoparkDB.Путевой_лист_Грузового_автоRow> mainInfo;
        private readonly int _number;
        private int _idauto;
        private readonly int _idvod;
        private readonly DateTime _date;
        private readonly int _idotdel;
        private readonly bool _modeIsNew; ////true - add, false - update
        private int PutevoiId { get; set; }

        public PutevoiListGruzavogo()
        {
            InitializeComponent();
            PrepareComboBoxDataSources();

            _modeIsNew = true;
            _idauto = int.Parse(cbZnak.SelectedValue.ToString());
            var queries = new AutoparkDBTableAdapters.QueriesTableAdapter();
            var newLegkNumber = queries.GetNewNumberGruz();
            if (newLegkNumber != null)
                _number = int.Parse(newLegkNumber.ToString());
            _date = DateTime.Today;
            txtViezdSpidometr.Text = queries.GetMileageGruz(_idauto, _date).ToString();
            mainInfo = new List<AutoparkDB.Путевой_лист_Грузового_автоRow>();
        }

        public PutevoiListGruzavogo(int id)
        {
            InitializeComponent();
            PrepareComboBoxDataSources();
            _modeIsNew = false;
            PutevoiId = id;
            
            var tablePutevoi = new AutoparkDBTableAdapters.TablePutevieGruzovieTableAdapter();
            mainInfo = tablePutevoi.GetDataByID(id).ToList();
            _number = mainInfo[0].Номер_путевого_листа;
            _idauto = mainInfo[0].ID_Автомобиля;
            _date = mainInfo[0].Дата_путевого_листа;
            _idvod = mainInfo[0].ID_Водителя;
            _idotdel = mainInfo[0].ID_Отдела;

            var tableZadanie = new AutoparkDBTableAdapters.ZadanieVoditelTableAdapter();
            _bindingZadanie.DataSource = tableZadanie.GetDataByPutevoiId(PutevoiId);
            dgvZadanieVoditelu.DataSource = _bindingZadanie;

            var tableZapravka = new AutoparkDBTableAdapters.ZapravkaTCMTableAdapter();
            _bindingZapravka.DataSource = tableZapravka.GetDataByPutevoiID(PutevoiId);
            dgvZapravkaTCM.DataSource = _bindingZapravka;
            
            
            var dataGridViewColumn = dgvZadanieVoditelu.Columns["ID_Путевого листа"];
            if (dataGridViewColumn != null)
                dataGridViewColumn.Visible = false;
            dataGridViewColumn = dgvZadanieVoditelu.Columns["id_Данных"];
            if (dataGridViewColumn != null)
                dataGridViewColumn.Visible = false;
             dataGridViewColumn = dgvZapravkaTCM.Columns["ID_Путевого листа"];
            if (dataGridViewColumn != null)
                dataGridViewColumn.Visible = false;
            dataGridViewColumn = dgvZapravkaTCM.Columns["ID_Заправка ТСМ"];
            if (dataGridViewColumn != null)
                dataGridViewColumn.Visible = false;
        }

        private void PrepareComboBoxDataSources()
        {
            var tablep = new AutoparkDBTableAdapters.PodvijnoiTableAdapter();
            _bindingAuto.DataSource = tablep.GetDataByType("Г");
            if (_bindingAuto.Count == 0)
            {
                throw new Exception("Пожалуйста, заполните справочник \"Подвижной состав\"");
            }
            cbZnak.DisplayMember = "Гос_номер";
            cbZnak.ValueMember = "ID";
            cbZnak.DataSource = _bindingAuto;

            var tablel = new AutoparkDBTableAdapters.LichniiTableAdapter();
            _bindingVoditel.DataSource = tablel.GetDataSpisokVoditeli();
            if (_bindingVoditel.Count == 0)
            {
                throw new Exception("Пожалуйста, заполните справочник \"Личный состав\"");
            }
            cbImia.DataSource = _bindingVoditel;
            cbImia.DisplayMember = "ФИО";
            cbImia.ValueMember = "табельный_номер";

            var tableOtdeli = new AutoparkDBTableAdapters.OtdelTableAdapter();
            _bindingOtdel.DataSource = tableOtdeli.GetData();
            cbOtdel.DataSource = _bindingOtdel;
            cbOtdel.DisplayMember = "Подразделение";
            cbOtdel.ValueMember = "Код";
        }

        private void PutevoiListGruzavogo_Load(object sender, EventArgs e)
        {
            dgvZadanieVoditelu.DataSource = _bindingZadanie;
            txtNumber.Text = _number.ToString(CultureInfo.InvariantCulture);
            cbZnak.SelectedItem = _bindingAuto.Find("ID", _idauto);
            cbImia.SelectedItem = _bindingVoditel.Find("табельный_номер", _idvod);
            cbOtdel.SelectedItem = _bindingOtdel.Find("Код", _idotdel);
            dtpHapka.Value = _date;
            cbToplivoType.SelectedIndex = 0;
            cbToplivoType.Enabled = false;
            cbToplivoType2.SelectedIndex = 1;
            cbToplivoType2.Enabled = false;
            if (_modeIsNew)
            {
                return;
            }
            txtViezdSpidometr.Text = mainInfo[0].Показания_спидометра_при_выезде.ToString(CultureInfo.InvariantCulture);
            txtVozvrahenieSpidometr.Text = mainInfo[0].Показания_спидометра_при_возвращении.ToString(CultureInfo.InvariantCulture);
            dtpPoGraphViezd.Value = mainInfo[0].Дата_Время_выезда_граф;
            dtpPoGraphVozvr.Value = mainInfo[0].Дата_Время_возвращения_граф;
            dtpFactViezd.Value = mainInfo[0].Дата_Время_выезда_факт;
            dtpFactVozvr.Value = mainInfo[0].Дата_Время_возвращения_факт;
            txtNulevoiProbegViezd.Text = mainInfo[0].Нулевой_пробег_выезд.ToString(CultureInfo.InvariantCulture);
            txtNulevoiProbegVozvrahenie.Text = mainInfo[0].Нулевой_пробег_возвр.ToString(CultureInfo.InvariantCulture);
            txtPriViezdiTCM.Text = mainInfo[0].Остаток_ТСМ1_выезд.ToString(CultureInfo.InvariantCulture);
            txtPriViezdiTCM2.Text = mainInfo[0].Остаток_ТСМ2_выезд.ToString(CultureInfo.InvariantCulture);
            txtPriVozvracheniiTCM.Text = mainInfo[0].Остаток_ТСМ1_возвр.ToString(CultureInfo.InvariantCulture);
            txtPriVozvracheniiTCM2.Text = mainInfo[0].Остаток_ТСМ2_возвр.ToString(CultureInfo.InvariantCulture);
            txtVremiaDvigViezd.Text = mainInfo[0].Время_работы_двигателя_выезд.ToString(CultureInfo.InvariantCulture);
            txtVremiaDvigVozvr.Text = mainInfo[0].Время_работы_двигателя_возвр.ToString(CultureInfo.InvariantCulture);
            txtVremiaOborudViezd.Text = mainInfo[0].Время_работы_спецоборудования_выезд.ToString(CultureInfo.InvariantCulture);
            txtVremiaOborudVozvr.Text = mainInfo[0].Время_работы_спецоборудования_возвр.ToString(CultureInfo.InvariantCulture);
        }

        private void cbZnak_SelectedValueChanged(object sender, EventArgs e)               //  Комбобок cbZnak  (Автомобиль)
        {
            ////Вытягивание из таблицы binding строку,затем преобразовываем в тип данных DataRowView,
            ////вытягивание из массива данных(Row) и затем вытягивание ячейки 1 (ItemArray[1])
            var id = int.Parse(cbZnak.SelectedValue.ToString());
            txtGaraz.Text = ((DataRowView)_bindingAuto[_bindingAuto.Find("ID", id)])["Гаражный номер"].ToString();
            txtMarka.Text = ((DataRowView)_bindingAuto[_bindingAuto.Find("ID", id)])["Марка и модель"].ToString();
            var toplivo = new List<string>
            {
                ((DataRowView) _bindingAuto[_bindingAuto.Find("ID", id)])["Вид топлива"].ToString(),
                ((DataRowView) _bindingAuto[_bindingAuto.Find("ID", id)])["Дополнительный вид топлива"].ToString()
            };
            cbToplivoType.DataSource = toplivo;
            cbToplivoType2.DataSource = toplivo;
        }

        private void cbImia_SelectedValueChanger(object sender, EventArgs e)           //  Комбобок cbImia  (Автомобиль)
        {
            ////Вытягивание из таблицы binding строку,затем преобразовываем в тип данных DataRowView,
            ////вытягивание из массива данных(Row) и затем вытягивание ячейки 1 (ItemArray[1])
          /*  var zapis = ((DataRowView)_bindingVoditel[cbImia.SelectedIndex]).Row.ItemArray;
            // Выбирает инициалы.т.е первую букву в фамилии и имени.
           txt.Text = zapis[1] + @" " +
                           (zapis[2].ToString().Length > 1 ? zapis[2].ToString().Substring(0, 1) + @". " : "") +   
                           (zapis[3].ToString().Length > 1 ? zapis[3].ToString().Substring(0, 1) + @". " : ""); */
            txtTabelniiNomer.Text = ((DataRowView)_bindingVoditel[cbImia.SelectedIndex]).Row["табельный_номер"].ToString();
            txtKlass.Text = ((DataRowView)_bindingVoditel[cbImia.SelectedIndex]).Row["классность"].ToString();
        }
    
       

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_modeIsNew)
            {
                
            }
            else
            {
                
            }
            btnCancel.Visible = false;
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
            Environment.Exit(0); //Полный выход из программы если нажимаем Навигация далее Выйти из приложения в Путевых листах грузового авто
        }

        private void PutevoiListGruzavogo_Resize(object sender, EventArgs e)
        {
            dgvZadanieVoditelu.Width = this.Width - 40;
            dgvZadanieVoditelu.Height = this.Height - dgvZadanieVoditelu.Location.Y - 85;
            btnSave.Location = new Point(btnSave.Location.X, this.Height - 70);
            btnCancel.Location = new Point(btnCancel.Location.X, this.Height - 70);
            btnReport.Location = new Point(btnReport.Location.X, this.Height - 70);
        }
    }
}
