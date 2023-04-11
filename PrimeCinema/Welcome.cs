using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeCinema
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Register = new Register();
            Register.Show();
            
        }

        private void Login_Click(object sender, EventArgs e)
        {
         
            Form Login = new Login();
            Login.Show();
            this.Hide();
           


        }

        private void Home_Load(object sender, EventArgs e)
        {


        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
    
    




}
