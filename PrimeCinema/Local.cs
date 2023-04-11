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
    public partial class Local : Form
    {
        public Local()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            control.name_local = label1.Text;
            Local_i local_I = new Local_i();
            local_I.Show();

        }

        private void Local_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            control.name_local = label2.Text;
            Local_i local_I = new Local_i();
            local_I.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            control.name_local = label3.Text;
            Local_i local_I = new Local_i();
            local_I.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            control.name_local = label4.Text;
            Local_i local_I = new Local_i();
            local_I.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            control.name_local = label5.Text;
            Local_i local_I = new Local_i();
            local_I.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            control.name_local = label6.Text;
            Local_i local_I = new Local_i();
            local_I.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            control.name_local = label7.Text;
            Local_i local_I = new Local_i();
            local_I.Show();
        }
    }
}
