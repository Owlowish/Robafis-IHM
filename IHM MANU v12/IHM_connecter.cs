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
    public partial class IHM_connecter : Form
    {
        public IHM_connecter()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(900, 0);
        }

        private void b_connecter_Click(object sender, EventArgs e)
        {
            VARIABLES.flag_connecter = true;
            VARIABLES.ihm_connecter = true;
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void IHM_connecter_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
