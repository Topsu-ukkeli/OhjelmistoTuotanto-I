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
            dtpVarauspv.Value = (DateTime)dgwMajoitusvaraus.CurrentRow.Cells[1].Value;
            dtpVahvistuspv.Value = (DateTime)dgwMajoitusvaraus.CurrentRow.Cells[2].Value;
            dtpVarauksenAlkupv.Value = (DateTime)dgwMajoitusvaraus.CurrentRow.Cells[3].Value;
            dtpVarauksenLoppupv.Value = (DateTime)dgwMajoitusvaraus.CurrentRow.Cells[4].Value;

        }
    }
}
