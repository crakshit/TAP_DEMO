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
            this.SuspendLayout();
            // 
            // head_label
            // 
            this.head_label.AutoEllipsis = true;
            this.head_label.AutoSize = true;
            this.head_label.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.head_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.head_label.Location = new System.Drawing.Point(256, 24);
            this.head_label.Name = "head_label";
            this.head_label.Size = new System.Drawing.Size(216, 32);
            this.head_label.TabIndex = 0;
            this.head_label.Text = "BIOMATIQUES";
            this.head_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.head_label.Click += new System.EventHandler(this.head_label_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(77, 98);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(206, 105);
            this.add.TabIndex = 1;
            this.add.Text = "Add an employee";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // viewall
            // 
            this.viewall.Location = new System.Drawing.Point(400, 98);
            this.viewall.Name = "viewall";
            this.viewall.Size = new System.Drawing.Size(206, 105);
            this.viewall.TabIndex = 2;
            this.viewall.Text = "View all employee";
            this.viewall.UseVisualStyleBackColor = true;
            this.viewall.Click += new System.EventHandler(this.viewall_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 443);
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
    }
}

