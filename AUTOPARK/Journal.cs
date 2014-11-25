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
    public partial class Journal : Form
    {
        public Journal()
        {
            InitializeComponent();
        }

        private void cbZnak_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Journal_Load(object sender, EventArgs e)
        {



            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void btnCancel_Click(object sender, EventArgs e)   // Кнопка Отмена 
        {
            Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }

        
    }
}
