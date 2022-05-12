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
    public partial class LaskuHallinta : Form
    {
        private static MySqlConnection connection;
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;
        public LaskuHallinta()
        {
            InitializeComponent();
        }
        public void populateDGV()
        {
            string query = "SELECT * FROM lasku";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgvLaskut.DataSource = table;
        }

        private void LaskuHallinta_Load(object sender, EventArgs e)
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


        private void dgvLaskut_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            string nimi="";
            tbLaskuID.Text = dgvLaskut.CurrentRow.Cells[0].Value.ToString();
            tbSumma.Text = dgvLaskut.CurrentRow.Cells[1].Value.ToString();
            tbAlv.Text= dgvLaskut.CurrentRow.Cells[2].Value.ToString();
            tbVarausID.Text = dgvLaskut.CurrentRow.Cells[3].Value.ToString();
            if (dgvLaskut.CurrentRow.Cells[4].Value.ToString() != "1")
            {
                tbTilanne.Text = "Maksettu";
                cbMerkitse.Checked = true;
                tbSumma.Enabled = false;
                cbMerkitse.Enabled = false;
            }
            else
            {
                tbTilanne.Text = "Avoin";
                cbMerkitse.Checked = false;
                tbSumma.Enabled = true;
                cbMerkitse.Enabled = true;
            }
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            connection.Open();
            string asiakasid = "SELECT asiakas_id FROM varaus WHERE varaus_id = '" + tbVarausID.Text + "';";
            MySqlCommand cmdID = new MySqlCommand(asiakasid, connection);
            id = (int)cmdID.ExecuteScalar();
            string queryenimi = "SELECT etunimi FROM asiakas WHERE asiakas_id = '" + id + "';";
            string querysnimi = "SELECT sukunimi FROM asiakas WHERE asiakas_id = '" + id + "';";
            MySqlCommand cmdenimi = new MySqlCommand(queryenimi, connection);
            MySqlCommand cmdsnimi = new MySqlCommand(querysnimi, connection);
            nimi= cmdenimi.ExecuteScalar().ToString()+" "+cmdsnimi.ExecuteScalar().ToString();
            tbMaksaja.Text = nimi;
            string Palvelut;
            //for (int i = 0; i < Alue; i++)
            //{
            //  Palvelut = dgwAlue.Rows[i].Cells[0].Value.ToString();
            //  lbPalvelut.Items.Add(Palvelut);
            //}
            connection.Close();
        }
        private void clearBox()
        {
            tbLaskuID.Text = "";
            tbVarausID.Text = "";
            tbTilanne.Text = "";
            tbAlv.Text = "";
            tbMaksaja.Text = "";
            tbSumma.Text = "";
        }

        private void btnPaivita_Click(object sender, EventArgs e)
        {
            double sum, alv;
            sum = double.Parse(tbSumma.Text);
            alv = sum * 0.1;
            string update="", replace;
            replace = alv.ToString();
            replace = replace.Replace(',', '.');
            int muuta = 2;
            if (cbMerkitse.Checked == true)
            {
                update = "UPDATE lasku SET summa = '" + sum + "', alv = '" + replace + "', maksettu ='"+muuta+"' WHERE lasku_id = '" + int.Parse(tbLaskuID.Text) + "';";
            }
            else
            {
                update = "UPDATE lasku SET summa = '" + sum + "', alv = '" + alv + "' WHERE lasku_id = '" + int.Parse(tbLaskuID.Text) + "';";
            }

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            connection.Open();
            MySqlCommand cmdupdate = new MySqlCommand(update, connection);
            cmdupdate.ExecuteNonQuery();
            connection.Close();
            cbMerkitse.Checked = false;
            clearBox();
            populateDGV();
        }
    }
}
