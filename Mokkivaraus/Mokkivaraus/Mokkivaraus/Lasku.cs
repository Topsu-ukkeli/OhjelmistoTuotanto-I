using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;

namespace Mokkivaraus
{
    public partial class frmVaraus : Form
    {
        private static MySqlConnection connection;
        public string IP, Tietonimi, ID, Port;
        public frmVaraus()
        {
            using (StreamReader read = new StreamReader("C:\\Temp\\Asiakastiedot.txt"))
            {
                IP = read.ReadLine();
                Port = read.ReadLine();
                Tietonimi = read.ReadLine();
                ID = read.ReadLine();
            }
            InitializeComponent();
        }

        private void Lasku_Load(object sender, EventArgs e)
        {

        }

        private void frmVaraus_Load(object sender, EventArgs e)
        {
            uint portparsed;
            portparsed = uint.Parse(Port);
            try
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = IP;
                builder.Port = portparsed;
                builder.UserID = ID;
                builder.Password = "Ruutti";
                builder.Database = Tietonimi;
                builder.SslMode = MySqlSslMode.None;
                connection = new MySqlConnection(builder.ToString());
                //MessageBox.Show("Database connection successfull", "Connection", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("connection failed" + ex);
            }
            populateDGV();
        }
        public void populateDGV()
        {
            string query = "SELECT * FROM varaus";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgvVaraus.DataSource = table;
        }
    }
}
