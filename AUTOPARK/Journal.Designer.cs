namespace AUTOPARK
{
    partial class Journal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblGosNomer = new System.Windows.Forms.Label();
            this.lblPricep = new System.Windows.Forms.Label();
            this.lblStrahovka = new System.Windows.Forms.Label();
            this.lblMedKomissia = new System.Windows.Forms.Label();
            this.lblShoferAuto = new System.Windows.Forms.Label();
            this.lblGaragniiNomer = new System.Windows.Forms.Label();
            this.lblKlassnost = new System.Windows.Forms.Label();
            this.lblMarkaTCM = new System.Windows.Forms.Label();
            this.cbZnak = new System.Windows.Forms.ComboBox();
            this.txtAuto = new System.Windows.Forms.TextBox();
            this.txtPricep = new System.Windows.Forms.TextBox();
            this.txtStrahovka = new System.Windows.Forms.TextBox();
            this.cbMarkaTopliva = new System.Windows.Forms.ComboBox();
            this.txtGarag = new System.Windows.Forms.TextBox();
            this.txtKlassnost = new System.Windows.Forms.TextBox();
            this.dgvJournalDannie = new System.Windows.Forms.DataGridView();
            this.lblVodUdostoverenir = new System.Windows.Forms.Label();
            this.cbShofer = new System.Windows.Forms.ComboBox();
            this.txtVodUdoatoverenie = new System.Windows.Forms.TextBox();
            this.txtMedSpravka = new System.Windows.Forms.TextBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournalDannie)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMarka.Location = new System.Drawing.Point(18, 24);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(159, 20);
            this.lblMarka.TabIndex = 0;
            this.lblMarka.Text = "Марка автомашины";
            // 
            // lblGosNomer
            // 
            this.lblGosNomer.AutoSize = true;
            this.lblGosNomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGosNomer.Location = new System.Drawing.Point(18, 56);
            this.lblGosNomer.Name = "lblGosNomer";
            this.lblGosNomer.Size = new System.Drawing.Size(54, 20);
            this.lblGosNomer.TabIndex = 1;
            this.lblGosNomer.Text = "Гос.№";
            // 
            // lblPricep
            // 
            this.lblPricep.AutoSize = true;
            this.lblPricep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPricep.Location = new System.Drawing.Point(18, 88);
            this.lblPricep.Name = "lblPricep";
            this.lblPricep.Size = new System.Drawing.Size(66, 20);
            this.lblPricep.TabIndex = 2;
            this.lblPricep.Text = "Прицеп";
            // 
            // lblStrahovka
            // 
            this.lblStrahovka.AutoSize = true;
            this.lblStrahovka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStrahovka.Location = new System.Drawing.Point(18, 119);
            this.lblStrahovka.Name = "lblStrahovka";
            this.lblStrahovka.Size = new System.Drawing.Size(213, 20);
            this.lblStrahovka.TabIndex = 3;
            this.lblStrahovka.Text = "Дата окончания страховки";
            // 
            // lblMedKomissia
            // 
            this.lblMedKomissia.AutoSize = true;
            this.lblMedKomissia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMedKomissia.Location = new System.Drawing.Point(516, 124);
            this.lblMedKomissia.Name = "lblMedKomissia";
            this.lblMedKomissia.Size = new System.Drawing.Size(302, 20);
            this.lblMedKomissia.TabIndex = 4;
            this.lblMedKomissia.Text = "Дата окончания медицинской справки";
            // 
            // lblShoferAuto
            // 
            this.lblShoferAuto.AutoSize = true;
            this.lblShoferAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblShoferAuto.Location = new System.Drawing.Point(516, 24);
            this.lblShoferAuto.Name = "lblShoferAuto";
            this.lblShoferAuto.Size = new System.Drawing.Size(161, 20);
            this.lblShoferAuto.TabIndex = 5;
            this.lblShoferAuto.Text = "Шофер автомобиля";
            // 
            // lblGaragniiNomer
            // 
            this.lblGaragniiNomer.AutoSize = true;
            this.lblGaragniiNomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGaragniiNomer.Location = new System.Drawing.Point(18, 184);
            this.lblGaragniiNomer.Name = "lblGaragniiNomer";
            this.lblGaragniiNomer.Size = new System.Drawing.Size(136, 20);
            this.lblGaragniiNomer.TabIndex = 6;
            this.lblGaragniiNomer.Text = "Гаражный номер";
            // 
            // lblKlassnost
            // 
            this.lblKlassnost.AutoSize = true;
            this.lblKlassnost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKlassnost.Location = new System.Drawing.Point(516, 59);
            this.lblKlassnost.Name = "lblKlassnost";
            this.lblKlassnost.Size = new System.Drawing.Size(98, 20);
            this.lblKlassnost.TabIndex = 7;
            this.lblKlassnost.Text = "Классность";
            // 
            // lblMarkaTCM
            // 
            this.lblMarkaTCM.AutoSize = true;
            this.lblMarkaTCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMarkaTCM.Location = new System.Drawing.Point(18, 151);
            this.lblMarkaTCM.Name = "lblMarkaTCM";
            this.lblMarkaTCM.Size = new System.Drawing.Size(94, 20);
            this.lblMarkaTCM.TabIndex = 8;
            this.lblMarkaTCM.Text = "Марка ТСМ";
            // 
            // cbZnak
            // 
            this.cbZnak.FormattingEnabled = true;
            this.cbZnak.Location = new System.Drawing.Point(259, 57);
            this.cbZnak.Name = "cbZnak";
            this.cbZnak.Size = new System.Drawing.Size(180, 21);
            this.cbZnak.TabIndex = 9;
            // 
            // txtAuto
            // 
            this.txtAuto.Location = new System.Drawing.Point(259, 26);
            this.txtAuto.Name = "txtAuto";
            this.txtAuto.Size = new System.Drawing.Size(180, 20);
            this.txtAuto.TabIndex = 10;
            // 
            // txtPricep
            // 
            this.txtPricep.Location = new System.Drawing.Point(259, 90);
            this.txtPricep.Name = "txtPricep";
            this.txtPricep.Size = new System.Drawing.Size(180, 20);
            this.txtPricep.TabIndex = 11;
            // 
            // txtStrahovka
            // 
            this.txtStrahovka.Location = new System.Drawing.Point(330, 121);
            this.txtStrahovka.Name = "txtStrahovka";
            this.txtStrahovka.Size = new System.Drawing.Size(109, 20);
            this.txtStrahovka.TabIndex = 12;
            // 
            // cbMarkaTopliva
            // 
            this.cbMarkaTopliva.FormattingEnabled = true;
            this.cbMarkaTopliva.Location = new System.Drawing.Point(330, 153);
            this.cbMarkaTopliva.Name = "cbMarkaTopliva";
            this.cbMarkaTopliva.Size = new System.Drawing.Size(109, 21);
            this.cbMarkaTopliva.TabIndex = 14;
            // 
            // txtGarag
            // 
            this.txtGarag.Location = new System.Drawing.Point(330, 184);
            this.txtGarag.Name = "txtGarag";
            this.txtGarag.Size = new System.Drawing.Size(109, 20);
            this.txtGarag.TabIndex = 16;
            // 
            // txtKlassnost
            // 
            this.txtKlassnost.Location = new System.Drawing.Point(916, 59);
            this.txtKlassnost.Name = "txtKlassnost";
            this.txtKlassnost.Size = new System.Drawing.Size(105, 20);
            this.txtKlassnost.TabIndex = 17;
            // 
            // dgvJournalDannie
            // 
            this.dgvJournalDannie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJournalDannie.Location = new System.Drawing.Point(12, 301);
            this.dgvJournalDannie.Name = "dgvJournalDannie";
            this.dgvJournalDannie.Size = new System.Drawing.Size(1022, 236);
            this.dgvJournalDannie.TabIndex = 18;
            // 
            // lblVodUdostoverenir
            // 
            this.lblVodUdostoverenir.AutoSize = true;
            this.lblVodUdostoverenir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVodUdostoverenir.Location = new System.Drawing.Point(516, 90);
            this.lblVodUdostoverenir.Name = "lblVodUdostoverenir";
            this.lblVodUdostoverenir.Size = new System.Drawing.Size(240, 20);
            this.lblVodUdostoverenir.TabIndex = 20;
            this.lblVodUdostoverenir.Text = "Водительское удостоверение";
            // 
            // cbShofer
            // 
            this.cbShofer.FormattingEnabled = true;
            this.cbShofer.Location = new System.Drawing.Point(809, 23);
            this.cbShofer.Name = "cbShofer";
            this.cbShofer.Size = new System.Drawing.Size(212, 21);
            this.cbShofer.TabIndex = 21;
            // 
            // txtVodUdoatoverenie
            // 
            this.txtVodUdoatoverenie.Location = new System.Drawing.Point(809, 88);
            this.txtVodUdoatoverenie.Name = "txtVodUdoatoverenie";
            this.txtVodUdoatoverenie.Size = new System.Drawing.Size(212, 20);
            this.txtVodUdoatoverenie.TabIndex = 22;
            // 
            // txtMedSpravka
            // 
            this.txtMedSpravka.Location = new System.Drawing.Point(916, 121);
            this.txtMedSpravka.Name = "txtMedSpravka";
            this.txtMedSpravka.Size = new System.Drawing.Size(105, 20);
            this.txtMedSpravka.TabIndex = 23;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(797, 690);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 24;
            this.btnReport.Text = "Отчет";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(878, 690);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(959, 690);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Journal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 725);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.txtMedSpravka);
            this.Controls.Add(this.txtVodUdoatoverenie);
            this.Controls.Add(this.cbShofer);
            this.Controls.Add(this.lblVodUdostoverenir);
            this.Controls.Add(this.dgvJournalDannie);
            this.Controls.Add(this.txtKlassnost);
            this.Controls.Add(this.txtGarag);
            this.Controls.Add(this.cbMarkaTopliva);
            this.Controls.Add(this.txtStrahovka);
            this.Controls.Add(this.txtPricep);
            this.Controls.Add(this.txtAuto);
            this.Controls.Add(this.cbZnak);
            this.Controls.Add(this.lblMarkaTCM);
            this.Controls.Add(this.lblKlassnost);
            this.Controls.Add(this.lblGaragniiNomer);
            this.Controls.Add(this.lblShoferAuto);
            this.Controls.Add(this.lblMedKomissia);
            this.Controls.Add(this.lblStrahovka);
            this.Controls.Add(this.lblPricep);
            this.Controls.Add(this.lblGosNomer);
            this.Controls.Add(this.lblMarka);
            this.Name = "Journal";
            this.Text = "Журнал учета выдачи путевых листов";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournalDannie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblGosNomer;
        private System.Windows.Forms.Label lblPricep;
        private System.Windows.Forms.Label lblStrahovka;
        private System.Windows.Forms.Label lblMedKomissia;
        private System.Windows.Forms.Label lblShoferAuto;
        private System.Windows.Forms.Label lblGaragniiNomer;
        private System.Windows.Forms.Label lblKlassnost;
        private System.Windows.Forms.Label lblMarkaTCM;
        private System.Windows.Forms.ComboBox cbZnak;
        private System.Windows.Forms.TextBox txtAuto;
        private System.Windows.Forms.TextBox txtPricep;
        private System.Windows.Forms.TextBox txtStrahovka;
        private System.Windows.Forms.ComboBox cbMarkaTopliva;
        private System.Windows.Forms.TextBox txtGarag;
        private System.Windows.Forms.TextBox txtKlassnost;
        private System.Windows.Forms.DataGridView dgvJournalDannie;
        private System.Windows.Forms.Label lblVodUdostoverenir;
        private System.Windows.Forms.ComboBox cbShofer;
        private System.Windows.Forms.TextBox txtVodUdoatoverenie;
        private System.Windows.Forms.TextBox txtMedSpravka;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}