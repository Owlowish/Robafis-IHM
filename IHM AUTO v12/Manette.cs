using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Gaming.Input;
using System.IO.Ports;

namespace PipesClientTest
{
    public partial class Manette : Form
    {
        string vitesse = "";
        double vit = 0;
        string dataRecu = " ";


        private bool montee = false;
        private bool statique = true;

        public Manette()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(0, 0);
            VARIABLES.sport.DataReceived += new SerialDataReceivedEventHandler(sport_DataReceived);
            timer1.Enabled = true;

        }

        private void sport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            dataRecu = "A0000";
            dataRecu = VARIABLES.sport.ReadExisting();

            switch (dataRecu[0])
            {
                case 'A':
                    if (dataRecu[1] != '0')
                    {
                        vit = -(int.Parse(dataRecu.Replace("A", "")) * 0.056 * 3.14 * 1000) / (60 * 7);
                    }
                    else
                    {
                        vit = 0.0;
                    }
                    //TextBox.Text = vit.ToString(".##");
                    break;
                case 'B':

                    if (dataRecu[1] != '0')
                    {
                        VARIABLES.pos = int.Parse(dataRecu.Replace("B", ""));
                    }
                    else
                    {
                        VARIABLES.pos = 0;
                    }
                    //TextBox.Text = vit.ToString(".##");
                    break;
                default:
                    break;
            }

        }


        void gestionVitesse()
        {
            if (VARIABLES.sequence == 4 || VARIABLES.sequence == 5)
            {
                VARIABLES.limiteVitesse = true;
            }
            else
            {
                VARIABLES.limiteVitesse = false;
            }
        }

     
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lb_vitesse.Text = "Vitesse: " + vit.ToString(".##");
            gestionVitesse();
            
            var Reading = VARIABLES.Controller.GetCurrentReading();
            int joystickGauche = Convert.ToInt16(Reading.LeftThumbstickY * 100);
            int joystickDroit = Convert.ToInt16(Reading.RightThumbstickX * 100);
            int gachetteDroite = Convert.ToInt16(Reading.RightTrigger * 100); ;
            int gachetteGauche = Convert.ToInt16(Reading.LeftTrigger * 100);
            string typeAction = "0";
            string signeAction2 = "0";
            string action2 = "000";
            string action1 = "000";
            string signeAction1 = "0";

            statique = true;

            if ((joystickGauche < 10 && joystickGauche > -10) && (joystickDroit < 10 && joystickDroit > -10))
            {
                if (gachetteDroite > 10 && gachetteGauche < 10)
                {
                    montee = true;
                    statique = false;
                    typeAction = "B";
                    signeAction1 = "M";
                    if (gachetteDroite < 100) action1 = "0" + gachetteDroite.ToString();
                    if (gachetteDroite >= 100) action1 = "100";
                }
                if (gachetteGauche > 10 && gachetteDroite < 10)
                {
                    montee = false;
                    statique = false;
                    typeAction = "B";
                    signeAction1 = "B";
                    if (gachetteGauche < 100) action1 = "0" + gachetteGauche.ToString();
                    else if (gachetteGauche >= 100) action1 = "100";
                }

                if (gachetteDroite < 10 && gachetteGauche < 10)
                {

                    typeAction = "0";
                    signeAction2 = "0";
                    action2 = "000";
                    action1 = "000";
                    signeAction1 = "0";
                    statique = true;
                }
            }
            else
            {
                typeAction = "A";
                if (joystickGauche > 10)
                {
                    double jg = (double)joystickGauche;
                    if (VARIABLES.limiteVitesse == true)
                    {
                        jg = joystickGauche / 1.00;
                        joystickGauche = (int)jg;
                    }
                    else
                    {
                        jg = joystickGauche * 1.6;
                        joystickGauche = (int)jg;
                    }
                    if (joystickGauche < 10) action1 = "00" + (-joystickGauche).ToString();
                    if (joystickGauche < 100) action1 = "0" + joystickGauche.ToString();
                    else if (joystickGauche >= 100) action1 = joystickGauche.ToString();
                    signeAction1 = "A";
                }
                if (joystickGauche < -10)
                {
                    double jg = (double)joystickGauche;
                    if (VARIABLES.limiteVitesse == true)
                    {
                        jg = joystickGauche / 1.00;
                        joystickGauche = (int)jg;
                    }
                    else
                    {
                        jg = joystickGauche * 1.6;
                        joystickGauche = (int)jg;
                    }
                    if (joystickGauche > -10) action1 = "00" + (-joystickGauche).ToString();
                    if (joystickGauche > -100) action1 = "0" + (-joystickGauche).ToString();
                    else if (joystickGauche <= -100) action1 = (-joystickGauche).ToString();
                    signeAction1 = "R";
                }

                if (joystickGauche < 10 && joystickGauche > -10)
                {
                    action1 = "000";
                    signeAction2 = "0";
                }

                if (joystickDroit > 10)
                {
                    double jg = (double)joystickDroit;
                    if (VARIABLES.limiteVitesse == true)
                    {
                        jg = joystickDroit /1.00;
                        joystickDroit = (int)jg;
                    }
                    else
                    {
                        jg = joystickDroit * 1.6;
                        joystickDroit = (int)jg;
                    }
                    if (joystickDroit < 10) action2 = "00" + joystickDroit.ToString();
                    if (joystickDroit < 100) action2 = "0" + joystickDroit.ToString();
                    else if (joystickDroit >= 100) action2 = joystickDroit.ToString();
                    signeAction2 = "D";
                }

                if (joystickDroit < -10)
                {
                    double jg = (double)joystickDroit;
                    if (VARIABLES.limiteVitesse == true)
                    {
                        jg = joystickDroit / 1.00;
                        joystickDroit = (int)jg;
                    }
                    else
                    {
                        jg = joystickDroit * 1.6;
                        joystickDroit = (int)jg;
                    }
                    if (joystickDroit > -10) action2 = "00" + (-joystickDroit).ToString();
                    if (joystickDroit > -100) action2 = "0" + (-joystickDroit).ToString();
                    else if (joystickDroit <= -100) action2 = (-joystickDroit).ToString();
                    signeAction2 = "G";
                }

                if (joystickDroit < 10 && joystickDroit > -10)
                {
                    action2 = "000";
                    signeAction2 = "0";
                }
            }


            VARIABLES.data = "<" + typeAction + signeAction2 + action2 + signeAction1 + action1 + ">";

            try
            {
                VARIABLES.sport.Write(VARIABLES.data);
            }
            catch
            {
                if (VARIABLES.sport.IsOpen == false)
                {
                    try
                    {
                        VARIABLES.sport.Open();
                    }
                    catch
                    {
                        MessageBox.Show("Problème de connexion Bluetooth");
                        timer1.Enabled = false;
                        this.Close();
                    }
                }
            }

            if (Reading.Buttons == GamepadButtons.B)
            {
                VARIABLES.data = "<MD0000000>";
                VARIABLES.sport.Write(VARIABLES.data);
                timer1.Enabled = false;

                VARIABLES.sport.DataReceived -= new SerialDataReceivedEventHandler(sport_DataReceived);
                if (VARIABLES.sequence == 5) VARIABLES.flag_sequence = false;
                this.Close();
            }

            //ajout
            //tb1.Text=vit.ToString(".##");

            if (timer1.Enabled == true)
            {
                lb_vitesse.Text = vit.ToString(".##" + " mm/s");
                if (vit == 0) lb_vitesse.Text = "0.00 mm/s";
                if (statique)
                {
                    tb2.Text = " ";
                }
                else
                {
                    if (montee) tb2.Text = "Descente en cours";
                    else tb2.Text = "Montée en cours";
                }
                if (VARIABLES.pos > 1800) tb2.Text = "Position basse atteinte";
                if (VARIABLES.pos < 0) tb2.Text = "Position haute atteinte";

            }


            if (Reading.Buttons == GamepadButtons.Menu )
            {
                if (VARIABLES.flag_aide == false)
                {
                    VARIABLES.flag_aide = true;
                    IHM_help_manette f1 = new IHM_help_manette();
                    f1.Show();
                }


                if (VARIABLES.flag_aide == true)
                {
                    VARIABLES.flag_aide = false;
                    VARIABLES.fermer_aide = true;
                }
            }

            voyant();

            // ***

        }

        
        private void b_help_Click(object sender, EventArgs e)
        {
            if (VARIABLES.flag_aide == false)
            {
                VARIABLES.flag_aide = true;
                IHM_help_manette f1 = new IHM_help_manette();
                f1.Show();
            }


            if (VARIABLES.flag_aide == true)
            {
                VARIABLES.flag_aide = false;
                VARIABLES.fermer_aide = true;
            }
        }

        // gestion voyant

        private void voyant()
        {
            if (vit > 16.0)
            {
                pb_vitesse_nok0.Visible = false;
                pb_vitesse_nok1.Visible = true;

                pb_vitesse_ok0.Visible = true;
                pb_vitesse_ok1.Visible = false;

            }

            else
            {
                pb_vitesse_nok0.Visible =true;
                pb_vitesse_nok1.Visible = false;

                pb_vitesse_ok0.Visible = false;
                pb_vitesse_ok1.Visible = true;
            }

            
        }
    }
}

