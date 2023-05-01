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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var payload = new Dictionary<string, string> { { "Usuario", control.user } };
            payload.Add("nombre", Nombre.Text);
            payload.Add("direccion", Direccion.Text);
            payload.Add("gerente", Gerente.Text);
            payload.Add("salas", Salas.Text);
            payload.Add("telefono", Telefono.Text);
            var jsonPayload = JsonConvert.SerializeObject(payload);

            var content = new StringContent(jsonPayload, System.Text.Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("http://20.90.72.41:5000/SeeLocal", content);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var datos = JsonConvert.DeserializeObject<Dictionary<string, JToken>>(json);
                label6.BackColor= Color.Red;
                label6.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Visible = false;
        }
    }
}
