﻿namespace QuanLyKTX
{
    partial class ThongKeStudent
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
            this.rptStudents1 = new QuanLyKTX.rptStudents();
            this.rptStudents2 = new QuanLyKTX.rptStudents();
            this.rptStudents3 = new QuanLyKTX.rptStudents();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = 0;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer2.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.ReportSource = this.rptStudents1;
            this.crystalReportViewer2.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewer2.TabIndex = 0;
            this.crystalReportViewer2.Load += new System.EventHandler(this.crystalReportViewer2_Load_1);
            // 
            // ThongKeStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewer2);
            this.Name = "ThongKeStudent";
            this.Text = "ThongKeStudent";
            this.Load += new System.EventHandler(this.ThongKeStudent_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private rptStudents rptStudents1;
        private rptStudents rptStudents2;
        private rptStudents rptStudents3;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
    }
}