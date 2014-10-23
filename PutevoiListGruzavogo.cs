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
            Form2 f1 = new Form2();
            f1.Show();
        }
    }
}
