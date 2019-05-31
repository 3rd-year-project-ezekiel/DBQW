namespace _3rdYearProject
{
    partial class Main
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.TopNavPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopNavPnl
            // 
            this.TopNavPnl.BackColor = System.Drawing.Color.Crimson;
            this.TopNavPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TopNavPnl.Controls.Add(this.btnNavMin);
            this.TopNavPnl.Controls.Add(this.btnNavClose);
            this.TopNavPnl.Location = new System.Drawing.Point(-3, -2);
            this.TopNavPnl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TopNavPnl.Name = "TopNavPnl";
            this.TopNavPnl.Size = new System.Drawing.Size(1072, 47);
            this.TopNavPnl.TabIndex = 0;
            this.TopNavPnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopNavPnl_MouseDown);
            // 
            // btnNavMin
            // 
            this.btnNavMin.BackColor = System.Drawing.Color.Crimson;
            this.btnNavMin.FlatAppearance.BorderSize = 0;
            this.btnNavMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavMin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNavMin.Location = new System.Drawing.Point(973, 9);
            this.btnNavMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNavMin.Name = "btnNavMin";
            this.btnNavMin.Size = new System.Drawing.Size(35, 28);
            this.btnNavMin.TabIndex = 3;
            this.btnNavMin.Text = "_";
            this.btnNavMin.UseVisualStyleBackColor = false;
            this.btnNavMin.Click += new System.EventHandler(this.btnNavMin_Click);
            // 
            // btnNavClose
            // 
            this.btnNavClose.BackColor = System.Drawing.Color.Crimson;
            this.btnNavClose.FlatAppearance.BorderSize = 0;
            this.btnNavClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavClose.Location = new System.Drawing.Point(1016, 9);
            this.btnNavClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNavClose.Name = "btnNavClose";
            this.btnNavClose.Size = new System.Drawing.Size(37, 28);
            this.btnNavClose.TabIndex = 2;
            this.btnNavClose.Text = "X";
            this.btnNavClose.UseVisualStyleBackColor = false;
            this.btnNavClose.Click += new System.EventHandler(this.btnNavClose_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "DataBase";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 373);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(944, 106);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(147, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(270, 318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 32);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_3rdYearProject.Properties.Resources.Option1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 507);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TopNavPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.Text = "Form2";
            this.TopNavPnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopNavPnl;
        private System.Windows.Forms.Button btnNavMin;
        private System.Windows.Forms.Button btnNavClose;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}