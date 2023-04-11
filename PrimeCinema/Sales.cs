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
using System.Reflection.Emit;

namespace PrimeCinema
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private async void Sales_Load(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            float total = 0;
            int cuenta = 0;
            for (int i = 1; i < 8; i++)
            {
                var a = this.Controls["label" + i.ToString()];
                var payload = new Dictionary<string, string> { { "local", a.Text.ToString() } };
                var jsonPayload = JsonConvert.SerializeObject(payload);
                var content = new StringContent(jsonPayload, System.Text.Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync("http://20.90.72.41:5000/local_sales", content);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var datos = JsonConvert.DeserializeObject<Dictionary<string, JToken>>(json);
                    a.Text = a.Text + ": $" + datos["total"].ToString();
                    total += float.Parse(datos["total"].ToString());
                }
            }
            Totals.Text += total.ToString();

            var payload1 = new Dictionary<string, string> { { "formato", "2D" } };
            var jsonPayload1 = JsonConvert.SerializeObject(payload1);
            var content1 = new StringContent(jsonPayload1, System.Text.Encoding.UTF8, "application/json");
            var response1 = await httpClient.PostAsync("http://20.90.72.41:5000/total_ticket", content1);

            if (response1.IsSuccessStatusCode)
            {
                var json = await response1.Content.ReadAsStringAsync();
                var datos = JsonConvert.DeserializeObject<Dictionary<string, JToken>>(json);
                A2D.Text += datos["adultos"].ToString();
                T2D.Text += datos["tercera_edad"].ToString();
                cuenta += int.Parse(datos["adultos"].ToString());
                cuenta += int.Parse(datos["tercera_edad"].ToString());
            }
            var payload2 = new Dictionary<string, string> { { "formato", "3D" } };
            var jsonPayload2 = JsonConvert.SerializeObject(payload2);
            var content2 = new StringContent(jsonPayload2, System.Text.Encoding.UTF8, "application/json");
            var response2 = await httpClient.PostAsync("http://20.90.72.41:5000/total_ticket", content2);

            if (response2.IsSuccessStatusCode)
            {
                var json = await response2.Content.ReadAsStringAsync();
                var datos = JsonConvert.DeserializeObject<Dictionary<string, JToken>>(json);
                A3D.Text += datos["adultos"].ToString();
                T3D.Text += datos["tercera_edad"].ToString();
                cuenta += int.Parse(datos["adultos"].ToString());
                cuenta += int.Parse(datos["tercera_edad"].ToString());
            }
            TotalT.Text+= cuenta;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            control.name_local = "";
            for (int i = 0; i < label1.Text.Length; i++) {
                if (label1.Text[i].ToString() == ":")
                {
                    break;
                }
                else
                {
                    control.name_local += label1.Text[i].ToString();
                }
            }
            Salas salas= new Salas();
            salas.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            control.name_local = "";
            for (int i = 0; i < label2.Text.Length; i++)
            {
                if (label2.Text[i].ToString() == ":")
                {
                    break;
                }
                else
                {
                    control.name_local += label2.Text[i].ToString();
                }
            }
            Salas salas = new Salas();
            salas.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            control.name_local = "";
            for (int i = 0; i < label3.Text.Length; i++)
            {
                if (label3.Text[i].ToString() == ":")
                {
                    break;
                }
                else
                {
                    control.name_local += label3.Text[i].ToString();
                }
            }
            Salas salas = new Salas();
            salas.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            control.name_local = "";
            for (int i = 0; i < label4.Text.Length; i++)
            {
                if (label4.Text[i].ToString() == ":")
                {
                    break;
                }
                else
                {
                    control.name_local += label4.Text[i].ToString();
                }
            }
            Salas salas = new Salas();
            salas.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            control.name_local = "";
            for (int i = 0; i < label5.Text.Length; i++)
            {
                if (label5.Text[i].ToString() == ":")
                {
                    break;
                }
                else
                {
                    control.name_local += label5.Text[i].ToString();
                }
            }
            Salas salas = new Salas();
            salas.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            control.name_local = "";
            for (int i = 0; i < label6.Text.Length; i++)
            {
                if (label6.Text[i].ToString() == ":")
                {
                    break;
                }
                else
                {
                    control.name_local += label6.Text[i].ToString();
                }
            }
            Salas salas = new Salas();
            salas.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            control.name_local = "";
            for (int i = 0; i < label7.Text.Length; i++)
            {
                if (label7.Text[i].ToString() == ":")
                {
                    break;
                }
                else
                {
                    control.name_local += label7.Text[i].ToString();
                }
            }
            Salas salas = new Salas();
            salas.Show();
        }
    }
}
