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

namespace TAP_DEMO
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
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

        public static string mySP;
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

        private void view_Click(object sender, EventArgs e)
        {
            mySP = Gett("http://localhost:8080/shiftPattern");

            List<ShiftPattern> sp = JsonConvert.DeserializeObject<List<ShiftPattern>>(mySP);
            dataGridView1.DataSource = sp;
        }
    }
}
