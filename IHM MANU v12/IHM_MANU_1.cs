using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Windows.Gaming.Input;

using Clifton.Core.ExtensionMethods;
using Clifton.Core.Pipes;
using System.IO.Ports;
using System.Linq;

namespace PipesClientTest
{
    public partial class IHM_MANU_1 : Form
    {
        // DECLARATION DES VARIABLES

        private List<ClientPipe> clientPipes;  // liste de clients
        private List<ServerPipe> serverPipes;  // liste de serveurs
        private List<TextBox> tbServerSenders;
        private List<TextBox> tbServerReceivers;
        // private List<TextBox> tbClientSenders;
        // private List<TextBox> tbClientReceivers;
        private ServerPipe nextServer;
        int serverIdx = 0;
        string message_recu = "";


        // INITIALISATION DES FORMES
        public IHM_MANU_1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(800, 0);
            ihm_connecter();


            serverPipes = new List<ServerPipe>();
            clientPipes = new List<ClientPipe>();
            tbServerReceivers = new List<TextBox>() { tb_reception };  // Réception des messages via l'IHM pilote

            VARIABLES.sport = new SerialPort("COM6", 9600, Parity.None, 8, StopBits.One);
            tbServerReceivers[0].Text = "       ";

            //textbox disable

            tb_reception.Visible = false;


            //bouton disable

            VARIABLES.flag_init = true;

        
            

            Gamepad.GamepadAdded += Gamepad_GamepadAdded;
        }


        private void Gamepad_GamepadAdded(object sender, Gamepad e)
        {
            VARIABLES.Controller = Gamepad.Gamepads?.First();
        }


        //APPUIE SUR LE BOUTON CONNECTION
        private void b_connecter_Click(object sender, EventArgs e)
        {
            CreateServer();

            //activation des contôles ...
           /*           
            b_debug.Enabled = true;
            b_commande.Enabled = true;
            b_mode_auto.Enabled = true;
            */
        }



        //APPUIE SUR LE BOUTON DE CREATION DE PIPE SERVEUR 
        public ServerPipe CreateServer()
        {
            // int serverIdx = 0 ;  //serverPipes.Count
            ServerPipe serverPipe = new ServerPipe("Test", p => p.StartStringReaderAsync()); // création d'une nouveau obet issus de la classe Serveur
            serverPipes.Add(serverPipe); // ajout d'un serveur

            serverPipe.DataReceived += (sndr, args) =>
                 this.BeginInvoke(() =>
                     tbServerReceivers[serverIdx].Text = args.String);

            serverPipe.Connected += (sndr, args) =>
                this.BeginInvoke(() =>
                {
                    CreateServerUI();
                    nextServer = CreateServer();
                });
            return serverPipe;
        }


        public void CreateServerUI()
        {
            if (serverPipes.Count > 1)
            {
                CreateServerControls(serverPipes.Count - 1);
            }
        }


        protected void CreateServerControls(int n)
        {
            ServerConnection cc = new ServerConnection();
            Button btnSend = (Button)cc.Controls.Find("btnSendToClient", true)[0];
            btnSend.Click += b_mode_auto_Click;
            btnSend.Tag = n;
            tbServerSenders.Add((TextBox)cc.Controls.Find("tbServerSend", true)[0]);
            tbServerReceivers.Add((TextBox)cc.Controls.Find("tbServerReceived", true)[0]);
            Controls.Add(cc);
        }


        // CLIQUE SUR LE BOUTON DE PASSAGE EN MODE AUTO
        private void b_mode_auto_Click(object sender, EventArgs e)
        {
            VARIABLES.flag_sequence = false;
            while (VARIABLES.sport.IsOpen)
            {
                VARIABLES.sport.Close();
            }



            // serverPipes[serverIdx].WriteString("auto"); //tbServerSenders[serverIdx].Text

            VARIABLES.flag_mode_de_marche = true;
            IHM2();

            //envoie message
            serverPipes[serverIdx].WriteString("A" + VARIABLES.sequence.ToString());


        }


        // CLIQUE SUR LE BOUTON DE PASSAGE EN MODE MANU
        private void b_mode_manu_Click(object sender, EventArgs e)
        {
            serverPipes[serverIdx].WriteString("manu");

        }

        //Appuie sur le bouton debug
        private void b_debug_Click(object sender, EventArgs e)
        {
            debug();
        }

        //Appuie sur le bouton control

        private void b_commande_Click(object sender, EventArgs e)
        {
            if (VARIABLES.flag_sequence == false)
            {
                VARIABLES.flag_sequence = true;
                VARIABLES.sequence++;
            }


            VARIABLES.data = "<MA0000000>";

            try
            {
                VARIABLES.sport.Write(VARIABLES.data);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

            if (VARIABLES.bluetooth == true && VARIABLES.robot == true) ihm_control();

            else MessageBox.Show("Le blutetooth ou le robot n'est pas connecté", "ERREUR", MessageBoxButtons.OK);
        }


        //TIMER
        private void timer1_Tick(object sender, EventArgs e)
        {
            message_recu = tbServerReceivers[serverIdx].Text;

            // GESTION FENETTRE CONEXION



            if (VARIABLES.ihm_connecter == false)
            {
                this.Hide();
            }


            if (VARIABLES.ihm_connecter == true && VARIABLES.flag_connecter == true)
            {
                VARIABLES.flag_connecter = false;
                this.Show();
                CreateServer();
            }


            // gestion bluetooth$


            if (VARIABLES.sport.IsOpen == true)
            {
                lb_bluetooth.Text = "OK";
                pb_bluetooth_nok.Visible = false;
                pb_bluetooth_ok.Visible = true;
            }

            if (VARIABLES.sport.IsOpen == false)
            {
                lb_bluetooth.Text = "N/A";
                pb_bluetooth_nok.Visible = true;
                pb_bluetooth_ok.Visible = false;
            }

            // gestion du label du mode de marche

            if (VARIABLES.flag_mode_de_marche == true)
            {
                // lb_mode_de_marche.Text = "MODE DE MARCHE: " + "AUTOMATIQUE ";
                b_mode_auto.Enabled = false;
                //b_mode_manu.Enabled = true;
                //tb_mode.Text = "AUTO";
                
            }

            if (VARIABLES.flag_mode_de_marche == false)
            {
                // lb_mode_de_marche.Text = "MODE DE MARCHE: " + "MANUEL";
             
                b_mode_auto.Enabled = true;
                //b_mode_manu.Enabled = false;
                if (VARIABLES.ihm_connecter == true) this.Show();
                //tb_mode.Text = "MANUEL";

                
            }

            //gestion des textbox d'information

            //if (VARIABLES.bluetooth == true) tb_bluetooth.Text = "OK";
            //if(VARIABLES.bluetooth == false) tb_bluetooth.Text = "N/A";
            // if (VARIABLES.robot == true) tb_robot.Text = "OK";
            // if (VARIABLES.robot == false) tb_robot.Text = "N/A";

            //gestion de la lecture des messages d'entrée


            if (message_recu[0] == 'M')
            {
                VARIABLES.flag_mode_de_marche = false;
                VARIABLES.flag_init = false;


                try
                {
                    VARIABLES.sport.Open();
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error"); }

                VARIABLES.sequence = int.Parse(message_recu.Remove(0, 1)); //Lire séquence

                tbServerReceivers[0].Text = "      "; //nettoyer
            }

            if (message_recu[0] == 'A')
            {
                VARIABLES.flag_mode_de_marche = true;
                IHM2();

                VARIABLES.sequence = int.Parse(message_recu.Remove(0, 1)); //Lire séquence

                tbServerReceivers[0].Text = "       "; //nettoyer

                VARIABLES.sport.Close(); // 


            }

            if (VARIABLES.envoie_manu == true)
            {
                VARIABLES.envoie_manu = false;
                VARIABLES.flag_mode_de_marche = false;
                serverPipes[serverIdx].WriteString("M" + VARIABLES.sequence.ToString());
            }

            // reception séquence
            if (tbServerReceivers[0].Text == "1" || tbServerReceivers[0].Text == "2" || tbServerReceivers[0].Text == "3" || tbServerReceivers[0].Text == "4" || tbServerReceivers[0].Text == "5" || tbServerReceivers[0].Text == "6")
            {
                VARIABLES.sequence = Int32.Parse(tbServerReceivers[0].Text);
            }
            chenillard();
            //lb_debug.Text = VARIABLES.ihm2_femer.ToString();



            // GESTION DE LA SECURITE
            
            if (VARIABLES.flag_init == true)
            {
                b_mode_auto.Enabled = false;
                b_manette.Enabled = false;
                b_commande.Enabled = false;
            }


            if (VARIABLES.flag_init == false)
            {
                b_mode_auto.Enabled = true;
                b_manette.Enabled = true;
                b_commande.Enabled = true;
            }
            
        }

        // FONCTION : AFFICHAGE IHM_MANU_2
        private void IHM2()
        {
            IHM_MANU_2 f2 = new IHM_MANU_2();
            f2.Show();
            this.Hide();
        }

        // AFFICHAGE DEBUG

        private void debug()
        {
            DEBUG f3 = new DEBUG();
            f3.Show();
        }


        // AFFICHAGE COMMANDE

        private void ihm_control()
        {
            IHM_CONTROLE f4 = new IHM_CONTROLE();
            f4.Show();
        }

        private void ihm_connecter()
        {
            IHM_connecter f6 = new IHM_connecter();
            f6.Show();
        }

        private void ihm_manette()
        {
            IHM_MANETTE f4 = new IHM_MANETTE();
            f4.Show();
        }

        private void b_manette_Click(object sender, EventArgs e)
        {

            if (VARIABLES.flag_sequence == false)
            {
                VARIABLES.flag_sequence = true;
                VARIABLES.sequence++;
            }

            ihm_manette();
            VARIABLES.data = "<MA0000000>";
            VARIABLES.sport.Write(VARIABLES.data);
        }

        private void IHM_MANU_1_Load(object sender, EventArgs e)
        {

        }

        private void b_bluetooth_Click(object sender, EventArgs e)
        {

            try
            {
                VARIABLES.sport.Open();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error"); }
        }


        private void chenillard()
        {
            switch (VARIABLES.sequence)
            {
                case 1:

                    pb_etape1_on.Visible = true;
                    pb_etape1_off.Visible = false;

                    pb_etape6_on.Visible = false;
                    pb_etape6_off.Visible = true;

                    break;
                case 2:
                    pb_etape1_on.Visible = false;
                    pb_etape1_off.Visible = true;

                    pb_etape2_on.Visible = true;
                    pb_etape2_off.Visible = false;

                    break;
                case 3:
                    pb_etape2_on.Visible = false;
                    pb_etape2_off.Visible = true;

                    pb_etape3_on.Visible = true;
                    pb_etape3_off.Visible = false;

                    break;

                case 4:
                    pb_etape3_on.Visible = false;
                    pb_etape3_off.Visible = true;

                    pb_etape4_on.Visible = true;
                    pb_etape4_off.Visible = false;

                    break;

                case 5:
                    pb_etape4_on.Visible = false;
                    pb_etape4_off.Visible = true;

                    pb_etape5_on.Visible = true;
                    pb_etape5_off.Visible = false;

                    break;

                case 6:
                    pb_etape5_on.Visible = false;
                    pb_etape5_off.Visible = true;

                    pb_etape6_on.Visible = true;
                    pb_etape6_off.Visible = false;
                    break;

                default:

                    break;
            }





        }

        private void IHM_MANU_1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
