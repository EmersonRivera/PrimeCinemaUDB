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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
            HomeS homes = new HomeS();
            homes.Show();
            control.search_screen = false;
            control.home_screen = true;
            this.Close();
        }

        private void Search_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (control.search_screen) { 
                Application.Exit();
            }
        }

        private void setting(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.Show();
            control.setting_screen = true;
            control.search_screen = false;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            movie.Show();
            control.movie_screen = true;
            control.search_screen = false;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Profile profile= new Profile();
            profile.Show();
            control.profile_screen = true;
            control.search_screen = false;
            this.Close();
        }

        private void SearchTB_TextChanged(object sender, EventArgs e)
        {

        }

        private async void SearchB_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var httpClient = new HttpClient();

            var payload = new Dictionary<string, string> { { "word", SearchTB.Text } };
           // payload.Add("Movie", control.moment_image6);
            var jsonPayload = JsonConvert.SerializeObject(payload);

            var content = new StringContent(jsonPayload, System.Text.Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("http://20.90.72.41:5000/peliculas", content);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var datos = JsonConvert.DeserializeObject<Dictionary<string, JToken>>(json);
                var data = datos["dato"];
                int n = 10;
                int z = -1;
                int y = 1;
                for (int x =0; x < data.Count(); x++) 
                {
                    var real_data = data[x];
                    if (x != 0 && x % 4 == 0)
                    {
                        n += 275;
                        z = 0;
                        y ++;
                    }
                    else
                    {
                        z += 1;
                        
                    }
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Name = "pictureBox" + (1 + x).ToString();
                    pictureBox.Size = new Size(170, 255);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Location = new Point(z * 175, n);
                    pictureBox.BackColor = Color.White;
                    pictureBox.LoadAsync(real_data["image"].ToString()); // Carga la imagen de la URL en el PictureBox
                    pictureBox.Tag = real_data["image"].ToString(); // Asigna la URL como etiqueta del PictureBox
                    pictureBox.Click += new EventHandler(PictureBox_Click); // Asigna el evento Click al PictureBox
                    panel1.Controls.Add(pictureBox);
                    //label
                    Label label = new Label();
                    label.Name = "label" + x.ToString();
                    label.Text = real_data["nombre"].ToString();
                    label.AutoSize = true;

                    // Establecer la posición del label dentro del panel
                    label.Location = new Point(z* 175 , ((y)*275)-10);

                    // Agregar el label al panel1
                    panel1.Controls.Add(label);
                }
            }

        }
        private async void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            string url = pictureBox.Tag.ToString();
            var httpClient = new HttpClient();

            var payload = new Dictionary<string, string> { { "Usuario", control.user } };
            payload.Add("Movie", url);
            var jsonPayload = JsonConvert.SerializeObject(payload);

            var content = new StringContent(jsonPayload, System.Text.Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("http://20.90.72.41:5000/AskInformationMovie", content);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var datos = JsonConvert.DeserializeObject<Dictionary<string, JToken>>(json);
                control.movie_name = datos["Movie_name"].ToString();
                control.movie_image = datos["Image"].ToString();
                control.movie_category = datos["Category"].ToString();
                control.movie_time = datos["Time"].ToString();
                control.movie_views = datos["Views"].ToString();
            }
            Selec_Movie selec_movie = new Selec_Movie();
            selec_movie.ShowDialog();
        }

        private void SearchTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }    
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
