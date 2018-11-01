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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public class Shift
        {
            public int id { get; set; }
            public string ShiftName { get; set; }
            public string StartTime { get; set; }
            public string EndTime { get; set; }

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


        public string myJson;

        private void viewshift_Click(object sender, EventArgs e)
        {
            myJson = Gett("http://localhost:8080/shift");
            //var emp = new List<Employee>();
            //var emp = JsonConvert.DeserializeObject<Employee>(myJson);

            List<Shift> shift = JsonConvert.DeserializeObject<List<Shift>>(myJson);
            
            dataGridView1.DataSource = shift;
        }

        
        private void update_Click(object sender, EventArgs e)
        {
            Form7 Form7 = new Form7();
            Form7.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string delURL = "http://localhost:8080/shift/" + (dataGridView1.CurrentCell.RowIndex + 1).ToString();

            WebRequest request = WebRequest.Create(delURL);
            request.Method = "DELETE";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        }
    }
}
