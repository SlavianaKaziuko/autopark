using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AUTOPARK
{
    public partial class PutevieListi : Form
    {
        private readonly string _name;
        private readonly BindingSource _binding = new BindingSource(); // Инициализирует новый экземпляр класса BindingSource значения свойств по умолчанию.
        private readonly BindingSource _bindingAuto = new BindingSource();

      
        public PutevieListi(string name)
        {
            InitializeComponent();
            _name = name;
            Text = _name;
            var tableAuto = new AutoparkDBTableAdapters.PodvijnoiTableAdapter();  
            switch (_name)
            { 
                case "Путевые листы легковых автомобилей":
                {
                    var table = new AutoparkDBTableAdapters.PutevieLegkovieTableAdapter();   //  Создание Путевых листов легкового авто
                    _binding.DataSource = table.GetData();
                    _bindingAuto.DataSource = tableAuto.GetDataByType("Л");
                    break;
                }
                case "Путевые листы грузовых автомобилей":
                {
                    var table = new AutoparkDBTableAdapters.PutevieGruzovieTableAdapter();   //   Создание Путевых листов грузового авто
                    _binding.DataSource = table.GetData();
                    _bindingAuto.DataSource = tableAuto.GetDataByType("Г"); 
                    break;
                }
                case "Журнал учета выдачи путевых листов":
                {
                    //var table = new AutoparkDBTableAdapters.BannerJornalGruzovieTableAdapter();   //   Создание Журнала!!!
                    //_binding.DataSource = table.GetData();
                    break;
                }
            }

            dgvPutevii.DataSource = _binding;

            var dataGridViewColumn = dgvPutevii.Columns["ID_Путевого листа"];
            if (dataGridViewColumn != null)
                dataGridViewColumn.Visible = false;
            if (_name != "Путевые листы легковых автомобилей") return;
            dataGridViewColumn = dgvPutevii.Columns["ID_Автомобиль"];
            if (dataGridViewColumn != null)
                dataGridViewColumn.Visible = false;
            dataGridViewColumn = dgvPutevii.Columns["ID_Водитель"];
            if (dataGridViewColumn != null)
                dataGridViewColumn.Visible = false;
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
                        try
                        {
                            Form form = new PutListLegkovogoavto();
                            form.ShowDialog(); //// открытие формы Spravochnik
                            this.Hide(); //// скрытие текущей формы
                            var table = new AutoparkDBTableAdapters.PutevieLegkovieTableAdapter();
                            _binding.DataSource = table.GetData();
                            this.Show(); //// отображение главной формы после закрытия PutListLegkovogoavto
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show(exc.Message);
                        }
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
                case "Журнал учета выдачи путевых листов":
                {
                    var form = new Journal (); ////создание экземпляра формы Журнала  !!!!!!!!!!!!!!
                    this.Hide(); //// скрытие текущей формы
                    form.ShowDialog(); //// открытие формы Spravochnik
                    //var table = new AutoparkDBTableAdapters.BannerJornalGruzovieTableAdapter();
                    //_binding.DataSource = table.GetData();
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
               /* case "Журнал учета выдачи путевых листов":   //  !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                {
                    var form = new Journal(rowid); ////создание экземпляра формы Journal
                    this.Hide(); //// скрытие текущей формы
                    form.ShowDialog(); //// открытие формы Spravochnik
                    this.Show(); //// отображение главной формы после закрытия Journal
                    break;
                }*/
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPutevii.CurrentRow == null)
            {
                return;
            }

            var rowid = (int)dgvPutevii.CurrentRow.Cells[0].Value;
            var result = MessageBox.Show(string.Format("Вы точно хотите удалить путевой лист {0}  авто?", rowid), @"Предупреждение", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }

            switch (_name)
            {
                case "Путевые листы легковых автомобилей":
                {
                    var table = new AutoparkDBTableAdapters.PutevoiListLegkTableAdapter();
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
               /* case "Журнал учета выдачи путевых листов":    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                {
                    var table = new AutoparkDBTableAdapters.TablePutevieGruzovieTableAdapter();
                    table.DeleteQueryById(rowid);
                    var tableData = new AutoparkDBTableAdapters.PutevieGruzovieTableAdapter();
                    _binding.DataSource = tableData.GetData();
                    break;
                }*/
            }

            dgvPutevii.DataSource = _binding;
        }

        private void PutevieListi_Resize(object sender, EventArgs e)
        {
            dgvPutevii.Width = this.Width - 40;
            dgvPutevii.Height = this.Height - dgvPutevii.Location.Y - 100;

            btnDelete.Location = new Point(this.Width - btnDelete.Width - 25, this.Height - 73);
            btnEdit.Location = new Point(btnDelete.Location.X - btnEdit.Width - 5, this.Height - 73);
            btnAdd.Location = new Point(btnEdit.Location.X - btnAdd.Width - 5, this.Height - 73);
            btnOtchet.Location = new Point(btnAdd.Location.X - btnOtchet.Width - 5, this.Height - 73);
            btnPrilogenieC.Location = new Point(btnAdd.Location.X - btnOtchet.Width - 222, this.Height - 73);
            btnPrilogenieL.Location = new Point(btnAdd.Location.X - btnOtchet.Width - 116, this.Height - 73);
            
        }

        private void tsmiToMenu_Click(object sender, EventArgs e)
        {
            var form = new Menu(); ////создание экземпляра формы PutevieListi
            this.Hide(); //// скрытие текущей формы
            form.ShowDialog(); //// открытие формы PutevieListi
            this.Close(); //// закрытие текущей формы
        }

        private void PutevieListi_Load(object sender, EventArgs e)
        {
            dtpStart.Value = dtpEnd.Value.AddYears(-1);
            cbAuto.DisplayMember = "Гос_номер";
            cbAuto.ValueMember = "ID";
            cbAuto.DataSource = _bindingAuto;
        }

        private void tsmiExitApplication_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);  //Полный выход из программы если нажимаем на дверку в Путевых листах легкового авто
        }

       
        
        private void cbAuto_SelectedValueChanged(object sender, EventArgs e)
        {
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

          private void btnOtchet_Click(object sender, EventArgs e)
           {
               switch (_name)
               {
                   case "Путевые листы легковых автомобилей":
                       {
                           var f1 = new OtchetJournal(dtpStart.Value, dtpEnd.Value, int.Parse(cbAuto.SelectedValue.ToString()), 'Л');
                           f1.Show();
                           break;
                       }
                   case "Путевые листы грузовых автомобилей":
                       {
                           var f1 = new OtchetJournal(dtpStart.Value, dtpEnd.Value, int.Parse(cbAuto.SelectedValue.ToString()), 'Г');
                           f1.Show();
                           break;
                       }
               }
           }

        private void btnPrilogenieL_Click(object sender, EventArgs e)
          {
              switch (_name)
              {
                  case "Путевые листы легковых автомобилей":
                      {
                          var f1 = new PrilogenieL(dtpStart.Value, dtpEnd.Value, int.Parse(cbAuto.SelectedValue.ToString()), 'Л');
                          f1.Show();
                          break;
                      }
                  case "Путевые листы грузовых автомобилей":
                      {
                          var f1 = new PrilogenieL(dtpStart.Value, dtpEnd.Value, int.Parse(cbAuto.SelectedValue.ToString()), 'Г');
                          f1.Show();
                          break;
                      }
              }

          }


       private void btnPrilogenieC_Click(object sender, EventArgs e)
        {
            switch (_name)
            {
                case "Путевые листы легковых автомобилей":
                    {
                        var f1 = new PrilogenieC(dtpStart.Value, dtpEnd.Value, int.Parse(cbAuto.SelectedValue.ToString()), 'Л');
                        f1.Show();
                        break;
                    }
                case "Путевые листы грузовых автомобилей":
                    {
                        var f1 = new PrilogenieC(dtpStart.Value, dtpEnd.Value, int.Parse(cbAuto.SelectedValue.ToString()), 'Г');
                        f1.Show();
                        break;
                   }
            }

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            switch (_name)
            {
                case "Путевые листы легковых автомобилей":
                    {
                        _binding.Filter = "[ID_Автомобиль] = " + int.Parse(cbAuto.SelectedValue.ToString());
                        break;
                    }
                case "Путевые листы грузовых автомобилей":
                    {

                        _binding.Filter = "[Гос_номер] = '" + cbAuto.Text + "'";
                        break;
                    }
            }
        }

       

        

       

       

          
       
    }
}
