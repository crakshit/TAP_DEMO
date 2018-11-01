namespace DesktopApp1
{
    partial class Form2
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
            this.label21 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.pincode = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.shiftname = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.employeepost = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.employeetype = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.experienceyears = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.aadharnumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.bloodgroup = new System.Windows.Forms.TextBox();
            this.linkedinid = new System.Windows.Forms.TextBox();
            this.dateofbirth = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.middlename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iris = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(796, 262);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 13);
            this.label21.TabIndex = 82;
            this.label21.Text = "label21";
            this.label21.UseWaitCursor = true;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(466, 448);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 81;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.UseWaitCursor = true;
            this.submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(554, 422);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 13);
            this.label20.TabIndex = 80;
            this.label20.Text = "Iris Data:";
            this.label20.UseWaitCursor = true;
            // 
            // department
            // 
            this.department.FormattingEnabled = true;
            this.department.Items.AddRange(new object[] {
            "Sales",
            "Manufacturing",
            "Marketing",
            "Maintenance"});
            this.department.Location = new System.Drawing.Point(670, 385);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(100, 21);
            this.department.TabIndex = 79;
            this.department.UseWaitCursor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(554, 384);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 13);
            this.label19.TabIndex = 78;
            this.label19.Text = "Department:";
            this.label19.UseWaitCursor = true;
            // 
            // pincode
            // 
            this.pincode.Location = new System.Drawing.Point(670, 346);
            this.pincode.Name = "pincode";
            this.pincode.Size = new System.Drawing.Size(100, 20);
            this.pincode.TabIndex = 77;
            this.pincode.UseWaitCursor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(554, 346);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 76;
            this.label18.Text = "Pincode:";
            this.label18.UseWaitCursor = true;
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(670, 298);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(100, 20);
            this.salary.TabIndex = 75;
            this.salary.UseWaitCursor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(554, 301);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 13);
            this.label17.TabIndex = 74;
            this.label17.Text = "Salary:";
            this.label17.UseWaitCursor = true;
            // 
            // shiftname
            // 
            this.shiftname.FormattingEnabled = true;
            this.shiftname.Items.AddRange(new object[] {
            "Shift 1",
            "Shift 2",
            "Shift 3"});
            this.shiftname.Location = new System.Drawing.Point(670, 255);
            this.shiftname.Name = "shiftname";
            this.shiftname.Size = new System.Drawing.Size(100, 21);
            this.shiftname.TabIndex = 73;
            this.shiftname.UseWaitCursor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(554, 255);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 72;
            this.label16.Text = "Shift Name:";
            this.label16.UseWaitCursor = true;
            // 
            // employeepost
            // 
            this.employeepost.FormattingEnabled = true;
            this.employeepost.Items.AddRange(new object[] {
            "Employee",
            "Manager",
            "H.O.D"});
            this.employeepost.Location = new System.Drawing.Point(670, 218);
            this.employeepost.Name = "employeepost";
            this.employeepost.Size = new System.Drawing.Size(100, 21);
            this.employeepost.TabIndex = 71;
            this.employeepost.UseWaitCursor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(554, 218);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 13);
            this.label15.TabIndex = 70;
            this.label15.Text = "Employee Post:";
            this.label15.UseWaitCursor = true;
            // 
            // employeetype
            // 
            this.employeetype.FormattingEnabled = true;
            this.employeetype.Items.AddRange(new object[] {
            "Employee",
            "Manager",
            "H.O.D"});
            this.employeetype.Location = new System.Drawing.Point(670, 171);
            this.employeetype.Name = "employeetype";
            this.employeetype.Size = new System.Drawing.Size(100, 21);
            this.employeetype.TabIndex = 69;
            this.employeetype.UseWaitCursor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(554, 173);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 13);
            this.label14.TabIndex = 68;
            this.label14.Text = "Employee Type:";
            this.label14.UseWaitCursor = true;
            // 
            // experienceyears
            // 
            this.experienceyears.Location = new System.Drawing.Point(670, 133);
            this.experienceyears.Name = "experienceyears";
            this.experienceyears.Size = new System.Drawing.Size(100, 20);
            this.experienceyears.TabIndex = 67;
            this.experienceyears.UseWaitCursor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(554, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 13);
            this.label13.TabIndex = 66;
            this.label13.Text = "Experience Years:";
            this.label13.UseWaitCursor = true;
            // 
            // aadharnumber
            // 
            this.aadharnumber.Location = new System.Drawing.Point(670, 83);
            this.aadharnumber.Name = "aadharnumber";
            this.aadharnumber.Size = new System.Drawing.Size(100, 20);
            this.aadharnumber.TabIndex = 65;
            this.aadharnumber.UseWaitCursor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(554, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 64;
            this.label12.Text = "Aadhar Number:";
            this.label12.UseWaitCursor = true;
            // 
            // bloodgroup
            // 
            this.bloodgroup.Location = new System.Drawing.Point(252, 459);
            this.bloodgroup.Name = "bloodgroup";
            this.bloodgroup.Size = new System.Drawing.Size(100, 20);
            this.bloodgroup.TabIndex = 63;
            this.bloodgroup.UseWaitCursor = true;
            // 
            // linkedinid
            // 
            this.linkedinid.Location = new System.Drawing.Point(252, 419);
            this.linkedinid.Name = "linkedinid";
            this.linkedinid.Size = new System.Drawing.Size(100, 20);
            this.linkedinid.TabIndex = 62;
            this.linkedinid.UseWaitCursor = true;
            // 
            // dateofbirth
            // 
            this.dateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateofbirth.Location = new System.Drawing.Point(252, 378);
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.Size = new System.Drawing.Size(100, 20);
            this.dateofbirth.TabIndex = 61;
            this.dateofbirth.UseWaitCursor = true;
            this.dateofbirth.Value = new System.DateTime(2018, 10, 20, 14, 4, 34, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(111, 459);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 60;
            this.label11.Text = "Blood Group:";
            this.label11.UseWaitCursor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(111, 422);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "Linkedin Id:";
            this.label10.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(111, 384);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 58;
            this.label9.Text = "Date of Birth:";
            this.label9.UseWaitCursor = true;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(252, 339);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 20);
            this.email.TabIndex = 57;
            this.email.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(111, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Email:";
            this.label8.UseWaitCursor = true;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(252, 298);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(100, 20);
            this.phone.TabIndex = 55;
            this.phone.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Phone:";
            this.label7.UseWaitCursor = true;
            // 
            // state
            // 
            this.state.Location = new System.Drawing.Point(252, 255);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(100, 20);
            this.state.TabIndex = 53;
            this.state.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "State:";
            this.label6.UseWaitCursor = true;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(252, 215);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(100, 20);
            this.address.TabIndex = 51;
            this.address.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Address:";
            this.label5.UseWaitCursor = true;
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(252, 166);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(100, 20);
            this.lastname.TabIndex = 49;
            this.lastname.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Last Name:";
            this.label4.UseWaitCursor = true;
            // 
            // middlename
            // 
            this.middlename.Location = new System.Drawing.Point(252, 126);
            this.middlename.Name = "middlename";
            this.middlename.Size = new System.Drawing.Size(100, 20);
            this.middlename.TabIndex = 47;
            this.middlename.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Middle Name:";
            this.label3.UseWaitCursor = true;
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(252, 79);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(100, 20);
            this.firstname.TabIndex = 45;
            this.firstname.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "First Name:";
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Employee Details";
            this.label1.UseWaitCursor = true;
            // 
            // iris
            // 
            this.iris.Location = new System.Drawing.Point(671, 419);
            this.iris.Name = "iris";
            this.iris.Size = new System.Drawing.Size(100, 20);
            this.iris.TabIndex = 83;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 526);
            this.Controls.Add(this.iris);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.department);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.pincode);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.shiftname);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.employeepost);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.employeetype);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.experienceyears);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.aadharnumber);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.bloodgroup);
            this.Controls.Add(this.linkedinid);
            this.Controls.Add(this.dateofbirth);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.state);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.middlename);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Name = "Form2";
            this.Text = "Form2";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox department;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox pincode;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox shiftname;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox employeepost;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox employeetype;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox experienceyears;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox aadharnumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox bloodgroup;
        private System.Windows.Forms.TextBox linkedinid;
        private System.Windows.Forms.DateTimePicker dateofbirth;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox middlename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox iris;
    }
}