using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApp1;

namespace TAP_DEMO
{
    public partial class Form6 : Form
    {

        public class Employee
        {
            public string id { get; set; }
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

        Employee oldemp;
        public string oldJson;
        public Form6(string v)
        {
            InitializeComponent();
            dateofbirth.CustomFormat = "yyyy-MM-dd";

            oldJson = Gett("http://localhost:8080/employee/" + v);
            oldemp = JsonConvert.DeserializeObject<Employee>(oldJson);

            label22.Text = oldemp.id.ToString();
            firstname.Text = oldemp.FirstName;
            middlename.Text = oldemp.MiddleName;
            lastname.Text = oldemp.LastName;
            address.Text = oldemp.Address;
            state.Text = oldemp.State;
            phone.Text = oldemp.PhoneNumber;
            email.Text = oldemp.Email;
            dateofbirth.Text = oldemp.DateOfBirth;
            linkedinid.Text = oldemp.LinkedinId;
            bloodgroup.Text = oldemp.BloodGroup;
            aadharnumber.Text = oldemp.AadharNumber;
            experienceyears.Text = oldemp.ExperienceYears;
            employeetype.Text = oldemp.EmployeeType;
            employeepost.Text = oldemp.EmployeePost;
            shiftname.Text = oldemp.ShiftName;
            salary.Text = oldemp.Salary;
            pincode.Text = oldemp.Pincode;
            department.Text = oldemp.Department;
            //iris.Text = oldemp.IrisId.ToString();

        }

        public Form6()
        {
        }

        private static readonly HttpClient client = new HttpClient();
    

        public string Gett(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

//        public static Employee newemp = new Employee();
        public static string myJson;

        private void submit_Click(object sender, EventArgs e)
        {

            oldemp.id = oldemp.id;
            oldemp.FirstName = firstname.Text;
            oldemp.MiddleName = middlename.Text;
            oldemp.LastName = lastname.Text;
            oldemp.Address = address.Text;
            oldemp.State = state.Text;
            oldemp.PhoneNumber = phone.Text;
            oldemp.Email = email.Text;
            oldemp.DateOfBirth = dateofbirth.Text;
            oldemp.LinkedinId = linkedinid.Text;
            oldemp.BloodGroup = bloodgroup.Text;
            oldemp.AadharNumber = aadharnumber.Text;
            oldemp.ExperienceYears = experienceyears.Text;
            oldemp.EmployeeType = employeetype.Text;
            oldemp.EmployeePost = employeepost.Text;
            oldemp.ShiftName = shiftname.Text;
            oldemp.Salary = salary.Text;
            oldemp.Pincode = pincode.Text;
            oldemp.Department = department.Text;
            oldemp.IrisId = oldemp.IrisId;

            myJson = JsonConvert.SerializeObject(oldemp);


            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/employee");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "PUT";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {

                streamWriter.Write(myJson);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }

            MessageBox.Show("Employee: "+firstname.Text + " added.");
            this.Hide();
            

        }
    }
}


