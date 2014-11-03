﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AUTOPARK
{
    public partial class OtchetLegkovogo : Form
    {
        private readonly BindingSource _bindingHead = new BindingSource();
        private readonly BindingSource _bindingDannie = new BindingSource();
        private int PutevoiId { get; set; }

        public OtchetLegkovogo(int id)
        {
            InitializeComponent();
             PutevoiId = id;

            var table = new AutoparkDBTableAdapters.PutListLegkovogoDannieTableAdapter();
            _bindingDannie.DataSource = table.GetDataWithCalculating(PutevoiId);

            var tablePutevoi = new AutoparkDBTableAdapters.PutevoiListLegkTableAdapter();
            var res = tablePutevoi.GetDataByID(id).ToList();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoparkDB.View_Данные_путевой_лист_легкового_авто". При необходимости она может быть перемещена или удалена.
            this.putListLegkovogoDannieTableAdapter.FillWithCalculating(this.autoparkDB.Данные_Путевой_лист_легкового_авто, PutevoiId);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoparkDB.View_Данные_путевой_лист_легкового_авто". При необходимости она может быть перемещена или удалена.
            this.reportViewer1.RefreshReport();
            

        }

    }
}
