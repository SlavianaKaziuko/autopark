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
        private readonly BindingSource _bindingAuto = new BindingSource();
        private readonly BindingSource _bindingVoditel = new BindingSource();
        private readonly BindingSource _bindingDannie = new BindingSource();
        private readonly int _number;
        private readonly int _idauto;
        private readonly int _idvod;
       
        
        public Journal()
        {
            InitializeComponent();
            var tablep = new AutoparkDBTableAdapters.BannerJornalGruzovieTableAdapter();
            _bindingAuto.DataSource = tablep.GetData();

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

        
    }
}
