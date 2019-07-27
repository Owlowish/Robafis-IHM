using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace PipesClientTest
{
    public partial class IHM_AUTO_3 : Form
    {

        double vit;
        String dataRecu = "";
        int intermediaire = 0;


        public IHM_AUTO_3()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(0, 0);

            VARIABLES.flag_mode_de_marche = true;
            //tb_direction.Enabled = false;
            //tb_erreurs.Enabled = false;
            lb_direction.Enabled = true;
            timer1.Enabled = true;
            VARIABLES.sport.DataReceived += Sport_DataReceived;

            
        }

        private void Sport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            dataRecu = "0";

            dataRecu = VARIABLES.sport.ReadLine();


            if (dataRecu.Length > 0)

            {
                switch (dataRecu[0])
                {
                    case 'A':
                        if (dataRecu[1] != '0')
                        {

                            
                                intermediaire = int.Parse(dataRecu.Replace("A", ""));
                            
                            
                                intermediaire = 0;
                            
                            vit = -(int.Parse(dataRecu.Replace("A", "")) * 0.056 * 3.14 * 1000) / (60 * 7);
                        }
                        else
                        {
                            vit = 0.0;
                        }
                        //TextBox.Text = vit.ToString(".##");
                        break;
                    case 'V':
                        if (dataRecu[1] == 'D') VARIABLES.virage = "Droite";
                        if (dataRecu[1] == 'G') VARIABLES.virage = "Gauche";
                        if (dataRecu[1] == '0') VARIABLES.virage = "Ligne Droite";

                        break;
                    case 'F':
                        VARIABLES.virage = "Fin de Ligne détecté";
                        VARIABLES.flag_mode_de_marche = false;
                        break;
                    default:
                        break;
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_direction.ForeColor = System.Drawing.Color.White ;
            lb_vitesse.Text = vit.ToString(".##");
            //tb_data.Text = dataRecu;

            // ajout
            //TextBox.AppendText(vit.ToString(".##"));
            if (vit == 0) lb_vitesse.Text="0.00";
            lb_direction.Text = VARIABLES.virage;

            //..

            if (VARIABLES.flag_mode_de_marche == false)
            {
                VARIABLES.data = "<CD0000000>";
                VARIABLES.sport.Write(VARIABLES.data);

                VARIABLES.sport.DiscardInBuffer();
                VARIABLES.sport.DiscardOutBuffer();
                VARIABLES.sport.BaseStream.Flush();
                VARIABLES.sport.DataReceived -= Sport_DataReceived;

                this.Close();
                timer1.Enabled = false;
              
               
            }

            //gestion flèches

            if (VARIABLES.virage == "Ligne Droite")
            {
                pb_bas.Visible = false;
                pb_haut.Visible = true;
                pb_gauche.Visible = false;
                pb_droit.Visible = false;
            }

            if (VARIABLES.virage == "bas")
            {
                pb_bas.Visible =true;
                pb_haut.Visible = false;
                pb_gauche.Visible = false;
                pb_droit.Visible = false;
            }


            if (VARIABLES.virage == "Gauche")
            {
                pb_bas.Visible = false;
                pb_haut.Visible = false;
                pb_gauche.Visible = true;
                pb_droit.Visible = false;
            }


            if (VARIABLES.virage == "Droite")
            {
                pb_bas.Visible = false;
                pb_haut.Visible = false;
                pb_gauche.Visible = false;
                pb_droit.Visible = true;
            }


            lb_message.Text = dataRecu;



        }

        private void b_arret_Click(object sender, EventArgs e)
        {
            VARIABLES.flag_mode_de_marche = false;
        }

   
    }
}
