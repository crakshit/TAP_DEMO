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
using TAP_DEMO;

namespace TAP_DEMO
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();

            myShift = Gett("http://localhost:8080/shift");
            shift = JsonConvert.DeserializeObject<List<Shift>>(myShift);
            mon.DataSource = shift;
            mon.DisplayMember = "id";

            myShift = Gett("http://localhost:8080/shift");
            shift = JsonConvert.DeserializeObject<List<Shift>>(myShift);
            tue.DataSource = shift;
            tue.DisplayMember = "id";

            myShift = Gett("http://localhost:8080/shift");
            shift = JsonConvert.DeserializeObject<List<Shift>>(myShift);
            wed.DataSource = shift;
            wed.DisplayMember = "id";

            myShift = Gett("http://localhost:8080/shift");
            shift = JsonConvert.DeserializeObject<List<Shift>>(myShift);
            thur.DataSource = shift;
            thur.DisplayMember = "id";

            myShift = Gett("http://localhost:8080/shift");
            shift = JsonConvert.DeserializeObject<List<Shift>>(myShift);
            fri.DataSource = shift;
            fri.DisplayMember = "id";

            myShift = Gett("http://localhost:8080/shift");
            shift = JsonConvert.DeserializeObject<List<Shift>>(myShift);
            sat.DataSource = shift;
            sat.DisplayMember = "id";

            myShift = Gett("http://localhost:8080/shift");
            shift = JsonConvert.DeserializeObject<List<Shift>>(myShift);
            sun.DataSource = shift;
            sun.DisplayMember = "id";

            myEmp = Gett("http://localhost:8080/employee");
            emp = JsonConvert.DeserializeObject<List<Employee>>(myEmp);

            empId.DataSource = emp;
            empId.DisplayMember = "id";
        }

        private string myShift;
        private string myEmp;


        List<Shift> shift;
        public class Shift
        {
            public string id { get; set; }
            public string ShiftName { get; set; }
            public string StartTime { get; set; }
            public string EndTime { get; set; }

        }
        List<Employee> emp;
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
            //public byte[] IrisId { get; set; }
        }
        public class ShiftPattern
        {
            public string EmployeeId { get; set; }
            public string Monday { get; set; }
            public string Tuesday { get; set; }
            public string Wednesday { get; set; }
            public string Thursday { get; set; }
            public string Friday { get; set; }
            public string Saturday { get; set; }
            public string Sunday { get; set; }
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

        public static ShiftPattern sp = new ShiftPattern();
        public static string myPattern;
        private void create_Click(object sender, EventArgs e)
        {
            sp.EmployeeId = (empId.SelectedIndex +1).ToString();
            sp.Monday = (mon.SelectedIndex +1).ToString();
            sp.Tuesday = (tue.SelectedIndex +1).ToString();
            sp.Wednesday = (wed.SelectedIndex +1).ToString();
            sp.Thursday = (thur.SelectedIndex +1).ToString();
            sp.Friday = (fri.SelectedIndex +1).ToString();
            sp.Saturday = (sat.SelectedIndex +1).ToString();
            sp.Sunday = (sun.SelectedIndex +1).ToString();

            myPattern = JsonConvert.SerializeObject(sp);
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/shiftPattern");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {

                streamWriter.Write(myPattern);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }
    }
}
