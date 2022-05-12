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
using System.Net.Mail;
using System.Web;

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
        private void cbPaperilasku_CheckedChanged(object sender, EventArgs e) //ehtojen tarkistusta mitä tulee näyttää milloinkin näytöllä
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
        

        private void cbSpostilasku_CheckedChanged(object sender, EventArgs e)//ehtojen tarkistusta mitä tulee näyttää milloinkin näytöllä
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
        private void cbVahvistasposti_CheckedChanged(object sender, EventArgs e)//ehtojen tarkistusta mitä tulee näyttää milloinkin näytöllä
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
        private void sendMail(string to, string lasku)    //spostin lähetys
        {
            string subject = "Village Newbies -lasku";
            string from = "NootWare@gmail.com";
            string pass = "pofierqtrudvxeje"; //onetime password from google
            SmtpClient mailClient = new SmtpClient("smtp.gmail.com");
            mailClient.EnableSsl = true;
            mailClient.Port = 587;
            mailClient.Credentials = new System.Net.NetworkCredential(from, pass);
            try
            {
                MailMessage msgMail = new MailMessage(from, to, subject, lasku);
                mailClient.Send(msgMail);
                MessageBox.Show("Lasku on lähetetty sähköpostiosoitteeseen:\n" + to);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void sendConfirm(string to)//tilausvahvistuksen lähetys spostiin
        {
            string subject = "Tilausvahvistus";
            string from = "NootWare@gmail.com";
            string pass = "pofierqtrudvxeje"; //onetime password from google
            SmtpClient mailClient = new SmtpClient("smtp.gmail.com");
            mailClient.EnableSsl = true;
            mailClient.Port = 587;
            mailClient.Credentials = new System.Net.NetworkCredential(from, pass);
            try
            {
                MailMessage msgMail = new MailMessage(from, to, subject, Lasku.Vahvistus);
                mailClient.Send(msgMail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void confirmed() //Varauksen syöttö tietokantaan sekä vahvistus viestin kokoaminen
        {
            string alku = Tiedot.Saapumispäivä.ToString("yyyy-MM-dd");
            string loppu = Tiedot.Poistumispäivä.ToString("yyyy-MM-dd");
            dtpAika.Value = DateTime.Today;
            string tanaan = dtpAika.Value.ToString("yyyy-MM-dd");
            string varaus = "insert into varaus(varattu_pvm, vahvistus_pvm, varattu_alkupvm, varattu_loppupvm, asiakas_id, mokki_id)" +
                " values('" + tanaan + "','" + tanaan + "','"
                + alku + "','" + loppu + "','" + Tiedot.id + "','" + Tiedot.mokkiID + "');";
            string palvelut = "";
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            connection.Open();
            cmd = new MySqlCommand(varaus, connection);
            cmd.ExecuteNonQuery();

            int alueid = (int)dgvVarausMokki.Rows[0].Cells[8].Value;
            int palveluid, palvelulkm;

            string varausidquery = "SELECT MAX(varaus_id) FROM varaus;";
            MySqlCommand cmd2 = new MySqlCommand(varausidquery, connection);
            Lasku.varausID= (int)cmd2.ExecuteScalar();
            List<string> check = new List<string>();
            if (Tiedot.Palvelut.Count>0)
            {
                for (int i = 0; i < Tiedot.Palvelut.Count; i++)
                {
                    palvelut += "\n"+Tiedot.Palvelut[i];
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
                        string varauksen_palvelut = "insert into varauksen_palvelut(palvelu_id, varaus_id, lkm) values('" + palveluid + "', '" + Lasku.varausID + "','" + palvelulkm + "');";

                        MySqlCommand cmd3 = new MySqlCommand(varauksen_palvelut, connection);
                        cmd3.ExecuteNonQuery();
                        check.Add(Tiedot.Palvelut[i]);
                    }
                }
            }
            else
            {
                palvelut = "Ei lisäpalveluita";
            }
            string mokinnimi = "SELECT mokkinimi FROM mokki WHERE mokki_id ='" + Tiedot.mokkiID + "';",nimi="";
            MySqlCommand cmd4 = new MySqlCommand(mokinnimi, connection);
            nimi = cmd4.ExecuteScalar().ToString();
            Lasku.Vahvistus = "Hei,\n" +
            "\n" +
            "Kiitos, että valitsit Village Newbies - mökin!\n" +
            "Alla löydät tarkemmat tiedot varauksestasi.\n" +
            "\n" +
            "Varausnumero:"+Lasku.varausID+"\n" +
            "Mökki: "+nimi+"\n" +
            "Saapumispäivä: "+alku+"\n"+
            "Lähtöpäivä: "+loppu+"\n"+
            "Lisäpalvelut: "+palvelut+"\n"+
            "Kokonaishinta: " + Lasku.Total + "€\n" +
            "Sis. Alv 10%: "+ Lasku.Alv + "€\n" +
            "\n" +
            "\n" +
            "\n" +
            "Varauksen voi peruuttaa/ muuttaa maksutta 10 vuorokautta ennen saapumispäivää. \n" +
            "Mikäli haluat tehdä muutoksia tilaukseesi, olethan yhteydessä asiakaspalveluumme!\n" +
            "\n" +
            "Huom! Tämä on tilausvahvistus. Lasku toimitetaan sinulle erikseen valitsemallasi toimitustavalla.\n" +
            "\n" +
            "\n" +
            "Ystävällisin terveisin\n" +
            "Village Newbies Oy\n" +
            "Siilokatu 1\n" +
            "90700 OULU\n";
            connection.Close();


        }
        private void insertlasku() //laskun syöttö tietokantaan
        {
            string insert, getlasku;
            string alv = Lasku.Alv.ToString();
            alv = alv.Replace(',', '.');
            insert= "INSERT INTO lasku(summa,alv,varaus_id,maksettu) values('"+Lasku.Total + "', '" + alv + "', '" + Lasku.varausID+"','"+1+"');";
            getlasku = "SELECT lasku_id FROM lasku WHERE varaus_id ='" + Lasku.varausID+"';";
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(insert, connection);
            MySqlCommand cmd2 = new MySqlCommand(getlasku, connection);

            cmd.ExecuteNonQuery();
            Lasku.LaskuID = (int)cmd2.ExecuteScalar();
            connection.Close();
        }
        private void checkmail(ref string to)
        {
            if (tbLsposti.Text == "")                   //tarkistellaan että syötetty sposti on oikeaa muotoa
            {
                MessageBox.Show("Syötä sähköpostiosoite");
            }
            else if (tbLsposti.Text.Contains("@") == false)
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
                
            }
        }

        private void btnVahvista_Click(object sender, EventArgs e)
        {
            string lasku;
            string to = "";
            Lasku.Vahvistus = "";
            
            if (cbPaperilasku.Checked == true || cbSpostilasku.Checked == true)//tarkistetaan että laitetaan lasku valitulla tavalla
            {
                if (cbSpostilasku.Checked)
                {
                    

                    if (cbVahvistasposti.Checked == true)
                    {
                        checkmail(ref to);

                        if (to=="")
                        {

                        }
                        else
                        {
                            confirmed();
                            insertlasku();
                            lasku = getHinnat();
                            sendConfirm(to);
                            sendMail(to, lasku);
                            frmAsiakastiedot frm = new frmAsiakastiedot();
                            frm.Show();
                            this.Hide();
                        }



                    }
                    else
                    {
                        to = "sahkoposti";
                        update(to);
                        to = dgvLasku.Rows[0].Cells[0].Value.ToString();

                        confirmed();
                        insertlasku();
                        lasku = getHinnat();
                        sendConfirm(to);
                        sendMail(to, lasku);
                        MessageBox.Show("Varaus on vahvistettu. \nLasku on lähetty sähköpostilla osoitteeseen: \n"+to);
                        frmAsiakastiedot frm = new frmAsiakastiedot();
                        frm.Show();
                        this.Hide();

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
                            MessageBox.Show("Varaus on vahvistettu. \nLasku postitetaan osoitteeseen:\n" + address);

                            to = "sahkoposti";
                            update(to);
                            to = dgvLasku.Rows[0].Cells[0].Value.ToString();

                            confirmed();
                            insertlasku();
                            lasku = getHinnat();
                            sendConfirm(to);

                            frmAsiakastiedot frm = new frmAsiakastiedot();
                            frm.Show();
                            this.Hide();

                        }
                        
                    }
                    else
                    {
                        address = "lahiosoite";
                        update(address);
                        address = dgvLasku.Rows[0].Cells[0].Value.ToString();
                        MessageBox.Show("Varaus on vahvistettu. \nLasku on postitettu osoitteeseen:\n" + address);
                        to = "sahkoposti";
                        update(to);
                        to = dgvLasku.Rows[0].Cells[0].Value.ToString();
                        
                        confirmed();
                        insertlasku();
                        lasku = getHinnat();
                        sendConfirm(to);

                        frmAsiakastiedot frm = new frmAsiakastiedot();
                        frm.Show();
                        this.Hide();
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
        {//yhdistetään tietokantaan
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
            dtpSaapumis.Value = Tiedot.Saapumispäivä;
            dtpLahto.Value = Tiedot.Poistumispäivä;
            populateDGVAsiakas();
            populateDGVMokki();
            populateDGVPalvelut();
            getHinnat();

        }
        private string getHinnat() //lasketaan hinnat varaukselle näkyviin sekä kerätään tiedot valmiiksi laskulle ja vahvistusviestille
        {
            lbHinnat.Items.Clear();
            string lasku = "", etunimi = "", sukunimi = "", lisapalvelu=""; 
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
                    lisapalvelu += "Lisäpalvelu: " + Tiedot.Palvelut[i] + ", " + palvelu + "€, (sis. ALV 10% " + (palvelu * 0.10) + "€)\n";


                }
            }
            string query3 = "select etunimi from asiakas where asiakas_id = " +Tiedot.id;
            string query4 = "select sukunimi from asiakas where asiakas_id = " + Tiedot.id;
            MySqlCommand etu = new MySqlCommand(query3, connection);
            MySqlCommand suku = new MySqlCommand(query4, connection);
            etunimi = etu.ExecuteScalar().ToString();
            sukunimi = suku.ExecuteScalar().ToString();
            lasku += "Hei,\n" +
                         "\n" +
                         "Tämä on lasku tekemästäsi varauksesta \n" +
                         "Varausnumero: " + Lasku.varausID + "\n" +
                         "Laskunumero: "+Lasku.LaskuID+"\n" +
                         "Alla löydät laskun maksutiedot sekä erittelyn.\n" +
                         "\n" +
                         "\n" +
                         "Maksajan nimi: " + etunimi + " " + sukunimi + "\n" +
                         "Saaja: Village Newbies Oy\n" +
                         "Saajan tilinumero IBAN: FI123 4000 5678 9123 45\n" +
                         "BIC: ABCCBA\n" +
                         "Viitenumero: 54533211\n" +
                         "Eräpäivä: "+ Tiedot.Poistumispäivä.ToString("yyyy-MM-dd") + "\n"+
                         "Summa(EURO): " + (paivat * mokki + palvelutotal) + "\n"+
                         "\n" +
                         "\n" +
                         "Erittely \n" +
                         "Mökkivuokra/vuorokausi: " + mokki+ "€,  (sis. ALV 10% " + (0.10 *mokki)+"€)\n" +
                         "Vuokra vuorokaudet: " + paivat + "\n" +
                         "Vuokrasumma: " + (mokki * paivat) + "\n" +
                            lisapalvelu+ "\n" +
                         "Kokonaishinta: " +(paivat * mokki + palvelutotal) + "€\n" +
                         "Sis. Alv 10%: " + alvtotal + "€\n" +
                         "\n" +
                         "\n" +
                         "\n" +
                         "Mikäli haluat tehdä muutoksia tilaukseesi, olethan yhteydessä asiakaspalveluumme!\n" +
                         "\n" +
                         "\n" +
                         "Ystävällisin terveisin\n" +
                         "Village Newbies Oy\n" +
                         "Siilokatu 1\n" +
                         "90700 OULU\n";
            lbHinnat.Items.Add("Kokonaishinta: "+(paivat*mokki+palvelutotal)+ "€, (sis. ALV 10% " +alvtotal+"€)");
            Lasku.Total = paivat * mokki + palvelutotal;
            Lasku.Alv = alvtotal;
            
            connection.Close();
            return lasku;
            
        }
        private void populateDGVMokki() //haetaan mökin tiedot
        {
            string query = "SELECT * FROM mokki WHERE mokki_id = '"+Tiedot.mokkiID+"'";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgvVarausMokki.DataSource = table;
        }
        private void populateDGVAsiakas()//haetaan asiakkaan tiedot
        {
            string query = "SELECT * FROM asiakas WHERE asiakas_id ='" + Tiedot.id + "'";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgvVaraus.DataSource = table;
        }
        private void populateDGVPalvelut()//haetaan palveluiden tiedot
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

        private void btnPalaa_Click(object sender, EventArgs e)
        {
            lbHinnat.Items.Clear();
            this.Hide();
            frmMokkivalinta mokki = new frmMokkivalinta();
            mokki.Show();
        }
    }
}
