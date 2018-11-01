using Newtonsoft.Json;
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

namespace TAP_DEMO
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();

            allEmp = Gett("http://localhost:8080/employee");
            List<Employee> emp = JsonConvert.DeserializeObject<List<Employee>>(allEmp);

            empId.DataSource = emp;
            empId.DisplayMember = "id";
        }
        public static string allEmp;


        public class Employee
        {
            public int id { get; set; }
            public string joinedAt { get; set; }
            public string updateddAt { get; set; }
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
            public string IrisId { get; set; }
        }

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

        private void attendance_Click(object sender, EventArgs e)
        {
            var i = empId.SelectedIndex + 1;
            var Emp = Gett("http://localhost:8080/employee/" + i.ToString());

            Employee empl = JsonConvert.DeserializeObject<Employee>(Emp);
            var json = empl.IrisId;

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/attendance");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {

                streamWriter.Write("raj raj raj raj raj raj raj ");
            }
            
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
            label2.Text = empl.IrisId.ToString();
        }
    }
}
