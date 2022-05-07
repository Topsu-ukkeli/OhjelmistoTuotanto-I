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
        public string IP, Tietonimi, ID, Port, pass;

        public frmVaraus()
        {
            using (StreamReader read = new StreamReader("C:\\Temp\\Asiakastiedot.txt"))
            {
                IP = read.ReadLine();
                Port = read.ReadLine();
                Tietonimi = read.ReadLine();
                ID = read.ReadLine();
            }
            using (StreamReader read = new StreamReader("C:\\Temp\\Asiakastiedot.txt"))
            {
                pass = read.ReadToEnd();
            }
            InitializeComponent();
        }
        private void cbPaperilasku_CheckedChanged(object sender, EventArgs e)
        {
            bool visible;
            if (cbSpostilasku.Checked == true)
            {
                cbSpostilasku.Checked = false;
            }
            if (cbLaskutusosoite.Visible == false)
            {
                cbLaskutusosoite.Visible = true;
                visible = true;
                laskutusVisible(visible);
            }


        }

        private void cbSpostilasku_CheckedChanged(object sender, EventArgs e)
        {
            bool visible;
            if (cbPaperilasku.Checked == true)
            {
                cbPaperilasku.Checked = false;
            }
            if (cbLaskutusosoite.Visible == true)
            {
                cbLaskutusosoite.Visible = false;
                visible = false;
                laskutusVisible(visible);
            }

        }

        private void cbLaskutusosoite_CheckedChanged(object sender, EventArgs e)
        {
            bool visible;
            if (cbLaskutusosoite.Checked == false)
            {
                visible = true;
                laskutusVisible(visible);
            }
            if (cbLaskutusosoite.Checked == true)
            {
                visible = false;
                laskutusVisible(visible); 
            }

        }

        private void laskutusVisible(bool visible)
        {
            lblOsoite.Visible = visible;
            lblPostinumero.Visible = visible;
            lblPostitoimipaikka.Visible = visible;
            tbLosoite.Visible = visible;
            tbPostinum.Visible = visible;
            tbPostitoim.Visible = visible;
        }
        

        private void frmVaraus_Load(object sender, EventArgs e)
        {
            string pass;
            
            uint portparsed;
            portparsed = uint.Parse(Port);
            try
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = IP;
                builder.Port = portparsed;
                builder.UserID = ID;
                builder.Password = pass;
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
            string query = "SELECT MAX(varaus_id) FROM varaus";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgvVaraus.DataSource = table;
        }
    }
}
