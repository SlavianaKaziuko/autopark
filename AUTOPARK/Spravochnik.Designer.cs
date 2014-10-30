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
            this.dgvSpravochnik = new System.Windows.Forms.DataGridView();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpravochnik)).BeginInit();
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
            // Spravochnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 268);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.dgvSpravochnik);
            this.Name = "Spravochnik";
            this.Text = "Справочник";
            this.Resize += new System.EventHandler(this.Spravochnik_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpravochnik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSpravochnik;
        private System.Windows.Forms.Button btnSaveChanges;
    }
}