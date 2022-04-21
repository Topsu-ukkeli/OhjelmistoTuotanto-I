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

namespace Mokkivaraus
{
    public partial class Kirjautuminen : Form
    {
        private static MySqlConnection connection;
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;
        public Kirjautuminen()
        {
            InitializeComponent();
        }

        private void Kirjautuminen_Load(object sender, EventArgs e)
        {
        }
        public void populateDGV()
        {
            //string query = "SELECT * FROM asiakas";
            //DataTable table = new DataTable();
            //MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            //adapter.fill(table);
            //dgwasiakas.datasource = table;
        }

        private void btnKirjaudu_Click(object sender, EventArgs e)//Tietokantaan kirjautuminen testaus
        {
            uint portti;
            portti = uint.Parse(txtPort.Text);
            try
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = txtIP.Text;
                builder.Port = portti;
                builder.UserID = txtID.Text;
                builder.Password = txtPass.Text;
                builder.Database = txtTietonimi.Text;
                builder.SslMode = MySqlSslMode.None;
                connection = new MySqlConnection(builder.ToString());
                MessageBox.Show("Database connection successfull", "Connection", MessageBoxButtons.OK);
                frmMokkivalinta m = new frmMokkivalinta();
                m.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("connection failed" + ex);
            }
            populateDGV();
        }
    }
}
