namespace DesktopApp1
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
            this.head_label = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.viewall = new System.Windows.Forms.Button();
            this.addShift = new System.Windows.Forms.Button();
            this.viewshift = new System.Windows.Forms.Button();
            this.addShiftPattern = new System.Windows.Forms.Button();
            this.viewshiftpattern = new System.Windows.Forms.Button();
            this.viewAttendance = new System.Windows.Forms.Button();
            this.attendance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // head_label
            // 
            this.head_label.AutoEllipsis = true;
            this.head_label.AutoSize = true;
            this.head_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.head_label.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.head_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.head_label.Location = new System.Drawing.Point(374, 22);
            this.head_label.Name = "head_label";
            this.head_label.Size = new System.Drawing.Size(216, 32);
            this.head_label.TabIndex = 0;
            this.head_label.Text = "BIOMATIQUES";
            this.head_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.head_label.Click += new System.EventHandler(this.head_label_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(59, 98);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(206, 105);
            this.add.TabIndex = 1;
            this.add.Text = "Add an employee";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // viewall
            // 
            this.viewall.Location = new System.Drawing.Point(59, 228);
            this.viewall.Name = "viewall";
            this.viewall.Size = new System.Drawing.Size(206, 105);
            this.viewall.TabIndex = 2;
            this.viewall.Text = "View all employee";
            this.viewall.UseVisualStyleBackColor = true;
            this.viewall.Click += new System.EventHandler(this.viewall_Click);
            // 
            // addShift
            // 
            this.addShift.Location = new System.Drawing.Point(380, 98);
            this.addShift.Name = "addShift";
            this.addShift.Size = new System.Drawing.Size(206, 105);
            this.addShift.TabIndex = 3;
            this.addShift.Text = "Add new shift";
            this.addShift.UseVisualStyleBackColor = true;
            this.addShift.Click += new System.EventHandler(this.addShift_Click);
            // 
            // viewshift
            // 
            this.viewshift.Location = new System.Drawing.Point(380, 228);
            this.viewshift.Name = "viewshift";
            this.viewshift.Size = new System.Drawing.Size(206, 105);
            this.viewshift.TabIndex = 4;
            this.viewshift.Text = "View all shift";
            this.viewshift.UseVisualStyleBackColor = true;
            this.viewshift.Click += new System.EventHandler(this.viewshift_Click_1);
            // 
            // addShiftPattern
            // 
            this.addShiftPattern.Location = new System.Drawing.Point(677, 98);
            this.addShiftPattern.Name = "addShiftPattern";
            this.addShiftPattern.Size = new System.Drawing.Size(206, 105);
            this.addShiftPattern.TabIndex = 5;
            this.addShiftPattern.Text = "Add new shift pattern";
            this.addShiftPattern.UseVisualStyleBackColor = true;
            this.addShiftPattern.Click += new System.EventHandler(this.addShiftPattern_Click);
            // 
            // viewshiftpattern
            // 
            this.viewshiftpattern.Location = new System.Drawing.Point(677, 228);
            this.viewshiftpattern.Name = "viewshiftpattern";
            this.viewshiftpattern.Size = new System.Drawing.Size(206, 105);
            this.viewshiftpattern.TabIndex = 6;
            this.viewshiftpattern.Text = "View all shift pattern";
            this.viewshiftpattern.UseVisualStyleBackColor = true;
            this.viewshiftpattern.Click += new System.EventHandler(this.viewshiftpattern_Click);
            // 
            // viewAttendance
            // 
            this.viewAttendance.Location = new System.Drawing.Point(527, 367);
            this.viewAttendance.Name = "viewAttendance";
            this.viewAttendance.Size = new System.Drawing.Size(206, 105);
            this.viewAttendance.TabIndex = 7;
            this.viewAttendance.Text = "View all attendance";
            this.viewAttendance.UseVisualStyleBackColor = true;
            this.viewAttendance.Click += new System.EventHandler(this.viewAttendance_Click);
            // 
            // attendance
            // 
            this.attendance.Location = new System.Drawing.Point(220, 367);
            this.attendance.Name = "attendance";
            this.attendance.Size = new System.Drawing.Size(206, 105);
            this.attendance.TabIndex = 8;
            this.attendance.Text = "Attendance";
            this.attendance.UseVisualStyleBackColor = true;
            this.attendance.Click += new System.EventHandler(this.attendance_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 498);
            this.Controls.Add(this.attendance);
            this.Controls.Add(this.viewAttendance);
            this.Controls.Add(this.viewshiftpattern);
            this.Controls.Add(this.addShiftPattern);
            this.Controls.Add(this.viewshift);
            this.Controls.Add(this.addShift);
            this.Controls.Add(this.viewall);
            this.Controls.Add(this.add);
            this.Controls.Add(this.head_label);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label head_label;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button viewall;
        private System.Windows.Forms.Button addShift;
        private System.Windows.Forms.Button viewshift;
        private System.Windows.Forms.Button addShiftPattern;
        private System.Windows.Forms.Button viewshiftpattern;
        private System.Windows.Forms.Button viewAttendance;
        private System.Windows.Forms.Button attendance;
    }
}

