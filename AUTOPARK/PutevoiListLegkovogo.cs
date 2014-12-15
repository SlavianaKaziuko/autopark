﻿using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace AUTOPARK
{
    public partial class PutListLegkovogoavto : Form
    {
        private readonly BindingSource _bindingAuto = new BindingSource();
        private readonly BindingSource _bindingVoditel = new BindingSource();
        private readonly BindingSource _bindingDannie = new BindingSource();
        private readonly BindingSource _bindingOtdel = new BindingSource();
        private int _number;
        private int _idotd;
        private int _idauto;
        private int _idvod;
        private DateTime _dateStart;
        private DateTime _dateEnd;
        private readonly bool _modeIsNew; ////true - add, false - update
        private int PutevoiId { get; set; }

        public PutListLegkovogoavto()
        {
            InitializeComponent();

            var tablep = new AutoparkDBTableAdapters.PodvijnoiTableAdapter();   
            _bindingAuto.DataSource = tablep.GetDataByType("Л");
            if (_bindingAuto.Count == 0)
            {
                throw new Exception("Пожалуйста, заполните справочник \"Подвижной состав\"");
            }
            cbNomerAuto.DataSource = _bindingAuto;                              
            cbNomerAuto.DisplayMember = "Гос_номер";                            
            cbNomerAuto.ValueMember = "ID";                                     

            var tablel = new AutoparkDBTableAdapters.LichniiTableAdapter();
            _bindingVoditel.DataSource = tablel.GetDataSpisokVoditeli();
            if (_bindingVoditel.Count == 0)
            {
                throw new Exception("Пожалуйста, заполните справочник \"Личный состав\"");
            }
            cbVodUdostoverenie.DataSource = _bindingVoditel;
            cbVodUdostoverenie.DisplayMember = "ФИО";
            cbVodUdostoverenie.ValueMember = "табельный_номер";
            var tablePutevoi = new AutoparkDBTableAdapters.PutevoiListLegkTableAdapter();
            var newLegkNumber = tablePutevoi.GetNewLegkNumber();
            if (newLegkNumber != null)
                _number = int.Parse(newLegkNumber.ToString());
            var tableOtdeli = new AutoparkDBTableAdapters.OtdelTableAdapter();
            _bindingOtdel.DataSource = tableOtdeli.GetData();
            cbOtdel.DataSource = _bindingOtdel;
            cbOtdel.DisplayMember = "Название отдела";
            cbOtdel.ValueMember = "ID";
            _dateStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);             //календарь 
            _dateEnd = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);
        }

        public PutListLegkovogoavto(int id)
        {
            InitializeComponent();
           
            _modeIsNew = false;
            PutevoiId = id;
            var tablep = new AutoparkDBTableAdapters.PodvijnoiTableAdapter();
            _bindingAuto.DataSource = tablep.GetDataByType("Л");
            if (_bindingAuto.Count == 0)
            {
                throw new Exception("Пожалуйста, заполните справочник \"Подвижной состав\"");
            }
            cbNomerAuto.DataSource = _bindingAuto;
            cbNomerAuto.DisplayMember = "Гос_номер";
            cbNomerAuto.ValueMember = "ID";

            var tablel = new AutoparkDBTableAdapters.LichniiTableAdapter();
            _bindingVoditel.DataSource = tablel.GetDataSpisokVoditeli();
            if (_bindingVoditel.Count == 0)
            {
                throw new Exception("Пожалуйста, заполните справочник \"Личный состав\"");
            } 
            cbVodUdostoverenie.DataSource = _bindingVoditel;
            cbVodUdostoverenie.DisplayMember = "ФИО";
            cbVodUdostoverenie.ValueMember = "табельный_номер";

            var tableOtdeli = new AutoparkDBTableAdapters.OtdelTableAdapter();
            _bindingOtdel.DataSource = tableOtdeli.GetData();
            cbOtdel.DataSource = _bindingOtdel;
            cbOtdel.DisplayMember = "Название отдела";
            cbOtdel.ValueMember = "ID";

            var tableDannie = new AutoparkDBTableAdapters.PutListLegkovogoDannieTableAdapter();
            _bindingDannie.DataSource = tableDannie.GetData();
            _bindingDannie.Filter = "[ID_Путевого листа] = " + PutevoiId;
            dgvPutevieLegkovie.DataSource = _bindingDannie;
            
            var dataGridViewColumn = dgvPutevieLegkovie.Columns["ID_Путевого листа"];
            if (dataGridViewColumn != null)
                dataGridViewColumn.Visible = false;
            dataGridViewColumn = dgvPutevieLegkovie.Columns["id_Данных"];
            if (dataGridViewColumn != null)
                dataGridViewColumn.Visible = false;
            var tablePutevoi = new AutoparkDBTableAdapters.PutevoiListLegkTableAdapter();
            var res = tablePutevoi.GetDataByID(id).ToList();
            _number = res[0].Номер_путевого_листа;
            _idauto = res[0].ID_Автомобиль;
            _idvod = res[0].ID_Водитель;
            _idotd = res[0].ID_Отдела;
            _dateStart = res[0].За_период_с;
            _dateEnd = res[0].За_период_по;

            txtNumber.Text = _number.ToString(CultureInfo.InvariantCulture);
            cbNomerAuto.SelectedItem = _bindingAuto[_bindingAuto.Find("ID", _idauto)];
            cbVodUdostoverenie.SelectedItem = _bindingVoditel[_bindingVoditel.Find("табельный_номер", _idvod)];
            cbOtdel.SelectedItem = _idotd;
            dtpStart.Value = _dateStart;
            dtpEnd.Value = _dateEnd;
        }


        private void PutListLegkovogoavto_Load(object sender, EventArgs e)
        {
            if (_bindingAuto.Count == 0)
            {
                MessageBox.Show(@"Пожалуйста, заполните справочник ""Подвижной состав""");
                Close();
            }
            else if (_bindingVoditel.Count==0)
            {
                MessageBox.Show(@"Пожалуйста, заполните справочник ""Личный состав""");
                Close();
            }
            txtNumber.Text = _number.ToString(CultureInfo.InvariantCulture);
            cbNomerAuto.SelectedItem = _idauto;
            cbVodUdostoverenie.SelectedItem = _idvod;
            dtpStart.Value = _dateStart;
            dtpEnd.Value = _dateEnd;
            //var dataGridViewColumn = dgvPutevieLegkovie.Columns["Число"];
            //if (dataGridViewColumn != null)
            //    dataGridViewColumn.
        }

        private void cbNomerAuto_SelectedValueChanged(object sender, EventArgs e)               //  Комбобок cbNomerAuto  (Автомобиль)
        {
            ////Вытягивание из таблицы binding строку,затем преобразовываем в тип данных DataRowView,
            ////вытягивание из массива данных(Row) и затем вытягивание ячейки 1 (ItemArray[1])
            txtAvto.Text = ((DataRowView)_bindingAuto[cbNomerAuto.SelectedIndex]).Row.ItemArray[1].ToString();  
        }

        private void cbVodUdostoverenie_SelectedValueChanged(object sender, EventArgs e)           //  Комбобок cbVodUdostoverenie  (Водитель)
        {
            //Вытягивание из таблицы binding строку,затем преобразовываем в тип данных DataRowView,
            //вытягивание из массива данных(Row) и затем вытягивание ячейки 1 (ItemArray[2,3])
            txtVoditel.Text = ((DataRowView)_bindingVoditel[cbVodUdostoverenie.SelectedIndex]).Row.ItemArray[4].ToString();
            txtKlassnost.Text = ((DataRowView)_bindingVoditel[cbVodUdostoverenie.SelectedIndex]).Row.ItemArray[5].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)      // Кнопка Сохранить
        {
            var tablePutevoi = new AutoparkDBTableAdapters.PutevoiListLegkTableAdapter();
            var tableDannie = new AutoparkDBTableAdapters.PutListLegkovogoDannieTableAdapter();
            if (_modeIsNew)
            {
                PutevoiId = tablePutevoi.Insert(int.Parse(txtNumber.Text), dtpStart.Value, dtpEnd.Value,
                    int.Parse(((DataRowView) _bindingAuto[cbNomerAuto.SelectedIndex]).Row.ItemArray[0].ToString()),
                    int.Parse(((DataRowView) _bindingVoditel[cbVodUdostoverenie.SelectedIndex]).Row.ItemArray[0].ToString()),
                    int.Parse(((DataRowView)_bindingOtdel[cbOtdel.SelectedIndex]).Row.ItemArray[0].ToString()));
                _bindingDannie.DataSource = tableDannie.GetData();
                _bindingDannie.Filter = "[ID_Путевого листа] = " + PutevoiId;
                dgvPutevieLegkovie.DataSource = _bindingDannie;
                var dataGridViewColumn = dgvPutevieLegkovie.Columns["ID_Путевого листа"];
                if (dataGridViewColumn != null)
                    dataGridViewColumn.Visible = false;
            }
            else
            {
                tablePutevoi.Update(int.Parse(txtNumber.Text), dtpStart.Value, dtpEnd.Value,
                    int.Parse(((DataRowView) _bindingAuto[cbNomerAuto.SelectedIndex]).Row.ItemArray[0].ToString()),
                    int.Parse(((DataRowView) _bindingVoditel[cbVodUdostoverenie.SelectedIndex]).Row.ItemArray[0].ToString()),
                    int.Parse(((DataRowView) _bindingOtdel[cbOtdel.SelectedIndex]).Row.ItemArray[0].ToString()),
                    PutevoiId, _number, _dateStart, _dateEnd, _idauto, _idvod,_idotd);
                
                tableDannie.Update((AutoparkDB.Данные_Путевой_лист_легкового_автоDataTable) _bindingDannie.DataSource);
                _bindingDannie.DataSource = tableDannie.GetData();
                _bindingDannie.Filter = "[ID_Путевого листа] = " + PutevoiId;
                dgvPutevieLegkovie.DataSource = _bindingDannie;
                _number = int.Parse(txtNumber.Text);
                _idauto = int.Parse(((DataRowView)_bindingAuto[cbNomerAuto.SelectedIndex]).Row.ItemArray[0].ToString());
                _idvod = int.Parse(((DataRowView)_bindingVoditel[cbVodUdostoverenie.SelectedIndex]).Row.ItemArray[0].ToString());
                _idotd = int.Parse(((DataRowView)_bindingOtdel[cbOtdel.SelectedIndex]).Row.ItemArray[0].ToString());
                _dateStart = dtpStart.Value;
                _dateEnd = dtpEnd.Value;
            }
            btnCancel.Visible = false;
        }

        private void dgvPutevieLegkovie_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgvPutevieLegkovie.CurrentRow == null) return;
//            if (dgvPutevieLegkovie.CurrentRow.Index==0 && _bindingDannie.Count!=0) return;
            if (!dgvPutevieLegkovie.IsCurrentCellInEditMode) return;
            dgvPutevieLegkovie.CurrentRow.Cells["ID_Путевого листа"].Value = PutevoiId;
            dgvPutevieLegkovie.CurrentRow.Cells["Время выезда"].Value = new TimeSpan(8, 15, 0);
            dgvPutevieLegkovie.CurrentRow.Cells["Время возвращения"].Value = new TimeSpan(17, 0, 0);
            dgvPutevieLegkovie.CurrentRow.Cells["Время в наряде"].Value = new TimeSpan(8, 45, 0);
            var queriesResult = new AutoparkDBTableAdapters.QueriesTableAdapter();
            dgvPutevieLegkovie.CurrentRow.Cells["Показания спидометра при выезде"].Value =
                queriesResult.GetMileageLegk(_idauto, _dateEnd);
        }

        private void btnCancel_Click(object sender, EventArgs e)        // Кнопка Отмена 
        {
            Close();
        }

        private void lblLiatLegkovogoavto_Resize(object sender, EventArgs e)
        {
            dgvPutevieLegkovie.Width = this.Width - 40; //как растянут датагридвью в ширину и высоту
            dgvPutevieLegkovie.Height = this.Height - 100 - dgvPutevieLegkovie.Location.Y;

            btnSave.Location = new Point(this.Width - 219, this.Height - 73);
                //как растянуты кнопки Сохранить и Отмена когда открывается полностью окно
            btnCancel.Location = new Point(this.Width - 103, this.Height - 73);
            btnReport.Location = new Point(this.Width - 320, this.Height - 73);
        }

        private void btnReport_Click_1(object sender, EventArgs e)      // кнопка Отчет
        {
            var f1 = new OtchetLegkovogo(PutevoiId);
            f1.Show();
        }

        private void tsmiToMenu_Click(object sender, EventArgs e)
        {
            var form = new Menu(); ////создание экземпляра формы PutevieListi
            Hide(); //// скрытие текущей формы
            form.ShowDialog(); //// открытие формы PutevieListi
            Close(); //// закрытие текущей формы
        }

        private void tsmiExitApplication_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);  //Полный выход из программы если нажимаем на Навигацию далее Выйти из приложения
        }

        private void tsmiRefresh_Click(object sender, EventArgs e)
        {
            var tableDannie = new AutoparkDBTableAdapters.PutListLegkovogoDannieTableAdapter();
            _bindingDannie.DataSource = tableDannie.GetData();
            _bindingDannie.Filter = "[ID_Путевого листа] = " + PutevoiId;
            dgvPutevieLegkovie.DataSource = _bindingDannie;
        }

        private void dgvPutevieLegkovie_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            var res = MessageBox.Show(@"Отменить редактирование ячейки", "", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                dgvPutevieLegkovie.EndEdit();
            }
        }

        private void dgvPutevieLegkovie_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridViewCell = ((DataGridView) sender).CurrentCell;
            if (dataGridViewCell.OwningColumn.Name != "Показания спидометра при возвращении" || dataGridViewCell.OwningColumn.Name != "Показания спидометра при выезде") return;
            var dataGridViewRow = ((DataGridView)sender).CurrentRow;
            if (dataGridViewRow != null)
                dataGridViewRow.Cells["Пробег км"].Value =
                    int.Parse(
                        dataGridViewRow.Cells["Показания спидометра при возвращении"].EditedFormattedValue.ToString()) -
                    int.Parse(dataGridViewRow.Cells["Показания спидометра при выезде"].EditedFormattedValue.ToString());
        }

    }
}
