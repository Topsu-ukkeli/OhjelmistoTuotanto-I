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
    public partial class frmVaraus : Form
    {
        private static MySqlConnection connection;
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;

        public frmVaraus()
        {
            InitializeComponent();
        }
        private void cbPaperilasku_CheckedChanged(object sender, EventArgs e)
        {
            bool visible;
            if (cbPaperilasku.Checked == true)
            {
                btnVahvista.Enabled = true;
                if (cbSpostilasku.Checked == true)
                {
                    cbSpostilasku.Checked = false;
                }
                if (cbLaskutusosoite.Visible == false)
                {
                    cbLaskutusosoite.Visible = true;
                }
            }
            else
            {
                cbLaskutusosoite.Visible = false;
                visible = false;
                laskutusVisible(visible);
            }
            
        }
        

        private void cbSpostilasku_CheckedChanged(object sender, EventArgs e)
        {

            if (cbSpostilasku.Checked == true)
            {
                if (cbPaperilasku.Checked == true)
                {
                    cbPaperilasku.Checked = false;
                }
                cbVahvistasposti.Visible = true;
                cbLaskutusosoite.Checked = false;
                btnVahvista.Enabled = true;
            }
            else
            {
                cbVahvistasposti.Checked = false;
                lblSposlasku.Visible = false;
                tbLsposti.Visible = false;
                cbVahvistasposti.Visible = false;
            }
        }
        private void cbVahvistasposti_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVahvistasposti.Checked == true)
            {
                lblSposlasku.Visible = true;
                tbLsposti.Visible = true;
            }
            else
            {
                lblSposlasku.Visible = false;
                tbLsposti.Visible = false;
            }
        }
        private void update(string add) //käydään hakemassa tarvittava tieto kyselyn avulla
        {
            string Query = "SELECT "+add +" FROM asiakas WHERE asiakas_id = '" + Tiedot.id + "';";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(Query, connection);
            adapter.Fill(table);
            dgvLasku.DataSource = table;
        }
        private void sendMail(string to)    //spostin lähetys
        {
            string subject = "Village Newbies -lasku";
            string from = "NootWare@gmail.com";
            string pass = "pofierqtrudvxeje"; //onetime password from google
            //SmtpClient mailClient = new SmtpClient("smtp.gmail.com");
            //mailClient.EnableSsl = true;
            //mailClient.Port = 587;
            //mailClient.Credentials = new System.Net.NetworkCredential(from, pass);
            try
            {
                //string lasku = "Tuote: " + textBox2.Text + "\nMäärä: " +  + "\nSumma: " + textBox4.Text + "\n Haluatko hienomman laskun?";
                //MailMessage msgMail = new MailMessage(from, to, subject, Text);
                //mailClient.Send(msgMail);
                MessageBox.Show("Lasku on lähetetty sähköpostiosoitteeseen:\n" + to);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void confirmed() //vitunpaskamopovittusaatana
        {
            string alku = Tiedot.Saapumispäivä.ToString("yyyy-MM-dd");
            string loppu = Tiedot.Poistumispäivä.ToString("yyyy-MM-dd");
            dtpAika.Value = DateTime.Today;
            string tanaan = dtpAika.Value.ToString("yyyy-MM-dd");
            string varaus = "insert into varaus(varattu_pvm, vahvistus_pvm, varattu_alkupvm, varattu_loppupvm, asiakas_id, mokki_id)" +
                " values('" + tanaan + "','" + tanaan + "','"
                + alku + "','" + loppu + "','" + Tiedot.id + "','" + Tiedot.mokkiID + "');";

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            connection.Open();
            cmd = new MySqlCommand(varaus, connection);
            cmd.ExecuteNonQuery();

            int alueid = (int)dgvVarausMokki.Rows[0].Cells[8].Value;
            int palveluid, varausid, palvelulkm;

            string varausidquery = "select varaus_id from varaus where asiakas_id ='" + Tiedot.id + "' and mokki_id = '" + Tiedot.mokkiID + "' and varattu_alkupvm = '" + alku + "' and varattu_pvm ='" + tanaan + "';";
            MySqlCommand cmd2 = new MySqlCommand(varausidquery, connection);
            varausid = (int)cmd2.ExecuteScalar();
            List<string> check = new List<string>();
            for (int i = 0; i < Tiedot.Palvelut.Count; i++)
            {
                if (check.Contains(Tiedot.Palvelut[i]) == false)
                {
                    List<string> lasketut = new List<string>();

                    string query = "select palvelu_id from palvelu where nimi ='" + Tiedot.Palvelut[i] + "' and alue_id = '" + alueid + "';";
                    MySqlCommand cmd1 = new MySqlCommand(query, connection);
                    palveluid = (int)cmd1.ExecuteScalar();

                    for (int j = 0; j < Tiedot.Palvelut.Count; j++)
                    {
                        if (Tiedot.Palvelut[j].Equals(Tiedot.Palvelut[i]) == true)
                        {
                            lasketut.Add(Tiedot.Palvelut[j]);
                        }
                    }
                    palvelulkm = lasketut.Count();
                    string varauksen_palvelut = "insert into varauksen_palvelut(palvelu_id, varaus_id, lkm) values('" + palveluid + "', '" + varausid + "','" + palvelulkm + "');";

                    MySqlCommand cmd3 = new MySqlCommand(varauksen_palvelut, connection);
                    cmd3.ExecuteNonQuery();
                    check.Add(Tiedot.Palvelut[i]);
                }
            }
            connection.Close();


        }

        private void btnVahvista_Click(object sender, EventArgs e)
        {
            
            
            
            if (cbPaperilasku.Checked == true || cbSpostilasku.Checked == true)
            {
                if (cbSpostilasku.Checked)
                {
                    string to = "";
                    if (cbVahvistasposti.Checked == true)
                    {
                        if (tbLsposti.Text == "")                   //tarkistellaan että syötetty sposti on oikeaa muotoa
                        {
                            MessageBox.Show("Syötä sähköpostiosoite");
                        }
                        else if (tbLsposti.Text.Contains("@") == false == false)
                        {
                            MessageBox.Show("Syötä toimiva sähköpostiosoite");

                        }
                        else if (tbLsposti.Text.Contains(".com") == false && tbLsposti.Text.Contains(".fi") == false)
                        {
                            MessageBox.Show("Syötä toimiva sähköpostiosoite");
                        }
                        else
                        {
                            to = tbLsposti.Text;
                            sendMail(to);
                            confirmed();
                        }
                    }
                    else
                    {
                        to = "sahkoposti";
                        update(to);
                        to = dgvLasku.Rows[0].Cells[0].Value.ToString();
                        sendMail(to);
                        confirmed();
                    }
                    
                }
                else
                {
                    string address = "";
                    if (cbLaskutusosoite.Checked == true) //samoin täällä tarkistellaan että osoitetiedot on varmasti syötetty
                    {
                        if (tbLosoite.Text == "" && tbPostinum.Text =="" && tbPostitoim.Text == "")
                        {
                            MessageBox.Show("Syötä laskutusosoite");
                        }
                        else
                        {
                            address = tbLosoite.Text+", "+tbPostinum.Text+ ", " + tbPostitoim.Text;
                            MessageBox.Show("Varaus on vahvistettu. \nLasku on postitettu osoitteeseen:\n" + address);
                        }
                        
                    }
                    else
                    {
                        address = "lahiosoite";
                        update(address);
                        address = dgvLasku.Rows[0].Cells[0].Value.ToString();
                        MessageBox.Show("Varaus on vahvistettu. \nLasku on postitettu osoitteeseen:\n" + address);
                    }
                    
                }

            }
            else
            {
                MessageBox.Show("Valitse laskutustapa");
            }
            
            
            
        }
        private void cbLaskutusosoite_CheckedChanged(object sender, EventArgs e)
        {
            bool visible;
            if (cbLaskutusosoite.Checked == false)
            {
                visible = false;
                laskutusVisible(visible);
            }
            if (cbLaskutusosoite.Checked == true)
            {
                visible = true;
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
            populateDGVAsiakas();
            populateDGVMokki();
            populateDGVPalvelut();
            getHinnat();

        }
        private void getHinnat() //lasketaan hinnat varaukselle näkyviin 
        {
            double mokki, palvelutotal=0,palvelu, alvtotal=0;
            double paivat = 1;
            if (Tiedot.Poistumispäivä.CompareTo(Tiedot.Saapumispäivä)>0)
            {
                paivat = (double)Tiedot.Poistumispäivä.Subtract(Tiedot.Saapumispäivä).Days+1;
            }
            string query1 = "SELECT hinta FROM mokki WHERE mokki_id = '" + Tiedot.mokkiID + "'";
            MySqlCommand mokkihinta = new MySqlCommand(query1, connection);
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            connection.Open();
            mokki = (double)mokkihinta.ExecuteScalar();
            string vk = "vuorokausi";
            if (paivat > 1)
            {
                vk = "vuorokautta";
            }
            lbHinnat.Items.Add("Mökin vuokra: "+paivat +" "+ vk + ", "+(paivat*mokki)+ "€, (sis. ALV 10% "+ (0.10*(paivat*mokki))+ "€)");
            alvtotal += 0.10 * (paivat * mokki);
            if (Tiedot.Palvelut.Count>0)
            {
                int alueid = (int)dgvVarausMokki.Rows[0].Cells[8].Value;
                for (int i = 0; i < Tiedot.Palvelut.Count; i++)
                {
                    string query2 = "SELECT hinta FROM palvelu WHERE nimi ='" + Tiedot.Palvelut[i] + "' AND alue_id = '" + alueid + "'";
                    MySqlCommand palveluhinta = new MySqlCommand(query2, connection);
                    palvelu = (double)palveluhinta.ExecuteScalar();
                    palvelutotal += (double)palveluhinta.ExecuteScalar();
                    alvtotal += palvelu * 0.10;
                    lbHinnat.Items.Add("Lisäpalvelu: " +Tiedot.Palvelut[i] + ", " + palvelu +"€, (sis. ALV 10% " + (palvelu * 0.10)+"€)");
                    
                }
            }
            lbHinnat.Items.Add("Kokonaishinta: "+(paivat*mokki+palvelutotal)+ "€, (sis. ALV 10% " +alvtotal+"€)");
            connection.Close();
            
        }
        private void populateDGVMokki()
        {
            string query = "SELECT * FROM mokki WHERE mokki_id = '"+Tiedot.mokkiID+"'";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgvVarausMokki.DataSource = table;
        }
        private void populateDGVAsiakas()
        {
            string query = "SELECT * FROM asiakas WHERE asiakas_id ='" + Tiedot.id + "'";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgvVaraus.DataSource = table;
        }
        private void populateDGVPalvelut()
        {
            if (Tiedot.Palvelut.Count > 0)
            {
                int alueid = (int)dgvVarausMokki.Rows[0].Cells[8].Value;
                DataTable table = new DataTable();
                for (int i = 0; i < Tiedot.Palvelut.Count; i++)
                {
                    
                    string query = "SELECT * FROM palvelu WHERE nimi ='" + Tiedot.Palvelut[i] + "' AND alue_id = '"+alueid+"'";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    adapter.Fill(table);
                }
                dgvVarausPalvelut.DataSource = table;
            } 
        }

    }
}
