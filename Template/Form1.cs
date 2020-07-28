using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Template
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Commercial> commercials = new List<Commercial>();
            
            /* Rechercehe et calcule des CA */
                Commercial com1 = new Commercial
                {
                    Nom = "Rakoto",
                    Ca2017 = 52020,
                    Ca2018 = 30253545,
                    Ca2019 = 202060,
                    Ca2020 = 5415035,
                };
                commercials.Add(com1);

                Commercial com2 = new Commercial
                {
                    Nom = "Raivo",
                    Ca2017 = 2017,
                    Ca2018 = 2018,
                    Ca2019 = 2019,
                    Ca2020 = 2020,
                };
                commercials.Add(com2);
            /* Rechercehe et calcule des CA */

            int numero = 1;
            foreach (Commercial com in commercials)
            {
                showCom(numero, com);
                numero++;

            }
        }

        private void showCom(int x, Commercial com)
        {
            if (x == 1)
            {
                panel1.Visible = true;
                labelCom1.Text = com.Nom;
                c1c2017.Text = com.Ca2017.ToString();
                c1c2018.Text = com.Ca2018.ToString();
                c1c2019.Text = com.Ca2019.ToString();
                c1c2020.Text = com.Ca2020.ToString();
            }
            else if (x == 2)
            {
                panel2.Visible = true;
                labelCom2.Text = com.Nom;
                c2c2017.Text = com.Ca2017.ToString();
                c2c2018.Text = com.Ca2018.ToString();
                c2c2019.Text = com.Ca2019.ToString();
                c2c2020.Text = com.Ca2020.ToString();
            }
            else if (x == 3)
            {
                panel3.Visible = true;
                labelCom3.Text = com.Nom;
                c3c2017.Text = com.Ca2017.ToString();
                c3c2018.Text = com.Ca2018.ToString();
                c3c2019.Text = com.Ca2019.ToString();
                c3c2020.Text = com.Ca2020.ToString();
            }
            else if (x == 4)
            {
                panel4.Visible = true;
                labelCom4.Text = com.Nom;
                c4c2017.Text = com.Ca2017.ToString();
                c4c2018.Text = com.Ca2018.ToString();
                c4c2019.Text = com.Ca2019.ToString();
                c4c2020.Text = com.Ca2020.ToString();
            }
            else if (x == 5)
            {
                panel5.Visible = true;
                labelCom5.Text = com.Nom;
                c5c2017.Text = com.Ca2017.ToString();
                c5c2018.Text = com.Ca2018.ToString();
                c5c2019.Text = com.Ca2019.ToString();
                c5c2020.Text = com.Ca2020.ToString();
            }
            else if (x == 6)
            {
                panel6.Visible = true;
                labelCom6.Text = com.Nom;
                c6c2017.Text = com.Ca2017.ToString();
                c6c2018.Text = com.Ca2018.ToString();
                c6c2019.Text = com.Ca2019.ToString();
                c6c2020.Text = com.Ca2020.ToString();
            }
            else if (x == 7)
            {
                panel7.Visible = true;
                labelCom7.Text = com.Nom;
                c7c2017.Text = com.Ca2017.ToString();
                c7c2018.Text = com.Ca2018.ToString();
                c7c2019.Text = com.Ca2019.ToString();
                c7c2020.Text = com.Ca2020.ToString();
            }
            else if (x == 2)
            {
                panel2.Visible = true;
                labelCom8.Text = com.Nom;
                c2c2017.Text = com.Ca2017.ToString();
                c2c2018.Text = com.Ca2018.ToString();
                c2c2019.Text = com.Ca2019.ToString();
                c2c2020.Text = com.Ca2020.ToString();
            }

        }

        private void btn2017_Click(object sender, EventArgs e)
        {
            ComParMois cm = new ComParMois();
            cm.Show();
            this.Hide();
        }
    }
}
