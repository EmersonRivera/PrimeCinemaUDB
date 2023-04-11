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
using RestSharp.Authenticators;
using RestSharp.Extensions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace PrimeCinema
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private async void Password_TextChanged(object sender, EventArgs e)
        {
            bool a = Password.Text.Contains('\n') || Password.Text.Contains('\r');
            if (Password.Text == "")
            {
                MiClase.m = "false";
            }
            if (MiClase.m == "true" && Password.Text.Length == Password.Text.Length)
            {
                Password.Text = "";
                MiClase.m = "false";
            }
            if (a)
            {
                Password.TextChanged -= Password_TextChanged; // Desactivar evento TextChanged
                Password.Text = Password.Text.Replace("\n", "");
                Password.Text = Password.Text.Replace("\r", "");
                bool resultado = await Conection.Conect_login(UserL.Text, Password.Text);
                if (resultado)
                {
                    
                    HomeS homeS = new HomeS();
                    homeS.Show();
                    MiClase.s = false;
                    control.user = UserL.Text;
                    this.Close();
                }
                else
                {
                    incorrect.Visible = true;
                    Password.Text = "";
                }
                Password.TextChanged += Password_TextChanged; // Volver a activar evento TextChanged
            }
            if (Password.Text == "Password")
            {
                Password.Text = "";
            }
            else
            {
                Password.PasswordChar = '*';
            }
        }

        private void User_TextChanged(object sender, EventArgs e)
        {
            if (MiClase.n == "true" && UserL.Text.Length == UserL.Text.Length)
            {
                UserL.Text = "";
                MiClase.n = "false";

            }
            if (UserL.Text == "")
            {
                MiClase.n = "false";
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MiClase.s)
            {
                Home home = new Home();
                home.Show();
            }

        }

        

        

        private void GoToPassword_Click(object sender, EventArgs e)
        {

        }

        private void GoToRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void ShowPassword_Click(object sender, EventArgs e)
        {
            ShowPassword.Visible = false;
            ShowPassword.Location = new Point(445, 197);
            Hide1.Location = new Point(381, 194);
            Hide1.Visible = true;
            Password.UseSystemPasswordChar = true;
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            Hide1.Visible = false;
            Hide1.Location = new Point(445, 197);
            ShowPassword.Location = new Point(381, 194);
            ShowPassword.Visible = true;
            Password.UseSystemPasswordChar = false;
        }

        
        public class MiClase
        {
            public static string m = "true";
            public static string n = "true";
            public static bool s = true;
        }





        
    }

    
}
class Conection
{
    public static async Task<bool> Conect_login(string usuario, string contrasena)
    {
        var client = new HttpClient();
        var content = new StringContent($@"{{""Usuario"": ""{usuario}"", ""Password"": ""{contrasena}""}}",
            System.Text.Encoding.UTF8, "application/json");
        var response = await client.PostAsync("http://20.90.72.41:5000/Login", content);
        var responseString = await response.Content.ReadAsStringAsync();
        var responseObject = JsonConvert.DeserializeObject<ApiResponse>(responseString);

        return responseObject.Status;
    }
    public static async Task<(bool, bool)> Conect_register(string Nombres, string apellidos, string correo, string contrasena1, string dui,  string usuario, string password2, string tel)
    {
        var client = new HttpClient();
        var content = new StringContent($@"{{""Nombres"": ""{Nombres}"", ""Apellidos"": ""{apellidos}"", ""Correo"": ""{correo}"", ""Password1"": ""{contrasena1}"", ""Dui"": {dui}, ""Usuario"": ""{usuario}"", ""Password2"":  ""{password2}"", ""Telefono"":  ""{tel}""}}",
            System.Text.Encoding.UTF8, "application/json");
        var response = await client.PostAsync("http://20.90.72.41:5000/Register", content);
        var responseString = await response.Content.ReadAsStringAsync();
        var responseObject = JsonConvert.DeserializeObject<(bool Status2, bool Status1)>(responseString);
        return (responseObject.Status2, responseObject.Status1); 
    }
}
class ApiResponse
{
    public bool Status { get; set; }
    public bool Status1 { get; set; }
    public bool Status2 { get; set; }
}
