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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoparkDB.View_Данные_путевой_лист_легкового_авто". При необходимости она может быть перемещена или удалена.
            this.View_Данные_путевой_лист_легкового_автоTableAdapter.Fill(this.autoparkDB.View_Данные_путевой_лист_легкового_авто);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoparkDB.Данные_Путевой_лист_легкового_авто". При необходимости она может быть перемещена или удалена.
            this.putListLegkovogoDannieTableAdapter.Fill(this.autoparkDB.Данные_Путевой_лист_легкового_авто);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
