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

        private void btnVahvista_Click(object sender, EventArgs e)
        {
            string from = "NootWare@gmail.com";
            string pass = "pofierqtrudvxeje"; //onetime password from google
            //SmtpClient mailClient = new SmtpClient("smtp.gmail.com");
            //mailClient.EnableSsl = true;
            //mailClient.Port = 587;
            //mailClient.Credentials = new System.Net.NetworkCredential(from, pass);
            if (cbPaperilasku.Checked == true || cbSpostilasku.Checked == true)
            {
                if (cbSpostilasku.Checked)
                {
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
                        //string lasku = "Tuote: " + textBox2.Text + "\nMäärä: " +  + "\nSumma: " + textBox4.Text + "\n Haluatko hienomman laskun?";

                        //MailMessage msgMail = new MailMessage(from, to, subject, Text);
                        //mailClient.Send(msgMail);
                        MessageBox.Show("Lasku on lähetetty sähköpostiosoitteeseen: "+ to);

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
