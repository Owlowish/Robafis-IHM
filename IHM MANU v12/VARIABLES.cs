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
        public static Boolean flag_mode_de_marche = false; // false = mode manuel / true = mode automatique
       public static Boolean envoie_manu = false;

        public static Boolean flag_init = true;
       
        public static Boolean bluetooth = true;
        public static Boolean robot = true;
     
        public static SerialPort sport; // a mettre en variable globale
        public static string data = "";  //a mettre en variable globale

        public static Boolean ihm_connecter = false;
        public static Boolean flag_connecter = false;

        //séquence
        public static Boolean limiteVitesse = false;
        public static int sequence = 0;
        public static Boolean sequence_envoie = false;


       
        public static int pos = 0;
        public static int posPrec = 0;
        public static String virage;



        public static Boolean flag1 = false;
        public static Boolean flag_aide = false;
      

        public static Gamepad Controller;

        //flags

        public static Boolean flag_sequence = false;
        public static Boolean fermer_aide = false;
    }
}
