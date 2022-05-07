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
    public partial class frmVaraus : Form
    {
        private static MySqlConnection connection;
        public string IP, Tietonimi, ID, Port, pass;

        public frmVaraus()
        {
            using (StreamReader read = new StreamReader("C:\\Temp\\Asiakastiedot.txt"))
            {
                IP = read.ReadLine();
                Port = read.ReadLine();
                Tietonimi = read.ReadLine();
                ID = read.ReadLine();
            }
            using (StreamReader read = new StreamReader("C:\\Temp\\Access.txt"))
            {
                pass = read.ReadLine();
            }
            InitializeComponent();
        }
        private void cbPaperilasku_CheckedChanged(object sender, EventArgs e)
        {
            bool visible;
            if (cbSpostilasku.Checked == true)
            {
                cbSpostilasku.Checked = false;
            }
            if (cbLaskutusosoite.Visible == false)
            {
                cbLaskutusosoite.Visible = true;
                visible = true;
                laskutusVisible(visible);
            }


        }

        private void cbSpostilasku_CheckedChanged(object sender, EventArgs e)
        {
            bool visible;
            if (cbPaperilasku.Checked == true)
            {
                cbPaperilasku.Checked = false;
            }
            if (cbLaskutusosoite.Visible == true)
            {
                cbLaskutusosoite.Visible = false;
                visible = false;
                laskutusVisible(visible);
            }
            if (cbSpostilasku.Checked == true)
            {
                lblSposlasku.Visible = true;
                tbLsposti.Visible = true;
                cbSpostilasku.Visible = true;
            }

        }

        private void btnVahvista_Click(object sender, EventArgs e)
        {
            string from = "NootWare@gmail.com";
            string pass = "pofierqtrudvxeje"; //onetime password from google
            //SmtpClient mailClient = new SmtpClient("smtp.gmail.com");
            //mailClient.EnableSsl = true;
            //mailClient.Port = 587;
            //mailClient.Credentials = new System.Net.NetworkCredential(from, pass);

            if (cbSpostilasku.Checked = true)
            {
                cbLaskutusosoite.Checked = false;
                
                string to;
                if (cbVahvistasposti.Checked == true)
                {
                    to = tbLsposti.Text;
                }
                else
                {
                    to = "???";
                }
                string subject = "Village Newbies -lasku";
                try
                {
                    //string Text = "Tuote: " + textBox2.Text + "\nMäärä: " +  + "\nSumma: " + textBox4.Text + "\n Haluatko hienomman laskun?";
                    
                    //MailMessage msgMail = new MailMessage(from, to, subject, Text);
                    //mailClient.Send(msgMail);
                    MessageBox.Show("Your Mail was sent");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {

            }
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
            uint portparsed;
            portparsed = uint.Parse(Port);
            try
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = IP;
                builder.Port = portparsed;
                builder.UserID = ID;
                builder.Password = pass;
                builder.Database = Tietonimi;
                builder.SslMode = MySqlSslMode.None;
                connection = new MySqlConnection(builder.ToString());
                //MessageBox.Show("Database connection successfull", "Connection", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("connection failed" + ex);
            }
            populateDGV();
        }
        public void populateDGV()
        {
            string query = "SELECT MAX(varaus_id) FROM varaus";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgvVaraus.DataSource = table;
        }
    }
}
