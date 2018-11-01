using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TAP_DEMO;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace DesktopApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void head_label_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You will be redirect to \"www.biomatiques.com\". ");

            System.Diagnostics.Process.Start("http://www.biomatiques.com");

        }
        //Form2 Form2 = new Form2();

        private void add_Click(object sender, EventArgs e)
        {
            
                Form2 Form2 = new Form2();
                Form2.Show();
            //Form2 Form2 = new Form2();
            //if(Form2.)
            //Form2.Activate();
            
        }

        Form3 Form3 = new Form3();
        private void viewall_Click(object sender, EventArgs e)
        {
            //Form3 Form3 = new Form3();
            Form3.Show();
        }

        Form4 Form4 = new Form4();
        private void addShift_Click(object sender, EventArgs e)
        {
            //Form4 Form4 = new Form4();
            Form4.Show();
        }

        
        private void viewshift_Click_1(object sender, EventArgs e)
        {
            Form5 Form5 = new Form5();
            Form5.Show();
        }

        private void addShiftPattern_Click(object sender, EventArgs e)
        {
            Form8 Form8 = new Form8();
            Form8.Show();
        }

        private void viewshiftpattern_Click(object sender, EventArgs e)
        {
            Form9 Form9 = new Form9();
            Form9.Show();
        }

        private void viewAttendance_Click(object sender, EventArgs e)
        {
            Form10 Form10 = new Form10();
            Form10.Show();
        }

        private void attendance_Click(object sender, EventArgs e)
        {
            Form11 Form11 = new Form11();
            Form11.Show();
        }
    }
}
