﻿using System;
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
    public partial class AIDE_MANETTE : Form
    {
        public AIDE_MANETTE()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (VARIABLES.fermer_aide == true)
            {
                VARIABLES.fermer_aide = false;
                this.Close();
                timer1.Enabled = false;
            }
        }
    }
}