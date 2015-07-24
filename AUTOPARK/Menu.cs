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
    public partial class Menu : Form
    
    {
        public Menu()
        {
            InitializeComponent();
           // linkJurnal.Visible = false;
        }

        private void linkSpravochniki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new Spravochnik(((LinkLabel)sender).Text); ////создание экземпляра формы Spravochnik
            this.Hide(); //// скрытие текущей формы
            form.ShowDialog(); //// открытие формы Spravochnik
            this.Show(); //// отображение главной формы после закрытия Spravochnik
        }

        private void linkPutevieListi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new PutevieListi(((LinkLabel)sender).Text); ////создание экземпляра формы PutevieListi
            this.Hide(); //// скрытие текущей формы
            form.ShowDialog(); //// открытие формы PutevieListi
            this.Show(); //// отображение главной формы после закрытия PutevieListi
        }

        

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

       
    }
}
