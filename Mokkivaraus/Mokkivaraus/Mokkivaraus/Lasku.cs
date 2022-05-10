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
        private void confirmed()
        {
            string varaus="INSERT INTO varaus(varattu_pvm, vahvistus_pvm, varattu_alkupvm,varattu_loppupvm,asiakas_id,mokki_id)" +
                " VALUES('" + DateTime.Today.ToString("yyyy-MM-dd") + "','"+ DateTime.Today.ToString("yyyy-MM-dd") + "','"
                +Tiedot.Saapumispäivä + "','" +Tiedot.Poistumispäivä + "','" +Tiedot.id + "','" +Tiedot.mokkiID + "';";

            connection.Open();
            cmd = new MySqlCommand(varaus, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            int alueid= (int)dgvVarausMokki.Rows[0].Cells[8].Value;
            int palveluid, varausid;
            for (int i = 0; i < Tiedot.Palvelut.Count; i++)
            {
                string query = "SELECT palvelu_id FROM palvelu WHERE nimi ='" + Tiedot.Palvelut[i] + "' AND alue_id = '" + alueid + "';";

                string varausidquery = "SELECT varaus_id FROM palvelu WHERE asiakas_id ='" + Tiedot.id + "' AND mokki_id = '" + Tiedot.mokkiID + "'"
                    + "AND varattu_alkupvm = '"+Tiedot.Saapumispäivä+"'"+"AND varattu_pvm ='"+ DateTime.Today.ToString("yyyy-MM-dd")+"'";

                MySqlCommand cmd1 = new MySqlCommand(query, connection);
                MySqlCommand cmd2 = new MySqlCommand(varausidquery,connection);
                connection.Open();
                palveluid = (int)cmd1.ExecuteScalar();
                varausid = (int)cmd2.ExecuteScalar();
                connection.Close();
                string varauksen_palvelut = "INSERT INTO varauksen_palvelut(palvelu_id, varaus_id, lkm) VALUES('" + palveluid + "','" + varausid + "','";

                MySqlCommand cmd3 = new MySqlCommand(varauksen_palvelut, connection);
            }
         

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
                        }
                    }
                    else
                    {
                        to = "sahkoposti";
                        update(to);
                        to = dgvLasku.Rows[0].Cells[0].Value.ToString();
                        sendMail(to);
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
            connection.Open();
            mokki = (double)mokkihinta.ExecuteScalar();
            string vk = "vuorokausi";
            if (paivat > 1)
            {
                vk = "vuorokautta";
            }
            lbHinnat.Items.Add("Mökin vuokra: "+paivat +" "+ vk + ", "+(paivat*mokki)+ "€, (sis. ALV 10% "+ (0.10*(paivat*mokki))+ "€)");
            connection.Close();
            alvtotal += 0.10 * (paivat * mokki);
            if (Tiedot.Palvelut.Count>0)
            {
                int alueid = (int)dgvVarausMokki.Rows[0].Cells[8].Value;
                for (int i = 0; i < Tiedot.Palvelut.Count; i++)
                {
                    string query2 = "SELECT hinta FROM palvelu WHERE nimi ='" + Tiedot.Palvelut[i] + "' AND alue_id = '" + alueid + "'";
                    MySqlCommand palveluhinta = new MySqlCommand(query2, connection);
                    connection.Open();
                    palvelu = (double)palveluhinta.ExecuteScalar();
                    palvelutotal += (double)palveluhinta.ExecuteScalar();
                    alvtotal += palvelu * 0.10;
                    lbHinnat.Items.Add("Lisäpalvelu: " +Tiedot.Palvelut[i] + ", " + palvelu +"€, (sis. ALV 10% " + (palvelu * 0.10)+"€)");
                    connection.Close();
                }
            }
            lbHinnat.Items.Add("Kokonaishinta: "+(paivat*mokki+palvelutotal)+ "€, (sis. ALV 10% " +alvtotal+"€)");
            
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
