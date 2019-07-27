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
    public partial class IHM_MANETTE : Form
    {
        string vitesse = "";
        double vit = 0;

        String dataRecu = "";
        private bool montee = false;
        private bool statique=true;

        public IHM_MANETTE()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(700, 0);
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

        // ajout
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

        //renvoie de la vitesse
        private void sport_DataReceived1(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string vitesse = VARIABLES.sport.ReadLine();
                double vit = (int.Parse(vitesse) * 0.056 * 3.14 * 100) / (60 * 7);
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
           
        }


        private void timer1_Tick(object sender, EventArgs e)
        {


            //label vitesse
            //lb_vit.Text ="vitesse : " +  vit.ToString(".##");

            gestionVitesse();

            TextBox.Clear();
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
                if (gachetteGauche > 10 && gachetteDroite < 10 )
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
                        jg = joystickDroit / 1.00;
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
                        jg = joystickDroit / 2.90;
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
            TextBox.AppendText("Sequence" + VARIABLES.sequence.ToString() + " ");

            try
            {
                VARIABLES.sport.Write(VARIABLES.data);
            }
            catch (Exception ex)
            {
          
            }

            if (Reading.Buttons == GamepadButtons.B)
            {
                VARIABLES.data = "<MD0000000>";
                VARIABLES.sport.Write(VARIABLES.data);
                timer1.Enabled = false;

                VARIABLES.sport.DiscardInBuffer();
                VARIABLES.sport.DiscardOutBuffer();
                VARIABLES.sport.BaseStream.Flush();

                VARIABLES.sport.DataReceived -= new SerialDataReceivedEventHandler(sport_DataReceived);

                this.Close();
 
            }

            if (Reading.Buttons == GamepadButtons.Menu )
            {
                if (VARIABLES.flag_aide == false)
                {
                    VARIABLES.flag_aide = true;
                    AIDE_MANETTE f1 = new AIDE_MANETTE();
                    f1.Show();
                }


                if (VARIABLES.flag_aide == true)
                {
                    VARIABLES.flag_aide = false;
                    VARIABLES.fermer_aide = true;
                }
            }

            //ajout

            if (timer1.Enabled == true)
            {
                
                tb1.Text=vit.ToString(".##"+" mm/s");
                if (vit == 0) tb1.Text="0.00 mm/s";
                if (statique)
                {
                    tb2.Text = " ";
                }
                else
                {
                    if (montee) tb2.Text = "Descente en cours";
                    else tb2.Text = "Montée en cours";
                }
               if (VARIABLES.pos > 1800) tb2.Text = "Position basse";
               if (VARIABLES.pos < 0) tb2.Text = "Position haute";
            }
            // ***

            voyant();

            if (signeAction2 == "G")
            {
                pb_g.Visible = true;


                pb_d.Visible = false;
                pb_a.Visible = false;
                pb_r.Visible = false;
                pb_n.Visible = false;
            }

            if (signeAction2 == "D")
            {
                pb_d.Visible = true;

                pb_a.Visible = false;
                pb_r.Visible = false;
                pb_g.Visible = false;
                pb_n.Visible = false;
            }

            if (signeAction1 == "A")
            {
                pb_a.Visible = true;

                pb_g.Visible = false;
                pb_d.Visible = false;
                pb_r.Visible = false;
                pb_n.Visible = false;
            }


            if (signeAction1 == "R")
            {
                pb_r.Visible = true;

                pb_d.Visible = false;
                pb_a.Visible = false;
                pb_g.Visible = false;
                pb_n.Visible = false;
            }


            if (signeAction1 == "0" && signeAction2 == "0")
            {
                pb_n.Visible = true;

                pb_d.Visible = false;
                pb_a.Visible = false;
                pb_r.Visible = false;
                pb_g.Visible = false;
            }





        }



        private void voyant()
        {
            if (VARIABLES.sequence == 2)
            {
                if (vit >80.0)
                {
                    pb_voy_rouger_allumer.Visible = true;
                    pb_voy_rouge_eteint.Visible = false;

                    pb_voy_vert_allumer.Visible = false;
                    pb_voy_vert_eteint.Visible = true;
                        
                }

                else
                {
                    pb_voy_rouger_allumer.Visible = false;
                    pb_voy_rouge_eteint.Visible = true;

                    pb_voy_vert_allumer.Visible = true;
                    pb_voy_vert_eteint.Visible =false;
                }
            }

            if (VARIABLES.sequence == 4)
            {
                if (vit > 50.0)
                {
                    pb_voy_rouger_allumer.Visible = true;
                    pb_voy_rouge_eteint.Visible = false;

                    pb_voy_vert_allumer.Visible = false;
                    pb_voy_vert_eteint.Visible = true;
                }

                else
                {
                    pb_voy_rouger_allumer.Visible = false;
                    pb_voy_rouge_eteint.Visible = true;

                    pb_voy_vert_allumer.Visible = true;
                    pb_voy_vert_eteint.Visible = false;
                }

            }



        }

        private void pb_a_Click(object sender, EventArgs e)
        {

        }
    }


   
}