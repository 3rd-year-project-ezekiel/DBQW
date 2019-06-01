﻿namespace _3rdYearProject
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
            this.pnlColumns = new System.Windows.Forms.Panel();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblColumnsHeading = new System.Windows.Forms.Label();
            this.btnRemoveColumn = new System.Windows.Forms.Button();
            this.lstColumns = new System.Windows.Forms.ListBox();
            this.pnlColumnDetails = new System.Windows.Forms.Panel();
            this.txtForeignTable = new System.Windows.Forms.TextBox();
            this.lblForeignTable = new System.Windows.Forms.Label();
            this.lblForeignHeading = new System.Windows.Forms.Label();
            this.lblColName = new System.Windows.Forms.Label();
            this.btnAAddColumn = new System.Windows.Forms.Button();
            this.lblRef = new System.Windows.Forms.Label();
            this.txtForeignColName = new System.Windows.Forms.TextBox();
            this.cbForeignKey = new System.Windows.Forms.CheckBox();
            this.cbNotNull = new System.Windows.Forms.CheckBox();
            this.cbPrimaryKey = new System.Windows.Forms.CheckBox();
            this.cbUnique = new System.Windows.Forms.CheckBox();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.lblColType = new System.Windows.Forms.Label();
            this.txtColName = new System.Windows.Forms.TextBox();
            this.lblColumnDetails = new System.Windows.Forms.Label();
            this.lblMainHeading = new System.Windows.Forms.Label();
            this.btnProceed = new System.Windows.Forms.Button();
            this.cbIdentity = new System.Windows.Forms.CheckBox();
            this.lblStartValue = new System.Windows.Forms.Label();
            this.lblIncrement = new System.Windows.Forms.Label();
            this.txtIncrementStartValue = new System.Windows.Forms.TextBox();
            this.txtIncrementValue = new System.Windows.Forms.TextBox();
            this.lblIndeityHeading = new System.Windows.Forms.Label();
            this.pnlColumns.SuspendLayout();
            this.pnlColumnDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlColumns
            // 
            this.pnlColumns.Controls.Add(this.btnProceed);
            this.pnlColumns.Controls.Add(this.btnCreateTable);
            this.pnlColumns.Controls.Add(this.txtTableName);
            this.pnlColumns.Controls.Add(this.label4);
            this.pnlColumns.Controls.Add(this.lblHeading);
            this.pnlColumns.Controls.Add(this.lblColumnsHeading);
            this.pnlColumns.Controls.Add(this.btnRemoveColumn);
            this.pnlColumns.Controls.Add(this.lstColumns);
            this.pnlColumns.Location = new System.Drawing.Point(82, 102);
            this.pnlColumns.Name = "pnlColumns";
            this.pnlColumns.Size = new System.Drawing.Size(373, 553);
            this.pnlColumns.TabIndex = 10;
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.Location = new System.Drawing.Point(117, 460);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(110, 23);
            this.btnCreateTable.TabIndex = 13;
            this.btnCreateTable.Text = "Create Table";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            this.btnCreateTable.Click += new System.EventHandler(this.BtnCreateTable_Click);
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(152, 68);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(100, 20);
            this.txtTableName.TabIndex = 5;
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
            // btnRemoveColumn
            // 
            this.btnRemoveColumn.Location = new System.Drawing.Point(117, 424);
            this.btnRemoveColumn.Name = "btnRemoveColumn";
            this.btnRemoveColumn.Size = new System.Drawing.Size(110, 23);
            this.btnRemoveColumn.TabIndex = 1;
            this.btnRemoveColumn.Text = "Remove Column";
            this.btnRemoveColumn.UseVisualStyleBackColor = true;
            this.btnRemoveColumn.Click += new System.EventHandler(this.BtnRemoveColumn_Click);
            // 
            // lstColumns
            // 
            this.lstColumns.FormattingEnabled = true;
            this.lstColumns.Location = new System.Drawing.Point(35, 154);
            this.lstColumns.Name = "lstColumns";
            this.lstColumns.Size = new System.Drawing.Size(313, 264);
            this.lstColumns.TabIndex = 0;
            // 
            // pnlColumnDetails
            // 
            this.pnlColumnDetails.Controls.Add(this.lblIndeityHeading);
            this.pnlColumnDetails.Controls.Add(this.txtIncrementValue);
            this.pnlColumnDetails.Controls.Add(this.txtIncrementStartValue);
            this.pnlColumnDetails.Controls.Add(this.lblIncrement);
            this.pnlColumnDetails.Controls.Add(this.lblStartValue);
            this.pnlColumnDetails.Controls.Add(this.cbIdentity);
            this.pnlColumnDetails.Controls.Add(this.txtForeignTable);
            this.pnlColumnDetails.Controls.Add(this.lblForeignTable);
            this.pnlColumnDetails.Controls.Add(this.lblForeignHeading);
            this.pnlColumnDetails.Controls.Add(this.lblColName);
            this.pnlColumnDetails.Controls.Add(this.btnAAddColumn);
            this.pnlColumnDetails.Controls.Add(this.lblRef);
            this.pnlColumnDetails.Controls.Add(this.txtForeignColName);
            this.pnlColumnDetails.Controls.Add(this.cbForeignKey);
            this.pnlColumnDetails.Controls.Add(this.cbNotNull);
            this.pnlColumnDetails.Controls.Add(this.cbPrimaryKey);
            this.pnlColumnDetails.Controls.Add(this.cbUnique);
            this.pnlColumnDetails.Controls.Add(this.cbxType);
            this.pnlColumnDetails.Controls.Add(this.lblColType);
            this.pnlColumnDetails.Controls.Add(this.txtColName);
            this.pnlColumnDetails.Controls.Add(this.lblColumnDetails);
            this.pnlColumnDetails.Location = new System.Drawing.Point(503, 102);
            this.pnlColumnDetails.Name = "pnlColumnDetails";
            this.pnlColumnDetails.Size = new System.Drawing.Size(502, 621);
            this.pnlColumnDetails.TabIndex = 11;
            // 
            // txtForeignTable
            // 
            this.txtForeignTable.Location = new System.Drawing.Point(272, 548);
            this.txtForeignTable.Name = "txtForeignTable";
            this.txtForeignTable.Size = new System.Drawing.Size(100, 20);
            this.txtForeignTable.TabIndex = 15;
            // 
            // lblForeignTable
            // 
            this.lblForeignTable.AutoSize = true;
            this.lblForeignTable.Location = new System.Drawing.Point(129, 551);
            this.lblForeignTable.Name = "lblForeignTable";
            this.lblForeignTable.Size = new System.Drawing.Size(121, 13);
            this.lblForeignTable.TabIndex = 14;
            this.lblForeignTable.Text = "Reference Table Name ";
            // 
            // lblForeignHeading
            // 
            this.lblForeignHeading.AutoSize = true;
            this.lblForeignHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForeignHeading.Location = new System.Drawing.Point(203, 465);
            this.lblForeignHeading.Name = "lblForeignHeading";
            this.lblForeignHeading.Size = new System.Drawing.Size(153, 18);
            this.lblForeignHeading.TabIndex = 12;
            this.lblForeignHeading.Text = "Foreign key Details";
            // 
            // lblColName
            // 
            this.lblColName.AutoSize = true;
            this.lblColName.Location = new System.Drawing.Point(129, 75);
            this.lblColName.Name = "lblColName";
            this.lblColName.Size = new System.Drawing.Size(76, 13);
            this.lblColName.TabIndex = 11;
            this.lblColName.Text = "Column Name:";
            // 
            // btnAAddColumn
            // 
            this.btnAAddColumn.Location = new System.Drawing.Point(233, 588);
            this.btnAAddColumn.Name = "btnAAddColumn";
            this.btnAAddColumn.Size = new System.Drawing.Size(75, 23);
            this.btnAAddColumn.TabIndex = 10;
            this.btnAAddColumn.Text = "Add Column";
            this.btnAAddColumn.UseVisualStyleBackColor = true;
            this.btnAAddColumn.Click += new System.EventHandler(this.BtnAAddColumn_Click);
            // 
            // lblRef
            // 
            this.lblRef.AutoSize = true;
            this.lblRef.Location = new System.Drawing.Point(114, 504);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(129, 13);
            this.lblRef.TabIndex = 9;
            this.lblRef.Text = "Reference Column Name ";
            // 
            // txtForeignColName
            // 
            this.txtForeignColName.Location = new System.Drawing.Point(272, 504);
            this.txtForeignColName.Name = "txtForeignColName";
            this.txtForeignColName.Size = new System.Drawing.Size(100, 20);
            this.txtForeignColName.TabIndex = 8;
            // 
            // cbForeignKey
            // 
            this.cbForeignKey.AutoSize = true;
            this.cbForeignKey.Location = new System.Drawing.Point(324, 281);
            this.cbForeignKey.Name = "cbForeignKey";
            this.cbForeignKey.Size = new System.Drawing.Size(82, 17);
            this.cbForeignKey.TabIndex = 7;
            this.cbForeignKey.Text = "Foreign Key";
            this.cbForeignKey.UseVisualStyleBackColor = true;
            this.cbForeignKey.CheckedChanged += new System.EventHandler(this.CbForeignKey_CheckedChanged);
            // 
            // cbNotNull
            // 
            this.cbNotNull.AutoSize = true;
            this.cbNotNull.Location = new System.Drawing.Point(324, 229);
            this.cbNotNull.Name = "cbNotNull";
            this.cbNotNull.Size = new System.Drawing.Size(64, 17);
            this.cbNotNull.TabIndex = 6;
            this.cbNotNull.Text = "Not Null";
            this.cbNotNull.UseVisualStyleBackColor = true;
            // 
            // cbPrimaryKey
            // 
            this.cbPrimaryKey.AutoSize = true;
            this.cbPrimaryKey.Location = new System.Drawing.Point(396, 67);
            this.cbPrimaryKey.Name = "cbPrimaryKey";
            this.cbPrimaryKey.Size = new System.Drawing.Size(81, 17);
            this.cbPrimaryKey.TabIndex = 5;
            this.cbPrimaryKey.Text = "Primary Key";
            this.cbPrimaryKey.UseVisualStyleBackColor = true;
            this.cbPrimaryKey.CheckedChanged += new System.EventHandler(this.CbPrimaryKey_CheckedChanged);
            // 
            // cbUnique
            // 
            this.cbUnique.AutoSize = true;
            this.cbUnique.Location = new System.Drawing.Point(206, 229);
            this.cbUnique.Name = "cbUnique";
            this.cbUnique.Size = new System.Drawing.Size(60, 17);
            this.cbUnique.TabIndex = 4;
            this.cbUnique.Text = "Unique";
            this.cbUnique.UseVisualStyleBackColor = true;
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(256, 137);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(100, 21);
            this.cbxType.TabIndex = 3;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.CbxType_SelectedIndexChanged);
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
            // txtColName
            // 
            this.txtColName.Location = new System.Drawing.Point(256, 75);
            this.txtColName.Name = "txtColName";
            this.txtColName.Size = new System.Drawing.Size(100, 20);
            this.txtColName.TabIndex = 1;
            // 
            // lblColumnDetails
            // 
            this.lblColumnDetails.AutoSize = true;
            this.lblColumnDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnDetails.Location = new System.Drawing.Point(188, 11);
            this.lblColumnDetails.Name = "lblColumnDetails";
            this.lblColumnDetails.Size = new System.Drawing.Size(150, 24);
            this.lblColumnDetails.TabIndex = 0;
            this.lblColumnDetails.Text = "Column Details";
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
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.Crimson;
            this.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceed.Location = new System.Drawing.Point(128, 504);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(91, 33);
            this.btnProceed.TabIndex = 12;
            this.btnProceed.Text = "Main Menu";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.BtnProceed_Click);
            // 
            // cbIdentity
            // 
            this.cbIdentity.AutoSize = true;
            this.cbIdentity.Location = new System.Drawing.Point(206, 281);
            this.cbIdentity.Name = "cbIdentity";
            this.cbIdentity.Size = new System.Drawing.Size(60, 17);
            this.cbIdentity.TabIndex = 16;
            this.cbIdentity.Text = "Identity";
            this.cbIdentity.UseVisualStyleBackColor = true;
            this.cbIdentity.CheckedChanged += new System.EventHandler(this.CbIdentity_CheckedChanged);
            // 
            // lblStartValue
            // 
            this.lblStartValue.AutoSize = true;
            this.lblStartValue.Location = new System.Drawing.Point(164, 376);
            this.lblStartValue.Name = "lblStartValue";
            this.lblStartValue.Size = new System.Drawing.Size(86, 13);
            this.lblStartValue.TabIndex = 17;
            this.lblStartValue.Text = "Start Identity On:";
            // 
            // lblIncrement
            // 
            this.lblIncrement.AutoSize = true;
            this.lblIncrement.Location = new System.Drawing.Point(171, 427);
            this.lblIncrement.Name = "lblIncrement";
            this.lblIncrement.Size = new System.Drawing.Size(72, 13);
            this.lblIncrement.TabIndex = 18;
            this.lblIncrement.Text = "Increment By:";
            // 
            // txtIncrementStartValue
            // 
            this.txtIncrementStartValue.Location = new System.Drawing.Point(256, 373);
            this.txtIncrementStartValue.Name = "txtIncrementStartValue";
            this.txtIncrementStartValue.Size = new System.Drawing.Size(100, 20);
            this.txtIncrementStartValue.TabIndex = 19;
            // 
            // txtIncrementValue
            // 
            this.txtIncrementValue.Location = new System.Drawing.Point(256, 427);
            this.txtIncrementValue.Name = "txtIncrementValue";
            this.txtIncrementValue.Size = new System.Drawing.Size(100, 20);
            this.txtIncrementValue.TabIndex = 20;
            // 
            // lblIndeityHeading
            // 
            this.lblIndeityHeading.AutoSize = true;
            this.lblIndeityHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndeityHeading.Location = new System.Drawing.Point(189, 334);
            this.lblIndeityHeading.Name = "lblIndeityHeading";
            this.lblIndeityHeading.Size = new System.Drawing.Size(118, 18);
            this.lblIndeityHeading.TabIndex = 21;
            this.lblIndeityHeading.Text = "Idnetity Details";
            // 
            // frmTableCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_3rdYearProject.Properties.Resources.Option1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1039, 735);
            this.Controls.Add(this.lblMainHeading);
            this.Controls.Add(this.pnlColumnDetails);
            this.Controls.Add(this.pnlColumns);
            this.Name = "frmTableCreation";
            this.Text = "TableCreation";
            this.Load += new System.EventHandler(this.FrmTableCreation_Load);
            this.pnlColumns.ResumeLayout(false);
            this.pnlColumns.PerformLayout();
            this.pnlColumnDetails.ResumeLayout(false);
            this.pnlColumnDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlColumns;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblColumnsHeading;
        private System.Windows.Forms.Button btnRemoveColumn;
        private System.Windows.Forms.ListBox lstColumns;
        private System.Windows.Forms.Panel pnlColumnDetails;
        private System.Windows.Forms.Label lblColName;
        private System.Windows.Forms.Button btnAAddColumn;
        private System.Windows.Forms.Label lblRef;
        private System.Windows.Forms.TextBox txtForeignColName;
        private System.Windows.Forms.CheckBox cbForeignKey;
        private System.Windows.Forms.CheckBox cbNotNull;
        private System.Windows.Forms.CheckBox cbPrimaryKey;
        private System.Windows.Forms.CheckBox cbUnique;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label lblColType;
        private System.Windows.Forms.TextBox txtColName;
        private System.Windows.Forms.Label lblColumnDetails;
        private System.Windows.Forms.Label lblMainHeading;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Label lblForeignHeading;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.TextBox txtForeignTable;
        private System.Windows.Forms.Label lblForeignTable;
        private System.Windows.Forms.TextBox txtIncrementValue;
        private System.Windows.Forms.TextBox txtIncrementStartValue;
        private System.Windows.Forms.Label lblIncrement;
        private System.Windows.Forms.Label lblStartValue;
        private System.Windows.Forms.CheckBox cbIdentity;
        private System.Windows.Forms.Label lblIndeityHeading;
    }
}