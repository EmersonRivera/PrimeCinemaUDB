using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Drawing;
using System.IO;

namespace PrimeCinema
{
    public partial class HomeS : Form
    {
        public HomeS()
        {
            InitializeComponent();
        }

        private void Setting_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.Show();
            control.home_screen = false;
            control.setting_screen = true;
            this.Close();
            
        }

        private void HomeS_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (control.home_screen)
            {
                Application.Exit();
            }
            control.images= true;
        }

        public  void HomeS_Load(object sender, EventArgs e)
        { 
            timer1.Interval = 100;
            timer1.Start();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
        }

        private void search_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
            control.home_screen = false;
            control.search_screen = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            control.profile_screen= true;
            control.home_screen= false;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            movie.Show();
            control.movie_screen = true;
            control.home_screen= false;
            this.Close();
        }

        public async void timer1_Tick(object sender, EventArgs e)
        {   
            if (control.images)
            {
                timer1.Interval = 8000;
                timer1.Start();
                control.images = false; }
            
            
            var httpClient = new HttpClient();

            var payload = new Dictionary<string, string>
    {
        { "Usuario", control.user } // Reemplaza "nombre_usuario" con el nombre del usuario que deseas consultar.
    };

            var jsonPayload = JsonConvert.SerializeObject(payload);
            var content = new StringContent(jsonPayload, System.Text.Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("http://20.90.72.41:5000/AskMovie", content);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var images = JsonConvert.DeserializeObject<Dictionary<string, JToken>>(json);

                pictureBox1.ImageLocation = images["textBox1"].ToString();
                control.moment_image1 = images["textBox1"].ToString();
                pictureBox2.ImageLocation = images["textBox2"].ToString();
                control.moment_image2 = images["textBox2"].ToString();
                pictureBox3.ImageLocation = images["textBox3"].ToString();
                control.moment_image3 = images["textBox3"].ToString();
                pictureBox4.ImageLocation = images["textBox4"].ToString();
                control.moment_image4 = images["textBox4"].ToString();
                pictureBox5.ImageLocation = images["textBox5"].ToString();
                control.moment_image5 = images["textBox5"].ToString();
                pictureBox6.ImageLocation = images["textBox6"].ToString();
                control.moment_image6 = images["textBox6"].ToString();
            }
            else
            {
                // Manejar el error de la solicitud.
            }

        }

        private  async void pictureBox1_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();

            var payload = new Dictionary<string, string> { { "Usuario", control.user } };
            payload.Add("Movie", control.moment_image1);
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

        private async void pictureBox2_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();

            var payload = new Dictionary<string, string> { { "Usuario", control.user } };
            payload.Add("Movie", control.moment_image2);
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

        private async void pictureBox3_Click_1(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var payload = new Dictionary<string, string> { { "Usuario", control.user } };
            payload.Add("Movie", control.moment_image3);
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

        private async void pictureBox4_Click_1(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();

            var payload = new Dictionary<string, string> { { "Usuario", control.user } };
            payload.Add("Movie", control.moment_image4);
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

        private async void pictureBox5_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();

            var payload = new Dictionary<string, string> { { "Usuario", control.user } };
            payload.Add("Movie", control.moment_image5);
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

        private async void pictureBox6_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();

            var payload = new Dictionary<string, string> { { "Usuario", control.user } };
            payload.Add("Movie", control.moment_image6);
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

        private void Locals_Click(object sender, EventArgs e)
        {
            Local local = new Local();
            local.Show();
        }
    }
    public class control
    {
        // para el control de las pantallas principales
        public static bool  home_screen = true;
        public static bool setting_screen = true;
        public static bool search_screen = true;
        public static bool movie_screen = true;
        public static bool profile_screen = true;
        public static bool images = true;
        public static bool images_control = false;
        //guarda el usuario que esta usando la app
        public static string user = "";
        //sirve para cargar la pantalla de selccion de imagenes, ya que no
        //esta definido y no se repiten
        public static string movie_name = "";
        public static string movie_image = "";
        public static string movie_category = "";
        public static string movie_time = "";
        public static string movie_views = "";
        //guarda una copia de las imagenes por si el usuario selecciona una 
        //imagen, se actualixa cada vez que las imagenes de HomeS se actualizan
        public static string moment_image1 = "";
        public static string moment_image2 = "";
        public static string moment_image3 = "";
        public static string moment_image4 = "";
        public static string moment_image5 = "";
        public static string moment_image6 = "";
        //Serviran para agregar los locales en el listboxt de Select_movie
        public static JObject sala;
        public static JObject locales;
        //servira para enviar el nombre de la pelicula para guardar las vistas
        public static string movie_name_information = "";
        //enviara los datos a la pantalla choose_seats
        public static JObject status_seats;
        //me ayudan a mostrar los datos de la pantalla acccept_all
        public static string Local_AA;
        public static string Sala_AA;
        public static string Seats_name;
        public static int Count_AA;
        public static int Count_General_AA;
        //local y sala para cambiar el true or false de los asientos
        public static string Locals;
        public static string Halls;
        //para ver la informacion de los locales
        public static string name_local;
    }
}
