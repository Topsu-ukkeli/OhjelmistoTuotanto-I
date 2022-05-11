using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mokkivaraus.Model
{
    class Hallinta
    {
        public static int mokinvalittuID { get; set; }
        public static int alueenvalittuID { get; set; }
        public static int Alueidenmaara { get; set; }
        public static List<string> Alueet { get; set; }
        public static int PalveluidenID { get; set; }
        public static int AlueidenID { get; set; }
        public static int PostiID { get; set; }
        public static int MajoitusAsiakasID { get; set; }
        public static int MajoitusMokkiID { get; set; }
        public static int MajoitusVarausID { get; set; }
    }
}
