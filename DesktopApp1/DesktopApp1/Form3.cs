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
using Newtonsoft.Json;

namespace DesktopApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
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
        public static string fname;
        public static string myJson;
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




        private void submit_Click(object sender, EventArgs e)
        {
            myJson = Gett("http://localhost:8080/employee");
            //var emp = new List<Employee>();
            //var emp = JsonConvert.DeserializeObject<Employee>(myJson);

            List<Employee> emp = JsonConvert.DeserializeObject<List<Employee>>(myJson);
            /*foreach (var item in emp)
            {
                Console.WriteLine("Id :"+item.id+ " FirstName :"+item.FirstName);
            }*/
            dataGridView1.DataSource = emp;
        }
    }
}
