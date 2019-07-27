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
    public partial class IHM_CONTROLE : Form
    {
        //variables

        Point Move;
        Point coord;
        Boolean flagx = false;
        Boolean flagy = false;
        int Xori = 300;
        int Yori = 100;
        int direction = 0;
        double vitesse = 0.0;
        int Xmax = 400;
        int Ymax = 200;
        int Xmin = 200;
        int Ymin = 0;
        int vitesse_bras_monter = 100;
        int vitesse_bras_descendre = -100;

        bool monter = false;
        bool descendre = false;        double vit;

        String dataRecu = "";
        bool statique = true;

        int flag = 0;




        public IHM_CONTROLE()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            VARIABLES.sport.DataReceived += new SerialDataReceivedEventHandler(sport_DataReceived);
            Location = new Point(700, 0);
            this.Width = 800;
            this.Height = 500;
            tb2.Enabled = true;
            tb1.Enabled = true;
            timer1.Enabled = true;
            KeyPreview = true;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                // Test position en X
                if (button1.Left == Xmin && e.X - Move.X <= 0)
                {
                    flagx = true;
                }
                if (button1.Left == Xmax && e.X - Move.X >= 0)
                {
                    flagx = true;
                }
                // Movement si possible en X
                if (button1.Left >= Xmin && e.X - Move.X >= -10 && flagx == false)
                {
                    button1.Left += e.X - Move.X;
                    flagx = true;
                }
                if (button1.Left <= Xmax && e.X - Move.X <= 10 && flagx == false)
                {
                    button1.Left += e.X - Move.X;
                    flagx = true;
                }
                // Limitation en X
                if (button1.Left < Xmin)
                {
                    button1.Left = Xmin;
                }
                if (button1.Left > Xmax)
                {
                    button1.Left = Xmax;
                }
                //reset flag X
                flagx = false;


                // Test position en Y
                if (button1.Top == Ymin && e.Y - Move.Y <= 0)
                {
                    flagy = true;
                }
                if (button1.Top == Ymax && e.Y - Move.Y >= 0)
                {
                    flagy = true;
                }
                // Movement si possible en Y
                if (button1.Top >= Ymin && e.Y - Move.Y >= -10 && flagy == false)
                {
                    button1.Top += e.Y - Move.Y;
                    flagy = true;
                }
                if (button1.Top <= Ymax && e.Y - Move.Y <= 10 && flagy == false)
                {
                    button1.Top += e.Y - Move.Y;
                    flagy = true;
                }
                // Limitation en Y
                if (button1.Top < Ymin)
                {
                    button1.Top = Ymin;
                }
                if (button1.Top > Ymax)
                {
                    button1.Top = Ymax;
                }
                //reset flag Y
                flagy = false;
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            Move = e.Location;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.Left = Xori;
            button1.Top = Yori;
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

            //flag = flag + 1;


        }






 
        private void IHM_CONTROLE_Paint(object sender, PaintEventArgs e)
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







        private void timer1_Tick(object sender, EventArgs e)
        {
            gestionVitesse();

            coord = button1.Location;

            //gestion de la direction
            direction = coord.X - 300;
            vitesse = -(coord.Y - 100);

            //tb1.Text = vitesse.ToString();
           // tb2.Text = direction.ToString();
            string typeAction = "0";
            string signeAction2 = "0";
            string action2 = "000";
            string action1 = "000";
            string signeAction1 = "0";
            statique = true;
                if ((vitesse < 10 && vitesse > -10) && (direction < 10 && direction > -10))
                {
                    if (monter)
                    {
                        typeAction = "B";
                        signeAction1 = "M";
                        action1 = "100";
                        statique = false;
                    }
                    else if (descendre)
                    {
                        typeAction = "B";
                        signeAction1 = "B";
                        action1 = "100";
                        statique = false;
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
                        jg = vitesse / 1.00;
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
                        jg = vitesse / 1.00;
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
                        jd = direction / 1.00;
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
                        jd = direction / 1.00;
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


            // VARIABLES.data = "<" + typeAction + signeAction2 + action2 + signeAction1 + action1 + ">";
            // VARIABLES.sport.Write(VARIABLES.data);

            VARIABLES.data = "<" + typeAction + signeAction2 + action2 + signeAction1 + action1 + ">";
            VARIABLES.sport.Write(VARIABLES.data);

            vitesse =( vitesse * 0.056 * 3.14 * 1000)/ (60 * 7);

            //ajout

            lb_pos.Text = " pos = " + VARIABLES.pos.ToString() + " vit = " + vit;


            

            tb1.Text=vit.ToString(".##"+"mm/s");
            if (vit == 0) tb1.Text="0.00 mm/s";
            if (descendre) tb2.Text = "Montée en cours";
            else if (monter) tb2.Text = "Descente en cours";
            else tb2.Text = " ";
            if (VARIABLES.pos > 1800) tb2.Text = "Position basse atteinte";
            if (VARIABLES.pos < 0) tb2.Text = "Position haute atteinte";


            // ***


        }



        private void b_monter_MouseDown(object sender, MouseEventArgs e)
        {
            monter = true;
        }

        private void b_descendre_MouseDown(object sender, MouseEventArgs e)
        {
            descendre = true;
        }

        private void b_monter_MouseUp(object sender, MouseEventArgs e)
        {
            monter = false;
        }
        
        private void b_descendre_MouseUp(object sender, MouseEventArgs e)
        {
            descendre = false;
        }
        

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //not implemented

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            VARIABLES.data = "<MD0000000>";
            VARIABLES.sport.Write(VARIABLES.data);
            timer1.Enabled = false;
            VARIABLES.sport.DataReceived -= new SerialDataReceivedEventHandler(sport_DataReceived);
            this.Close();
        }
    }
}
