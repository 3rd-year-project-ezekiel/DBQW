namespace _3rdYearProject
{
    partial class frmData
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
            this.pnlHolder = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.Label();
            this.Database = new System.Windows.Forms.Label();
            this.cmbTable = new System.Windows.Forms.ComboBox();
            this.cmbDatabase = new System.Windows.Forms.ComboBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.pnlHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHolder
            // 
            this.pnlHolder.Controls.Add(this.btnMenu);
            this.pnlHolder.Controls.Add(this.Table);
            this.pnlHolder.Controls.Add(this.Database);
            this.pnlHolder.Controls.Add(this.cmbTable);
            this.pnlHolder.Controls.Add(this.cmbDatabase);
            this.pnlHolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHolder.Location = new System.Drawing.Point(0, 0);
            this.pnlHolder.Name = "pnlHolder";
            this.pnlHolder.Size = new System.Drawing.Size(1777, 69);
            this.pnlHolder.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(528, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(110, 50);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = "Bact to Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // Table
            // 
            this.Table.AutoSize = true;
            this.Table.Location = new System.Drawing.Point(245, 13);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(44, 17);
            this.Table.TabIndex = 3;
            this.Table.Text = "Table";
            // 
            // Database
            // 
            this.Database.AutoSize = true;
            this.Database.Location = new System.Drawing.Point(13, 13);
            this.Database.Name = "Database";
            this.Database.Size = new System.Drawing.Size(69, 17);
            this.Database.TabIndex = 2;
            this.Database.Text = "Database";
            // 
            // cmbTable
            // 
            this.cmbTable.FormattingEnabled = true;
            this.cmbTable.Location = new System.Drawing.Point(248, 39);
            this.cmbTable.Name = "cmbTable";
            this.cmbTable.Size = new System.Drawing.Size(193, 24);
            this.cmbTable.TabIndex = 1;
            this.cmbTable.SelectedIndexChanged += new System.EventHandler(this.cmbTable_SelectedIndexChanged);
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.FormattingEnabled = true;
            this.cmbDatabase.Location = new System.Drawing.Point(12, 39);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(180, 24);
            this.cmbDatabase.TabIndex = 0;
            this.cmbDatabase.SelectedIndexChanged += new System.EventHandler(this.cmbDatabase_SelectedIndexChanged);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 69);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(1777, 704);
            this.dgvData.TabIndex = 1;
            // 
            // frmData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1777, 773);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.pnlHolder);
            this.Name = "frmData";
            this.Text = "frmData";
            this.pnlHolder.ResumeLayout(false);
            this.pnlHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHolder;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label Table;
        private System.Windows.Forms.Label Database;
        private System.Windows.Forms.ComboBox cmbTable;
        private System.Windows.Forms.ComboBox cmbDatabase;
    }
}