using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Web;
using System.Net;

namespace mail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string from = "NootWare@gmail.com";
            string to = textBox1.Text;
            string subject = "Lasku";
            try
            {
                string Text = "Tuote: "+ textBox2.Text+ "\nMäärä: "+ textBox3.Text+ "\nSumma: "+  textBox4.Text+ "\n Haluatko hienomman laskun?";
                string pass = "pofierqtrudvxeje"; //onetime password from google
                SmtpClient mailClient = new SmtpClient("smtp.gmail.com");
                mailClient.EnableSsl = true;
                mailClient.Port = 587;
                mailClient.Credentials = new System.Net.NetworkCredential(from, pass);
                MailMessage msgMail = new MailMessage(from, to, subject, Text);
                mailClient.Send(msgMail);
                MessageBox.Show("Your Mail was sent");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
