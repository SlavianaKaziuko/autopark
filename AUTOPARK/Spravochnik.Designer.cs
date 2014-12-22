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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.навигацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiToMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExitApplication = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpravochnik)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSpravochnik
            // 
            this.dgvSpravochnik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpravochnik.Location = new System.Drawing.Point(12, 27);
            this.dgvSpravochnik.Name = "dgvSpravochnik";
            this.dgvSpravochnik.Size = new System.Drawing.Size(764, 309);
            this.dgvSpravochnik.TabIndex = 0;
            this.dgvSpravochnik.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvSpravochnik_CellValidating);
            this.dgvSpravochnik.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSpravochnik_CellValueChanged);
            this.dgvSpravochnik.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvSpravochnik_DataError);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(638, 342);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(138, 23);
            this.btnSaveChanges.TabIndex = 1;
            this.btnSaveChanges.Text = "Сохранить изменения";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.навигацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // навигацияToolStripMenuItem
            // 
            this.навигацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiToMenu,
            this.tsmiExitApplication});
            this.навигацияToolStripMenuItem.Name = "навигацияToolStripMenuItem";
            this.навигацияToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.навигацияToolStripMenuItem.Text = "Навигация";
            // 
            // tsmiToMenu
            // 
            this.tsmiToMenu.Name = "tsmiToMenu";
            this.tsmiToMenu.Size = new System.Drawing.Size(197, 22);
            this.tsmiToMenu.Text = "Вернуться к меню";
            this.tsmiToMenu.Click += new System.EventHandler(this.tsmiToMenu_Click);
            // 
            // tsmiExitApplication
            // 
            this.tsmiExitApplication.Name = "tsmiExitApplication";
            this.tsmiExitApplication.Size = new System.Drawing.Size(197, 22);
            this.tsmiExitApplication.Text = "Выйти из приложения";
            this.tsmiExitApplication.Click += new System.EventHandler(this.tsmiExitApplication_Click);
            // 
            // Spravochnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 377);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.dgvSpravochnik);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Spravochnik";
            this.Text = "Справочник";
            this.Load += new System.EventHandler(this.Spravochnik_Load);
            this.Resize += new System.EventHandler(this.Spravochnik_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpravochnik)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSpravochnik;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem навигацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiToMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiExitApplication;
    }
}