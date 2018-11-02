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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            
            myJson = Gett("http://localhost:8080/shift");
            
            shift = JsonConvert.DeserializeObject<List<Shift>>(myJson);

            shiftId.DataSource = shift;
            shiftId.DisplayMember = "id";
         
        }
        List<Shift> shift;
        public static string myJson;

        public class Shift
        {
            public string id { get; set; }
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

        public static Shift newshift = new Shift();
        private void submit_Click(object sender, EventArgs e)
        {
            newshift.id = (id+1).ToString();
            newshift.ShiftName = shiftname.Text;
            newshift.StartTime = starttime.Text;
            newshift.EndTime = endtime.Text;

            myJson = JsonConvert.SerializeObject(newshift);


            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/shift");
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

            MessageBox.Show("Shift: " +newshift.id +" updated.");
            this.Hide();
        }

        public static int id;
        private void index_Change(object sender, EventArgs e)
        {
            id = shiftId.SelectedIndex;

            shiftname.Text = shift[id].ShiftName;
            starttime.Text = shift[id].StartTime;
            endtime.Text = shift[id].EndTime;
        }
    }
}

