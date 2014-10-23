using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace AUTOPARK
{
    public partial class PutevieListi : Form
    {
        private readonly string _name;
        private readonly BindingSource _binding = new BindingSource(); // Инициализирует новый экземпляр класса BindingSource значения свойств по умолчанию.

      
        public PutevieListi(string name)
        {
            InitializeComponent();
            _name = name;
            Text = _name;
            switch (_name)
            {
                case "Путевые листы легковых автомобилей":
                {
                        var table = new AutoparkDBTableAdapters.PutevieLegkovieTableAdapter();   //  Создание Путевых листов легкового авто
                    _binding.DataSource = table.GetData();
                    break;
                }
                case "Путевые листы грузовых автомобилей":
                {
                        var table = new AutoparkDBTableAdapters.PutevieGruzovieTableAdapter();   //   Создание Путевых листов грузового авто
                    _binding.DataSource = table.GetData();
                    break;
                }
            }

            dgvPutevii.DataSource = _binding;
        }

        private void dgvPutevii_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(@"Введите корректные данные!");//если введены не верные параметры выбивает ошибку Введите корректные данные!
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (_name)
            {
                case "Путевые листы легковых автомобилей":
                {
                    var form = new PutListLegkovogoavto(); ////PutListLegkovogoavto
                    this.Hide(); //// скрытие текущей формы
                    form.ShowDialog(); //// открытие формы Spravochnik
                    var table = new AutoparkDBTableAdapters.PutevieLegkovieTableAdapter();
                    _binding.DataSource = table.GetData();
                    this.Show(); //// отображение главной формы после закрытия PutListLegkovogoavto
                    break;
                }

                case "Путевые листы грузовых автомобилей":
                {
                    var form = new PutevoiListGruzavogo(); ////создание экземпляра формы PutevoiListGruzavogo
                    this.Hide(); //// скрытие текущей формы
                    form.ShowDialog(); //// открытие формы Spravochnik
                    var table = new AutoparkDBTableAdapters.PutevieGruzovieTableAdapter();
                    _binding.DataSource = table.GetData();
                    this.Show(); //// отображение главной формы после закрытия PutevoiListGruzavogo
                    break;
                }
            }
            dgvPutevii.DataSource = _binding;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPutevii.CurrentRow == null)
            {
                return;
            }

            var rowid = (int)dgvPutevii.CurrentRow.Cells[0].Value;
            switch (_name)
            {
                case "Путевые листы легковых автомобилей":
                {
                    var form = new PutListLegkovogoavto(rowid); ////PutListLegkovogoavto
                    this.Hide(); //// скрытие текущей формы
                    form.ShowDialog(); //// открытие формы Spravochnik
                    this.Show(); //// отображение главной формы после закрытия PutListLegkovogoavto
                    break;
                }

                case "Путевые листы грузовых автомобилей":
                {
                    var form = new PutevoiListGruzavogo(rowid); ////создание экземпляра формы PutevoiListGruzavogo
                    this.Hide(); //// скрытие текущей формы
                    form.ShowDialog(); //// открытие формы Spravochnik
                    this.Show(); //// отображение главной формы после закрытия PutevoiListGruzavogo
                    break;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPutevii.CurrentRow == null)
            {
                return;
            }

            var rowid = (int)dgvPutevii.CurrentRow.Cells[0].Value;
            var result = MessageBox.Show(string.Format("Вы точно хотите удалить путевой лист {0} легкового авто?", rowid), @"Предупреждение", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }

            switch (_name)
            {
                case "Путевые листы легковых автомобилей":
                {
                    var table = new AutoparkDBTableAdapters.TablePutevieLegkovieTableAdapter();
                    table.DeleteQueryById(rowid);
                    var tableData = new AutoparkDBTableAdapters.PutevieLegkovieTableAdapter();
                    _binding.DataSource = tableData.GetData();
                    break;
                }

                case "Путевые листы грузовых автомобилей":
                {
                    var table = new AutoparkDBTableAdapters.TablePutevieGruzovieTableAdapter();
                    table.DeleteQueryById(rowid);
                    var tableData = new AutoparkDBTableAdapters.PutevieGruzovieTableAdapter();
                    _binding.DataSource = tableData.GetData();
                    break;
                }
            }

            dgvPutevii.DataSource = _binding;
        }

        private void PutevieListi_Resize(object sender, EventArgs e)
        {
            dgvPutevii.Width = this.Width - 40;
            dgvPutevii.Height = this.Height - 100;

            btnAdd.Location = new Point(this.Width - 300, this.Height - 73);
            btnEdit.Location = new Point(this.Width - 214, this.Height - 73);
            btnDelete.Location = new Point(this.Width - 103, this.Height - 73);
        }
    }
}
