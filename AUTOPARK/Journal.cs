using System;
using System.Windows.Forms;

namespace AUTOPARK
{
    public partial class Journal : Form
    {
        private readonly BindingSource _bindingAuto = new BindingSource();
        private readonly BindingSource _bindingVoditel = new BindingSource();
        private readonly BindingSource _bindingDannie = new BindingSource();
        
        public Journal()
        {
            InitializeComponent();
            //var tablep = new AutoparkDBTableAdapters.BannerJornalGruzovieTableAdapter();
            //_bindingAuto.DataSource = tablep.GetData();

            cbZnak.DataSource = _bindingAuto;
            cbZnak.DisplayMember = "Гос_номер";
            cbZnak.ValueMember = "ID";

            cbShofer.DataSource = _bindingVoditel;
            cbShofer.DisplayMember = "ФИО";
            cbShofer.ValueMember = "ID";
        }
     
        private void btnCancel_Click(object sender, EventArgs e)   // Кнопка Отмена 
        {
            Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

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

        private void Journal_Load(object sender, EventArgs e)
        {

        }

        
    }
}
