﻿namespace Latihan_POS
{
    partial class FormDelete
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
            this.Kode = new System.Windows.Forms.Label();
            this.txtKodeHapus = new System.Windows.Forms.TextBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.Jenis = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Kode
            // 
            this.Kode.AutoSize = true;
            this.Kode.Location = new System.Drawing.Point(54, 52);
            this.Kode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Kode.Name = "Kode";
            this.Kode.Size = new System.Drawing.Size(46, 20);
            this.Kode.TabIndex = 0;
            this.Kode.Text = "Kode";
            // 
            // txtKodeHapus
            // 
            this.txtKodeHapus.Location = new System.Drawing.Point(174, 42);
            this.txtKodeHapus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKodeHapus.Name = "txtKodeHapus";
            this.txtKodeHapus.Size = new System.Drawing.Size(210, 26);
            this.txtKodeHapus.TabIndex = 1;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(174, 161);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(212, 35);
            this.btnHapus.TabIndex = 2;
            this.btnHapus.Text = "Delete";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(174, 100);
            this.cmbType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(210, 28);
            this.cmbType.TabIndex = 3;
            // 
            // Jenis
            // 
            this.Jenis.AutoSize = true;
            this.Jenis.Location = new System.Drawing.Point(56, 112);
            this.Jenis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Jenis.Name = "Jenis";
            this.Jenis.Size = new System.Drawing.Size(43, 20);
            this.Jenis.TabIndex = 5;
            this.Jenis.Text = "Type";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(174, 206);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(212, 35);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 255);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.Jenis);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.txtKodeHapus);
            this.Controls.Add(this.Kode);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDelete";
            this.Text = "FormDelete";
            this.Load += new System.EventHandler(this.FormDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Kode;
        private System.Windows.Forms.TextBox txtKodeHapus;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label Jenis;
        private System.Windows.Forms.Button btnBack;
    }
}