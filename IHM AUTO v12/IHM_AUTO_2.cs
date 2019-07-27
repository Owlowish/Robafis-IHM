using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PipesClientTest
{
    public partial class IHM_AUTO_2 : Form
    {
        public IHM_AUTO_2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(0,0);
        }

        private void b_ihmauto2_modemanu_Click(object sender, EventArgs e)
        {
            this.Hide();
            VARIABLES.flag_mode_de_marche = true;
            VARIABLES.envoie_auto = true;

            /*while (VARIABLES.sport.IsOpen == false)
            {
                VARIABLES.sport.Open();
            }
            */
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (VARIABLES.flag_mode_de_marche == true)
            {
                this.Hide();
                //VARIABLES.flag_mode_de_marche = true;
            }
        }

        private void IHM_AUTO_2_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
