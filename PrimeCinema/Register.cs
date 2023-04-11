using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PrimeCinema.Login;

namespace PrimeCinema
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void User_TextChanged(object sender, EventArgs e)
        {
            if (regis.Name == true && Names.Text.Length == Names.Text.Length)
            {
                Names.Text = "";
                regis.Name = false;
            }
            if (Names.Text == "" && regis.Name == true)
            {
                regis.Name = false;
            }
        }

        private void User_TextChanged_1(object sender, EventArgs e)
        {
            if (regis.Lname == true && LastNames.Text.Length == LastNames.Text.Length)
            {
                LastNames.Text = "";
                regis.Lname = false;
            }
            if (LastNames.Text == "" && regis.Lname == true)
            {
                regis.Lname = false;
            }
        }

        private  void label1_Click(object sender, EventArgs e)
        {

        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool a = PasswordR1.Text.Contains('\n') || PasswordR1.Text.Contains('\r');

            if (regis.Password1 == true && PasswordR1.Text.Length == PasswordR1.Text.Length)
            {
                PasswordR1.Text = "";
                regis.Password1 = false;
                PasswordR1.PasswordChar = '*';
            }
            if (a)
            {
                PasswordR1.TextChanged -= textBox1_TextChanged; // Desactivar evento TextChanged
                PasswordR1.Text = PasswordR1.Text.Replace("\n", "");
                PasswordR1.Text = PasswordR1.Text.Replace("\r", "");
                using (var client = new HttpClient())
                {
                    var user = new User()
                    {
                        Usuario = UserR.Text,
                        Password1 = PasswordR1.Text,
                        Password2 = PasswordR2.Text,
                        Apellidos = LastNames.Text,
                        Correo = Email.Text,
                        Dui = DUI.Text,
                        Nombres = Names.Text,
                        Telefono = Phone.Text
                    };

                    var json = JsonConvert.SerializeObject(user);
                    var data = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                    var response = await client.PostAsync("http://20.90.72.41:5000/Register", data);

                    var result = await response.Content.ReadAsStringAsync();

                    var responseJson = JsonConvert.DeserializeObject<dynamic>(result);
                    bool status1 = (bool)responseJson.Status1;
                    bool status2 = (bool)responseJson.Status2;
                    bool status3 = (bool)responseJson.Status3;

                    if (status1== true && status2 == true && status3== true)
                    {
                        HomeS homes = new HomeS();
                        homes.Show();
                        MiClase.s = false;
                        control.user = UserR.Text;
                        this.Hide();
                    }
                    if (status1 == true && status2 == false && status3 == false)
                    {
                        error.Text = "This User already exist";
                        error.Visible = true;
                    }
                    if (status1 == true && status2 == true && status3 == false)
                    {
                        error.Text = "This Dui already exist";
                        error.Visible = true;
                    }
                    if (status1 == false && status2 == true && status3 == false)
                    {
                        error.Text = "This Phone already exist";
                        error.Visible = true;
                    }
                    if (status1 == false && status2 == true && status3 == true)
                    {
                        error.Text = "This Email already exist";
                        error.Visible = true;
                    }
                    if (status1 == false && status2 == false && status3 == false)
                    {
                        error.Text = "The passwords are different";
                        error.Visible = true;
                    }
                    if (status1 == true && status2 == false && status3 == true)
                    {
                        error.Text = "has ocurred an error";
                        error.Visible = true;
                    }
                    PasswordR1.TextChanged += textBox1_TextChanged;
                }
            }
            
            if (PasswordR1.Text == "" && regis.Password1 == true)
            {
                regis.Password1 = false;
                PasswordR1.PasswordChar = '*';
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (regis.User == true && UserR.Text.Length == UserR.Text.Length)
            {
                UserR.Text = "";
                regis.User = false;
            }
            if (UserR.Text == "" && regis.User == true)
            {
                regis.User = false;
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {   
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Home home = new Home();
            home.Show();
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            if (regis.email1 == true && Email.Text.Length == Email.Text.Length)
            {
                Email.Text = "";
                regis.email1 = false;
            }
            if (Email.Text == "" && regis.email1 == true)
            {
                regis.email1 = false;
            }
        }

        private void DUI_TextChanged(object sender, EventArgs e)
        {
            if (regis.Dui1 == true && DUI.Text.Length == DUI.Text.Length)
            {
                DUI.Text = "";
                regis.Dui1 = false;
            }
            if (DUI.Text == "" && regis.Dui1 == true)
            {
                regis.Dui1 = false;
            }
            
        }

        private void Phone_TextChanged(object sender, EventArgs e)
        {
            if (regis.phone1 == true && Phone.Text.Length == Phone.Text.Length)
            {
                Phone.Text = "";
                regis.phone1 = false;
            }
            if (Phone.Text == "" && regis.phone1 == true)
            {
                regis.phone1 = false;
            }
        }

        private async void PasswordR2_TextChanged(object sender, EventArgs e)
        {
            bool a = PasswordR2.Text.Contains('\n') || PasswordR2.Text.Contains('\r');

            if (regis.Password2 == true && PasswordR2.Text.Length == PasswordR2.Text.Length)
            {
                PasswordR2.Text = "";
                regis.Password2 = false;
                PasswordR2.PasswordChar = '*';
            }
            if (PasswordR2.Text == "" && regis.Password2 == true)
            {
                regis.Password2 = false;
                PasswordR2.PasswordChar = '*';
            }
            if (a)
            {
                PasswordR2.TextChanged -= PasswordR2_TextChanged; // Desactivar evento TextChanged
                PasswordR2.Text = PasswordR2.Text.Replace("\n", "");
                PasswordR2.Text = PasswordR2.Text.Replace("\r", "");
                using (var client = new HttpClient())
                {
                    var user = new User()
                    {
                        Usuario = UserR.Text,
                        Password1 = PasswordR1.Text,
                        Password2 = PasswordR2.Text,
                        Apellidos = LastNames.Text,
                        Correo = Email.Text,
                        Dui = DUI.Text,
                        Nombres = Names.Text,
                        Telefono = Phone.Text
                    };

                    var json = JsonConvert.SerializeObject(user);
                    var data = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                    var response = await client.PostAsync("http://20.90.72.41:5000/Register", data);

                    var result = await response.Content.ReadAsStringAsync();

                    var responseJson = JsonConvert.DeserializeObject<dynamic>(result);
                    bool status1 = (bool)responseJson.Status1;
                    bool status2 = (bool)responseJson.Status2;
                    bool status3 = (bool)responseJson.Status3;

                    if (status1 == true && status2 == true && status3 == true)
                    {
                        HomeS homes = new HomeS();
                        homes.Show();
                        MiClase.s = false;
                        control.user = UserR.Text;
                        var httpClient = new HttpClient();

                        var payload = new Dictionary<string, string> { { "Usuario", control.user } };

                        var jsonPayload = JsonConvert.SerializeObject(payload);
                        var content = new StringContent(jsonPayload, System.Text.Encoding.UTF8, "application/json");

                        var response1 = await httpClient.PostAsync("http://20.90.72.41:5000/AskMovie", content);

                        if (response1.IsSuccessStatusCode)
                        {
                            var json1 = await response1.Content.ReadAsStringAsync();
                            var images = JsonConvert.DeserializeObject<Dictionary<string, JToken>>(json1);

                            control.moment_image1 = images["textBox1"].ToString();
                            control.moment_image2 = images["textBox2"].ToString();
                            control.moment_image3 = images["textBox3"].ToString();
                            control.moment_image4 = images["textBox4"].ToString();
                            control.moment_image5 = images["textBox5"].ToString();
                            control.moment_image6 = images["textBox6"].ToString();
                        }
                        this.Close();
                    }
                    if (status1 == true && status2 == false && status3 == false)
                    {
                        error.Text = "This User already exist";
                        error.Visible = true;
                    }
                    if (status1 == true && status2 == true && status3 == false)
                    {
                        error.Text = "This Dui already exist";
                        error.Visible = true;
                    }
                    if (status1 == false && status2 == true && status3 == false)
                    {
                        error.Text = "This Phone already exist";
                        error.Visible = true;
                    }
                    if (status1 == false && status2 == true && status3 == true)
                    {
                        error.Text = "This Email already exist";
                        error.Visible = true;
                    }
                    if (status1 == false && status2 == false && status3 == false)
                    {
                        error.Text = "The passwords are different";
                        error.Visible = true;
                    }
                    if (status1 == true && status2 == false && status3 == true)
                    {
                        error.Text = "has ocurred an error";
                        error.Visible = true;
                    }
                    PasswordR2.TextChanged += PasswordR2_TextChanged;
                }
            }

            
        }

        private void GoToLogin_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Show();
            this.Hide();
        }

        private void ShowPassword_Click(object sender, EventArgs e)
        {
            ShowPassword.Visible = false;
            ShowPassword.Location = new Point(345, 303);
            Hide1.Location = new Point(602, 264);
            Hide1.Visible = true;
            PasswordR1.UseSystemPasswordChar = true;
            PasswordR2.UseSystemPasswordChar = true;
        }

        private void Hide1_Click(object sender, EventArgs e)
        {
            Hide1.Visible = false;
            Hide1.Location = new Point(345, 303);
            ShowPassword.Location = new Point(602, 264);
            ShowPassword.Visible = true;
            PasswordR1.UseSystemPasswordChar = false;
            PasswordR2.UseSystemPasswordChar = false;
        }

        private void error_Click(object sender, EventArgs e)
        {

        }

        private void DUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Bloquear el ingreso de la tecla en el control
                e.Handled = true;
            }
        }

        private void Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Bloquear el ingreso de la tecla en el control
                e.Handled = true;
            }
        }

        private void UserR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '_' && e.KeyChar != '\b')
            {
                // Bloquear el ingreso de la tecla en el control
                e.Handled = true;
            }
        }

        private void Names_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
            {
                // Bloquear el ingreso de la tecla en el control
                e.Handled = true;
            }
        }

        private void LastNames_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
            {
                // Bloquear el ingreso de la tecla en el control
                e.Handled = true;
            }
        }

        private void Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '_' && e.KeyChar != '@' && e.KeyChar != '\b')
            {
                // Bloquear el ingreso de la tecla en el control
                e.Handled = true;
            }
        }
    }
    public class regis
    {
        public static bool Name = true;
        public static bool Lname = true;
        public static bool email1 = true;
        public static bool User = true;
        public static bool Dui1 = true;
        public static bool phone1 = true;
        public static bool Password1 = true;
        public static bool Password2 = true;
    }
}

class User
{
    public string Usuario { get; set; }
    public string Password1 { get; set; }
    public string Password2 { get; set; }
    public string Apellidos { get; set; }
    public string Correo { get; set; }
    public string Dui { get; set; }
    public string Nombres { get; set; }
    public string Telefono { get; set; }
}
