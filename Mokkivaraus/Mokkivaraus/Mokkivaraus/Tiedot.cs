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
    public partial class frmTiedot : Form
    {
        private static MySqlConnection connection;
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;
        public frmTiedot()
        {
            InitializeComponent();
        }

        private void frmTiedot_Load(object sender, EventArgs e)
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
            AlueID();
            //HaeAlueet();
            if (rdbAlue.Checked == true)
            {
                NaytaAlue();
            }
            else
            {
                NaytaMokki();
            }
        }

        public void populateDGV()
        {
            if (rdbAlue.Checked == true)
            {
                string query = "SELECT * FROM alue";
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                adapter.Fill(table);
                dgwAlue.DataSource = table;
            }
            else if (rdbMokki.Checked == true)
            {
                string query2 = "SELECT * FROM mokki";
                DataTable table2 = new DataTable();
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(query2, connection);
                adapter2.Fill(table2);
                dgwMokki.DataSource = table2;
            }
        }
        private void HaeAlueet()
        {
            string Postit,Posti;
            int postinro;
            string query = "SELECT MAX(postinro) FROM posti;";
            MySqlCommand PostiN = new MySqlCommand(query, connection);
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            connection.Open();
            Postit = PostiN.ExecuteScalar().ToString();
            postinro = int.Parse(Postit);
            for (int i = 1; i <= postinro; i++)
            {
                string query2 = "SELECT postinro FROM posti WHERE postinro = '" + i + "'";
                MySqlCommand Alue2 = new MySqlCommand(query2, connection);
                object test = Alue2.ExecuteScalar();
                if (test == null)
                {

                }
                else
                {
                    Posti = Alue2.ExecuteScalar().ToString();
                    cbPostiN.Items.Add(Posti);
                }

            }
            connection.Close();
        }
        private void btnAsiakkaat_Click(object sender, EventArgs e)
        {
            frmAsiakastiedot a = new frmAsiakastiedot();
            a.Show();
        }

        private void btnMokki_Click(object sender, EventArgs e)
        {
        }

        private void btnLisaaAlue_Click(object sender, EventArgs e)
        {
            if (tbAlue.Text == "")
            {
                MessageBox.Show("Anna alueen nimi!");
            }
            else if (tbAlue.Text != "")
            {
                for (int i = 0; i < dgwAlue.Rows.Count; i++)
                {
                    if (tbAlue.Text == dgwAlue.Rows[i].Cells[1].Value.ToString())
                    {
                        i--;
                        break;
                    }
                    else if (tbAlue.Text != dgwAlue.Rows[i].Cells[1].Value.ToString() && i + 1 == dgwAlue.Rows.Count)
                    {
                        string LisaaAlue = "INSERT INTO alue(nimi) values ('" + tbAlue.Text + "')";
                        ExecuteMyQuery(LisaaAlue);
                        populateDGV();
                    }
                }
                tbAlue.Clear();
            }
            Hallinta.alueenvalittuID = 0;
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

        private void dgwMokki_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgwMokki_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMokinnimi.Text = dgwMokki.CurrentRow.Cells[1].Value.ToString();
            tbKatuosoite.Text = dgwMokki.CurrentRow.Cells[2].Value.ToString();
            tbHinta.Text = dgwMokki.CurrentRow.Cells[3].Value.ToString();
            tbKuvaus.Text = dgwMokki.CurrentRow.Cells[4].Value.ToString();
            tbMax.Text = dgwMokki.CurrentRow.Cells[5].Value.ToString();
            tbVarustelu.Text = dgwMokki.CurrentRow.Cells[6].Value.ToString();
            tbPostiN.Text = dgwMokki.CurrentRow.Cells[7].Value.ToString();
            Hallinta.mokinvalittuID = (int)dgwMokki.CurrentRow.Cells[0].Value;
            string query = "SELECT nimi FROM alue WHERE alue_id = '" + (int)dgwMokki.CurrentRow.Cells[8].Value + "'";
            MySqlCommand Aluenimi = new MySqlCommand(query, connection);
            connection.Open();
            cbAlueid.Text = Aluenimi.ExecuteScalar().ToString();
            connection.Close();
        }

        private void dgwAlue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbAlue.Text = dgwAlue.CurrentRow.Cells[1].Value.ToString();
            Hallinta.alueenvalittuID = (int)dgwAlue.CurrentRow.Cells[0].Value;
        }

        private void btnPoistaAlue_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM alue WHERE alue_id = '" + Hallinta.alueenvalittuID + "'";
            ExecuteMyQuery(query);
            populateDGV();
            tbAlue.Clear();
        }

        private void btnPoistaMokki_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Haluatko varmasti poistaa tiedot?", "Olet poistamassa tietoja", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                if (Hallinta.mokinvalittuID == 0)
                {
                    MessageBox.Show("toimii");
                }
                else
                {
                    string query = "DELETE FROM mokki WHERE mokki_id = '" + Hallinta.mokinvalittuID + "';";
                    ExecuteMyQuery(query);
                    populateDGV();
                    poisto();
                    Hallinta.mokinvalittuID = 0;
                }
            }
            else if (Result == DialogResult.No)
            {

            }
        }

        private void btnLisaaMokki_Click(object sender, EventArgs e)
        {
            double Hinta;
            int HenkMaara;
            if (tbMokinnimi.Text == "" || tbKatuosoite.Text == "" || tbHinta.Text == "" || tbKuvaus.Text == "" || tbMax.Text == "" || tbVarustelu.Text == "" || tbPostiN.Text == "" || cbAlueid.Text == "")
            {
                MessageBox.Show("Tietoja puuttuu ole hyvä ja täytä kaikki tiedot");
            }
            else
            {
                for (int i = 0; i < dgwMokki.Rows.Count; i++)
                {
                    if (tbMokinnimi.Text == dgwMokki.Rows[i].Cells[1].Value.ToString())
                    {

                    }
                    else if (tbMokinnimi.Text != dgwMokki.Rows[i].Cells[1].Value.ToString() && i + 1 == dgwMokki.Rows.Count)
                    {
                        Hinta = double.Parse(tbHinta.Text);
                        HenkMaara = int.Parse(tbMax.Text);
                        string lisaaQuery = "INSERT INTO mokki(mokkinimi,katuosoite,hinta,kuvaus,henkilomaara,varustelu,postinro,alue_id) VALUES('" + tbMokinnimi.Text + "','" + tbKatuosoite.Text + "','" + Hinta + "','" + tbKuvaus.Text + "','" + HenkMaara + "','" + tbVarustelu.Text + "','" + tbPostiN.Text + "','" + Hallinta.alueenvalittuID + "');";
                        ExecuteMyQuery(lisaaQuery);
                        populateDGV();
                    }
                }
                poisto();
            }
            Hallinta.mokinvalittuID = 0;
        }
        private void poisto()
        {
            tbMokinnimi.Clear();
            tbKatuosoite.Clear();
            tbHinta.Clear();
            tbKuvaus.Text = "";
            tbMax.Clear();
            tbVarustelu.Clear();
            tbPostiN.Clear();
            cbAlueid.Text = "";
        }
        private void AlueID()
        {
            string Alue;
            int Posti = dgwAlue.Rows.Count;
            for (int i = 0; i < Posti; i++)
            {
                Alue = dgwAlue.Rows[i].Cells[1].Value.ToString();
                cbAlueid.Items.Add(Alue);
            }
        }

        private void cbAlueid_SelectedIndexChanged(object sender, EventArgs e)
        {

            string query = "SELECT alue_id FROM alue WHERE nimi = '" + cbAlueid.Text + "'";
            MySqlCommand AlueID = new MySqlCommand(query, connection);
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            connection.Open();
            Hallinta.alueenvalittuID = (int)AlueID.ExecuteScalar();
            connection.Close();
        }

        private void cbAlueid_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void rdbAlue_CheckedChanged(object sender, EventArgs e)
        {
            NaytaAlue();
        }

        private void rdbMokki_CheckedChanged(object sender, EventArgs e)
        {
            NaytaMokki();
        }
        public void NaytaAlue()
        {
            if (rdbAlue.Checked == true)
            {
                dgwMokki.Enabled = false;
                dgwMokki.Visible = false;
                tbMokinnimi.Visible = false;
                tbKatuosoite.Visible = false;
                tbHinta.Visible = false;
                tbKuvaus.Visible = false;
                tbMax.Visible = false;
                tbVarustelu.Visible = false;
                tbPostiN.Visible = false;
                cbAlueid.Visible = false;
                btnLisaaMokki.Visible = false;
                btnPoistaMokki.Visible = false;
                lblMokinnimi.Visible = false;
                lblkatu.Visible = false;
                lblHinta.Visible = false;
                lblKuvaus.Visible = false;
                lblVarustelu.Visible = false;
                lblPostiN.Visible = false;
                lblMax.Visible = false;
                lblAlueV.Visible = false;
                cbPostiN.Visible = false;
                tbAlue.Visible = true;
                btnLisaaAlue.Visible = true;
                btnPoistaAlue.Visible = true;
                lblAlue.Visible = true;
                dgwAlue.Visible = true;
                dgwAlue.Enabled = true;
                populateDGV();
            }
        }
        public void NaytaMokki()
        {
            if (rdbMokki.Checked == true)
            {
                dgwMokki.Enabled = true;
                dgwMokki.Visible = true;
                tbMokinnimi.Visible = true;
                tbKatuosoite.Visible = true;
                tbHinta.Visible = true;
                tbKuvaus.Visible = true;
                tbMax.Visible = true;
                tbVarustelu.Visible = true;
                tbPostiN.Visible = true;
                cbAlueid.Visible = true;
                btnLisaaMokki.Visible = true;
                btnPoistaMokki.Visible = true;
                lblMokinnimi.Visible = true;
                lblkatu.Visible = true;
                lblHinta.Visible = true;
                lblKuvaus.Visible = true;
                lblVarustelu.Visible = true;
                lblPostiN.Visible = true;
                lblMax.Visible = true;
                lblAlueV.Visible = true;
                cbPostiN.Visible = true;
                tbAlue.Visible = false;
                btnLisaaAlue.Visible = false;
                btnPoistaAlue.Visible = false;
                lblAlue.Visible = false;
                dgwAlue.Enabled = false;
                dgwAlue.Visible = false;
                populateDGV();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PalveluidenHallinta p = new PalveluidenHallinta();
            p.Show();
        }
    }
}
