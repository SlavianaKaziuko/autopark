namespace AUTOPARK
{
    partial class PutListLegkovogoavto
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
             System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
           this.components = new System.ComponentModel.Container();
            this.lblLegkovoi = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblperiod = new System.Windows.Forms.Label();
            this.lblpo = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblvoditel = new System.Windows.Forms.Label();
            this.txtVoditel = new System.Windows.Forms.TextBox();
            this.lblVodUdostoverenie = new System.Windows.Forms.Label();
            this.lblAvto = new System.Windows.Forms.Label();
            this.txtAvto = new System.Windows.Forms.TextBox();
            this.cbNomerAuto = new System.Windows.Forms.ComboBox();
            this.cbVodUdostoverenie = new System.Windows.Forms.ComboBox();
            this.dgvPutevieLegkovie = new System.Windows.Forms.DataGridView();
            this.pnlShapka = new System.Windows.Forms.Panel();
            this.txtKlassnost = new System.Windows.Forms.TextBox();
            this.lblKlassnost = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.autoparkDB = new AUTOPARK.AutoparkDB();
            this.данныеПутевойЛистЛегковогоАвтоBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.putListLegkovogoDannieTableAdapter = new AUTOPARK.AutoparkDBTableAdapters.PutListLegkovogoDannieTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPutevieLegkovie)).BeginInit();
            this.pnlShapka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoparkDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.данныеПутевойЛистЛегковогоАвтоBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLegkovoi
            // 
            this.lblLegkovoi.AutoSize = true;
            this.lblLegkovoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLegkovoi.Location = new System.Drawing.Point(68, 20);
            this.lblLegkovoi.Name = "lblLegkovoi";
            this.lblLegkovoi.Size = new System.Drawing.Size(382, 25);
            this.lblLegkovoi.TabIndex = 0;
            this.lblLegkovoi.Text = "Путевой лист легкового автомобиля №";
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNumber.Location = new System.Drawing.Point(456, 22);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(130, 23);
            this.txtNumber.TabIndex = 1;
            // 
            // lblperiod
            // 
            this.lblperiod.AutoSize = true;
            this.lblperiod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblperiod.Location = new System.Drawing.Point(82, 52);
            this.lblperiod.Name = "lblperiod";
            this.lblperiod.Size = new System.Drawing.Size(90, 18);
            this.lblperiod.TabIndex = 2;
            this.lblperiod.Text = "за период с";
            // 
            // lblpo
            // 
            this.lblpo.AutoSize = true;
            this.lblpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblpo.Location = new System.Drawing.Point(364, 52);
            this.lblpo.Name = "lblpo";
            this.lblpo.Size = new System.Drawing.Size(25, 18);
            this.lblpo.TabIndex = 4;
            this.lblpo.Text = "по";
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "dd MMM yyyy";
            this.dtpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(168, 51);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(170, 23);
            this.dtpStart.TabIndex = 6;
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "dd MMM yyyy";
            this.dtpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(385, 50);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(170, 23);
            this.dtpEnd.TabIndex = 7;
            // 
            // lblvoditel
            // 
            this.lblvoditel.AutoSize = true;
            this.lblvoditel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblvoditel.Location = new System.Drawing.Point(26, 114);
            this.lblvoditel.Name = "lblvoditel";
            this.lblvoditel.Size = new System.Drawing.Size(76, 18);
            this.lblvoditel.TabIndex = 8;
            this.lblvoditel.Text = "Водитель";
            // 
            // txtVoditel
            // 
            this.txtVoditel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtVoditel.Location = new System.Drawing.Point(489, 115);
            this.txtVoditel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVoditel.Name = "txtVoditel";
            this.txtVoditel.Size = new System.Drawing.Size(116, 23);
            this.txtVoditel.TabIndex = 9;
            // 
            // lblVodUdostoverenie
            // 
            this.lblVodUdostoverenie.AutoSize = true;
            this.lblVodUdostoverenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVodUdostoverenie.Location = new System.Drawing.Point(265, 114);
            this.lblVodUdostoverenie.Name = "lblVodUdostoverenie";
            this.lblVodUdostoverenie.Size = new System.Drawing.Size(218, 18);
            this.lblVodUdostoverenie.TabIndex = 10;
            this.lblVodUdostoverenie.Text = "Водительское удостоверение";
            // 
            // lblAvto
            // 
            this.lblAvto.AutoSize = true;
            this.lblAvto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAvto.Location = new System.Drawing.Point(117, 83);
            this.lblAvto.Name = "lblAvto";
            this.lblAvto.Size = new System.Drawing.Size(95, 18);
            this.lblAvto.TabIndex = 12;
            this.lblAvto.Text = "Автомобиль";
            // 
            // txtAvto
            // 
            this.txtAvto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAvto.Location = new System.Drawing.Point(367, 84);
            this.txtAvto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAvto.Name = "txtAvto";
            this.txtAvto.ReadOnly = true;
            this.txtAvto.Size = new System.Drawing.Size(116, 23);
            this.txtAvto.TabIndex = 13;
            // 
            // cbNomerAuto
            // 
            this.cbNomerAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbNomerAuto.FormattingEnabled = true;
            this.cbNomerAuto.Location = new System.Drawing.Point(218, 82);
            this.cbNomerAuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNomerAuto.Name = "cbNomerAuto";
            this.cbNomerAuto.Size = new System.Drawing.Size(140, 24);
            this.cbNomerAuto.TabIndex = 14;
            this.cbNomerAuto.SelectedValueChanged += new System.EventHandler(this.cbNomerAuto_SelectedValueChanged);
            // 
            // cbVodUdostoverenie
            // 
            this.cbVodUdostoverenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbVodUdostoverenie.FormattingEnabled = true;
            this.cbVodUdostoverenie.Location = new System.Drawing.Point(108, 113);
            this.cbVodUdostoverenie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbVodUdostoverenie.Name = "cbVodUdostoverenie";
            this.cbVodUdostoverenie.Size = new System.Drawing.Size(140, 24);
            this.cbVodUdostoverenie.TabIndex = 15;
            this.cbVodUdostoverenie.SelectedIndexChanged += new System.EventHandler(this.cbVodUdostoverenie_SelectedValueChanged);
            // 
            // dgvPutevieLegkovie
            // 
            this.dgvPutevieLegkovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPutevieLegkovie.Location = new System.Drawing.Point(13, 188);
            this.dgvPutevieLegkovie.Name = "dgvPutevieLegkovie";
            this.dgvPutevieLegkovie.Size = new System.Drawing.Size(981, 278);
            this.dgvPutevieLegkovie.TabIndex = 16;
            this.dgvPutevieLegkovie.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvPutevieLegkovie_RowsAdded);
            // 
            // pnlShapka
            // 
            this.pnlShapka.Controls.Add(this.txtKlassnost);
            this.pnlShapka.Controls.Add(this.lblKlassnost);
            this.pnlShapka.Controls.Add(this.cbVodUdostoverenie);
            this.pnlShapka.Controls.Add(this.cbNomerAuto);
            this.pnlShapka.Controls.Add(this.txtAvto);
            this.pnlShapka.Controls.Add(this.lblAvto);
            this.pnlShapka.Controls.Add(this.lblVodUdostoverenie);
            this.pnlShapka.Controls.Add(this.txtVoditel);
            this.pnlShapka.Controls.Add(this.lblvoditel);
            this.pnlShapka.Controls.Add(this.dtpEnd);
            this.pnlShapka.Controls.Add(this.dtpStart);
            this.pnlShapka.Controls.Add(this.lblpo);
            this.pnlShapka.Controls.Add(this.lblperiod);
            this.pnlShapka.Controls.Add(this.txtNumber);
            this.pnlShapka.Controls.Add(this.lblLegkovoi);
            this.pnlShapka.Location = new System.Drawing.Point(167, 12);
            this.pnlShapka.Name = "pnlShapka";
            this.pnlShapka.Size = new System.Drawing.Size(766, 156);
            this.pnlShapka.TabIndex = 17;
            // 
            // txtKlassnost
            // 
            this.txtKlassnost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtKlassnost.Location = new System.Drawing.Point(725, 115);
            this.txtKlassnost.Name = "txtKlassnost";
            this.txtKlassnost.Size = new System.Drawing.Size(37, 23);
            this.txtKlassnost.TabIndex = 17;
            // 
            // lblKlassnost
            // 
            this.lblKlassnost.AutoSize = true;
            this.lblKlassnost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKlassnost.Location = new System.Drawing.Point(628, 118);
            this.lblKlassnost.Name = "lblKlassnost";
            this.lblKlassnost.Size = new System.Drawing.Size(91, 18);
            this.lblKlassnost.TabIndex = 16;
            this.lblKlassnost.Text = "Классность";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(819, 486);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(919, 486);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(738, 486);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 20;
            this.btnReport.Text = "Отчет";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click_1);
            // 
            // autoparkDB
            // 
            this.autoparkDB.DataSetName = "AutoparkDB";
            this.autoparkDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // данныеПутевойЛистЛегковогоАвтоBindingSource
            // 
            this.данныеПутевойЛистЛегковогоАвтоBindingSource.DataMember = "Данные Путевой лист легкового авто";
            this.данныеПутевойЛистЛегковогоАвтоBindingSource.DataSource = this.autoparkDB;
            // 
            // putListLegkovogoDannieTableAdapter
            // 
            this.putListLegkovogoDannieTableAdapter.ClearBeforeFill = true;
            // 
            // PutListLegkovogoavto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 521);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlShapka);
            this.Controls.Add(this.dgvPutevieLegkovie);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PutListLegkovogoavto";
            this.Text = "Путевой лист легкового автомобиля";
            this.Load += new System.EventHandler(this.PutListLegkovogoavto_Load);
            this.Resize += new System.EventHandler(this.lblLiatLegkovogoavto_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPutevieLegkovie)).EndInit();
            this.pnlShapka.ResumeLayout(false);
            this.pnlShapka.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoparkDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.данныеПутевойЛистЛегковогоАвтоBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLegkovoi;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblperiod;
        private System.Windows.Forms.Label lblpo;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblvoditel;
        private System.Windows.Forms.TextBox txtVoditel;
        private System.Windows.Forms.Label lblVodUdostoverenie;
        private System.Windows.Forms.Label lblAvto;
        private System.Windows.Forms.TextBox txtAvto;
        private System.Windows.Forms.ComboBox cbNomerAuto;
        private System.Windows.Forms.ComboBox cbVodUdostoverenie;
        private System.Windows.Forms.DataGridView dgvPutevieLegkovie;
        private System.Windows.Forms.Panel pnlShapka;
        private System.Windows.Forms.TextBox txtKlassnost;
        private System.Windows.Forms.Label lblKlassnost;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private AutoparkDB autoparkDB;
        private System.Windows.Forms.BindingSource данныеПутевойЛистЛегковогоАвтоBindingSource;
        private AutoparkDBTableAdapters.PutListLegkovogoDannieTableAdapter putListLegkovogoDannieTableAdapter;
        private System.Windows.Forms.Button btnReport;

    }
}