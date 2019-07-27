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
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            lb_sequence.Text = VARIABLES.sequence.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VARIABLES.sequence++;
            button1.Name = VARIABLES.sequence.ToString();
        }
    }
}
