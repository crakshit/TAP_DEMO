﻿namespace TAP_DEMO
{
    partial class Form11
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
            this.label1 = new System.Windows.Forms.Label();
            this.attendance = new System.Windows.Forms.Button();
            this.iris = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Employee Iris ID";
            // 
            // attendance
            // 
            this.attendance.Location = new System.Drawing.Point(113, 153);
            this.attendance.Name = "attendance";
            this.attendance.Size = new System.Drawing.Size(96, 37);
            this.attendance.TabIndex = 11;
            this.attendance.Text = "Take Attendance";
            this.attendance.UseVisualStyleBackColor = true;
            this.attendance.Click += new System.EventHandler(this.attendance_Click);
            // 
            // iris
            // 
            this.iris.Location = new System.Drawing.Point(162, 82);
            this.iris.Name = "iris";
            this.iris.Size = new System.Drawing.Size(100, 20);
            this.iris.TabIndex = 12;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 287);
            this.Controls.Add(this.iris);
            this.Controls.Add(this.attendance);
            this.Controls.Add(this.label1);
            this.Name = "Form11";
            this.Text = "Form11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button attendance;
        private System.Windows.Forms.TextBox iris;
    }
}