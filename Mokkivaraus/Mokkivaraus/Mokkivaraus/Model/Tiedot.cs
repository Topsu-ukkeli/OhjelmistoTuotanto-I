using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mokkivaraus.Model
{
    class Tiedot
    {
        public int id { get; set; }
        public int mokkiID { get; set; }
        public string Katuosoite { get; set; }
        public string Hinta { get; set; }
        public string Kuvaus { get; set; }
        public string Henkilomaara { get; set; }
        public string Varustelu { get; set; }
        public string Postinumero { get; set; }

    }
}
