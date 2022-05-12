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
        {//yhteyden luominen tietokantaan
            Tiedot.id = 0;
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
        {//Tyhjennetään kaikki kentät lisäyksen/päivityksen/poiston jälkeen
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
            if (lblID.Text == "0")
            {
                MessageBox.Show("Asiakasta ei ole valittu ole hyvä ja valitse asiakas"); //Tarkastetaan että asiakas on valittu kenen nimellä varaus tehdään
            }
            else
            {//kun asiakas on valittu varmistetaan tiedot oikeiksi
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
                }//Tarkistetaan uudelleen onko asiakas valittu
                else
                {
                    frmMokkivalinta valinnat = new frmMokkivalinta(); 
                    valinnat.Show();
                    this.Hide();
                }
            }

        }
        private void Postinumerot()
        {//Ladataan postinumerot tietokannasta valmiiksi
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
        {//päivitetään datagridview
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
        {//Käyttäjä voi valita datagridview:stä tietoja klikkaamalla rivejä ja tiedot tulevat näkyviin tekstikenttiin
            lblID.Text = dgvAsiakkaat.CurrentRow.Cells[0].Value.ToString();
            txtEtu.Text = dgvAsiakkaat.CurrentRow.Cells[1].Value.ToString();
            txtSuku.Text = dgvAsiakkaat.CurrentRow.Cells[2].Value.ToString();
            txtPostiO.Text = dgvAsiakkaat.CurrentRow.Cells[3].Value.ToString();
            txtSahko.Text = dgvAsiakkaat.CurrentRow.Cells[4].Value.ToString();
            txtPuhelin.Text = dgvAsiakkaat.CurrentRow.Cells[5].Value.ToString();
            cbPostiN.Text = dgvAsiakkaat.CurrentRow.Cells[6].Value.ToString();
            string Query = "SELECT toimipaikka FROM posti WHERE postinro = '"+cbPostiN.Text+"' "; // Toimipaikka valitaan sql kyselyllä postinumeron mukaan
            ExecuteMyQuery(Query);
            DataTable table2 = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(Query, connection);
            adapter.Fill(table2);
            dgwVali.DataSource = table2;
            txtPostiP.Text = dgwVali.CurrentRow.Cells[0].Value.ToString();
        }

        private void frmAsiakastiedot_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void Tyhjenna()
        {//tyhjennetään kentät 
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
            //Lisätään asiakas ja tarkistetaan onko sähköpostiosoite oikein kirjoitettu 
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
                {//sitten lisätään asiakas tietokantaan sekä postinumero postitoimipaikkoineen posti tauluun
                    string insertQuery2 = "INSERT INTO posti(postinro,toimipaikka) VALUES('" + cbPostiN.Text + "','" + txtPostiP.Text + "')";
                    ExecuteMyQuery(insertQuery2);
                    string insertQuery = "INSERT INTO asiakas(etunimi,sukunimi,lahiosoite,sahkoposti,puhelinnro,postinro) VALUES('" + txtEtu.Text + "','" + txtSuku.Text + "','" + txtPostiO.Text + "','" + txtSahko.Text + "','" + txtPuhelin.Text + "','" + cbPostiN.Text + "')";
                    ExecuteMyQuery(insertQuery);
                }
                catch (Exception ex)
                {

                }
                populateDGV();
                Tyhjenna();
            }
            
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {//Poistetaan valittu asiakas
            string Delete = "DELETE FROM asiakas WHERE asiakas_id = ('"+lblID.Text+"')";
            ExecuteMyQuery(Delete);
            populateDGV();
        }

        private void btnPaivita_Click(object sender, EventArgs e)
        {//päivitetään tietoja asiakkaan ID tulee olla valittu, joka onnistuu kun datagridview:n riviä klikataan
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

        private void dgvAsiakkaat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMajoitusvaraukset_Click(object sender, EventArgs e)
        {
            Majoitusvaraukset m = new Majoitusvaraukset();
            m.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbPostiN_TextChanged(object sender, EventArgs e)
        {//haetaan postitoimipaikka kun postinumero vaihtuu jos sitä ei löydy ei anneta mitään
            string haeToimipaikka = "SELECT toimipaikka FROM posti WHERE postinro = '" + cbPostiN.Text + "' ";
            MySqlCommand Toimipaikka = new MySqlCommand(haeToimipaikka, connection);
            connection.Open();
            object test = Toimipaikka.ExecuteScalar();
            connection.Close();
            if (test == null)
            {

            }
            else
            {
                connection.Open();
                txtPostiP.Text = Toimipaikka.ExecuteScalar().ToString();
                connection.Close();
            }
        }
    }
}
