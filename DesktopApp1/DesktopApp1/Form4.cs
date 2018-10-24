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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public class Shift
        {
            public string ShiftName { get; set; }
            public string StartTime { get; set; }
            public string EndTime { get; set; }

        }

        public static Shift shift = new Shift();
        public static string myJson;

        private void submit_Click(object sender, EventArgs e)
        {
            shift.ShiftName = shiftname.Text;
            shift.StartTime = starttime.Text;
            shift.EndTime = endtime.Text;

            myJson = JsonConvert.SerializeObject(shift);


            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/shift");
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
        }

    }
}   
