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
    public partial class Local_i : Form
    {
        public Local_i()
        {
            InitializeComponent();
        }

        private async void Local_i_Load(object sender, EventArgs e)
        {
            Local.Text = control.name_local.ToString();
            var httpClient = new HttpClient();

            var payload = new Dictionary<string, string> { { "Usuario", control.user } };
            payload.Add("nombre", control.name_local);
            var jsonPayload = JsonConvert.SerializeObject(payload);

            var content = new StringContent(jsonPayload, System.Text.Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("http://20.90.72.41:5000/local_info", content);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var datos = JsonConvert.DeserializeObject<Dictionary<string, JToken>>(json);
                var dat = datos["dato"];
                var data = dat[0];
                Gerente.Text += data["Gerente"].ToString();
                Salas.Text += data["Salas"].ToString();
                Direction.Text += data["Direccion"].ToString();
                Telefono.Text += data["Telefono"].ToString();
            }
        }
    }
}
