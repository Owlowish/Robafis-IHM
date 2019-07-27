using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Clifton.Core.ExtensionMethods;
using Clifton.Core.Pipes;

using Windows.Gaming.Input;

using System.IO.Ports;
using System.Linq;


namespace PipesClientTest
{
    public partial class IHM_AUTO_1 : Form
    {

        // DECLARATION DES VARIABLES

        private List<ClientPipe> clientPipes;  // liste de clients
        private List<ServerPipe> serverPipes;  // liste de serveurs
        private List<TextBox> tbServerSenders;
        private List<TextBox> tbServerReceivers;
        private List<TextBox> tbClientSenders;
        private List<TextBox> tbClientReceivers;
        private ServerPipe nextServer;
        int clientIdx = 0;
        int i = 0; //debug
        string message_recu = "     ";





        // INITIALISATION

        public IHM_AUTO_1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(0, 0);



            ihm_connecter();


            serverPipes = new List<ServerPipe>();
            clientPipes = new List<ClientPipe>();
            tbClientReceivers = new List<TextBox>() { tb_reception };  // Réception des messages via l'IHM pilote
            tb_reception.Visible = false;

            tbClientReceivers[0].Text = "    ";

            //disable bouton
            b_modemanu.Enabled = true;
            b_modeauto.Enabled = false;
            //b_debug.Enabled = false;
            b_suivie_de_ligne.Enabled = true ;


            //texboxe d'information
       
            b_control.Enabled =true;

            VARIABLES.sport = new SerialPort("COM6", 9600, Parity.None, 8, StopBits.One);
            try
            {
                VARIABLES.sport.Open();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error"); }

            Gamepad.GamepadAdded += Gamepad_GamepadAdded;
        }


        private void Gamepad_GamepadAdded(object sender, Gamepad e)
        {
            VARIABLES.Controller = Gamepad.Gamepads?.First();
        }

        // CLIENT PIPE
        protected void CreateClientUI()
        {
            if (clientPipes.Count > 1)
            {
                CreateClientControls(clientPipes.Count - 1);
            }
        }

        // CLIENT CONTROL PIPE
        protected void CreateClientControls(int n)
        {
            ClientConnection cc = new ClientConnection();
            Button btnSend = (Button)cc.Controls.Find("btnSendToServer", true)[0];
            btnSend.Click += b_modemanu_Click;
            btnSend.Tag = n;
            tbClientSenders.Add((TextBox)cc.Controls.Find("tbClientSend", true)[0]);
            tbClientReceivers.Add((TextBox)cc.Controls.Find("tbClientReceived", true)[0]);
            Controls.Add(cc);
        }

        // APPUIE SUR LE BOUTON IHM MANU
        private void b_modemanu_Click(object sender, EventArgs e)
        {


            if (VARIABLES.sport.IsOpen == true)
            {


                // fermeture du port série

                while (VARIABLES.sport.IsOpen)
                {
                    VARIABLES.sport.Close();
                }

                //envoie du mode et de la séquence

                string message = "M" + VARIABLES.sequence.ToString();
                clientPipes[clientIdx].WriteString(message);
                VARIABLES.flag_mode_de_marche = false;

                //affichage de l'ihm d'attente
                IHM2();
                VARIABLES.flag_sequence = false;
            }

            else
            {
                MessageBox.Show("Connectez-vous sur Bluetooth", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          
        }

        // APPUIE SUR LE BOUTON MODE AUTO
        private void b_modeauto_Click(object sender, EventArgs e)
        {
            clientPipes[clientIdx].WriteString("auto"); //tbServerSenders[serverIdx].Text
            //b_modemanu.Enabled = false;
            VARIABLES.flag_mode_de_marche = true;
        }


        //APPUIE SUR LE BOUTON DEBUG
        private void b_debug_Click(object sender, EventArgs e)
        {
            debug();
        }


        private void b_suivie_de_ligne_Click(object sender, EventArgs e)
        {
            if (VARIABLES.sport.IsOpen == true)
            {

                VARIABLES.flag_mode_de_marche = true;

                if (VARIABLES.flag_sequence == false )
                {

                    VARIABLES.flag_sequence = true;
                    VARIABLES.sequence++;
                }


                VARIABLES.data = "<CA" + VARIABLES.sequence.ToString() + "000000>";
                VARIABLES.sport.Write(VARIABLES.data);
                IHM3();
                
                //envoie de message CAx000000           
            }

            else

            {
                MessageBox.Show("Veuillez d'abord vous connecter au Bluetooth", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


        private void b_control_Click(object sender, EventArgs e)
        {
            if (VARIABLES.sport.IsOpen== true)
            {

                if (VARIABLES.flag_sequence == false)
                {
                    VARIABLES.flag_sequence = true;
                    VARIABLES.sequence++;
                }

                mode_manu();
            }

            else

            {
                MessageBox.Show("Veuillez d'abord vous connecter au Bluetooth", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Appuie sur le bout debug
        private void b_bluetooth_Click(object sender, EventArgs e)
        {

            try
            {
                VARIABLES.sport.Open();
            }
            catch (Exception ex)
            {

                if (VARIABLES.sport.IsOpen == true)
                {
                    MessageBox.Show("Vous êtes déjà connecté sur Bluetooth", "BLUETOOTH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    MessageBox.Show("Problème de connexion Bluetooth","BLUETOOTH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }



        // #############   TIMER 1  ################

        private void timer1_Tick(object sender, EventArgs e)
        {


            message_recu = tbClientReceivers[clientIdx].Text;



            // PAGE DE CONNEXION ENTRE IHM

            if (VARIABLES.ihm_connecter == false)
            {
                this.Hide();
            }

            if (VARIABLES.ihm_connecter == true && VARIABLES.flag_connexion == true)
            {
                this.Show();

                VARIABLES.flag_connexion = false;


                ClientPipe clientPipe = new ClientPipe(".", "Test", p => p.StartStringReaderAsync());
                clientPipes.Add(clientPipe);

                CreateClientUI();

                clientPipe.DataReceived += (sndr, args) =>
                    this.BeginInvoke(() =>
                        tbClientReceivers[clientIdx].Text = args.String); // args.String

                clientPipe.Connect();
            }


            // GESTION DE l'icone bluetooth


            if (VARIABLES.sport.IsOpen == true)
            {
                pb_bluetooth_nok.Visible = false;
                pb_bluetooth_ok.Visible = true;
                lb_bluetooth.Text = "OK";
            }


            if (VARIABLES.sport.IsOpen == false)
            {
                pb_bluetooth_nok.Visible =true;
                pb_bluetooth_ok.Visible = false;
                lb_bluetooth.Text = "N/A";
            }

            // GESTION DES MESSAGES RECUS

            if (message_recu[0] =='M')
            {
                VARIABLES.flag_mode_de_marche = false;
                IHM2();
                VARIABLES.sport.Close();
                // envoie de séquence
                VARIABLES.sequence = int.Parse(message_recu.Remove(0,1));

                tbClientReceivers[0].Text = "      ";       // effacer le textbox de réception    
            }

            if (message_recu[0] == 'A')
            {
                try
                {
                    VARIABLES.sport.Open();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                VARIABLES.flag_mode_de_marche = true;

                // envoie de séquence
                VARIABLES.sequence = int.Parse(message_recu.Remove(0, 1));

                tbClientReceivers[0].Text = "      ";           // effacer le textbox de réception          
            }

            // GESTIOND DES MODES DE MARCHES
            if (VARIABLES.flag_mode_de_marche == true)
            {
      
                b_modeauto.Enabled = false;
                b_modemanu.Enabled = true;
                this.Show();
            }

            if (VARIABLES.flag_mode_de_marche == false)
            {
         
                b_modemanu.Enabled = true;
                b_modeauto.Enabled = true;
            }

           
            // réception de ce qu'envoie l'IHM auto 2
            if (VARIABLES.envoie_auto == true)
            {
                VARIABLES.envoie_auto = false;
                VARIABLES.flag_mode_de_marche = true;

                string message = "A" + VARIABLES.sequence.ToString();
                clientPipes[clientIdx].WriteString(message);

                VARIABLES.sport.Open();
            }
            
                       

            // gestion des LEDs d'étapes

                chenillard(); //debug
          

        }

        
        // ######## GESTION DES AFFICHAGES ########
        
        // affichage ihm auto 2

        private void IHM2()
        {      
            IHM_AUTO_2 f2 = new IHM_AUTO_2();
            f2.Show();
            this.Hide();
        }

        // affichage debug
        
        private void debug()
        {
            DEBUG f3 = new DEBUG();
            f3.Show();
        }

        // affichage ihm_auto_3

        private void IHM3()
        {
            IHM_AUTO_3 f4 = new IHM_AUTO_3();
            f4.Show();
        }


        // affichage mode manuelle

            private void mode_manu()
        {
            Mode_manuel f5 = new Mode_manuel();
            f5.Show();
        }

        //affichage ihm connecter

            private void ihm_connecter()
        {
            IHM_connecter f6 = new IHM_connecter();
            f6.Show();
        }


        //fonction chenillard

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

           // VARIABLES.sequence++;

            if (VARIABLES.sequence > 6) VARIABLES.sequence = 1;
        }

        private void IHM_AUTO_1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
