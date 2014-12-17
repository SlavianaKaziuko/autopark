﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AUTOPARK.AutoparkDBTableAdapters;

namespace AUTOPARK
{
    public partial class Spravochnik : Form
    {
        private readonly string _name;
        private readonly BindingSource _binding = new BindingSource();

        public Spravochnik(string name)
        {
            InitializeComponent();
            _name = name;
            Text += @" " + _name;
            switch (_name)
            {
                case "Личный состав":
                {
                    var table = new LichniiTableAdapter();
                    _binding.DataSource = table.GetData();
                    break;
                }
                case "Подвижной состав":
                {
                    var table = new PodvijnoiTableAdapter();
                    _binding.DataSource = table.GetData();
                    break;
                }
                case "Нормы расхода ГСМ":
                {
                    var table = new NormyTableAdapter();
                    _binding.DataSource = table.GetData();
                    break;
                }
                case "Отделы":
                {
                    var table = new OtdelTableAdapter();
                    _binding.DataSource = table.GetData();
                    break;
                }
            }

            dgvSpravochnik.DataSource = _binding;
            //var dataGridViewColumn = dgvSpravochnik.Columns["ФИО"];
            //if (dataGridViewColumn != null) dataGridViewColumn.Visible = false;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            switch (_name)
            {
                case "Личный состав":
                {
                    var table = new AutoparkDBTableAdapters.LichniiTableAdapter();
                    // сохраняет все изменения в Личном составе
                    table.Update((AutoparkDB.Личный_составDataTable) _binding.DataSource);
                    break;
                }

                case "Подвижной состав":
                {
                    var table = new AutoparkDBTableAdapters.PodvijnoiTableAdapter();
                    // сохраняет все изменения в Подвижном составе 
                    table.Update((AutoparkDB.Подвижной_составDataTable) _binding.DataSource);
                    break;
                }

                case "Нормы расхода ГСМ":
                {
                    var table = new AutoparkDBTableAdapters.NormyTableAdapter();
                    // сохраняет все изменения в Нормы расхода ГСМ
                    table.Update((AutoparkDB._Нормы_расхода_ГСМ_на_авто_тракторыDataTable) _binding.DataSource);
                    break;
                }

                case "Отделы":
                {
                    var table = new AutoparkDBTableAdapters.OtdelTableAdapter(); // сохраняет все изменения в Отделы
                    table.Update((AutoparkDB.ОтделыDataTable) _binding.DataSource);
                    break;
                }
            }
        }

        private void Spravochnik_Resize(object sender, EventArgs e)
            //        растягивание формы и кнопки сохранить по высоте и ширине
        {
            dgvSpravochnik.Width = this.Width - 40;
            dgvSpravochnik.Height = this.Height - 115;
            btnSaveChanges.Location = new Point(this.Width - 170, this.Height - 75);
        }

        private void dgvSpravochnik_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(@"Введите корректные данные!");
            ////если введены не верные параметры выбивает ошибку Введите корректные данные!
        }

        private void Spravochnik_Load(object sender, EventArgs e)
        {
            DataGridViewColumn dataGridViewColumn;
            switch (_name)
            {
                case "Личный состав":
                    break;
                case "Подвижной состав":
                    dataGridViewColumn = dgvSpravochnik.Columns["ID"];
                    if (dataGridViewColumn != null)
                        dataGridViewColumn.Visible = false;
                    dataGridViewColumn = dgvSpravochnik.Columns["Вид топлива"];
                    if (dataGridViewColumn != null)
                        dataGridViewColumn.Visible = false;
                    dataGridViewColumn = dgvSpravochnik.Columns["Дополнительный вид топлива"];
                    if (dataGridViewColumn != null)
                        dataGridViewColumn.Visible = false;
                    var gridViewColumn = dgvSpravochnik.Columns["Гос_номер"];
                    if (gridViewColumn != null)
                        gridViewColumn.DefaultCellStyle.Format = "[0-9]{4}[A-Z]{2}-[0-9]{1}";
                    var dc = new DataGridViewComboBoxColumn
                    {
                        DataSource = new List<string>
                        {
                            "АИ-92",
                            "Д/Т",
                            "СУГ"
                        },
                        AutoComplete = true,
                        Name = "Тип топлива",
                        DisplayIndex = 5
                    };
                    dgvSpravochnik.Columns.Add(dc);
                    var dcDop = new DataGridViewComboBoxColumn
                    {
                        DataSource = new List<string>
                        {
                            "АИ-92",
                            "Д/Т",
                            "СУГ"
                        },
                        AutoComplete = true,
                        Name = "Дополнительный тип топлива",
                        DisplayIndex = 6
                    };                    
                    dgvSpravochnik.Columns.Add(dcDop);
                    foreach (DataGridViewRow row in dgvSpravochnik.Rows)
                    {
                        row.Cells["Тип топлива"].Value = row.Cells["Вид топлива"].Value;
                        row.Cells["Дополнительный тип топлива"].Value = row.Cells["Дополнительный вид топлива"].Value;
                    }
                    break;
                case "Нормы расхода ГСМ":
                    dataGridViewColumn = dgvSpravochnik.Columns["ID"];
                    if (dataGridViewColumn != null)
                        dataGridViewColumn.Visible = false;
                    break;
                case "Отделы":
                    dataGridViewColumn = dgvSpravochnik.Columns["Код"];
                    if (dataGridViewColumn != null)
                        dataGridViewColumn.Visible = false;
                    break;
            }
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
            Environment.Exit(0);
            //Полный выход из программы если нажимаем Навигация далее Выйти из приложения в Справочниках
        }

        private void dgvSpravochnik_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            switch (_name)
            {
                case "Личный состав":
                {
                    if (dgvSpravochnik.CurrentCell.OwningColumn.Name != "классность") return;
                    var val = int.Parse(e.FormattedValue.ToString());
                    if (val == 1 || val == 2 || val == 3) return;
                    MessageBox.Show(@"Классность может принимать значения 1,2 или 3");
                    e.Cancel = true;
                    break;
                }
                case "Подвижной состав":
                {
                    switch (dgvSpravochnik.CurrentCell.OwningColumn.Name)
                    {
                        case "Тип назначения авто":
                        {
                            var val = e.FormattedValue.ToString();
                            if (val == "Л" || val == "Г") return;
                            MessageBox.Show(@"Тип назначения авто может либо легковой (Л), либо грузовой (Г)");
                            e.Cancel = true;
                            break;
                        }
                        case "Гос_номер":
                        {
                            var val = e.FormattedValue.ToString();
                            dgvSpravochnik.CurrentCell.Value = val.Replace(" ", "");
                            if (!Regex.IsMatch(val,
                                dgvSpravochnik.CurrentCell.OwningColumn.DefaultCellStyle.Format))
                            {
                                MessageBox.Show(
                                    @"Гос номер должен состветствовать формату 0000AA-0\n0 - цифры\nA - буквы номера латиницей");
                            e.Cancel = true;
                            }
                            break;
                        }
                        case "Тип топлива":
                        {
                            if (dgvSpravochnik.CurrentRow != null)
                                dgvSpravochnik.CurrentRow.Cells["Вид топлива"].Value = e.FormattedValue;
                            break;
                        }
                        case "Дополнительный тип топлива":
                        {
                            if (dgvSpravochnik.CurrentRow != null)
                                dgvSpravochnik.CurrentRow.Cells["Дополнительный вид топлива"].Value = e.FormattedValue;
                            break;
                        }
                    }
                    break;
                }
            }

        }
    }
}
