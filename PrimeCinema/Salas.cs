using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeCinema
{
    public partial class Salas : Form
    {
        public Salas()
        {
            InitializeComponent();
        }

        private async void Salas_Load(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();

            var payload = new Dictionary<string, string> { { "nombre", control.name_local } };
            var jsonPayload = JsonConvert.SerializeObject(payload);
            var content = new StringContent(jsonPayload, System.Text.Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("http://20.90.72.41:5000/n_salas", content);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var datos = JsonConvert.DeserializeObject<Dictionary<string, JToken>>(json);
                var data = datos["sala"].ToString();
                for (int i = 1; i < int.Parse(data)+1; i ++) {
                    Label label = new Label();
                    label.Name = "label" + i.ToString();
                    label.Location = new Point(50, i*25);
                    label.Font = new Font(label.Font.FontFamily, 12, FontStyle.Bold);
                    var payload1 = new Dictionary<string, string> { { "local", control.name_local } };
                    payload1.Add("sala", i.ToString());
                    var jsonPayload1 = JsonConvert.SerializeObject(payload1);

                    var content1 = new StringContent(jsonPayload1, System.Text.Encoding.UTF8, "application/json");
                    var response1 = await httpClient.PostAsync("http://20.90.72.41:5000/total_hall", content1);

                    if (response1.IsSuccessStatusCode)
                    {
                        var json1 = await response1.Content.ReadAsStringAsync();
                        var datos1 = JsonConvert.DeserializeObject<Dictionary<string, JToken>>(json1);
                        label.Text = $"Sala {i}: $" + datos1["total"];
                    }
                    label.AutoSize = true;
                    this.Controls.Add(label);
                }
            }
        }
    }
}
