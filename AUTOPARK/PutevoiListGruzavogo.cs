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
        private List<AutoparkDB.Путевой_лист_Грузового_автоRow> _mainInfo;
        private readonly int _number;
        private int _idauto;
        private int _idvod;
        private readonly DateTime _date;
        private int _idotdel;
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
            txtVozvrahenieSpidometr.Text = txtViezdSpidometr.Text;
            txtPriViezdiTCM.Text = queries.GetToplivoGruz(_idauto, 1, _date).ToString();
            txtPriViezdiTCM2.Text = queries.GetToplivoGruz(_idauto, 2, _date).ToString();
            txtPriVozvracheniiTCM.Text = txtPriViezdiTCM.Text;
            txtPriVozvracheniiTCM2.Text = txtPriViezdiTCM2.Text;

            _mainInfo = new List<AutoparkDB.Путевой_лист_Грузового_автоRow>();
        }

        public PutevoiListGruzavogo(int id)
        {
            InitializeComponent();
            PrepareComboBoxDataSources();
            _modeIsNew = false;
            PutevoiId = id;
            
            var tablePutevoi = new AutoparkDBTableAdapters.TablePutevieGruzovieTableAdapter();
            _mainInfo = tablePutevoi.GetDataByID(id).ToList();
            _number = _mainInfo[0].Номер_путевого_листа;
            _idauto = _mainInfo[0].ID_Автомобиля;
            _date = _mainInfo[0].Дата_путевого_листа;
            _idvod = _mainInfo[0].ID_Водителя;
            _idotdel = _mainInfo[0].ID_Отдела;

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
            if (_modeIsNew)
            {

                return;
            }
            txtViezdSpidometr.Text = _mainInfo[0].Показания_спидометра_при_выезде.ToString(CultureInfo.InvariantCulture);
            txtVozvrahenieSpidometr.Text = _mainInfo[0].Показания_спидометра_при_возвращении.ToString(CultureInfo.InvariantCulture);
            dtpPoGraphViezd.Value = _mainInfo[0].Дата_Время_выезда_граф;
            dtpPoGraphVozvr.Value = _mainInfo[0].Дата_Время_возвращения_граф;
            dtpFactViezd.Value = _mainInfo[0].Дата_Время_выезда_факт;
            dtpFactVozvr.Value = _mainInfo[0].Дата_Время_возвращения_факт;
            txtNulevoiProbegViezd.Text = _mainInfo[0].Нулевой_пробег_выезд.ToString(CultureInfo.InvariantCulture);
            txtNulevoiProbegVozvrahenie.Text = _mainInfo[0].Нулевой_пробег_возвр.ToString(CultureInfo.InvariantCulture);
            txtPriViezdiTCM.Text = _mainInfo[0].Остаток_ТСМ1_выезд.ToString(CultureInfo.InvariantCulture);
            txtPriViezdiTCM2.Text = _mainInfo[0].Остаток_ТСМ2_выезд.ToString(CultureInfo.InvariantCulture);
            txtPriVozvracheniiTCM.Text = _mainInfo[0].Остаток_ТСМ1_возвр.ToString(CultureInfo.InvariantCulture);
            txtPriVozvracheniiTCM2.Text = _mainInfo[0].Остаток_ТСМ2_возвр.ToString(CultureInfo.InvariantCulture);
            txtVremiaDvigViezd.Text = _mainInfo[0].Время_работы_двигателя_выезд.ToString(CultureInfo.InvariantCulture);
            txtVremiaDvigVozvr.Text = _mainInfo[0].Время_работы_двигателя_возвр.ToString(CultureInfo.InvariantCulture);
            txtVremiaOborudViezd.Text = _mainInfo[0].Время_работы_спецоборудования_выезд.ToString(CultureInfo.InvariantCulture);
            txtVremiaOborudVozvr.Text = _mainInfo[0].Время_работы_спецоборудования_возвр.ToString(CultureInfo.InvariantCulture);
        }

        private void cbZnak_SelectedValueChanged(object sender, EventArgs e)               //  Комбобок cbZnak  (Автомобиль)
        {
            ////Вытягивание из таблицы binding строку,затем преобразовываем в тип данных DataRowView,
            ////вытягивание из массива данных(Row) и затем вытягивание ячейки 1 (ItemArray[1])
            var id = int.Parse(cbZnak.SelectedValue.ToString());
            txtGaraz.Text = ((DataRowView)_bindingAuto[_bindingAuto.Find("ID", id)])["Гаражный номер"].ToString();
            txtMarka.Text = ((DataRowView)_bindingAuto[_bindingAuto.Find("ID", id)])["Марка и модель"].ToString();
            lblToplivo1.Text = ((DataRowView) _bindingAuto[_bindingAuto.Find("ID", id)])["Вид топлива"].ToString();
            lblToplivo2.Text = ((DataRowView) _bindingAuto[_bindingAuto.Find("ID", id)])["Дополнительный вид топлива"].ToString();
        }

        private void cbImia_SelectedValueChanger(object sender, EventArgs e)           //  Комбобок cbImia  (Автомобиль)
        {
            ////Вытягивание из таблицы binding строку,затем преобразовываем в тип данных DataRowView,
            ////вытягивание из массива данных(Row) и затем вытягивание ячейки 1 (ItemArray[1])
            // Выбирает инициалы.т.е первую букву в фамилии и имени.
            txtTabelniiNomer.Text = ((DataRowView)_bindingVoditel[cbImia.SelectedIndex]).Row["табельный_номер"].ToString();
            txtKlass.Text = ((DataRowView)_bindingVoditel[cbImia.SelectedIndex]).Row["классность"].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var tablePutevoi = new AutoparkDBTableAdapters.TablePutevieGruzovieTableAdapter();
            var tableZadanie = new AutoparkDBTableAdapters.ZadanieVoditelTableAdapter();
            var tableZapravka = new AutoparkDBTableAdapters.ZapravkaTCMTableAdapter();
            if (_modeIsNew)
            {
                _idauto = int.Parse(cbZnak.SelectedValue.ToString());
                _idvod = int.Parse(cbImia.SelectedValue.ToString());
                _idotdel = int.Parse(cbOtdel.SelectedValue.ToString());
                PutevoiId = int.Parse(tablePutevoi.InsertQuery(int.Parse(txtNumber.Text), dtpHapka.Value.ToString(CultureInfo.CurrentCulture), int.Parse(txtViezdSpidometr.Text), int.Parse(txtVozvrahenieSpidometr.Text),
                    dtpPoGraphViezd.Value, dtpFactViezd.Value, dtpPoGraphVozvr.Value, dtpFactVozvr.Value,
                    int.Parse(txtNulevoiProbegViezd.Text), int.Parse(txtNulevoiProbegVozvrahenie.Text),
                    Convert.ToDouble(txtVremiaDvigViezd.Text), Convert.ToDouble(txtVremiaDvigVozvr.Text),
                    Convert.ToDouble(txtVremiaOborudViezd.Text), Convert.ToDouble(txtVremiaOborudVozvr.Text),
                    Convert.ToDouble(txtPriViezdiTCM.Text), Convert.ToDouble(txtPriVozvracheniiTCM.Text),
                    Convert.ToDouble(txtPriViezdiTCM2.Text), Convert.ToDouble(txtPriVozvracheniiTCM2.Text), _idvod,
                    _idauto, _idotdel).ToString());
                _bindingZadanie.DataSource = tableZadanie.GetDataByPutevoiId(PutevoiId);
                dgvZadanieVoditelu.DataSource = _bindingZadanie;
                _bindingZapravka.DataSource = tableZapravka.GetDataByPutevoiID(PutevoiId);
                dgvZapravkaTCM.DataSource = _bindingZapravka;

                var dataGridViewColumn = dgvZadanieVoditelu.Columns["ID_Путевого листа"];
                if (dataGridViewColumn != null)
                    dataGridViewColumn.Visible = false;
                dataGridViewColumn = dgvZadanieVoditelu.Columns["id"];
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
            else
            {
                _mainInfo = tablePutevoi.GetDataByID(PutevoiId).ToList();
                tablePutevoi.Update(int.Parse(txtNumber.Text), dtpHapka.Value, int.Parse(txtViezdSpidometr.Text),
                    int.Parse(txtVozvrahenieSpidometr.Text),
                    dtpPoGraphViezd.Value, dtpFactViezd.Value, dtpPoGraphVozvr.Value, dtpFactVozvr.Value,
                    int.Parse(txtNulevoiProbegViezd.Text), int.Parse(txtNulevoiProbegVozvrahenie.Text),
                    Convert.ToDouble(txtVremiaDvigViezd.Text), Convert.ToDouble(txtVremiaDvigVozvr),
                    Convert.ToDouble(txtVremiaOborudViezd.Text), Convert.ToDouble(txtVremiaOborudVozvr.Text),
                    Convert.ToDouble(txtPriViezdiTCM.Text), Convert.ToDouble(txtPriVozvracheniiTCM.Text),
                    Convert.ToDouble(txtPriViezdiTCM2.Text), Convert.ToDouble(txtPriVozvracheniiTCM2.Text), _idvod,
                    _idauto, _idotdel, PutevoiId,_mainInfo[0].Номер_путевого_листа,_mainInfo[0].Дата_путевого_листа,
                    _mainInfo[0].Показания_спидометра_при_выезде,
                    _mainInfo[0].Показания_спидометра_при_возвращении,
                    _mainInfo[0].Дата_Время_выезда_граф, _mainInfo[0].Дата_Время_выезда_факт,
                    _mainInfo[0].Дата_Время_возвращения_граф, _mainInfo[0].Дата_Время_возвращения_факт,
                    _mainInfo[0].Нулевой_пробег_выезд,
                    _mainInfo[0].Нулевой_пробег_возвр,
                    _mainInfo[0].Время_работы_двигателя_выезд,
                    _mainInfo[0].Время_работы_двигателя_возвр,
                    _mainInfo[0].Время_работы_спецоборудования_выезд,
                    _mainInfo[0].Время_работы_спецоборудования_возвр,
                    _mainInfo[0].Остаток_ТСМ1_выезд,
                    _mainInfo[0].Остаток_ТСМ1_возвр,
                    _mainInfo[0].Остаток_ТСМ2_выезд,
                    _mainInfo[0].Остаток_ТСМ2_возвр,
                    _mainInfo[0].ID_Водителя,
                    _mainInfo[0].ID_Автомобиля,
                    _mainInfo[0].ID_Отдела);

                _idauto = int.Parse(cbZnak.SelectedValue.ToString());
                _idvod = int.Parse(cbImia.SelectedValue.ToString());
                _idotdel = int.Parse(cbOtdel.SelectedValue.ToString());

                tableZadanie.Update((AutoparkDB.Задание_водителюDataTable)_bindingZadanie.DataSource);
                tableZapravka.Update((AutoparkDB.Заправка_ТСМDataTable) _bindingZapravka.DataSource);
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

        private void dgvZadanieVoditelu_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvZadanieVoditelu.CurrentRow != null)
                dgvZadanieVoditelu.CurrentRow.Cells["ID_Путевого листа"].Value = PutevoiId;
        }
    }
}
