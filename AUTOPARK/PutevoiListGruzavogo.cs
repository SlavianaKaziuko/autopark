using System;
using System.Windows.Forms;

namespace AUTOPARK
{
    public partial class PutevoiListGruzavogo : Form
    {
        public PutevoiListGruzavogo()
        {
            InitializeComponent();
        }

        public PutevoiListGruzavogo(int id)
        {
            InitializeComponent();
        }

        private void PutevoiListGruzavogo_Load(object sender, EventArgs e)
        {
        }

        private void txtMarka_TextChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void lblKolichestvo_Click(object sender, EventArgs e)
        {
        }

        private void lblPriVozvrachenii_Click(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            var f1 = new OtchetGruzavogo();
            f1.Show();
        }

        private void exitPic_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);  //Полный выход из программы если нажимаем на картинку с дверкой в Путевых листах грузового авто
        }

        private void llblMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new Menu(); ////создание экземпляра формы PutevieListi
            this.Hide(); //// скрытие текущей формы
            form.ShowDialog(); //// открытие формы PutevieListi
            this.Close(); //// закрытие текущей формы
        }
    }
}
