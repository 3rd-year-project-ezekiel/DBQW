namespace _3rdYearProject
{
    partial class frmTableCreation
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
            this.TopNavPnl = new System.Windows.Forms.Panel();
            this.btnNavMin = new System.Windows.Forms.Button();
            this.btnNavClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstColumns = new System.Windows.Forms.ListBox();
            this.btnRemoveColumn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMainHeading = new System.Windows.Forms.Label();
            this.lblColumnDetails = new System.Windows.Forms.Label();
            this.lblColumnsHeading = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblColType = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.cbUnique = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.cnNotNull = new System.Windows.Forms.CheckBox();
            this.cbForeignKey = new System.Windows.Forms.CheckBox();
            this.txtForeignColName = new System.Windows.Forms.TextBox();
            this.lblRef = new System.Windows.Forms.Label();
            this.btnProceed = new System.Windows.Forms.Button();
            this.btnAAddColumn = new System.Windows.Forms.Button();
            this.lblColName = new System.Windows.Forms.Label();
            this.lblForeignHeading = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtForeignTable = new System.Windows.Forms.TextBox();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.TopNavPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopNavPnl
            // 
            this.TopNavPnl.BackColor = System.Drawing.Color.Crimson;
            this.TopNavPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TopNavPnl.Controls.Add(this.btnNavMin);
            this.TopNavPnl.Controls.Add(this.btnNavClose);
            this.TopNavPnl.Location = new System.Drawing.Point(0, 0);
            this.TopNavPnl.Name = "TopNavPnl";
            this.TopNavPnl.Size = new System.Drawing.Size(1104, 38);
            this.TopNavPnl.TabIndex = 9;
            // 
            // btnNavMin
            // 
            this.btnNavMin.BackColor = System.Drawing.Color.Crimson;
            this.btnNavMin.FlatAppearance.BorderSize = 0;
            this.btnNavMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavMin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNavMin.Location = new System.Drawing.Point(1037, 10);
            this.btnNavMin.Name = "btnNavMin";
            this.btnNavMin.Size = new System.Drawing.Size(26, 23);
            this.btnNavMin.TabIndex = 1;
            this.btnNavMin.Text = "_";
            this.btnNavMin.UseVisualStyleBackColor = false;
            // 
            // btnNavClose
            // 
            this.btnNavClose.BackColor = System.Drawing.Color.Crimson;
            this.btnNavClose.FlatAppearance.BorderSize = 0;
            this.btnNavClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavClose.Location = new System.Drawing.Point(1069, 10);
            this.btnNavClose.Name = "btnNavClose";
            this.btnNavClose.Size = new System.Drawing.Size(28, 23);
            this.btnNavClose.TabIndex = 0;
            this.btnNavClose.Text = "X";
            this.btnNavClose.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCreateTable);
            this.panel1.Controls.Add(this.txtTableName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblHeading);
            this.panel1.Controls.Add(this.lblColumnsHeading);
            this.panel1.Controls.Add(this.btnRemoveColumn);
            this.panel1.Controls.Add(this.lstColumns);
            this.panel1.Location = new System.Drawing.Point(82, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 493);
            this.panel1.TabIndex = 10;
            // 
            // lstColumns
            // 
            this.lstColumns.FormattingEnabled = true;
            this.lstColumns.Location = new System.Drawing.Point(35, 154);
            this.lstColumns.Name = "lstColumns";
            this.lstColumns.Size = new System.Drawing.Size(313, 264);
            this.lstColumns.TabIndex = 0;
            // 
            // btnRemoveColumn
            // 
            this.btnRemoveColumn.Location = new System.Drawing.Point(117, 424);
            this.btnRemoveColumn.Name = "btnRemoveColumn";
            this.btnRemoveColumn.Size = new System.Drawing.Size(110, 23);
            this.btnRemoveColumn.TabIndex = 1;
            this.btnRemoveColumn.Text = "Remove Column";
            this.btnRemoveColumn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtForeignTable);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblForeignHeading);
            this.panel2.Controls.Add(this.lblColName);
            this.panel2.Controls.Add(this.btnAAddColumn);
            this.panel2.Controls.Add(this.lblRef);
            this.panel2.Controls.Add(this.txtForeignColName);
            this.panel2.Controls.Add(this.cbForeignKey);
            this.panel2.Controls.Add(this.cnNotNull);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Controls.Add(this.cbUnique);
            this.panel2.Controls.Add(this.cbxType);
            this.panel2.Controls.Add(this.lblColType);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.lblColumnDetails);
            this.panel2.Location = new System.Drawing.Point(550, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 483);
            this.panel2.TabIndex = 11;
            // 
            // lblMainHeading
            // 
            this.lblMainHeading.AutoSize = true;
            this.lblMainHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHeading.Location = new System.Drawing.Point(403, 54);
            this.lblMainHeading.Name = "lblMainHeading";
            this.lblMainHeading.Size = new System.Drawing.Size(167, 25);
            this.lblMainHeading.TabIndex = 2;
            this.lblMainHeading.Text = "Table Creation";
            // 
            // lblColumnDetails
            // 
            this.lblColumnDetails.AutoSize = true;
            this.lblColumnDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnDetails.Location = new System.Drawing.Point(188, 15);
            this.lblColumnDetails.Name = "lblColumnDetails";
            this.lblColumnDetails.Size = new System.Drawing.Size(150, 24);
            this.lblColumnDetails.TabIndex = 0;
            this.lblColumnDetails.Text = "Column Details";
            // 
            // lblColumnsHeading
            // 
            this.lblColumnsHeading.AutoSize = true;
            this.lblColumnsHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnsHeading.Location = new System.Drawing.Point(148, 121);
            this.lblColumnsHeading.Name = "lblColumnsHeading";
            this.lblColumnsHeading.Size = new System.Drawing.Size(71, 20);
            this.lblColumnsHeading.TabIndex = 2;
            this.lblColumnsHeading.Text = "Columns";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(113, 15);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(114, 20);
            this.lblHeading.TabIndex = 3;
            this.lblHeading.Text = "Table Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Table Name:";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(152, 68);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(100, 20);
            this.txtTableName.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(256, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblColType
            // 
            this.lblColType.AutoSize = true;
            this.lblColType.Location = new System.Drawing.Point(171, 145);
            this.lblColType.Name = "lblColType";
            this.lblColType.Size = new System.Drawing.Size(34, 13);
            this.lblColType.TabIndex = 2;
            this.lblColType.Text = "Type:";
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(256, 137);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(121, 21);
            this.cbxType.TabIndex = 3;
            // 
            // cbUnique
            // 
            this.cbUnique.AutoSize = true;
            this.cbUnique.Location = new System.Drawing.Point(164, 224);
            this.cbUnique.Name = "cbUnique";
            this.cbUnique.Size = new System.Drawing.Size(60, 17);
            this.cbUnique.TabIndex = 4;
            this.cbUnique.Text = "Unique";
            this.cbUnique.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(396, 67);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(81, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Primary Key";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // cnNotNull
            // 
            this.cnNotNull.AutoSize = true;
            this.cnNotNull.Location = new System.Drawing.Point(297, 224);
            this.cnNotNull.Name = "cnNotNull";
            this.cnNotNull.Size = new System.Drawing.Size(64, 17);
            this.cnNotNull.TabIndex = 6;
            this.cnNotNull.Text = "Not Null";
            this.cnNotNull.UseVisualStyleBackColor = true;
            // 
            // cbForeignKey
            // 
            this.cbForeignKey.AutoSize = true;
            this.cbForeignKey.Location = new System.Drawing.Point(164, 280);
            this.cbForeignKey.Name = "cbForeignKey";
            this.cbForeignKey.Size = new System.Drawing.Size(82, 17);
            this.cbForeignKey.TabIndex = 7;
            this.cbForeignKey.Text = "Foreign Key";
            this.cbForeignKey.UseVisualStyleBackColor = true;
            // 
            // txtForeignColName
            // 
            this.txtForeignColName.Location = new System.Drawing.Point(277, 368);
            this.txtForeignColName.Name = "txtForeignColName";
            this.txtForeignColName.Size = new System.Drawing.Size(100, 20);
            this.txtForeignColName.TabIndex = 8;
            // 
            // lblRef
            // 
            this.lblRef.AutoSize = true;
            this.lblRef.Location = new System.Drawing.Point(142, 371);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(129, 13);
            this.lblRef.TabIndex = 9;
            this.lblRef.Text = "Reference Column Name ";
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(472, 596);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(75, 23);
            this.btnProceed.TabIndex = 12;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = true;
            // 
            // btnAAddColumn
            // 
            this.btnAAddColumn.Location = new System.Drawing.Point(242, 446);
            this.btnAAddColumn.Name = "btnAAddColumn";
            this.btnAAddColumn.Size = new System.Drawing.Size(75, 23);
            this.btnAAddColumn.TabIndex = 10;
            this.btnAAddColumn.Text = "Add Column";
            this.btnAAddColumn.UseVisualStyleBackColor = true;
            // 
            // lblColName
            // 
            this.lblColName.AutoSize = true;
            this.lblColName.Location = new System.Drawing.Point(130, 71);
            this.lblColName.Name = "lblColName";
            this.lblColName.Size = new System.Drawing.Size(76, 13);
            this.lblColName.TabIndex = 11;
            this.lblColName.Text = "Column Name:";
            // 
            // lblForeignHeading
            // 
            this.lblForeignHeading.AutoSize = true;
            this.lblForeignHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForeignHeading.Location = new System.Drawing.Point(208, 322);
            this.lblForeignHeading.Name = "lblForeignHeading";
            this.lblForeignHeading.Size = new System.Drawing.Size(153, 18);
            this.lblForeignHeading.TabIndex = 12;
            this.lblForeignHeading.Text = "Foreign key Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Reference Column Name ";
            // 
            // txtForeignTable
            // 
            this.txtForeignTable.Location = new System.Drawing.Point(277, 402);
            this.txtForeignTable.Name = "txtForeignTable";
            this.txtForeignTable.Size = new System.Drawing.Size(100, 20);
            this.txtForeignTable.TabIndex = 15;
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.Location = new System.Drawing.Point(117, 460);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(110, 23);
            this.btnCreateTable.TabIndex = 13;
            this.btnCreateTable.Text = "Create Table";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            // 
            // frmTableCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_3rdYearProject.Properties.Resources.Option1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1109, 631);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.lblMainHeading);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TopNavPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTableCreation";
            this.Text = "TableCreation";
            this.TopNavPnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopNavPnl;
        private System.Windows.Forms.Button btnNavMin;
        private System.Windows.Forms.Button btnNavClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblColumnsHeading;
        private System.Windows.Forms.Button btnRemoveColumn;
        private System.Windows.Forms.ListBox lstColumns;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblColName;
        private System.Windows.Forms.Button btnAAddColumn;
        private System.Windows.Forms.Label lblRef;
        private System.Windows.Forms.TextBox txtForeignColName;
        private System.Windows.Forms.CheckBox cbForeignKey;
        private System.Windows.Forms.CheckBox cnNotNull;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox cbUnique;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label lblColType;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblColumnDetails;
        private System.Windows.Forms.Label lblMainHeading;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Label lblForeignHeading;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.TextBox txtForeignTable;
        private System.Windows.Forms.Label label1;
    }
}