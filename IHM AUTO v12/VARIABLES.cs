using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using Windows.Gaming.Input;

namespace PipesClientTest
{
    class VARIABLES
    {
        public static Boolean flag_mode_de_marche = false;  // true = mode auto ; false = mode manu
        public static Boolean envoie_auto = false;       
        public static Boolean sequence_envoie = false;
        public static Boolean ihm_connecter = false;
        public static Boolean flag_connexion = false;
            
       // public static int etape = 1;

        public static SerialPort sport; // a mettre en variable globale
        public static string data = "";  // a mettre en variable globale

        //séquence
        public static Boolean limiteVitesse = false;
        public static int sequence = 0;

        
        public static int pos = 0;
        public static int posPrec = 0;
        public static String virage;


        public static Gamepad Controller;

        //bool séquence

        public static Boolean flag_sequence = false;
        public static Boolean flag_aide = false;
        public static Boolean fermer_aide = false;


    }
}
