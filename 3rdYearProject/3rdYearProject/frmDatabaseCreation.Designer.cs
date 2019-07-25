namespace _3rdYearProject
{
    partial class frmDatabaseCreation
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
            this.pnlDatabase = new System.Windows.Forms.Panel();
            this.btnFilePath = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtLogName = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.lblLogFile = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHead = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlDatabase.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDatabase
            // 
            this.pnlDatabase.BackColor = System.Drawing.Color.Crimson;
            this.pnlDatabase.Controls.Add(this.button1);
            this.pnlDatabase.Controls.Add(this.btnFilePath);
            this.pnlDatabase.Controls.Add(this.btnCreate);
            this.pnlDatabase.Controls.Add(this.txtLogName);
            this.pnlDatabase.Controls.Add(this.txtSize);
            this.pnlDatabase.Controls.Add(this.txtFile);
            this.pnlDatabase.Controls.Add(this.txtDBName);
            this.pnlDatabase.Controls.Add(this.lblLogFile);
            this.pnlDatabase.Controls.Add(this.lblSize);
            this.pnlDatabase.Controls.Add(this.lblFilePath);
            this.pnlDatabase.Controls.Add(this.lblName);
            this.pnlDatabase.Controls.Add(this.lblHead);
            this.pnlDatabase.Location = new System.Drawing.Point(299, 89);
            this.pnlDatabase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDatabase.Name = "pnlDatabase";
            this.pnlDatabase.Size = new System.Drawing.Size(680, 443);
            this.pnlDatabase.TabIndex = 0;
            // 
            // btnFilePath
            // 
            this.btnFilePath.Location = new System.Drawing.Point(377, 165);
            this.btnFilePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFilePath.Name = "btnFilePath";
            this.btnFilePath.Size = new System.Drawing.Size(100, 28);
            this.btnFilePath.TabIndex = 10;
            this.btnFilePath.Text = "Browse..";
            this.btnFilePath.UseVisualStyleBackColor = true;
            this.btnFilePath.Click += new System.EventHandler(this.BtnFilePath_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.Location = new System.Drawing.Point(287, 398);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 28);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // txtLogName
            // 
            this.txtLogName.Location = new System.Drawing.Point(220, 321);
            this.txtLogName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLogName.Name = "txtLogName";
            this.txtLogName.Size = new System.Drawing.Size(132, 22);
            this.txtLogName.TabIndex = 8;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(220, 247);
            this.txtSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(132, 22);
            this.txtSize.TabIndex = 7;
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(220, 169);
            this.txtFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(132, 22);
            this.txtFile.TabIndex = 6;
            // 
            // txtDBName
            // 
            this.txtDBName.Location = new System.Drawing.Point(220, 110);
            this.txtDBName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(132, 22);
            this.txtDBName.TabIndex = 5;
            // 
            // lblLogFile
            // 
            this.lblLogFile.AutoSize = true;
            this.lblLogFile.Location = new System.Drawing.Point(57, 321);
            this.lblLogFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogFile.Name = "lblLogFile";
            this.lblLogFile.Size = new System.Drawing.Size(103, 17);
            this.lblLogFile.TabIndex = 4;
            this.lblLogFile.Text = "Log File Name:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(85, 247);
            this.lblSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(75, 17);
            this.lblSize.TabIndex = 3;
            this.lblSize.Text = "Initial Size:";
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(93, 178);
            this.lblFilePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(67, 17);
            this.lblFilePath.TabIndex = 2;
            this.lblFilePath.Text = "File Path:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(45, 110);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(114, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Database Name:";
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.Location = new System.Drawing.Point(149, 0);
            this.lblHead.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(304, 31);
            this.lblHead.TabIndex = 0;
            this.lblHead.Text = "Create Your Database";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDatabaseCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_3rdYearProject.Properties.Resources.Option1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1211, 619);
            this.Controls.Add(this.pnlDatabase);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDatabaseCreation";
            this.Text = "DatabaseCreation";
            this.Load += new System.EventHandler(this.FrmDatabaseCreation_Load);
            this.pnlDatabase.ResumeLayout(false);
            this.pnlDatabase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDatabase;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtLogName;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.TextBox txtDBName;
        private System.Windows.Forms.Label lblLogFile;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Button btnFilePath;
        private System.Windows.Forms.Button button1;
    }
}