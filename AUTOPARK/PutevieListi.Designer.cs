namespace AUTOPARK
{
    partial class PutevieListi
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
            this.dgvPutevii = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.навигацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiToMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExitApplication = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPutevii)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPutevii
            // 
            this.dgvPutevii.AllowUserToAddRows = false;
            this.dgvPutevii.AllowUserToDeleteRows = false;
            this.dgvPutevii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPutevii.Location = new System.Drawing.Point(12, 27);
            this.dgvPutevii.MultiSelect = false;
            this.dgvPutevii.Name = "dgvPutevii";
            this.dgvPutevii.ReadOnly = true;
            this.dgvPutevii.Size = new System.Drawing.Size(821, 365);
            this.dgvPutevii.TabIndex = 0;
            this.dgvPutevii.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvPutevii_DataError);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(571, 400);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(652, 400);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(758, 400);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.навигацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(845, 24);
            this.menuStrip1.TabIndex = 4;
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
            this.tsmiToMenu.Text = "Вернуться к Меню";
            this.tsmiToMenu.Click += new System.EventHandler(this.tsmiToMenu_Click);
            // 
            // tsmiExitApplication
            // 
            this.tsmiExitApplication.Name = "tsmiExitApplication";
            this.tsmiExitApplication.Size = new System.Drawing.Size(197, 22);
            this.tsmiExitApplication.Text = "Выйти из приложения";
            this.tsmiExitApplication.Click += new System.EventHandler(this.tsmiExitApplication_Click);
            // 
            // PutevieListi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 435);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvPutevii);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PutevieListi";
            this.Text = "Путевые листы";
            this.Resize += new System.EventHandler(this.PutevieListi_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPutevii)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPutevii;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem навигацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiToMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiExitApplication;
    }
}