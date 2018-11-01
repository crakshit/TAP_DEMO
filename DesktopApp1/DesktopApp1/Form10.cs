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

namespace TAP_DEMO
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
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

        public class Empl
        {
            public int id { get; set; }
            public string attendedDate { get; set; }
            public int employeeId { get; set; }
            public string employeeFirstName { get; set; }
            public string employeeLastName { get; set; }
        }

        
        public string myjson;
        private void view_Click(object sender, EventArgs e)
        {
            string str = string.Format("yyyy-MM-dd");
            string date = dateTimePicker1.Value.ToString(str);

            myjson = Gett("http://localhost:8080/attendance/attended_date/"+date);

            

            List <Empl> emp = JsonConvert.DeserializeObject<List<Empl>>(myjson);
            
            dataGridView1.DataSource = emp;
        }
    }
}
