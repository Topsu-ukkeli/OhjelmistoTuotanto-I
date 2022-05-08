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
using Mokkivaraus.Model;

namespace Mokkivaraus
{
    public partial class frmMokkivalinta : Form
    {
        private static MySqlConnection connection;
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;

        public frmMokkivalinta()
        {
            InitializeComponent();
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
                builder.Server = LoginInfo.IP;
                builder.Port = LoginInfo.Port;
                builder.UserID = LoginInfo.User;
                builder.Password = LoginInfo.Pass;
                builder.Database = LoginInfo.Name;
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
