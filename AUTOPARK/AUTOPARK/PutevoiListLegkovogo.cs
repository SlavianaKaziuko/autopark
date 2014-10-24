using System;
using System.Collections.Generic;
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
        private string _number;
        private int _idauto;
        private int _idvod;
        private DateTime _dateStart;
        private DateTime _dateEnd;
        private readonly bool _modeIsNew; ////true - add, false - update
        private int PutevoiId { get; set; }

        public PutListLegkovogoavto()
        {
            InitializeComponent();
            _modeIsNew = true;
            var tablep = new AutoparkDBTableAdapters.PodvijnoiTableAdapter();   
            _bindingAuto.DataSource = tablep.GetDataByType("Л");                
            cbNomerAuto.DataSource = _bindingAuto;                              
            cbNomerAuto.DisplayMember = "Гос_номер";                            
            cbNomerAuto.ValueMember = "ID";                                     

            var tablel = new AutoparkDBTableAdapters.LichniiTableAdapter();    
            _bindingVoditel.DataSource = tablel.GetData();                            
            cbVodUdostoverenie.DataSource = _bindingVoditel;
            cbVodUdostoverenie.DisplayMember = "ФИО";
            cbVodUdostoverenie.ValueMember = "табельный_номер";
            var tablePutevoi = new AutoparkDBTableAdapters.PutevieLegkovieTableAdapter();
            var newLegkNumber = tablePutevoi.GetNewLegkNumber();
            if (newLegkNumber != null)
                txtNumber.Text = newLegkNumber.Value.ToString(CultureInfo.InvariantCulture);
        }

        public PutListLegkovogoavto(int id)
        {
            InitializeComponent();
            _modeIsNew = false;
            PutevoiId = id;
            var tablep = new AutoparkDBTableAdapters.PodvijnoiTableAdapter();
            _bindingAuto.DataSource = tablep.GetDataByType("Л");
            cbNomerAuto.DataSource = _bindingAuto;
            cbNomerAuto.DisplayMember = "Гос_номер";
            cbNomerAuto.ValueMember = "ID";

            var tablel = new AutoparkDBTableAdapters.LichniiTableAdapter();
            _bindingVoditel.DataSource = tablel.GetData();
            cbVodUdostoverenie.DataSource = _bindingVoditel;
            cbVodUdostoverenie.DisplayMember = "ФИО";
            cbVodUdostoverenie.ValueMember = "табельный_номер";

            var table = new AutoparkDBTableAdapters.PutListLegkovogoDannieTableAdapter();
            _bindingDannie.DataSource = table.GetDataWithCalculating(PutevoiId);
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
            _dateStart = res[0].За_период_с;
            _dateEnd = res[0].За_период_по;
            txtNumber.Text = _number;
            cbNomerAuto.SelectedItem = _bindingAuto[_bindingAuto.Find("ID", _idauto)];
            cbVodUdostoverenie.SelectedItem = _bindingVoditel[_bindingVoditel.Find("табельный_номер", _idvod)];
            dtpStart.Value = _dateStart;
            dtpEnd.Value = _dateEnd;
        }


        private void PutListLegkovogoavto_Load(object sender, EventArgs e)
        {
            txtNumber.Text = _number;
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
            txtVoditel.Text = ((DataRowView)_bindingVoditel[cbVodUdostoverenie.SelectedIndex]).Row.ItemArray[2].ToString();
            txtKlassnost.Text = ((DataRowView)_bindingVoditel[cbVodUdostoverenie.SelectedIndex]).Row.ItemArray[3].ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)      // Кнопка Сохранить
        {
            var tablePutevoi = new AutoparkDBTableAdapters.PutevoiListLegkTableAdapter();
            var tableDannie = new AutoparkDBTableAdapters.PutListLegkovogoDannieTableAdapter();
            if (_modeIsNew)
            {
                PutevoiId = tablePutevoi.Insert(txtNumber.Text, dtpStart.Value, dtpEnd.Value,
                    int.Parse(((DataRowView) _bindingAuto[cbNomerAuto.SelectedIndex]).Row.ItemArray[0].ToString()),
                    int.Parse(
                        ((DataRowView) _bindingVoditel[cbVodUdostoverenie.SelectedIndex]).Row.ItemArray[0].ToString()));
                _bindingDannie.DataSource = tableDannie.GetDataWithCalculating(PutevoiId);
                dgvPutevieLegkovie.DataSource = _bindingDannie;
                var dataGridViewColumn = dgvPutevieLegkovie.Columns["ID_Путевого листа"];
                if (dataGridViewColumn != null)
                    dataGridViewColumn.Visible = false;
            }
            else
            {
                tablePutevoi.Update(txtNumber.Text, dtpStart.Value, dtpEnd.Value,
                    int.Parse(((DataRowView) _bindingAuto[cbNomerAuto.SelectedIndex]).Row.ItemArray[0].ToString()),
                    int.Parse(
                        ((DataRowView) _bindingVoditel[cbVodUdostoverenie.SelectedIndex]).Row.ItemArray[0].ToString()),
                    PutevoiId, _number, _dateStart, _dateEnd, _idauto, _idvod);
                
                tableDannie.Update((AutoparkDB.Данные_Путевой_лист_легкового_автоDataTable) _bindingDannie.DataSource);
                _bindingDannie.DataSource = tableDannie.GetDataWithCalculating(PutevoiId);
                dgvPutevieLegkovie.DataSource = _bindingDannie;
            }
            btnCancel.Visible = false;
        }

        private void dgvPutevieLegkovie_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgvPutevieLegkovie.CurrentRow == null) return;
            dgvPutevieLegkovie.CurrentRow.Cells["ID_Путевого листа"].Value = PutevoiId;
            dgvPutevieLegkovie.CurrentRow.Cells["Время выезда"].Value = new TimeSpan(0, 0, 0);
            dgvPutevieLegkovie.CurrentRow.Cells["Время возвращения"].Value = new TimeSpan(0, 0, 0);
            dgvPutevieLegkovie.CurrentRow.Cells["Время в наряде"].Value = new TimeSpan(0, 0, 0);
            if (dgvPutevieLegkovie.RowCount > 1)
            {
                dgvPutevieLegkovie.CurrentRow.Cells["Показания спидометра при выезде"].Value =
                    dgvPutevieLegkovie.Rows[dgvPutevieLegkovie.CurrentRow.Index].Cells[
                        "Показания спидометра при возвращении"].Value;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)        // Кнопка Отмена 
        {
            Close();
        }

        private void lblLiatLegkovogoavto_Resize(object sender, EventArgs e)
        {
            dgvPutevieLegkovie.Width = this.Width - 40;   //как растянут датагридвью в ширину и высоту
            dgvPutevieLegkovie.Height = this.Height - 100 - dgvPutevieLegkovie.Location.Y;

            btnSave.Location = new Point(this.Width - 219, this.Height - 73);       //как растянуты кнопки Сохранить и Отмена когда открывается полностью окно
            btnCancel.Location = new Point(this.Width - 103, this.Height - 73);
                    btnReport.Location = new Point(this.Width - 320, this.Height - 73);
}

        private void btnReport_Click_1(object sender, EventArgs e)      // кнопка Отчет
        {
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
