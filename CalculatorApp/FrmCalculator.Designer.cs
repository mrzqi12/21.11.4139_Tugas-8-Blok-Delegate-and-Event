﻿namespace CalculatorApp
{
    partial class FrmCalculator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstHasil = new System.Windows.Forms.ListBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstHasil);
            this.groupBox1.Location = new System.Drawing.Point(15, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(389, 274);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[ Hasil ]";
            // 
            // lstHasil
            // 
            this.lstHasil.FormattingEnabled = true;
            this.lstHasil.Location = new System.Drawing.Point(9, 16);
            this.lstHasil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstHasil.MultiColumn = true;
            this.lstHasil.Name = "lstHasil";
            this.lstHasil.Size = new System.Drawing.Size(371, 251);
            this.lstHasil.TabIndex = 0;
            this.lstHasil.SelectedIndexChanged += new System.EventHandler(this.lstHasil_SelectedIndexChanged);
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(15, 289);
            this.btnHitung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(389, 29);
            this.btnHitung.TabIndex = 1;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 326);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmCalculator";
            this.Text = "Hasil Perhitungan";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.ListBox lstHasil;
    }
}