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
        Tiedot t = new Tiedot();
        int ID;
        List<Tiedot> tiedot = new List<Tiedot>();
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
                string Tanaan = dtpEhk.Value.ToString("yyyy-MM-dd");
                string Saapumis = dtpSaapumis.Value.ToString("yyyy-MM-dd");
                string Poistumis = dtpPoistumis.Value.ToString("yyyy-MM-dd");
                ID = (int)dgwMokinid.CurrentRow.Cells[0].Value;
                string insertquery = "INSERT INTO varaus(varattu_pvm ,varattu_alkupvm,varattu_loppupvm,asiakas_id ,mokki_id) VALUES ('" + Tanaan + "','" + Saapumis + "','" + Poistumis + "','" + Tiedot.id + "','" + ID + "');";
                ExecuteMyQuery(insertquery);
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
            Tiedot.alueid = dgwMokkivalinta.CurrentRow.Cells[8].Value.ToString();
            string Query = "SELECT mokki_id FROM mokki WHERE mokkinimi = '" + tbMokinnimi.Text + "' ";
            ExecuteMyQuery(Query);
            DataTable table2 = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(Query, connection);
            adapter.Fill(table2);
            dgwMokinid.DataSource = table2;
            string Aluequery = "SELECT (nimi) FROM palvelu WHERE alue_id = 5;";
            ExecuteMyQuery(Aluequery);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(Aluequery, connection);
            adapter2.Fill(table);
            dgwAlue.DataSource = table;
            int Alue = dgwAlue.Rows.Count;
            string Palvelut;
            for (int i = 0; i < Alue; i++)
            {
                Palvelut = dgwAlue.Rows[i].Cells[0].Value.ToString();
                lbPalvelut.Items.Add(Palvelut);
            }
        }

        private void chkPaikanP_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void chkLasku_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void ExecuteMyQuery(string query)
        {
            //tarkastetaan onko kysely mennyt läpi
            try
            {
                OpenConnection();
                cmd = new MySqlCommand(query, connection);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    //MessageBox.Show("Kysely suoritettu");
                }
                else
                {
                    //MessageBox.Show("Kyselyä ei suoritettu");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void lbPalvelut_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lbPalvelut_MouseClick(object sender, MouseEventArgs e)
        {
            lbValitutpalvelut.Items.Add(lbPalvelut.SelectedItem);
            lbPalvelut.Items.Remove(lbPalvelut.SelectedItem);
        }

        private void lbValitutpalvelut_MouseClick(object sender, MouseEventArgs e)
        {
            lbPalvelut.Items.Add(lbValitutpalvelut.SelectedItem);
            lbValitutpalvelut.Items.Remove(lbValitutpalvelut.SelectedItem);
        }

        private void dgwMokkivalinta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
