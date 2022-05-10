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
using Mokkivaraus.Model;

namespace Mokkivaraus
{
    public partial class PalveluidenHallinta : Form
    {
        private static MySqlConnection connection;
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;
        public PalveluidenHallinta()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PalveluidenHallinta_Load(object sender, EventArgs e)
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
            HaeAlueet();
        }
        public void populateDGV()
        {
            string query = "SELECT * FROM palvelu";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgwPalvelut.DataSource = table;
        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            double hinta,Alv;
            int alueenID;
            if (tbPalvelunNimi.Text == "" || tbPalvelunTyyppi.Text == "" || tbPalvelunKuvaus.Text == "" || tbPalvelunHinta.Text == "" || tbALV.Text == "")
            {
                MessageBox.Show("Et voi lisätä tyhjiä laatikoita");
            }
            else
            {
                for (int i = 0; i < dgwPalvelut.Rows.Count; i++)
                {
                    if (tbPalvelunNimi.Text == dgwPalvelut.Rows[i].Cells[1].Value.ToString())
                    {
                        i--;
                        break;
                    }
                    else if (tbPalvelunNimi.Text != dgwPalvelut.Rows[i].Cells[1].Value.ToString() && i + 1 == dgwPalvelut.Rows.Count||tbPalvelunNimi.Text == "Loppusiivous"||tbPalvelunNimi.Text == "loppusiivous")
                    {
                        hinta = double.Parse(tbPalvelunHinta.Text);
                        Alv = double.Parse(tbALV.Text);
                        string query = "SELECT alue_id FROM alue WHERE nimi = '" + cbAlue.Text + "'";
                        MySqlCommand alue = new MySqlCommand(query, connection);
                        connection.Open();
                        alueenID = (int)alue.ExecuteScalar();
                        connection.Close();
                        string query2 = "INSERT INTO palvelu(nimi,tyyppi,kuvaus,hinta,alv,alue_id) VALUES('" + tbPalvelunNimi.Text + "','" + tbPalvelunTyyppi.Text + "','" + tbPalvelunKuvaus.Text + "','" + hinta + "','" + Alv + "','" + alueenID + "');";
                        ExecuteMyQuery(query2);
                        populateDGV();
                        break;
                    }
                }
                Poisto();
            }

        }
        private void Poisto()
        {
            tbPalvelunNimi.Clear();
            tbPalvelunTyyppi.Clear();
            tbPalvelunKuvaus.Clear();
            tbPalvelunHinta.Clear();
            tbALV.Clear();
            cbAlue.Text = "";
        }
        private void HaeAlueet()
        {
            int alueet;
            string alue;
            string query = "SELECT MAX(alue_id) FROM alue;";
            MySqlCommand Alue = new MySqlCommand(query, connection);
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            connection.Open();
            alueet = (int)Alue.ExecuteScalar();
            for(int i = 1; i<= alueet; i++)
            {
                string query2 = "SELECT nimi FROM alue WHERE alue_id = '" + i + "'";
                MySqlCommand Alue2 = new MySqlCommand(query2, connection);
                object test = Alue2.ExecuteScalar();
                if(test == null)
                {

                }
                else
                {
                    alue = Alue2.ExecuteScalar().ToString();
                    cbAlue.Items.Add(alue);
                }

            }
            connection.Close(); 
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

        private void dgwPalvelut_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string alueentieto;
            tbPalvelunNimi.Text = dgwPalvelut.CurrentRow.Cells[1].Value.ToString();
            tbPalvelunTyyppi.Text = dgwPalvelut.CurrentRow.Cells[2].Value.ToString();
            tbPalvelunKuvaus.Text = dgwPalvelut.CurrentRow.Cells[3].Value.ToString();
            tbPalvelunHinta.Text = dgwPalvelut.CurrentRow.Cells[4].Value.ToString();
            tbALV.Text = dgwPalvelut.CurrentRow.Cells[5].Value.ToString();
            Hallinta.AlueidenID = (int)dgwPalvelut.CurrentRow.Cells[6].Value;
            string query = "SELECT nimi FROM alue WHERE alue_id = '" + Hallinta.AlueidenID + "'";
            MySqlCommand alue = new MySqlCommand(query, connection);
            connection.Open();
            alueentieto = alue.ExecuteScalar().ToString();
            connection.Close();
            cbAlue.Text = alueentieto;
            Hallinta.PalveluidenID = (int)dgwPalvelut.CurrentRow.Cells[0].Value;
        }

        private void btnPoistaPalvelu_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Haluatko varmasti poistaa palvelun?", "Olet poistamassa palvelun", MessageBoxButtons.YesNo);
            if(Result == DialogResult.Yes)
            {
                string DeleteQuery = "DELETE FROM palvelu WHERE palvelu_id = '" + Hallinta.PalveluidenID + "'";
                ExecuteMyQuery(DeleteQuery);
                populateDGV();
            }
            else if(Result == DialogResult.No)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnPaivitaPalvelua_Click(object sender, EventArgs e)
        {
            if(tbPalvelunNimi.Text == ""||tbPalvelunTyyppi.Text == ""||tbPalvelunKuvaus.Text  == ""||tbPalvelunHinta.Text == ""||tbALV.Text == "")
            {
                MessageBox.Show("Valitse tieto jota päivitetään");
            }
            else
            {
            double hinta, Alv;
                string HaeQuery = "SELECT alue_id FROM alue WHERE nimi = '" + cbAlue.Text + "'";
                MySqlCommand alue = new MySqlCommand(HaeQuery, connection);
                connection.Open();
                Hallinta.AlueidenID = (int)alue.ExecuteScalar();
                connection.Close();
                hinta = double.Parse(tbPalvelunHinta.Text);
            Alv = double.Parse(tbALV.Text);
            string UpdateQuery = "UPDATE palvelu SET nimi = '" + tbPalvelunNimi.Text + "',tyyppi = '" + tbPalvelunTyyppi.Text + "',kuvaus = '" + tbPalvelunKuvaus.Text + "',hinta = '" + hinta + "',alv = '" + Alv + "',alue_id = '" + Hallinta.AlueidenID + "' WHERE palvelu_id = '" + Hallinta.PalveluidenID + "';";
            ExecuteMyQuery(UpdateQuery);
            populateDGV();
            Poisto();
            }

        }
    }
}
