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
            DirectoryInfo di = new DirectoryInfo("C:\\Temp"); //Luodaan temp-kansio väliaikas
            if(di.Exists != true)
            {
                di.Create();
            }

            FileInfo tf = new FileInfo("C:\\Temp\\Asiakastiedot.txt");
            if (tf.Exists != true)
            {
                using (FileStream fs = tf.Create())
                {
                }
            }
            cbTiedot.Checked = true;

            FileInfo pass = new FileInfo("C:\\Temp\\Access.txt");
            if (pass.Exists != true)
            {
                using (FileStream fa = pass.Create())
                {
                }
            }

            if (cbTiedot.Checked)
            {
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
            {//vaatii vain salasanan silloin
                this.ActiveControl = txtPass;
            }
            else
            {

            }
        }
        public void populateDGV()
        {
            //string query = "SELECT * FROM asiakas";
            //DataTable table = new DataTable();
            //MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            //adapter.fill(table);
            //dgwasiakas.datasource = table;
        }

        private void btnKirjaudu_Click(object sender, EventArgs e)//Tietokantaan kirjautuminen testaus
        {

            Kirjautuminen kirjaus = new Kirjautuminen();
            uint portti;
            portti = uint.Parse(txtPort.Text);
                try
                {
                    MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                    builder.Server = txtIP.Text;
                    builder.Port = portti;
                    builder.UserID = txtID.Text;
                    builder.Password = txtPass.Text;
                    builder.Database = txtTietonimi.Text;
                    builder.SslMode = MySqlSslMode.None;
                    connection = new MySqlConnection(builder.ToString());
                    //MessageBox.Show("Database connection successfull", "Connection", MessageBoxButtons.OK);
                    frmAsiakastiedot asiakkaat = new frmAsiakastiedot();
                    asiakkaat.Show();
                
            }
                catch (Exception ex)
                {
                    MessageBox.Show("connection failed" + ex);
                }
                populateDGV();
            using (StreamWriter writeasiakkaat = new StreamWriter("C:\\Temp\\Asiakastiedot.txt"))
            {
                writeasiakkaat.WriteLine(txtIP.Text);
                writeasiakkaat.WriteLine(txtPort.Text);
                writeasiakkaat.WriteLine(txtTietonimi.Text);
                writeasiakkaat.WriteLine(txtID.Text);
            }
            using (StreamWriter writepass = new StreamWriter("C:\\Temp\\Access.txt")) //kirjoitetaan salasana väliaikaiseen tiedostoon lukemisen helpottamiseksi
            {
                writepass.WriteLine(txtPass.Text);
            }
            this.Hide();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void cbTiedot_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Kirjautuminen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cbTiedot.Checked != true)
            {
                FileInfo tf = new FileInfo("C:\\Temp\\Asiakastiedot.txt");
                tf.Delete();
            }
        }
    }
}
