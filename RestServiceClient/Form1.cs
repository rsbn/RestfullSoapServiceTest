using ClientTester.ServiceReference;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClientTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RestServiceClient client = new RestServiceClient("BasicHttpBinding_IRestService");
            string text = client.GetStringUserName();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RestServiceClient client = new RestServiceClient("BasicHttpBinding_IRestService");
            string text = client.GetStringUserFullName("John", "Wayne");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // SOAP
            RestServiceClient client = new RestServiceClient("BasicHttpBinding_IRestService");
            var user = client.GetObjectUser("Chuck", "Noris");

            // JSON
            using (var jsonClient = new System.Net.WebClient())
            {
                var json = jsonClient.DownloadString("http://localhost:5000/json/GetObjectUser/John/Wayne");
                User userJson = JsonConvert.DeserializeObject<User>(json);
            }
        }
    }
}
