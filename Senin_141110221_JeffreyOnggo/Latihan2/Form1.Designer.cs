namespace Latihan2
{
    partial class Form1
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
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.nudBulan = new System.Windows.Forms.NumericUpDown();
            this.nudTanggal = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudBulan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTanggal)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.BoldedDates = new System.DateTime[] {
        new System.DateTime(2016, 7, 24, 0, 0, 0, 0)};
            this.monthCalendar.CalendarDimensions = new System.Drawing.Size(3, 3);
            this.monthCalendar.Location = new System.Drawing.Point(96, 85);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(14);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ScrollChange = 4;
            this.monthCalendar.TabIndex = 9;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(577, 32);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(112, 35);
            this.btnHapus.TabIndex = 8;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(456, 32);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(112, 35);
            this.btnTambah.TabIndex = 7;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            // 
            // nudBulan
            // 
            this.nudBulan.Location = new System.Drawing.Point(266, 36);
            this.nudBulan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudBulan.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudBulan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBulan.Name = "nudBulan";
            this.nudBulan.Size = new System.Drawing.Size(180, 26);
            this.nudBulan.TabIndex = 6;
            this.nudBulan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudTanggal
            // 
            this.nudTanggal.Location = new System.Drawing.Point(181, 36);
            this.nudTanggal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudTanggal.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudTanggal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTanggal.Name = "nudTanggal";
            this.nudTanggal.Size = new System.Drawing.Size(76, 26);
            this.nudTanggal.TabIndex = 5;
            this.nudTanggal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 672);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.nudBulan);
            this.Controls.Add(this.nudTanggal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBulan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTanggal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.NumericUpDown nudBulan;
        private System.Windows.Forms.NumericUpDown nudTanggal;
    }
}

