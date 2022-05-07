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
    public partial class frmMokkivalinta : Form
    {
        private static MySqlConnection connection;
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;
        public string IP, Tietonimi, ID, pass;
        public uint Port;
        public frmMokkivalinta()
        {
            InitializeComponent();
            using (StreamReader read = new StreamReader("C:\\Temp\\Asiakastiedot.txt"))
            {
                IP = read.ReadLine();
                Port = uint.Parse(read.ReadLine());
                Tietonimi = read.ReadLine();
                ID = read.ReadLine();
            }
            using (StreamReader read = new StreamReader("C:\\Temp\\Asiakastiedot.txt"))
            {
                pass = read.ReadLine();
            }
        }
        public void populateDGV()
        {
            string query = "SELECT * FROM mokki";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgwMokkivalinta.DataSource = table;
        }
        private void btnVaraaM_Click(object sender, EventArgs e)
        {
            //string insertquery = "INSERT INTO posti(postinro, toimipaikka) VALUES('70780','Kuopio')";
            //DataTable table = new DataTable();
            //MySqlDataAdapter adapter = new MySqlDataAdapter(insertquery, connection);
            //adapter.Fill(table);
            //dgwMokkivalinta.DataSource = table;
            populateDGV();
                frmVaraus lasku = new frmVaraus();
                lasku.Show();
        }

        private void frmMokkivalinta_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = IP;
                builder.Port = Port;
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

        private void btnAsiakkaisiin_Click(object sender, EventArgs e)
        {
            frmTiedot at = new frmTiedot();
            at.Show();
        }

        private void dgwMokkivalinta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMokinnimi.Text = dgwMokkivalinta.CurrentRow.Cells[1].Value.ToString();
            tbKatuosoite.Text = dgwMokkivalinta.CurrentRow.Cells[2].Value.ToString();
            tbHinta.Text = dgwMokkivalinta.CurrentRow.Cells[3].Value.ToString();
            tbKuvaus.Text = dgwMokkivalinta.CurrentRow.Cells[4].Value.ToString();
            tbMax.Text = dgwMokkivalinta.CurrentRow.Cells[5].Value.ToString();
            tbVarustelu.Text = dgwMokkivalinta.CurrentRow.Cells[6].Value.ToString();
            tbPostiN.Text = dgwMokkivalinta.CurrentRow.Cells[7].Value.ToString();

        }

        private void chkPaikanP_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void chkLasku_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
