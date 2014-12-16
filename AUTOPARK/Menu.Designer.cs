namespace AUTOPARK
{
    partial class Menu
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.linklichnii = new System.Windows.Forms.LinkLabel();
            this.Spravochniki = new System.Windows.Forms.GroupBox();
            this.lblVoditeliAuto = new System.Windows.Forms.LinkLabel();
            this.lblOtdel = new System.Windows.Forms.LinkLabel();
            this.linkNormy = new System.Windows.Forms.LinkLabel();
            this.linkPodvijnoi = new System.Windows.Forms.LinkLabel();
            this.groupListi = new System.Windows.Forms.GroupBox();
            this.linkJurnal = new System.Windows.Forms.LinkLabel();
            this.linkGruzovoi = new System.Windows.Forms.LinkLabel();
            this.linkLegkovoi = new System.Windows.Forms.LinkLabel();
            this.Spravochniki.SuspendLayout();
            this.groupListi.SuspendLayout();
            this.SuspendLayout();
            // 
            // linklichnii
            // 
            this.linklichnii.AutoSize = true;
            this.linklichnii.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linklichnii.LinkColor = System.Drawing.Color.Navy;
            this.linklichnii.Location = new System.Drawing.Point(6, 28);
            this.linklichnii.Name = "linklichnii";
            this.linklichnii.Size = new System.Drawing.Size(124, 20);
            this.linklichnii.TabIndex = 0;
            this.linklichnii.TabStop = true;
            this.linklichnii.Text = "Личный состав";
            this.linklichnii.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSpravochniki_LinkClicked);
            // 
            // Spravochniki
            // 
            this.Spravochniki.Controls.Add(this.lblVoditeliAuto);
            this.Spravochniki.Controls.Add(this.lblOtdel);
            this.Spravochniki.Controls.Add(this.linkNormy);
            this.Spravochniki.Controls.Add(this.linkPodvijnoi);
            this.Spravochniki.Controls.Add(this.linklichnii);
            this.Spravochniki.Location = new System.Drawing.Point(3, 176);
            this.Spravochniki.Name = "Spravochniki";
            this.Spravochniki.Size = new System.Drawing.Size(177, 190);
            this.Spravochniki.TabIndex = 1;
            this.Spravochniki.TabStop = false;
            this.Spravochniki.Text = "Справочники";
            this.Spravochniki.Enter += new System.EventHandler(this.Spravochniki_Enter);
            // 
            // lblVoditeliAuto
            // 
            this.lblVoditeliAuto.AutoSize = true;
            this.lblVoditeliAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVoditeliAuto.LinkColor = System.Drawing.Color.Navy;
            this.lblVoditeliAuto.Location = new System.Drawing.Point(6, 121);
            this.lblVoditeliAuto.Name = "lblVoditeliAuto";
            this.lblVoditeliAuto.Size = new System.Drawing.Size(126, 20);
            this.lblVoditeliAuto.TabIndex = 4;
            this.lblVoditeliAuto.TabStop = true;
            this.lblVoditeliAuto.Text = "Водители авто";
            // 
            // lblOtdel
            // 
            this.lblOtdel.AutoSize = true;
            this.lblOtdel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOtdel.LinkColor = System.Drawing.Color.Navy;
            this.lblOtdel.Location = new System.Drawing.Point(6, 90);
            this.lblOtdel.Name = "lblOtdel";
            this.lblOtdel.Size = new System.Drawing.Size(71, 20);
            this.lblOtdel.TabIndex = 3;
            this.lblOtdel.TabStop = true;
            this.lblOtdel.Text = "Отделы";
            this.lblOtdel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSpravochniki_LinkClicked);
            // 
            // linkNormy
            // 
            this.linkNormy.AutoSize = true;
            this.linkNormy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkNormy.LinkColor = System.Drawing.Color.Navy;
            this.linkNormy.Location = new System.Drawing.Point(6, 156);
            this.linkNormy.Name = "linkNormy";
            this.linkNormy.Size = new System.Drawing.Size(164, 20);
            this.linkNormy.TabIndex = 2;
            this.linkNormy.TabStop = true;
            this.linkNormy.Text = "Нормы расхода ГСМ";
            this.linkNormy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSpravochniki_LinkClicked);
            // 
            // linkPodvijnoi
            // 
            this.linkPodvijnoi.AutoSize = true;
            this.linkPodvijnoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkPodvijnoi.LinkColor = System.Drawing.Color.Navy;
            this.linkPodvijnoi.Location = new System.Drawing.Point(6, 59);
            this.linkPodvijnoi.Name = "linkPodvijnoi";
            this.linkPodvijnoi.Size = new System.Drawing.Size(153, 20);
            this.linkPodvijnoi.TabIndex = 1;
            this.linkPodvijnoi.TabStop = true;
            this.linkPodvijnoi.Text = "Подвижной состав";
            this.linkPodvijnoi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSpravochniki_LinkClicked);
            // 
            // groupListi
            // 
            this.groupListi.Controls.Add(this.linkJurnal);
            this.groupListi.Controls.Add(this.linkGruzovoi);
            this.groupListi.Controls.Add(this.linkLegkovoi);
            this.groupListi.Location = new System.Drawing.Point(556, 176);
            this.groupListi.Name = "groupListi";
            this.groupListi.Size = new System.Drawing.Size(317, 131);
            this.groupListi.TabIndex = 2;
            this.groupListi.TabStop = false;
            this.groupListi.Text = "Путевые листы";
            // 
            // linkJurnal
            // 
            this.linkJurnal.AutoSize = true;
            this.linkJurnal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkJurnal.LinkColor = System.Drawing.Color.Navy;
            this.linkJurnal.Location = new System.Drawing.Point(7, 90);
            this.linkJurnal.Name = "linkJurnal";
            this.linkJurnal.Size = new System.Drawing.Size(298, 20);
            this.linkJurnal.TabIndex = 2;
            this.linkJurnal.TabStop = true;
            this.linkJurnal.Text = "Журнал учета выдачи путевых листов";
            // 
            // linkGruzovoi
            // 
            this.linkGruzovoi.AutoSize = true;
            this.linkGruzovoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkGruzovoi.LinkColor = System.Drawing.Color.Navy;
            this.linkGruzovoi.Location = new System.Drawing.Point(7, 59);
            this.linkGruzovoi.Name = "linkGruzovoi";
            this.linkGruzovoi.Size = new System.Drawing.Size(303, 20);
            this.linkGruzovoi.TabIndex = 1;
            this.linkGruzovoi.TabStop = true;
            this.linkGruzovoi.Text = "Путевые листы грузовых автомобилей";
            this.linkGruzovoi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPutevieListi_LinkClicked);
            // 
            // linkLegkovoi
            // 
            this.linkLegkovoi.AutoSize = true;
            this.linkLegkovoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLegkovoi.LinkColor = System.Drawing.Color.Navy;
            this.linkLegkovoi.Location = new System.Drawing.Point(7, 27);
            this.linkLegkovoi.Name = "linkLegkovoi";
            this.linkLegkovoi.Size = new System.Drawing.Size(306, 20);
            this.linkLegkovoi.TabIndex = 0;
            this.linkLegkovoi.TabStop = true;
            this.linkLegkovoi.Text = "Путевые листы легковых автомобилей";
            this.linkLegkovoi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPutevieListi_LinkClicked);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(885, 409);
            this.Controls.Add(this.groupListi);
            this.Controls.Add(this.Spravochniki);
            this.Name = "Menu";
            this.Text = "ОАО \"Зенит\" Автопарк";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Spravochniki.ResumeLayout(false);
            this.Spravochniki.PerformLayout();
            this.groupListi.ResumeLayout(false);
            this.groupListi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel linklichnii;
        private System.Windows.Forms.GroupBox Spravochniki;
        private System.Windows.Forms.LinkLabel linkNormy;
        private System.Windows.Forms.LinkLabel linkPodvijnoi;
        private System.Windows.Forms.GroupBox groupListi;
        private System.Windows.Forms.LinkLabel linkLegkovoi;
        private System.Windows.Forms.LinkLabel linkJurnal;
        private System.Windows.Forms.LinkLabel linkGruzovoi;
        private System.Windows.Forms.LinkLabel lblVoditeliAuto;
        private System.Windows.Forms.LinkLabel lblOtdel;
    }
}

