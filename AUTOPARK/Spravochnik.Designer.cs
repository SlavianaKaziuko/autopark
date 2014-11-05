namespace AUTOPARK
{
    partial class Spravochnik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spravochnik));
            this.dgvSpravochnik = new System.Windows.Forms.DataGridView();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.exitPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpravochnik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPic)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSpravochnik
            // 
            this.dgvSpravochnik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpravochnik.Location = new System.Drawing.Point(12, 12);
            this.dgvSpravochnik.Name = "dgvSpravochnik";
            this.dgvSpravochnik.Size = new System.Drawing.Size(1144, 217);
            this.dgvSpravochnik.TabIndex = 0;
            this.dgvSpravochnik.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvSpravochnik_DataError);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(1018, 235);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(138, 23);
            this.btnSaveChanges.TabIndex = 1;
            this.btnSaveChanges.Text = "Сохранить изменения";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // exitPic
            // 
            this.exitPic.Image = ((System.Drawing.Image)(resources.GetObject("exitPic.Image")));
            this.exitPic.Location = new System.Drawing.Point(1282, 12);
            this.exitPic.Name = "exitPic";
            this.exitPic.Size = new System.Drawing.Size(32, 32);
            this.exitPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitPic.TabIndex = 58;
            this.exitPic.TabStop = false;
            this.exitPic.Click += new System.EventHandler(this.exitPic_Click);
            // 
            // Spravochnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 377);
            this.Controls.Add(this.exitPic);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.dgvSpravochnik);
            this.Name = "Spravochnik";
            this.Text = "Справочник";
            this.Resize += new System.EventHandler(this.Spravochnik_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpravochnik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSpravochnik;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.PictureBox exitPic;
    }
}