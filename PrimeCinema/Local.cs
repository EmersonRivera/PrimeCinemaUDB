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
    public partial class Local : Form
    {
        public Local()
        {
            InitializeComponent();
        }

       

        private  async void Local_Load(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var payload = new Dictionary<string, string> { { "Usuario", control.user } };
            
            var jsonPayload = JsonConvert.SerializeObject(payload);

            var content = new StringContent(jsonPayload, System.Text.Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("http://20.90.72.41:5000/SeeLocal", content);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var datos = JsonConvert.DeserializeObject<Dictionary<string, JToken>>(json);
                var data = datos["Locales"];
                int t = 0, a=0, y =0, s=0;
                for (int x = 0; x < data.Count(); x++)
                {
                    if (x != 0 && x % 4 == 0) { a = 0; y += 140; s += 140; t = 0; }
                    else { t = 190 * a; }
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Name = $"Picturebox{x + 1}";
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Tag = data[$"Local{x + 1}"];
                    pictureBox.Location = new Point( 40+ t , 15 + y);   // Ubicamos cada PictureBox en una nueva fila
                    pictureBox.Size = new Size(100, 100);
                    pictureBox.LoadAsync("https://firebasestorage.googleapis.com/v0/b/primecinema-4e809.appspot.com/o/locales.png?alt=media&token=4cf56d17-8d5e-41b9-ad88-88308019a385");
                    pictureBox.Click += new EventHandler(PictureBox_Click);
                    this.Controls.Add(pictureBox);
                    Label label= new Label();
                    label.Name = $"label{x + 1}";
                    label.AutoSize= true;
                    label.Text = data[$"Local{x + 1}"].ToString();
                    label.Location = new Point(t + 35, 118+ s);
                    this.Controls.Add(label);
                    a++;

                }
            }
        }
        private async void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            control.name_local = pictureBox.Tag.ToString();
            Local_i local_I = new Local_i();
            local_I.Show();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Form1 form1form = new Form1();
            form1form.ShowDialog();
        }
    }
}
