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
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void greeting_Click(object sender, EventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
            HomeS homeS= new HomeS();
            homeS.Show();
            control.setting_screen = false;
            control.home_screen = true;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            control.profile_screen= true;
            control.setting_screen = false;
            this.Close();
        }

        private void search_Click(object sender, EventArgs e)
        {
            Search search= new Search();
            search.Show();
            control.search_screen = true;
            control.setting_screen = false;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            movie.Show();
            control.movie_screen = true;
            control.setting_screen = false;
            this.Close();
        }
        

        private void Setting_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (control.setting_screen)
            {
                Application.Exit();
            }
        }

        private void Setting_Load(object sender, EventArgs e)
        {

        }
    }
    
}
