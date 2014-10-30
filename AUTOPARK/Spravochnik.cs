using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
                    var table = new AutoparkDBTableAdapters.LichniiTableAdapter();
                    _binding.DataSource = table.GetData();
                    break;
                }

                case "Подвижной состав":
                {
                    var table = new AutoparkDBTableAdapters.PodvijnoiTableAdapter();
                    _binding.DataSource = table.GetData();            
                    break;
                }

                case "Нормы расхода ГСМ":
                {
                    var table = new AutoparkDBTableAdapters.NormyTableAdapter();
                    _binding.DataSource = table.GetData();
                    break;
                }
            }

            dgvSpravochnik.DataSource = _binding;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            switch (_name)
            {
                case "Личный состав":
                {
                    var table = new AutoparkDBTableAdapters.LichniiTableAdapter();// сохраняет все изменения в Личном составе
                    table.Update((AutoparkDB.Личный_составDataTable)_binding.DataSource);
                    break;
                }

                case "Подвижной состав":
                {
                    var table = new AutoparkDBTableAdapters.PodvijnoiTableAdapter(); // сохраняет все изменения в Подвижном составе 
                    table.Update((AutoparkDB.Подвижной_составDataTable)_binding.DataSource);
                    break;
                }

                case "Нормы расхода ГСМ":
                {
                    var table = new AutoparkDBTableAdapters.NormyTableAdapter();  // сохраняет все изменения в Нормы расхода ГСМ
                    table.Update((AutoparkDB._Нормы_расхода_ГСМ_на_авто_тракторыDataTable)_binding.DataSource);
                    break;
                }
            }
        }

        private void Spravochnik_Resize(object sender, EventArgs e)
        {
            dgvSpravochnik.Width = this.Width - 40;
            dgvSpravochnik.Height = this.Height - 100;
            btnSaveChanges.Location = new Point(this.Width - 170, this.Height - 75);
        }

        private void dgvSpravochnik_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(@"Введите корректные данные!"); ////если введены не верные параметры выбивает ошибку Введите корректные данные!
        }
    }
}
