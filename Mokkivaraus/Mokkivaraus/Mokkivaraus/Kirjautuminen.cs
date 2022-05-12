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
    public partial class Kirjautuminen : Form
    {
        private static MySqlConnection connection;
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;
        public Kirjautuminen()
        {
            InitializeComponent();
            DirectoryInfo di = new DirectoryInfo("C:\\Temp"); //Luodaan temp-kansio mikäli sitä ei löydy hakemistosta
            FileInfo tf = new FileInfo("C:\\Temp\\Asiakastiedot.txt");
            if (di.Exists != true)
            {
                di.Create();
            }
            cbTiedot.Checked = true;

            if (cbTiedot.Checked) //tarkistetaan näin onko käyttäjä aiemmin valinnut kirjautumistiedot tallennettaviksi              
            {
                if (tf.Exists != true)  //luodaan tiedosta jotta vältytään error-messageilta
                {
                    using (FileStream fs = tf.Create())
                    {
                    }
                }
                using (StreamReader read = new StreamReader("C:\\Temp\\Asiakastiedot.txt")) 
                {
                    txtIP.Text = read.ReadLine();
                    txtPort.Text = read.ReadLine();
                    txtTietonimi.Text = read.ReadLine();
                    txtID.Text = read.ReadLine();
                }
            }
        }

        private void Kirjautuminen_Load(object sender, EventArgs e)
        {
            if (txtIP.Text != "" && txtPort.Text != "" && txtTietonimi.Text != "" && txtID.Text != "")//tarkistaa onko kaikki tiedot täytetty valmiiksi
            { //vaatii vain salasanan silloin
                this.ActiveControl = txtPass;
            }
        }
        private void checkLogin()
        {
            string test= "SELECT MAX(alue_id) FROM alue";
            int i;
            MySqlCommand sqlCommand = new MySqlCommand(test, connection);
            connection.Open();
            i = (int)sqlCommand.ExecuteScalar();
            connection.Close();
        }
        private void btnKirjaudu_Click(object sender, EventArgs e)//Tietokantaan kirjautuminen 
        {
            Kirjautuminen kirjaus = new Kirjautuminen();
            bool check=true;
                try
                {
                    MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                    builder.Server = txtIP.Text;
                    builder.Port = uint.Parse(txtPort.Text);
                    builder.UserID = txtID.Text;
                    builder.Password = txtPass.Text;
                    builder.Database = txtTietonimi.Text;
                    builder.SslMode = MySqlSslMode.None;
                    connection = new MySqlConnection(builder.ToString());
                    LoginInfo.IP = txtIP.Text;                          
                    LoginInfo.Name = txtTietonimi.Text;             //Tallennetaan tiedot Modeliin välitystä varten
                    LoginInfo.Port = uint.Parse(txtPort.Text);
                    LoginInfo.User = txtID.Text;
                    LoginInfo.Pass = txtPass.Text;
                checkLogin();
                //MessageBox.Show("Database connection successfull", "Connection", MessageBoxButtons.OK);
            }
                catch (Exception ex)
                {
                if(ex != null)
                {
                    check = false;
                    txtPass.Clear();
                }

                    MessageBox.Show("connection failed" + ex);
                }

            if (check == false)
            {

            }
            else
            {
                try
                {
                    Valikko frm = new Valikko();
                    frm.Show();
                    this.Hide();
                }
                catch (Exception)
                {
                    MessageBox.Show("Tapahtui virhe\n Olkaa hyvä ja käynnistäkää sovellus uudelleen");
   
                }
                
            }
        }
        private void Kirjautuminen_KeyDown(object sender, KeyEventArgs e) //mahdollistetaan kirjautuminen enteriä painamalla
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnKirjaudu_Click(sender, e);
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }
        private void Kirjautuminen_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileInfo tf = new FileInfo("C:\\Temp\\Asiakastiedot.txt");
            if (cbTiedot.Checked != true)
            {
                tf.Delete();
            }
            else
            {
                using (StreamWriter writeasiakkaat = new StreamWriter("C:\\Temp\\Asiakastiedot.txt"))   //kirjataan kaikki muut tiedot txt-tiedostoon ylös nopeuttamaan kirjautumista
                {                                                                                       //salasanaa ei tallenneta turvallisuussyistä
                    writeasiakkaat.WriteLine(txtIP.Text);
                    writeasiakkaat.WriteLine(txtPort.Text);
                    writeasiakkaat.WriteLine(txtTietonimi.Text);
                    writeasiakkaat.WriteLine(txtID.Text);
                }
            }
        }
    }
}
