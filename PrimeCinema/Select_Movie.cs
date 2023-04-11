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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrimeCinema
{
    public partial class Selec_Movie : Form
    {
        public Selec_Movie()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void Selec_Movie_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = control.movie_image;
            NameI.Text = control.movie_name;
            Category.Text = control.movie_category;
            Time.Text = control.movie_time;
            Views.Text = control.movie_views;

            var httpClient = new HttpClient();
            var payload = new Dictionary<string, string> { { "Usuario", control.user } };
            var jsonPayload = JsonConvert.SerializeObject(payload);
            var content = new StringContent(jsonPayload, System.Text.Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("http://20.90.72.41:5000/SeeLocal", content);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var datos = JsonConvert.DeserializeObject<Dictionary<string, JToken>>(json);
                var Locales = datos["Locales"];
                var local = (JObject)datos["Locales"];
                control.locales = local;
                var salas = (JObject)datos["Salas"];
                control.sala = salas;
                Locals.Items.Add($"{Locales["Local1"]}");
                Locals.Items.Add($"{Locales["Local2"]}");
                Locals.Items.Add($"{Locales["Local3"]}");
                Locals.Items.Add($"{Locales["Local4"]}");
                Locals.Items.Add($"{Locales["Local5"]}");
                Locals.Items.Add($"{Locales["Local6"]}");
                Locals.Items.Add($"{Locales["Local7"]}");
                
            }
        }

        private void Selec_Movie_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void ListLocals_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Locals_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hall.Items.Clear();
            if (Locals.SelectedItem.ToString() == control.locales["Local1"].ToString())
            {
                var a = control.sala["Local1"];
                int b = int.Parse(a.ToString());
                for (int x = 1; x < b + 1; x++)
                {
                    Hall.Items.Add($"Screen {x}");
                };
            }
            if (Locals.SelectedItem.ToString() == control.locales["Local2"].ToString())
            {
                var a = control.sala["Local2"];
                int b = int.Parse(a.ToString());
                for (int x = 1; x < b + 1; x++)
                {
                    Hall.Items.Add($"Screen {x}");
                };
            }
            if (Locals.SelectedItem.ToString() == control.locales["Local3"].ToString())
            {
                var a = control.sala["Local3"];
                int b = int.Parse(a.ToString());
                for (int x = 1; x < b + 1; x++)
                {
                    Hall.Items.Add($"Screen {x}");
                };

            }
            if (Locals.SelectedItem.ToString() == control.locales["Local4"].ToString())
            {
                var a = control.sala["Local4"];
                int b = int.Parse(a.ToString());
                for (int x = 1; x < b + 1; x++)
                {
                    Hall.Items.Add($"Screen {x}");
                };

            }
            if (Locals.SelectedItem.ToString() == control.locales["Local5"].ToString())
            {
                var a = control.sala["Local5"];
                int b = int.Parse(a.ToString());
                for (int x = 1; x < b + 1; x++)
                {
                    Hall.Items.Add($"Screen {x}");
                };

            }
            if (Locals.SelectedItem.ToString() == control.locales["Local6"].ToString())
            {
                var a = control.sala["Local6"];
                int b = int.Parse(a.ToString());
                for (int x = 1; x < b + 1; x++)
                {
                    Hall.Items.Add($"Screen {x}");
                };

            }
            if (Locals.SelectedItem.ToString() == control.locales["Local7"].ToString())
            {
                var a = control.sala["Local7"];
                int b = int.Parse(a.ToString());
                for (int x = 1; x < b + 1; x++)
                {
                    Hall.Items.Add($"Screen {x}");
                };

            }
        }

        private async void Next_Click(object sender, EventArgs e)
        {
            Choose_seats choose_Seats = new Choose_seats();
            string a = "", b= "";
            var httpClient = new HttpClient();
            var payload = new Dictionary<string, string> { { "Usuario", control.user } };
            for (int x = 1; x < 8; x++) {
                if (control.locales[$"Local{x}"].ToString() == Locals.SelectedItem.ToString()) {
                    a = x.ToString();
                    control.Locals = a;
                    int z = int.Parse(control.sala[$"Local{x}"].ToString());
                    for (int y = 1; y < z+1; y++)
                    {
                        string o = "Screen " + y.ToString();
                        if (o == Hall.SelectedItem.ToString())
                        {
                            b = y.ToString();
                            control.Halls = b;
                        }
                    }

                }
            }
        
            payload.Add("Local", a);
            payload.Add("Sala", b);
            var jsonPayload = JsonConvert.SerializeObject(payload);
            var content = new StringContent(jsonPayload, System.Text.Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("http://20.90.72.41:5000/Selectseat", content);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var datos = JsonConvert.DeserializeObject<Dictionary<string, JToken>>(json);
                var da = (JObject)datos["Butacas"];
                control.status_seats = da;
            }
            control.Sala_AA = Hall.SelectedItem.ToString();
            control.Local_AA = Locals.SelectedItem.ToString();
            choose_Seats.ShowDialog();
            control.movie_name_information = NameI.Text;
        }
    }
}
