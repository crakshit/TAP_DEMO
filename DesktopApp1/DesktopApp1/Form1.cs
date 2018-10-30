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
        Form2 Form2 = new Form2();

        private void add_Click(object sender, EventArgs e)
        {
            
                //Form2 Form2 = new Form2();
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

        Form5 Form5 = new Form5();
        private void viewshift_Click_1(object sender, EventArgs e)
        {
            //Form5 Form5 = new Form5();
            Form5.Show();
        }
    }
}
