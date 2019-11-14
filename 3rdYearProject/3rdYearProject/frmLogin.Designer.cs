namespace _3rdYearProject
{
    partial class frmLogin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TopNavPnl = new System.Windows.Forms.Panel();
            this.btnNavMin = new System.Windows.Forms.Button();
            this.btnNavClose = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.dropAuthentication = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TopNavPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::_3rdYearProject.Properties.Resources.BLoho;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 108);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // TopNavPnl
            // 
            this.TopNavPnl.BackColor = System.Drawing.Color.Crimson;
            this.TopNavPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TopNavPnl.Controls.Add(this.btnNavMin);
            this.TopNavPnl.Controls.Add(this.btnNavClose);
            this.TopNavPnl.Location = new System.Drawing.Point(-3, -5);
            this.TopNavPnl.Margin = new System.Windows.Forms.Padding(4);
            this.TopNavPnl.Name = "TopNavPnl";
            this.TopNavPnl.Size = new System.Drawing.Size(664, 47);
            this.TopNavPnl.TabIndex = 8;
            this.TopNavPnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopNavPnl_MouseDown);
            // 
            // btnNavMin
            // 
            this.btnNavMin.BackColor = System.Drawing.Color.Crimson;
            this.btnNavMin.FlatAppearance.BorderSize = 0;
            this.btnNavMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavMin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNavMin.Location = new System.Drawing.Point(573, 12);
            this.btnNavMin.Margin = new System.Windows.Forms.Padding(4);
            this.btnNavMin.Name = "btnNavMin";
            this.btnNavMin.Size = new System.Drawing.Size(35, 28);
            this.btnNavMin.TabIndex = 1;
            this.btnNavMin.Text = "_";
            this.btnNavMin.UseVisualStyleBackColor = false;
            this.btnNavMin.Click += new System.EventHandler(this.btnNavMin_Click);
            // 
            // btnNavClose
            // 
            this.btnNavClose.BackColor = System.Drawing.Color.Crimson;
            this.btnNavClose.FlatAppearance.BorderSize = 0;
            this.btnNavClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavClose.Location = new System.Drawing.Point(616, 12);
            this.btnNavClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnNavClose.Name = "btnNavClose";
            this.btnNavClose.Size = new System.Drawing.Size(37, 28);
            this.btnNavClose.TabIndex = 0;
            this.btnNavClose.Text = "X";
            this.btnNavClose.UseVisualStyleBackColor = false;
            this.btnNavClose.Click += new System.EventHandler(this.btnNavClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Server Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Authentication:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 273);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Login:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 305);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Password:";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(291, 208);
            this.txtServerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(260, 22);
            this.txtServerName.TabIndex = 24;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(291, 273);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(260, 22);
            this.txtLogin.TabIndex = 25;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(291, 305);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(260, 22);
            this.txtPassword.TabIndex = 26;
            // 
            // dropAuthentication
            // 
            this.dropAuthentication.FormattingEnabled = true;
            this.dropAuthentication.Location = new System.Drawing.Point(291, 240);
            this.dropAuthentication.Margin = new System.Windows.Forms.Padding(4);
            this.dropAuthentication.Name = "dropAuthentication";
            this.dropAuthentication.Size = new System.Drawing.Size(260, 24);
            this.dropAuthentication.TabIndex = 27;
            this.dropAuthentication.SelectedIndexChanged += new System.EventHandler(this.dropAuthentication_SelectedIndexChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(104, 380);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 28);
            this.btnConnect.TabIndex = 28;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(403, 380);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(291, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 22);
            this.textBox1.TabIndex = 30;
            this.textBox1.Text = "LAPTOP-Q6DPUL5L";
            this.textBox1.Visible = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_3rdYearProject.Properties.Resources.Option1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(667, 458);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.dropAuthentication);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TopNavPnl);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TopNavPnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel TopNavPnl;
        private System.Windows.Forms.Button btnNavMin;
        private System.Windows.Forms.Button btnNavClose;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox dropAuthentication;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBox1;
    }
}

