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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoparkDB.View_Заправка_ТСМ". При необходимости она может быть перемещена или удалена.
            this.view_Заправка_ТСМTableAdapter.Fill(this.autoparkDB.View_Заправка_ТСМ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoparkDB.View_Подвижной_состав". При необходимости она может быть перемещена или удалена.
            this.view_Подвижной_составTableAdapter.Fill(this.autoparkDB.View_Подвижной_состав);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoparkDB.View_Работа_водителя_и_авто". При необходимости она может быть перемещена или удалена.
            this.view_Работа_водителя_и_автоTableAdapter.Fill(this.autoparkDB.View_Работа_водителя_и_авто);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoparkDB.View_Движение__ТСМ". При необходимости она может быть перемещена или удалена.
            this.view_Движение__ТСМTableAdapter.Fill(this.autoparkDB.View_Движение__ТСМ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoparkDB.View_Личный_состав". При необходимости она может быть перемещена или удалена.
            this.view_Личный_составTableAdapter.Fill(this.autoparkDB.View_Личный_состав);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoparkDB.View_Задание_водителю1". При необходимости она может быть перемещена или удалена.
            this.view_Задание_водителю1TableAdapter.Fill(this.autoparkDB.View_Задание_водителю1);

            this.reportViewer1.RefreshReport();
        }
    }
}
