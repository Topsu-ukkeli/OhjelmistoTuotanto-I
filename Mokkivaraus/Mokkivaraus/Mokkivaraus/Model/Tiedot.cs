using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mokkivaraus.Model
{
    class Tiedot
    {
        public static int id { get; set; }
        public static int mokkiID { get; set; }
        public static List<string> Palvelut { get; set; } 
        public static string alueid { get; set; }
        public static string Hinta { get; set; }
        public static string Kuvaus { get; set; }
        public static string Henkilomaara { get; set; }
        public static string Varustelu { get; set; }
        public static string Postinumero { get; set; }

    }
}
