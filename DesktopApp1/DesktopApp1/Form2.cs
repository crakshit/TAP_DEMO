using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;



namespace DesktopApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            dateofbirth.CustomFormat = "yyyy-MM-dd";
        }
        public class Employee
        {
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string LastName { get; set; }
            public string PhoneNumber { get; set; }
            public string DateOfBirth { get; set; }
            public string Address { get; set; }
            public string Pincode { get; set; }
            public string State { get; set; }
            public string Email { get; set; }
            public string LinkedinId { get; set; }
            public string BloodGroup { get; set; }
            public string AadharNumber { get; set; }
            public string ExperienceYears { get; set; }
            public string Department { get; set; }
            public string EmployeeType { get; set; }
            public string EmployeePost { get; set; }
            public string ShiftName { get; set; }
            public string Salary { get; set; }
            public byte[] IrisId { get; set; }
        }

        public static Employee emp = new Employee();
        public static string myJson;
        //public static string Firstname, Middlename, Lastname, Address, State, Phone, Email, DOB, Linkedin, Blood, Aadhar, Experience, Employeetype, Employeepost, Shiftname, Salary, Pincode, Department;

        private void Submit_Click(object sender, EventArgs e)
        {

            emp.FirstName = firstname.Text;
            emp.MiddleName = middlename.Text;
            emp.LastName = lastname.Text;
            emp.Address = address.Text;
            emp.State = state.Text;
            emp.PhoneNumber = phone.Text;
            emp.Email = email.Text;
            emp.DateOfBirth = dateofbirth.Text;
            emp.LinkedinId = linkedinid.Text;
            emp.BloodGroup = bloodgroup.Text;
            emp.AadharNumber = aadharnumber.Text;
            emp.ExperienceYears = experienceyears.Text;
            emp.EmployeeType = employeetype.Text;
            emp.EmployeePost = employeepost.Text;
            emp.ShiftName = shiftname.Text;
            emp.Salary = salary.Text;
            emp.Pincode = pincode.Text;
            emp.Department = department.Text;
            emp.IrisId = System.Text.Encoding.ASCII.GetBytes(iris.Text);



            label21.Text = emp.DateOfBirth;
            myJson = JsonConvert.SerializeObject(emp);


            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/employee");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {

                streamWriter.Write(myJson);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
            MessageBox.Show("Employee: "+emp.FirstName +" added.");
            this.Hide();
        }
    }
}
