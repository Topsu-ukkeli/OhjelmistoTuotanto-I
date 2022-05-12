using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mokkivaraus.Model
{
    class Lasku
    {
        public static double Total { get; set; }
        public static double Alv { get; set; }
        public static int varausID { get; set; }
        public static string Vahvistus { get; set; }
        public static int LaskuID { get; set; }
    }
}
