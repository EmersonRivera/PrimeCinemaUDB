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
using System.Runtime.CompilerServices;

namespace PrimeCinema
{
    public partial class Acept_All : Form
    {
        public Acept_All()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string j = Quantity.Text;
            j = j.Replace(" ", "");
            j = j.Replace("Quantity:", "");
            int a = int.Parse(j);
            var httpClient = new HttpClient();
            for (int i = 0; i < a; i++)
            {
                var payload = new Dictionary<string, string> { { "Usuario", control.user } };
                payload.Add("Movie", control.movie_name);
                var jsonPayload = JsonConvert.SerializeObject(payload);
                var content = new StringContent(jsonPayload, System.Text.Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync("http://20.90.72.41:5000/AddSales", content);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var datos = JsonConvert.DeserializeObject<Dictionary<string, JToken>>(json);
                }

            }
            int b = int.Parse(Quantity_A.Text);
            string y = Seats.Text;
            y = y.Replace(" ", "");
            y = y.Replace("Seats:", "");
            string p= "";

            List<string> seats_list = new List<string>();
            for (int k = 0; k < y.Length; k++)
            {   if (y[k].ToString() != ",")
                p += y[k].ToString();
                if (y[k].ToString() == "," || y.Length-1 == k) {
                    seats_list.Add(p);
                    p = "";
                } 
            }
            for (int z = 0; z < b; z++)
            {
                var data = new Dictionary<string, string> { { "Usuario", control.user } };
                data.Add("Asiento", seats_list[z].ToString());
                data.Add("Formato", Format.SelectedItem.ToString());
                data.Add("Edad", "Adultos");
                data.Add("Local", Local.Text);
                data.Add("Sala", Hall.Text);
                data.Add("Pelicula", Movie.Text);
                if (Format.SelectedItem.ToString() == "2D")
                {
                    data.Add("Precio", "$5");
                }
                else
                {
                    data.Add("Precio", "$6.55");
                }

                var jsonPayload = JsonConvert.SerializeObject(data);
                var content = new StringContent(jsonPayload, System.Text.Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync("http://20.90.72.41:5000/Sales", content);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var datos = JsonConvert.DeserializeObject<Dictionary<string, JToken>>(json);
                }
                //next
                var payload1 = new Dictionary<string, string> { { "Usuario", control.user } };
                payload1.Add("local", control.Locals.ToString());
                payload1.Add("hall", control.Halls.ToString());
                payload1.Add("seat", seats_list[z]);
                var jsonPayload1 = JsonConvert.SerializeObject(payload1);
                var content1 = new StringContent(jsonPayload1, System.Text.Encoding.UTF8, "application/json");
                var response1 = await httpClient.PostAsync("http://20.90.72.41:5000/update_seat", content1);
                if (response1.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var datos = JsonConvert.DeserializeObject<Dictionary<string, JToken>>(json);
                }

            }
            int w = int.Parse(Quantity_TA.Text);
            for (int n = 0; n < w; n++)
            {

                var data = new Dictionary<string, string> { { "Usuario", control.user } };
                data.Add("Asiento", seats_list[control.Count_AA-n-1]);
                data.Add("Formato", Format.SelectedItem.ToString());
                data.Add("Edad", "Tercera Edad");
                data.Add("Local", Local.Text);
                data.Add("Sala", Hall.Text);
                data.Add("Pelicula", Movie.Text);
                if (Format.SelectedItem.ToString() == "2D")
                {
                    data.Add("Precio", "$3.9");
                }
                else
                {
                    data.Add("Precio", "$5.6");
                }

                var jsonPayload = JsonConvert.SerializeObject(data);
                var content = new StringContent(jsonPayload, System.Text.Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync("http://20.90.72.41:5000/Sales", content);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var datos = JsonConvert.DeserializeObject<Dictionary<string, JToken>>(json);
                }




                var payload1 = new Dictionary<string, string> { { "Usuario", control.user } };
                payload1.Add("local", control.Locals.ToString());
                payload1.Add("hall", control.Halls.ToString());
                payload1.Add("seat", seats_list[control.Count_AA - n - 1]);
                var jsonPayload1 = JsonConvert.SerializeObject(payload1);
                var content1 = new StringContent(jsonPayload1, System.Text.Encoding.UTF8, "application/json");
                var response1 = await httpClient.PostAsync("http://20.90.72.41:5000/update_seat", content1);
                if (response1.IsSuccessStatusCode)
                {
                    var json = await response1.Content.ReadAsStringAsync();
                    var datos = JsonConvert.DeserializeObject<Dictionary<string, JToken>>(json);
                }

            }
            Accept accept = new Accept();
            accept.ShowDialog();
        }

        private void Acept_All_Load(object sender, EventArgs e)
        {
            Movie.Text = control.movie_name;
            Local.Text = control.Local_AA;
            Hall.Text = control.Sala_AA;
            Quantity_TA.Text = "0";
            Quantity_A.Text = "0";
            Total.Text = "0";
            Seats.Text = "";
            Seats.Text = "Seats: ";
            Format.Items.Add("2D");
            Format.Items.Add("3D");
            int count = 0;
            bool controlb = false;
            bool add = false;
            for (int x = 0; x < control.Seats_name.Length; x++)
            {

                if (control.Seats_name[x].ToString() == ",")
                { count++; }

                if (control.Seats_name[x].ToString() == "n" && controlb == false)
                {
                    add = true;
                    controlb = true;
                }

                if (control.Seats_name[x].ToString() == "," && controlb)
                {
                    add = false;
                    Seats.Text += ", ";
                    controlb = false;
                }
                if (add && control.Seats_name[x].ToString() != "n")
                { Seats.Text += control.Seats_name[x].ToString(); }
            }
            control.Count_AA = count;
            Quantity.Text = "Quantity: " + count.ToString();
        }

        private void Plus_TA_Click(object sender, EventArgs e)
        {
            if (Format.SelectedItem != null)
            {
                if (control.Count_General_AA < control.Count_AA)
                {
                    int quantity = int.Parse(Quantity_TA.Text);
                    quantity += 1;
                    Quantity_TA.Text = quantity.ToString();
                    control.Count_General_AA += 1;
                }
                if (Format.SelectedItem.ToString() == "2D")
                {
                    float price_A, price_TA, price;
                    price_A = 5 * float.Parse(Quantity_A.Text);
                    price_TA = float.Parse("3.90") * float.Parse(Quantity_TA.Text);
                    price = price_TA + price_A;
                    Total.Text = price.ToString();
                }
                if (Format.SelectedItem.ToString() == "3D")
                {
                    float price_A, price_TA, price;
                    price_A = float.Parse("6.55") * float.Parse(Quantity_A.Text);
                    price_TA = float.Parse("5.60") * float.Parse(Quantity_TA.Text);
                    price = price_TA + price_A;
                    Total.Text = price.ToString();
                }
            }
        }

        private void Less_TA_Click(object sender, EventArgs e)
        {
            if (Format.SelectedItem != null)
            {
                if (control.Count_General_AA > 0)
                {
                    int quantity = int.Parse(Quantity_TA.Text);
                    if (quantity.ToString() != "0")
                    {
                        quantity -= 1;
                        Quantity_TA.Text = quantity.ToString();
                        control.Count_General_AA -= 1;
                    }
                }
                if (Format.SelectedItem.ToString() == "2D")
                {
                    float price_A, price_TA, price;
                    price_A = 5 * float.Parse(Quantity_A.Text);
                    price_TA = float.Parse("3.90") * float.Parse(Quantity_TA.Text);
                    price = price_TA + price_A;
                    Total.Text = price.ToString();
                }
                if (Format.SelectedItem.ToString() == "3D")
                {
                    float price_A, price_TA, price;
                    price_A = float.Parse("6.55") * float.Parse(Quantity_A.Text);
                    price_TA = float.Parse("5.60") * float.Parse(Quantity_TA.Text);
                    price = price_TA + price_A;
                    Total.Text = price.ToString();
                }
            }
        }


        private void Plus_A_Click(object sender, EventArgs e)
        {
            if (Format.SelectedItem != null)
            {
                if (control.Count_General_AA < control.Count_AA)
                {
                    int quantity = int.Parse(Quantity_A.Text);
                    quantity += 1;
                    Quantity_A.Text = quantity.ToString();
                    control.Count_General_AA += 1;
                }
                if (Format.SelectedItem.ToString() == "2D")
                {
                    float price_A, price_TA, price;
                    price_A = 5 * float.Parse(Quantity_A.Text);
                    price_TA = float.Parse("3.90") * float.Parse(Quantity_TA.Text);
                    price = price_TA + price_A;
                    Total.Text = price.ToString();
                }
                if (Format.SelectedItem.ToString() == "3D")
                {
                    float price_A, price_TA, price;
                    price_A = float.Parse("6.55") * float.Parse(Quantity_A.Text);
                    price_TA = float.Parse("5.60") * float.Parse(Quantity_TA.Text);
                    price = price_TA + price_A;
                    Total.Text = price.ToString();
                }
            }
        }

        private void Less_A_Click(object sender, EventArgs e)
        {
            if (Format.SelectedItem != null)
            {
                if (control.Count_General_AA > 0)
                {
                    int quantity = int.Parse(Quantity_A.Text);
                    if (quantity.ToString() != "0")
                    {
                        quantity -= 1;
                        Quantity_A.Text = quantity.ToString();
                        control.Count_General_AA -= 1;
                    }
                }
                if (Format.SelectedItem.ToString() == "2D")
                {
                    float price_A, price_TA, price;
                    price_A = 5 * float.Parse(Quantity_A.Text);
                    price_TA = float.Parse("3.90") * float.Parse(Quantity_TA.Text);
                    price = price_TA + price_A;
                    Total.Text = price.ToString();
                }
                if (Format.SelectedItem.ToString() == "3D")
                {
                    float price_A, price_TA, price;
                    price_A = float.Parse("6.55") * float.Parse(Quantity_A.Text);
                    price_TA = float.Parse("5.60") * float.Parse(Quantity_TA.Text);
                    price = price_TA + price_A;
                    Total.Text = price.ToString();
                }

            }
        }

        private void Acept_All_FormClosed(object sender, FormClosedEventArgs e)
        {
            Movie.Text = "";
            Local.Text = "";
            Hall.Text = "";
            Seats.Text = "";
            Quantity.Text = "";
            Quantity_A.Text = "";
            Quantity_TA.Text = "";
            Total.Text = "";
            control.Seats_name = "";
            control.Count_AA = 0;
            control.Count_General_AA = 0;
        }
    }
    
}