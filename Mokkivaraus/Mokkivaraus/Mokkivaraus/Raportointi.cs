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
    public partial class Raportointi : Form
    {
        private static MySqlConnection connection;
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;
        public Raportointi()
        {
            InitializeComponent();
        }

        private void Raportointi_Load(object sender, EventArgs e)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("connection failed" + ex);
            }
            PopulateMajoituDgv();
            //PopulatePalveluDgv();
            TaytaAlueet();
        }
        private void PopulateMajoituDgv()
        {
            string query = "SELECT * FROM varaus";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgwMajoitus.DataSource = table;
        }
        //private void PopulatePalveluDgv()
        //{
        //    string query = "SELECT * FROM varauksen_palvelut";
        //    DataTable table = new DataTable();
        //    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
        //    adapter.Fill(table);
        //    dgwPalvelut.DataSource = table;
        //}
        private void TaytaAlueet()
        {
            int MaxAlue;
            string Nimi;
            string Query = "SELECT MAX(alue_id) FROM alue";
            MySqlCommand AlueID = new MySqlCommand(Query, connection);
            connection.Open();
            MaxAlue = (int)AlueID.ExecuteScalar();
            for(int i = 0; i<=MaxAlue; i++)
            {
                string AlueQuery = "SELECT nimi FROM alue WHERE alue_id = '" + i + "'";
                MySqlCommand Aluenimi = new MySqlCommand(AlueQuery, connection);
                object test = Aluenimi.ExecuteScalar();
                if (test == null)
                {

                }
                else
                {
                    Nimi = Aluenimi.ExecuteScalar().ToString();
                    cbAlueet.Items.Add(Nimi);
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

        private void btnHae_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            string Alkupv = dtpAlkupv.Value.ToString("yyyy-MM-dd");
            string Loppupv = dtpLoppupv.Value.ToString("yyyy-MM-dd");
            string Hae = "SELECT * FROM varaus WHERE (varattu_alkupvm BETWEEN ('"+ Alkupv+ "') AND ('" + Loppupv + "')) AND(varattu_loppupvm BETWEEN('" + Alkupv + "') AND('" + Loppupv + "')); ";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(Hae, connection);
            adapter.Fill(table);
            dgwMajoitus.DataSource = table;
            List<int> VarausID = new List<int>();
            List<int> PalveluID = new List<int>();
            for(int i = 0; i< dgwMajoitus.Rows.Count; i++)
            {
                VarausID.Add((int)dgwMajoitus.Rows[i].Cells[0].Value);
            }
            for (int i = 0; i < VarausID.Count; i++)
            {
                string HaePalvelut = "SELECT palvelu_id FROM varauksen_palvelut WHERE varaus_id = '" + VarausID[i] + "';";
                DataTable table2 = new DataTable();
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(HaePalvelut, connection);
                adapter2.Fill(table2);
                dgwPalveluID.DataSource = table2;
            }
        }

        private void btnHaeAlue_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            lbNimet.Items.Clear();
            List<string> KaikkiTiedot = new List<string>();
            List<string> KaikkiTiedot2 = new List<string>();
            int AlueenID;
            string AlueIDhaku = "SELECT alue_id FROM alue WHERE nimi = '" + cbAlueet.Text + "'";
            MySqlCommand AlueID = new MySqlCommand(AlueIDhaku, connection);
            connection.Open();
            AlueenID = (int)AlueID.ExecuteScalar();
            connection.Close();
            int count = dgwPalveluID.Rows.Count;
            for(int i = 0; i<count;i++)
            {
                string PalvelunNimi = "SELECT nimi FROM palvelu WHERE alue_id = '" + AlueenID + "' AND palvelu_id = '" + (int)dgwPalveluID.Rows[i].Cells[0].Value + "';";
                MySqlCommand Palvelut = new MySqlCommand(PalvelunNimi, connection);
                connection.Open();
                object test = Palvelut.ExecuteScalar();
                connection.Close();
                if (test == null)
                {

                }
                else
                {
                    connection.Open();
                    KaikkiTiedot.Add(Palvelut.ExecuteScalar().ToString());
                    connection.Close();
                }
            }
            for (int j = 0; j < dgwPalveluID.Rows.Count; j++)
            {
                string test = "SELECT hinta FROM palvelu WHERE alue_id = '" + AlueenID + "' AND palvelu_id = '" + (int)dgwPalveluID.Rows[j].Cells[0].Value + "';";
                MySqlCommand Palvelut2 = new MySqlCommand(test, connection);
                connection.Open();
                object test2 = Palvelut2.ExecuteScalar();
                connection.Close();
                if (test2 == null)
                {

                }
                else
                {
                    connection.Open();
                    KaikkiTiedot2.Add(Palvelut2.ExecuteScalar().ToString());
                    connection.Close();
                }
            }
            for (int j = 0; j < KaikkiTiedot.Count; j++)
            {
                lbNimet.Items.Add(KaikkiTiedot[j] + "," + KaikkiTiedot2[j] + " €");
            }
        }
    }
}
