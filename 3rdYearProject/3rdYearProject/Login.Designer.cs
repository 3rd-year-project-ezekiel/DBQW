namespace _3rdYearProject
{
    partial class Login
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TopNavPnl = new System.Windows.Forms.Panel();
            this.btnNavMin = new System.Windows.Forms.Button();
            this.btnNavClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TopNavPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(217, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(117, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(231, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(138, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Sign Up";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::_3rdYearProject.Properties.Resources.BLoho;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 88);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // TopNavPnl
            // 
            this.TopNavPnl.BackColor = System.Drawing.Color.Crimson;
            this.TopNavPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TopNavPnl.Controls.Add(this.btnNavMin);
            this.TopNavPnl.Controls.Add(this.btnNavClose);
            this.TopNavPnl.Location = new System.Drawing.Point(-2, -4);
            this.TopNavPnl.Name = "TopNavPnl";
            this.TopNavPnl.Size = new System.Drawing.Size(406, 38);
            this.TopNavPnl.TabIndex = 8;
            this.TopNavPnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopNavPnl_MouseDown);
            // 
            // btnNavMin
            // 
            this.btnNavMin.BackColor = System.Drawing.Color.Crimson;
            this.btnNavMin.FlatAppearance.BorderSize = 0;
            this.btnNavMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavMin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNavMin.Location = new System.Drawing.Point(335, 10);
            this.btnNavMin.Name = "btnNavMin";
            this.btnNavMin.Size = new System.Drawing.Size(26, 23);
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
            this.btnNavClose.Location = new System.Drawing.Point(367, 10);
            this.btnNavClose.Name = "btnNavClose";
            this.btnNavClose.Size = new System.Drawing.Size(28, 23);
            this.btnNavClose.TabIndex = 0;
            this.btnNavClose.Text = "X";
            this.btnNavClose.UseVisualStyleBackColor = false;
            this.btnNavClose.Click += new System.EventHandler(this.btnNavClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_3rdYearProject.Properties.Resources.Option1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(405, 307);
            this.ControlBox = false;
            this.Controls.Add(this.TopNavPnl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TopNavPnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel TopNavPnl;
        private System.Windows.Forms.Button btnNavMin;
        private System.Windows.Forms.Button btnNavClose;
    }
}

