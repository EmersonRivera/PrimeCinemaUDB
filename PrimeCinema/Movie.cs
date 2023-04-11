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
    public partial class Movie : Form
    {
        public Movie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Setting setting= new Setting();
            setting.Show();
            control.setting_screen = true;
            control.movie_screen = false;
            this.Close();
        }

        private void Movie_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(control.movie_screen)
            {
                Application.Exit();
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            Search search= new Search();
            search.Show();
            control.search_screen = true;
            control.movie_screen = false;
            this.Close();
        }

        private void home_Click(object sender, EventArgs e)
        {
            HomeS homeS = new HomeS();
            homeS.Show();
            control.home_screen = true;
            control.movie_screen = false;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Profile profile= new Profile();
            profile.Show();
            control.profile_screen = true;
            control.movie_screen = false;
            this.Close();
        }

        private async void Movie_Load(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();

            var payload = new Dictionary<string, string> { { "Usuario", control.user } };
            payload.Add("Movie", control.moment_image6);
            var jsonPayload = JsonConvert.SerializeObject(payload);

            var content = new StringContent(jsonPayload, System.Text.Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("http://20.90.72.41:5000/all_movies", content);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var datos = JsonConvert.DeserializeObject<Dictionary<string, JToken>>(json);
                int n = 10;
                int z = -1;
                for (int i = 0; i < datos.Count; i++)
                {

                    if (i != 0 && i % 4 == 0)
                    {
                        n += 260;
                        z = 0;
                    }
                    else
                    {
                        z += 1;
                    }
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Name = "pictureBox" + (1 + i).ToString();
                    pictureBox.Size = new Size(170, 255);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Location = new Point(z * 175, n);
                    pictureBox.BackColor = Color.White;
                    pictureBox.LoadAsync(datos[$"{i + 1}"].ToString()); 
                    pictureBox.Tag = datos[$"{i + 1}"].ToString(); 
                    pictureBox.Click += new EventHandler(PictureBox_Click); 
                    panel1.Controls.Add(pictureBox);
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
    



        private void greeting_Click(object sender, EventArgs e)
        {

        }
    }
    
}
