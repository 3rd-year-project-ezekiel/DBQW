namespace _3rdYearProject
{
    partial class frmSelectDataDisplay
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
            this.dgvDataDisplay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDataDisplay
            // 
            this.dgvDataDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataDisplay.Location = new System.Drawing.Point(0, 0);
            this.dgvDataDisplay.Name = "dgvDataDisplay";
            this.dgvDataDisplay.RowTemplate.Height = 24;
            this.dgvDataDisplay.Size = new System.Drawing.Size(800, 450);
            this.dgvDataDisplay.TabIndex = 0;
            // 
            // frmSelectDataDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDataDisplay);
            this.Name = "frmSelectDataDisplay";
            this.Text = "frmSelectDataDisplay";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDataDisplay;
    }
}