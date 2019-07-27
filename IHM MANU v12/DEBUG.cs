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
    public partial class DEBUG : Form
    {
        public DEBUG()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(1200, 0);
        }

       

        private void b_sequence_Click(object sender, EventArgs e)
        {
            VARIABLES.sequence++;
            if (VARIABLES.sequence > 6) VARIABLES.sequence = 1;
            b_sequence.Text = "séquence : " + VARIABLES.sequence.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_sequence.Text = VARIABLES.sequence.ToString();
            lb_flag.Text = VARIABLES.flag_init.ToString();
        }
    }
}
