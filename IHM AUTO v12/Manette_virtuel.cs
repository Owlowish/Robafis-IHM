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
    public partial class Manette_virtuel : Form
    {
        //variables

        Point Move;
        Point coord;
        Boolean flagx = false;
        Boolean flagy = false;
        int Xori = 300;
        int Yori = 100;
        int direction = 0;
        int vitesse = 0;
        int Xmax = 400;
        int Ymax = 200;
        int Xmin = 200;
        int Ymin = 0;

        

        bool monter = false;
        bool descendre = false;

        double vit;


        String dataRecu = "";


        public Manette_virtuel()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            VARIABLES.sport.DataReceived += new SerialDataReceivedEventHandler(sport_DataReceived);
            Location = new Point(0, 0);
            this.Width = 800;
            this.Height = 400;
            KeyPreview = true;
            timer1.Enabled = true;
            this.KeyDown += Manette_virtuel_KeyDown;

        }

        private void Manette_virtuel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                VARIABLES.data = "<MD0000000>";
                VARIABLES.sport.Write(VARIABLES.data);
                timer1.Enabled = false;
                this.Close();
            }
        }

        private void b_joystick_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Test position en X
                if (b_joystick.Left == Xmin && e.X - Move.X <= 0)
                {
                    flagx = true;
                }
                if (b_joystick.Left == Xmax && e.X - Move.X >= 0)
                {
                    flagx = true;
                }
                // Movement si possible en X
                if (b_joystick.Left >= Xmin && e.X - Move.X >= -10 && flagx == false)
                {
                    b_joystick.Left += e.X - Move.X;
                    flagx = true;
                }
                if (b_joystick.Left <= Xmax && e.X - Move.X <= 10 && flagx == false)
                {
                    b_joystick.Left += e.X - Move.X;
                    flagx = true;
                }
                // Limitation en X
                if (b_joystick.Left < Xmin)
                {
                    b_joystick.Left = Xmin;
                }
                if (b_joystick.Left > Xmax)
                {
                    b_joystick.Left = Xmax;
                }
                //reset flag X
                flagx = false;


                // Test position en Y
                if (b_joystick.Top == Ymin && e.Y - Move.Y <= 0)
                {
                    flagy = true;
                }
                if (b_joystick.Top == Ymax && e.Y - Move.Y >= 0)
                {
                    flagy = true;
                }
                // Movement si possible en Y
                if (b_joystick.Top >= Ymin && e.Y - Move.Y >= -10 && flagy == false)
                {
                    b_joystick.Top += e.Y - Move.Y;
                    flagy = true;
                }
                if (b_joystick.Top <= Ymax && e.Y - Move.Y <= 10 && flagy == false)
                {
                    b_joystick.Top += e.Y - Move.Y;
                    flagy = true;
                }
                // Limitation en Y
                if (b_joystick.Top < Ymin)
                {
                    b_joystick.Top = Ymin;
                }
                if (b_joystick.Top > Ymax)
                {
                    b_joystick.Top = Ymax;
                }
                //reset flag Y
                flagy = false;
            }




        }

        private void b_joystick_MouseDown(object sender, MouseEventArgs e)
        {
            Move = e.Location;
        }

        private void b_joystick_MouseUp(object sender, MouseEventArgs e)
        {
            b_joystick.Left = Xori;
            b_joystick.Top = Yori;
        }

        private void Manette_virtuel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen mypen = new Pen(Color.Blue); //extérieur
            Brush mybrush = new SolidBrush(Color.DimGray);
            Brush mybrush2 = new SolidBrush(Color.IndianRed);//intérieur

            // g.DrawLine(mypen, 2, 2, 200, 100);

            // g.DrawRectangle(mypen, 194, 2 , 325 ,310);

            // g.DrawEllipse(mypen, 194, 2, 325, 310);


            // e.Graphics.FillRectangle(mybrush2, 200, 0, 300, 300);
            e.Graphics.FillEllipse(mybrush, 200, 0, 300, 300);

        }

        //ajout séquence
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


        private void timer1_Tick(object sender, EventArgs e)
        {
            //lb_vit.Text = "Vitesse: " + vit.ToString(".##");
            gestionVitesse();

            coord = b_joystick.Location;

            //gestion de la direction
            direction = coord.X - 300;
            vitesse = -(coord.Y - 100);




            string typeAction = "0";
            string signeAction2 = "0";
            string action2 = "000";
            string action1 = "000";
            string signeAction1 = "0";
            if ((vitesse < 10 && vitesse > -10) && (direction < 10 && direction > -10))
            {
                if (monter)
                {
                    typeAction = "B";
                    signeAction1 = "M";
                    action1 = "100";
                }
                else if (descendre)
                {
                    typeAction = "B";
                    signeAction1 = "B";
                    action1 = "100";
                }
            }
            else
            {
                typeAction = "A";
                if (vitesse > 10)
                {
                    double jg = (double)vitesse;
                    if (VARIABLES.limiteVitesse == true)
                    {
                        jg = vitesse / 2.83;
                        vitesse = (int)jg;
                    }
                    else
                    {
                        jg = vitesse * 1.6;
                        vitesse = (int)jg;
                    }
                    if (vitesse < 10) action1 = "00" + (-vitesse).ToString();
                    if (vitesse < 100) action1 = "0" + vitesse.ToString();
                    else if (vitesse >= 100) action1 = vitesse.ToString();
                    signeAction1 = "A";
                }
                if (vitesse < -10)
                {
                    double jg = (double)vitesse;
                    if (VARIABLES.limiteVitesse == true)
                    {
                        jg = vitesse / 2.83;
                        vitesse = (int)jg;
                    }
                    else
                    {
                        jg = vitesse * 1.6;
                        vitesse = (int)jg;
                    }
                    if (vitesse > -10) action1 = "00" + (-vitesse).ToString();
                    if (vitesse > -100) action1 = "0" + (-vitesse).ToString();
                    else if (vitesse <= -100) action1 = (-vitesse).ToString();
                    signeAction1 = "R";
                }

                if (vitesse < 10 && vitesse > -10)
                {
                    action1 = "000";
                    signeAction2 = "0";
                }

                if (direction > 10)
                {
                    double jd = (double)direction;
                    if (VARIABLES.limiteVitesse == true)
                    {
                        jd = direction / 2.83;
                        direction = (int)jd;
                    }
                    else
                    {
                        jd = direction * 1.6;
                        direction = (int)jd;
                    }
                    if (direction < 10) action2 = "00" + direction.ToString();
                    if (direction < 100) action2 = "0" + direction.ToString();
                    else if (direction >= 100) action2 = direction.ToString();
                    signeAction2 = "D";
                }
                if (direction < -10)
                {
                    double jd = (double)direction;
                    if (VARIABLES.limiteVitesse == true)
                    {
                        jd = direction / 2.83;
                        direction = (int)jd;
                    }
                    else
                    {
                        jd = direction * 1.6;
                        direction = (int)jd;
                    }
                    if (direction > -10) action2 = "00" + (-direction).ToString();
                    if (direction > -100) action2 = "0" + (-direction).ToString();
                    else if (direction <= -100) action2 = (-direction).ToString();
                    signeAction2 = "G";
                }

                if (direction < 10 && direction > -10)
                {
                    action2 = "000";
                    signeAction2 = "0";
                }



            }
      
            VARIABLES.data = "<" + typeAction + signeAction2 + action2 + signeAction1 + action1 + ">";
            VARIABLES.sport.Write(VARIABLES.data);

            //ajout
            tb1.Text = vit.ToString(".##") + "mm/s";
            if (vit == 0) tb1.Text = "0.00 mm/s";
            if (monter) tb2.Text = "Montée en cours";
            else if (descendre) tb2.Text = "Descente en cours";
            else tb2.Text = " ";
            if (VARIABLES.pos > 1800) tb2.Text = "Position basse atteinte";
            if (VARIABLES.pos < 0) tb2.Text = "Position haute atteinte";

            // ***

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VARIABLES.data = "<MD0000000>";
            VARIABLES.sport.Write(VARIABLES.data);
            timer1.Enabled = false;
            VARIABLES.sport.DataReceived -= new SerialDataReceivedEventHandler(sport_DataReceived);
            this.Close();
        }
    }
}
