﻿using System;
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
        {//Avataan yhteys tietokantaan 
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("connection failed" + ex);
            }
            populateDGV();//Päivitetään datagridview tietokannan tiedoilla
            AlueID();
            HaePostit(); //Haetaan postit
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
        {//Tarkistetaan kumpaa tietoa päivitetään
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
        private void HaePostit()
        {//Haetaan postinumerot comboboxiin tietokannasta
            string PostiNumero;
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
        private void btnAsiakkaat_Click(object sender, EventArgs e)
        {
            frmAsiakastiedot a = new frmAsiakastiedot();
            a.Show();
        }

        private void btnMokki_Click(object sender, EventArgs e)
        {
        }

        private void btnLisaaAlue_Click(object sender, EventArgs e)
        {//Lisätään uusi alue tietokantaan painike näkyy vain jos alueen muokkaus on valittu
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
        {//Datagridviewi:n riviä painamalla tulee valitut tiedot näkyviin mökin laatikoihin
            tbMokinnimi.Text = dgwMokki.CurrentRow.Cells[1].Value.ToString();
            tbKatuosoite.Text = dgwMokki.CurrentRow.Cells[2].Value.ToString();
            tbHinta.Text = dgwMokki.CurrentRow.Cells[3].Value.ToString();
            tbKuvaus.Text = dgwMokki.CurrentRow.Cells[4].Value.ToString();
            tbMax.Text = dgwMokki.CurrentRow.Cells[5].Value.ToString();
            tbVarustelu.Text = dgwMokki.CurrentRow.Cells[6].Value.ToString();
            cbPostiN.Text = dgwMokki.CurrentRow.Cells[7].Value.ToString();
            Hallinta.mokinvalittuID = (int)dgwMokki.CurrentRow.Cells[0].Value;
            string query = "SELECT nimi FROM alue WHERE alue_id = '" + (int)dgwMokki.CurrentRow.Cells[8].Value + "'";
            MySqlCommand Aluenimi = new MySqlCommand(query, connection);
            connection.Open();
            cbAlueid.Text = Aluenimi.ExecuteScalar().ToString();
            connection.Close();
        }

        private void dgwAlue_CellClick(object sender, DataGridViewCellEventArgs e)
        {//Alueen datagridview:n riviä klikkaamalla tulee tiedot näkyviin alueiden laatikoihin
            tbAlue.Text = dgwAlue.CurrentRow.Cells[1].Value.ToString();
            Hallinta.alueenvalittuID = (int)dgwAlue.CurrentRow.Cells[0].Value;
        }

        private void btnPoistaAlue_Click(object sender, EventArgs e)
        {//Poistetaan alue tietokannasta
            string query = "DELETE FROM alue WHERE alue_id = '" + Hallinta.alueenvalittuID + "'";
            ExecuteMyQuery(query);
            populateDGV();
            tbAlue.Clear();
        }

        private void btnPoistaMokki_Click(object sender, EventArgs e)
        {//Poistetaan mökki tietokannasta
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
        {//Lisätään mökki tietokantaan tarkistetaan että kaikki tiedot on mitä tarvitaan
            double Hinta;
            int HenkMaara;
            if (tbMokinnimi.Text == "" || tbKatuosoite.Text == "" || tbHinta.Text == "" || tbKuvaus.Text == "" || tbMax.Text == "" || tbVarustelu.Text == "" || cbPostiN.Text == "" || cbAlueid.Text == "")
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
                        HenkMaara = int.Parse(tbMax.Text);//Laitetaan sql komento toimimaan ja lisätään mökki
                        string lisaaQuery = "INSERT INTO mokki(mokkinimi,katuosoite,hinta,kuvaus,henkilomaara,varustelu,postinro,alue_id) VALUES('" + tbMokinnimi.Text + "','" + tbKatuosoite.Text + "','" + Hinta + "','" + tbKuvaus.Text + "','" + HenkMaara + "','" + tbVarustelu.Text + "','" + cbPostiN.Text + "','" + Hallinta.alueenvalittuID + "');";
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
            cbPostiN.Text = "";
            cbAlueid.Text = "";
        }
        private void AlueID()
        {//Haetaan alueen tiedot comboboxiin josta käyttäjä voi valita niitä
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
            //Haetaan alueen id jotta voidaan käyttää sitä muissa funktioissa ja se lisätään luokkaan
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
            NaytaAlue();//Kutsutaan näytäalueen funktiota
        }

        private void rdbMokki_CheckedChanged(object sender, EventArgs e)
        {
            NaytaMokki();//Kutsutaan näytämökki funktiota
        }
        public void NaytaAlue()
        {//Jos radiobutton on painettu näytetään alueiden tiedot ja peitetään mökin tiedot
            if (rdbAlue.Checked == true)
            {
                panel3.Visible = true;
                panel1.Visible = false;
                panel2.Visible = false;
                dgwMokki.Enabled = false;
                dgwMokki.Visible = false;
                tbMokinnimi.Visible = false;
                tbKatuosoite.Visible = false;
                tbHinta.Visible = false;
                tbKuvaus.Visible = false;
                tbMax.Visible = false;
                tbVarustelu.Visible = false;
                cbPostiN.Visible = false;
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
        {//Jos radiobutton on painettu näytetään mökin tiedot ja piilotetaan alueen tiedot
            if (rdbMokki.Checked == true)
            {
                panel1.Visible = true;
                panel2.Visible = true;
                panel3.Visible = false;
                dgwMokki.Enabled = true;
                dgwMokki.Visible = true;
                tbMokinnimi.Visible = true;
                tbKatuosoite.Visible = true;
                tbHinta.Visible = true;
                tbKuvaus.Visible = true;
                tbMax.Visible = true;
                tbVarustelu.Visible = true;
                cbPostiN.Visible = true;
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

        private void cbPostiN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
