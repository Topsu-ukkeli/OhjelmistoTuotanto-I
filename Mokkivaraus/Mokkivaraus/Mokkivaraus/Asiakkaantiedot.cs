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
    public partial class frmAsiakastiedot : Form
    {
        private static MySqlConnection connection;
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;
        int i = 4;
        public frmAsiakastiedot()
        {
            InitializeComponent();
        }

        private void frmAsiakastiedot_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = "127.0.0.1";
                builder.Port = 3307;
                builder.UserID = "root";
                builder.Password = "Ruutti";
                builder.Database = "Mokkivaraus";
                builder.SslMode = MySqlSslMode.None;
                connection = new MySqlConnection(builder.ToString());
                MessageBox.Show("Database connection successfull", "Connection", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("connection failed" + ex);
            }
        }

        private void btnVarauksiin_Click(object sender, EventArgs e)
        {
            populateDGV();
            frmMokkivalinta valinnat = new frmMokkivalinta(); // tähän täytyy tehdä postinumeron tarkistus saadaan vanhasta työstä jos numeroa ei löydy se lisätään niin myös henkilöön kuin postiin
            valinnat.Show();
            string insertQuery2 = "INSERT INTO posti(postinro,toimipaikka) VALUES('" + cbPostiN.Text + "','" + txtPostiP.Text + "')";
            ExecuteMyQuery(insertQuery2);
            string insertQuery = "INSERT INTO asiakas(asiakas_id,etunimi,sukunimi,lahiosoite,sahkoposti,puhelinnro,postinro) VALUES('" + i + "','" + txtEtu.Text + "','" + txtSuku.Text + "','" + txtPostiO.Text + "','" + txtSahko.Text + "','" + txtPuhelin.Text + "','" + cbPostiN.Text + "')";
            ExecuteMyQuery(insertQuery);
            //do
            //{
            //    i++;
            //    string insertQuery3 = "INSERT INTO asiakas(asiakas_id,etunimi,sukunimi,lahiosoite,sahkoposti,puhelinnro,postinro) VALUES('" + i + "','" + txtEtu.Text + "','" + txtSuku.Text + "','" + txtPostiO.Text + "','" + txtSahko.Text + "','" + txtPuhelin.Text + "','" + cbPostiN.Text + "')";
            //    ExecuteMyQuery(insertQuery3);
            //} while (cmd.ExecuteNonQuery() == 1);
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
                    MessageBox.Show("Kysely suoritettu");
                }
                else
                {
                    MessageBox.Show("Kyselyä ei suoritettu");
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
        public void populateDGV()
        {
            string query = "SELECT * FROM asiakas";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgwTest.DataSource = table;
        }

        private void btnAsiakkaat_Click(object sender, EventArgs e)
        {
            frmTiedot asiakkaat = new frmTiedot();
            asiakkaat.Show();
        }

        private void chkYksityinen_CheckedChanged(object sender, EventArgs e)
        {
            if(chkYksityinen.Checked == true)
            {
                chkYritys.Checked = false;
            }
        }

        private void chkYritys_CheckedChanged(object sender, EventArgs e)
        {
            if (chkYritys.Checked == true)
            {
                chkYksityinen.Checked = false;
            }
        }
    }
}
