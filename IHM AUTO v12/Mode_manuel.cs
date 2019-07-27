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
    public partial class Mode_manuel : Form
    {
        public Mode_manuel()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(0, 0);
        }

        private void b_manette_Click(object sender, EventArgs e)
        {
            VARIABLES.data = "<MA0000000>";
            VARIABLES.sport.Write(VARIABLES.data);
            Manette f1 = new Manette();
            f1.Show();
            this.Close();
        }

        private void b_manette_virtuel_Click(object sender, EventArgs e)
        {
            VARIABLES.data = "<MA0000000>";
            VARIABLES.sport.Write(VARIABLES.data);
            Manette_virtuel f1 = new Manette_virtuel();
            f1.Show();
            this.Close();
        }
    }
}
