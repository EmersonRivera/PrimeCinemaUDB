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
using System.Xml.Linq;

namespace PrimeCinema
{
    public partial class Choose_seats : Form
    {
        public Choose_seats()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {  
            //hecho por chatgpt

            List<string> aquaButtonNames = new List<string>();

            foreach (Control c in this.Controls)
            {
                if (c is Button && c.BackColor == Color.Aqua)
                {
                    aquaButtonNames.Add(c.Name);
                }
            }

            // Ahora puedes usar la lista 'aquaButtonNames' para hacer lo que necesites con los nombres de los botones Aqua
            foreach (string buttonName in aquaButtonNames)
            {
                control.Seats_name= control.Seats_name + ", "+buttonName;
            }

            Acept_All acept_All= new Acept_All();
            acept_All.Show();
        }

        private void Choose_seats_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 40; i++)
            {
                var B = control.status_seats[i.ToString()];
                bool status = bool.Parse(B.ToString());

                if (status)
                {
                    this.Controls["Button" + i.ToString()].BackColor = Color.GreenYellow;
                }
                else
                {
                    this.Controls["Button" + i.ToString()].BackColor = Color.Red;
                }
            }
            foreach (var button in this.Controls.OfType<Button>())
            {
                button.Click += Button_Click;
            }


        }
        private void Button_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (button.BackColor == Color.GreenYellow)
            {
                button.BackColor = Color.Aqua;
            }
            else
            {
                if (button.BackColor == Color.Red)
                {
                    button.BackColor = Color.Red;
                }
                else
                {
                    button.BackColor = Color.GreenYellow;
                }
            }
        }

    }
}
