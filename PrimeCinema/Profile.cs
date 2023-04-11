using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeCinema
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void Profile_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (control.profile_screen)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            movie.Show();
            control.movie_screen = true;
            control.profile_screen= false;
            this.Close();
        }

        private void home_Click(object sender, EventArgs e)
        {
            HomeS homeS = new HomeS();
            homeS.Show();
            control.home_screen = true;
            control.profile_screen = false;
            this.Close();
        }

        private void search_Click(object sender, EventArgs e)
        {
            Search search = new Search();  
            search.Show();
            control.search_screen = true;
            control.profile_screen = false;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.Show();
            control.setting_screen = true;
            control.profile_screen = false;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dui_Click(object sender, EventArgs e)
        {

        }

        private void Phone_Click(object sender, EventArgs e)
        {

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void PhoneI_Click(object sender, EventArgs e)
        {

        }
    }
}
