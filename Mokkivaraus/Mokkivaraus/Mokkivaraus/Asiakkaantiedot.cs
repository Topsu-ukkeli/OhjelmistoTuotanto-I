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
    public partial class frmAsiakastiedot : Form
    {
        List<Tiedot> tiedot = new List<Tiedot>();
        private static MySqlConnection connection;
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;
        string PostiNumero;
        public frmAsiakastiedot()
        {
            InitializeComponent();
        }

        private void frmAsiakastiedot_Load(object sender, EventArgs e)
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
            Postinumerot();
        }
        private void poisto()
        {
            txtEtu.Clear();
            txtSuku.Clear();
            txtPostiO.Clear();
            cbPostiN.Text = "";
            txtPostiP.Clear();
            txtSahko.Clear();
            txtPuhelin.Clear();
        }
        private void btnVarauksiin_Click(object sender, EventArgs e)
        {
                populateDGV();
                string Query = "SELECT asiakas_id FROM asiakas WHERE asiakas_id = '" + lblID.Text + "' ";
                ExecuteMyQuery(Query);
                DataTable table2 = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(Query, connection);
                adapter.Fill(table2);
                dgwVali.DataSource = table2;
                Tiedot.id = (int)dgwVali.CurrentRow.Cells[0].Value;
                populateDGV();
                Tyhjenna();
                if (Tiedot.id == 0)
                {
                    MessageBox.Show("Asiakasta ei ole valittu ole hyvä ja valitse asiakas");
                }
                else
                {
                    frmMokkivalinta valinnat = new frmMokkivalinta(); // tähän täytyy tehdä postinumeron tarkistus saadaan vanhasta työstä jos numeroa ei löydy se lisätään niin myös henkilöön kuin postiin
                    valinnat.Show();
                }
        }
        private void Postinumerot()
        {
            string Query = "SELECT postinro FROM posti WHERE postinro BETWEEN 00000 AND 99999;";
            ExecuteMyQuery(Query);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(Query, connection);
            adapter.Fill(table);
            dgwPostinro.DataSource = table;
            int Posti = dgwPostinro.Rows.Count;
            for (int i = 0; i < Posti; i++)
            {
                PostiNumero = dgwPostinro.Rows[i].Cells[0].Value.ToString();
                cbPostiN.Items.Add(PostiNumero);
            }
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
                //MessageBox.Show(e.Message);
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
            dgvAsiakkaat.DataSource = table;
        }

        private void btnAsiakkaat_Click(object sender, EventArgs e)
        {
            frmTiedot asiakkaat = new frmTiedot();
            asiakkaat.Show();
        }

        private void chkYksityinen_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void chkYritys_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnhae_Click(object sender, EventArgs e)
        {
        }

        private void dgvAsiakkaat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblID.Text = dgvAsiakkaat.CurrentRow.Cells[0].Value.ToString();
            txtEtu.Text = dgvAsiakkaat.CurrentRow.Cells[1].Value.ToString();
            txtSuku.Text = dgvAsiakkaat.CurrentRow.Cells[2].Value.ToString();
            txtPostiO.Text = dgvAsiakkaat.CurrentRow.Cells[3].Value.ToString();
            txtSahko.Text = dgvAsiakkaat.CurrentRow.Cells[4].Value.ToString();
            txtPuhelin.Text = dgvAsiakkaat.CurrentRow.Cells[5].Value.ToString();
            cbPostiN.Text = dgvAsiakkaat.CurrentRow.Cells[6].Value.ToString();
            string Query = "SELECT toimipaikka FROM posti WHERE postinro = '"+cbPostiN.Text+"' ";
            ExecuteMyQuery(Query);
            DataTable table2 = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(Query, connection);
            adapter.Fill(table2);
            dgwVali.DataSource = table2;
            txtPostiP.Text = dgwVali.CurrentRow.Cells[0].Value.ToString();
        }

        private void frmAsiakastiedot_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Result = MessageBox.Show("Haluatko poistua ilman tietojen tallennusta?", "Olet poistumassa tallentamatta!", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (Result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void Tyhjenna()
        {
            txtEtu.Clear();
            txtSuku.Clear();
            txtPostiO.Clear();
            cbPostiN.Text = "";
            txtPostiP.Clear();
            txtSahko.Clear();
            txtPuhelin.Clear();
        }
        private void btnLissee_Click(object sender, EventArgs e)
        {
            
            if (txtSahko.Text == "")
            {
                MessageBox.Show("Syötä sähköpostiosoite");
            }
            else if (txtSahko.Text.Contains("@") == false)
            {
                MessageBox.Show("Syötä toimiva sähköpostiosoite");

            }
            else if (txtSahko.Text.Contains(".com") == false && txtSahko.Text.Contains(".fi") == false)
            {
                MessageBox.Show("Syötä toimiva sähköpostiosoite");
            }
            else
            {
                try
                {
                    string insertQuery2 = "INSERT INTO posti(postinro,toimipaikka) VALUES('" + cbPostiN.Text + "','" + txtPostiP.Text + "')";
                    ExecuteMyQuery(insertQuery2);
                    string insertQuery = "INSERT INTO asiakas(etunimi,sukunimi,lahiosoite,sahkoposti,puhelinnro,postinro) VALUES('" + txtEtu.Text + "','" + txtSuku.Text + "','" + txtPostiO.Text + "','" + txtSahko.Text + "','" + txtPuhelin.Text + "','" + cbPostiN.Text + "')";
                    ExecuteMyQuery(insertQuery);
                }
                catch (Exception ex)
                {

                }
                populateDGV();
                poisto();
            }
            
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            string Delete = "DELETE FROM asiakas WHERE asiakas_id = ('"+lblID.Text+"')";
            ExecuteMyQuery(Delete);
            populateDGV();
        }

        private void btnPaivita_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lblID.Text);
            if(id <= 0)
            {

            }
            else
            {
                string Update = "UPDATE asiakas SET etunimi = '" + txtEtu.Text + "', sukunimi = '" + txtSuku.Text + "', lahiosoite = '" + txtPostiO.Text + "', puhelinnro = '" + txtPuhelin.Text + "', postinro = '" + cbPostiN.Text + "', sahkoposti = '" + txtSahko.Text + "'WHERE asiakas_id = '" + lblID.Text + "';";
                ExecuteMyQuery(Update);
                string Update2 = "UPDATE posti SET toimipaikka = '"+txtPostiP.Text+"' WHERE postinro = '" + cbPostiN.Text + "';";
                ExecuteMyQuery(Update2);
                populateDGV();
                Tyhjenna();
            }
        }
    }
}
