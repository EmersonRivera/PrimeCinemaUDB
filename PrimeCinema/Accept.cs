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
    public partial class Accept : Form
    {
        public Accept()
        {
            InitializeComponent();
        }

        private void Accept_Load(object sender, EventArgs e)
        {

        }

        private void Done_Click(object sender, EventArgs e)
        {
            
            
            Choose_seats choose_Seats = new Choose_seats();
            choose_Seats.Close();
            Selec_Movie selec_Movien = new Selec_Movie();
            selec_Movien.Close();
            this.Close();
        }

        private void Accept_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Accept_FormClosed(object sender, FormClosedEventArgs e)
        {
            Acept_All acept_All = new Acept_All();
            acept_All.Close();
            Choose_seats choose_Seats = new Choose_seats();
            choose_Seats.Close();
            Selec_Movie selec_Movien = new Selec_Movie();
            selec_Movien.Close();
        }
    }
}
