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
            Location = new Point(0, 0);
        }

        private void b_connecter_Click(object sender, EventArgs e)
        {
            VARIABLES.ihm_connecter = true;
            VARIABLES.flag_connexion = true;
            this.Hide();

        }

        private void IHM_connecter_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
