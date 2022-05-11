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
    public partial class Majoitusvaraukset : Form
    {
        private static MySqlConnection connection;
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;
        public Majoitusvaraukset()
        {
            InitializeComponent();
        }

        private void Majoitusvaraukset_Load(object sender, EventArgs e)
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
            populateDGV();
            HaeAsikkaat();
            HaeMokit();
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
        public void populateDGV()
        {
            string query = "SELECT * FROM varaus";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgwMajoitusvaraus.DataSource = table;
        }

        private void dgwMajoitusvaraus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Hallinta.MajoitusVarausID = (int)dgwMajoitusvaraus.CurrentRow.Cells[0].Value;
            dtpVarauspv.Value = (DateTime)dgwMajoitusvaraus.CurrentRow.Cells[1].Value;
            dtpVahvistuspv.Value = (DateTime)dgwMajoitusvaraus.CurrentRow.Cells[2].Value;
            dtpVarauksenAlkupv.Value = (DateTime)dgwMajoitusvaraus.CurrentRow.Cells[3].Value;
            dtpVarauksenLoppupv.Value = (DateTime)dgwMajoitusvaraus.CurrentRow.Cells[4].Value;
            Hallinta.MajoitusAsiakasID = (int)dgwMajoitusvaraus.CurrentRow.Cells[5].Value;
            Hallinta.MajoitusMokkiID = (int)dgwMajoitusvaraus.CurrentRow.Cells[6].Value;
            string Aquery = "SELECT etunimi,sukunimi,lahiosoite FROM asiakas WHERE asiakas_id = '" + Hallinta.MajoitusAsiakasID + "';";
            MySqlCommand Asiakas = new MySqlCommand(Aquery, connection);
            connection.Open();
            cbAsiakas.Text = Asiakas.ExecuteScalar().ToString();
            connection.Close();
            string Mquery = "SELECT mokkinimi,katuosoite FROM mokki WHERE mokki_id = '" + Hallinta.MajoitusMokkiID + "'";
            MySqlCommand Mokki = new MySqlCommand(Mquery, connection);
            connection.Open();
            cbMokki.Text = Mokki.ExecuteScalar().ToString();
            connection.Close();
        }

        private void btnPaivitaMajoitus_Click(object sender, EventArgs e)
        {
            //TarkistaPaivat();
            int maara,maara2;
            string Varauspv = dtpVarauspv.Value.ToString("yyyy-MM-dd");
            string Vahvistupv = dtpVarauspv.Value.ToString("yyyy-MM-dd");
            string VarausAlkupv = dtpVarauksenAlkupv.Value.ToString("yyyy-MM-dd");
            string VarausLoppupv = dtpVarauksenLoppupv.Value.ToString("yyyy-MM-dd");
            string hae = "SELECT MAX(asiakas_id) FROM asiakas;";
            MySqlCommand Asiakasmaara = new MySqlCommand(hae, connection);
            connection.Open();
            maara = (int)Asiakasmaara.ExecuteScalar();
            connection.Close();
            for(int i = 0; i <= maara; i++)
            {
                string valitse = "SELECT asiakas_id FROM asiakas WHERE etunimi = '" +cbAsiakas.Text+ "'";
                MySqlCommand Valitsemaara = new MySqlCommand(valitse, connection);
                connection.Open();
                Hallinta.MajoitusAsiakasID = (int)Valitsemaara.ExecuteScalar();
                connection.Close();
            }
            string hae2 = "SELECT MAX(mokki_id) FROM mokki;";
            MySqlCommand Mokkimaara = new MySqlCommand(hae2, connection);
            connection.Open();
            maara2 = (int)Mokkimaara.ExecuteScalar();
            connection.Close();
            for (int i = 0; i <= maara2; i++)
            {
                string valitse2 = "SELECT mokki_id FROM mokki WHERE mokkinimi = '" + cbMokki.Text + "'";
                MySqlCommand Valitsemaara2 = new MySqlCommand(valitse2, connection);
                connection.Open();
                Hallinta.MajoitusMokkiID = (int)Valitsemaara2.ExecuteScalar();
                connection.Close();
            }
            string Paivita = "UPDATE varaus SET varattu_pvm = '" + Varauspv.ToString() + "',vahvistus_pvm = '" + Vahvistupv.ToString() + "', varattu_alkupvm = '" + VarausAlkupv.ToString() + "',varattu_loppupvm = '" + VarausLoppupv.ToString() + "', asiakas_id = '"+Hallinta.MajoitusAsiakasID+"',mokki_id = '"+Hallinta.MajoitusMokkiID+ "' WHERE varaus_id = '" + Hallinta.MajoitusVarausID + "'";
            ExecuteMyQuery(Paivita);
            populateDGV();
            Poisto();
        }
        private void Poisto()
        {
            cbAsiakas.Text = "";
            cbMokki.Text = "";
            Hallinta.MajoitusAsiakasID = 0;
            Hallinta.MajoitusAsiakasID = 0;

        }
        private void HaeAsikkaat()
        {
            int MaxAsiakas;
            string asiakas;
            string haequery = "SELECT MAX(asiakas_id) FROM asiakas;";
            MySqlCommand Max = new MySqlCommand(haequery, connection);
            connection.Open();
            MaxAsiakas = (int)Max.ExecuteScalar();
            connection.Close();
            connection.Open();
            for (int i = 0; i <= MaxAsiakas; i++)
            {
                string query = "SELECT etunimi,sukunimi,lahiosoite FROM asiakas WHERE asiakas_id = '" + i + "'; ";
                MySqlCommand Asiakas = new MySqlCommand(query, connection);
                object test = Asiakas.ExecuteScalar();
                if (test == null)
                {

                }
                else
                {
                    asiakas = Asiakas.ExecuteScalar().ToString();
                    cbAsiakas.Items.Add(asiakas);
                }
            }
            connection.Close();
        }
        private void HaeMokit()
        {
            int MaxMokki;
            string Mokki;
            string haequery = "SELECT MAX(mokki_id) FROM mokki;";
            MySqlCommand Max = new MySqlCommand(haequery, connection);
            connection.Open();
            MaxMokki = (int)Max.ExecuteScalar();
            connection.Close();
            connection.Open();
            for (int i = 0; i <= MaxMokki; i++)
            {
                string query = "SELECT mokkinimi,katuosoite FROM mokki WHERE mokki_id = '" + i + "'; ";
                MySqlCommand Asiakas = new MySqlCommand(query, connection);
                object test = Asiakas.ExecuteScalar();
                if (test == null)
                {

                }
                else
                {
                    Mokki = Asiakas.ExecuteScalar().ToString();
                    cbMokki.Items.Add(Mokki);
                }
            }
            connection.Close();
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            string poista = "DELETE varaus WHERE varaus_id = '" + Hallinta.MajoitusVarausID + "'";
            ExecuteMyQuery(poista);
            populateDGV();
        }
        private void TarkistaPaivat()
        {
            connection.Close();
            string AikaAlku = dtpVarauksenAlkupv.Value.ToString("yyyy-MM-dd");
            string AikaLoppu = dtpVarauksenLoppupv.Value.ToString("yyyy-MM-dd");
            string HaeAlku = "SELECT varattu_alkupvm FROM varaus WHERE varattu_alkupvm = '"+AikaAlku+"' AND mokki_id = '" + Hallinta.MajoitusMokkiID+"';";
            MySqlCommand VarausAlku = new MySqlCommand(HaeAlku, connection);
            connection.Open();
            AikaAlku = VarausAlku.ExecuteScalar().ToString();
            connection.Close();
            string HaeLoppu = "SELECT varattu_loppupvm FROM varaus WHERE varattu_loppupvm = '" + AikaLoppu + "' AND mokki_id = '" + Hallinta.MajoitusMokkiID + "';";
            MySqlCommand VarausLoppu = new MySqlCommand(HaeLoppu, connection);
            connection.Open();
            AikaLoppu = VarausLoppu.ExecuteScalar().ToString();
            connection.Close();
            //if(dtpVarauksenAlkupv.Value > Convert.ToDateTime(AikaAlku) && dtpVarauksenLoppupv.Value < Convert.ToDateTime(AikaLoppu))
            //{
            //    MessageBox.Show("Varaus on jo olemassa tälle viikolle");
            //}
            //dtpVarauksenAlkupv.MinDate = Convert.ToDateTime(AikaLoppu);
            //dtpVarauksenAlkupv.MaxDate = Convert.ToDateTime(AikaAlku);
            //dtpVarauksenLoppupv.MinDate = Convert.ToDateTime(AikaLoppu);
            //dtpVarauksenLoppupv.MaxDate = Convert.ToDateTime(AikaAlku);

        }
    }
}
