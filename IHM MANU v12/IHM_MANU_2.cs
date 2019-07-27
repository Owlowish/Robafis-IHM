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
    public partial class IHM_MANU_2 : Form
    {
        //variable
        public IHM_MANU_2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(1200, 0);
        }

        private void b_mode_manu_Click(object sender, EventArgs e)
        {
            this.Hide();
            VARIABLES.flag_mode_de_marche = false;
            VARIABLES.envoie_manu = true;
            VARIABLES.sport.Open();           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (VARIABLES.flag_mode_de_marche == false)
            {
                this.Hide();
            }
        }

        private void IHM_MANU_2_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
