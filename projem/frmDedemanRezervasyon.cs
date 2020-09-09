using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projem
{
    public partial class frmDedemanRezervasyon : Form
    {
        public frmDedemanRezervasyon()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void frmDedemanRezervasyon_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            SqlConnection cnn = new SqlConnection("server =.; Initial Catalog = OtelProje; Integrated Security = SSPI");
            SqlCommand cmd = new SqlCommand("select * from DedemanOdaDurum  where DedemanOdaDurum.DedemanOdaID=@IDler ", cnn);
            cmd.Parameters.AddWithValue("@IDler", 1);
            cmd.Connection.Open();
            SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            if (rd.HasRows) // Girilen K.Adı ve K.Parola Dahilinde Gelen Data var ise 
            {
                while (rd.Read()) // reader Okuyabiliyorsa
                {
                    pictureBox1.Image = Image.FromFile(rd["OdaResim"].ToString());
                    pictureBox2.Image = Image.FromFile(rd["OdaResim"].ToString());
                    pictureBox3.Image = Image.FromFile(rd["OdaResim"].ToString());
                    pictureBox4.Image = Image.FromFile(rd["OdaResim"].ToString());
                    pictureBox5.Image = Image.FromFile(rd["OdaResim"].ToString());

                }
            }
            cmd.Connection.Close();
            cmd.Parameters.RemoveAt("@IDler");
            cmd.Parameters.AddWithValue("@IDler", 6);
            cmd.Connection.Open();
            rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (rd.HasRows) // Girilen K.Adı ve K.Parola Dahilinde Gelen Data var ise 
            {
                while (rd.Read()) // reader Okuyabiliyorsa
                {
                    pictureBox6.Image = Image.FromFile(rd["OdaResim"].ToString());
                    pictureBox7.Image = Image.FromFile(rd["OdaResim"].ToString());
                    pictureBox8.Image = Image.FromFile(rd["OdaResim"].ToString());

                }
            }
            cmd.Connection.Close();
            cmd.Parameters.RemoveAt("@IDler");
            cmd.Parameters.AddWithValue("@IDler", 10);
            cmd.Connection.Open();
            rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (rd.HasRows) // Girilen K.Adı ve K.Parola Dahilinde Gelen Data var ise 
            {
                while (rd.Read()) // reader Okuyabiliyorsa
                {
                    pictureBox9.Image = Image.FromFile(rd["OdaResim"].ToString());
                    pictureBox10.Image = Image.FromFile(rd["OdaResim"].ToString());

                }
            }
            cmd.Connection.Close();




        }
        public static int odanumarasi = 0;
        public static int odafiyat = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            odanumarasi = 1;
            odafiyat = 100;
            Form DedemanRezervasyonIslemleri = new frmDedemanRezervasyonİslemleri();
            DedemanRezervasyonIslemleri.Show();


        }


        private void button2_Click(object sender, EventArgs e)
        {
            odafiyat = 100;
            odanumarasi = 2;
            Form DedemanRezervasyonIslemleri = new frmDedemanRezervasyonİslemleri();
            DedemanRezervasyonIslemleri.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            odafiyat = 100;
            odanumarasi = 3;
            Form DedemanRezervasyonIslemleri = new frmDedemanRezervasyonİslemleri();
            DedemanRezervasyonIslemleri.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            odafiyat = 100;
            odanumarasi = 4;
            Form DedemanRezervasyonIslemleri = new frmDedemanRezervasyonİslemleri();
            DedemanRezervasyonIslemleri.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            odafiyat = 100;
            odanumarasi = 5;
            Form DedemanRezervasyonIslemleri = new frmDedemanRezervasyonİslemleri();
            DedemanRezervasyonIslemleri.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            odafiyat = 150;
            odanumarasi = 6;
            Form DedemanRezervasyonIslemleri = new frmDedemanRezervasyonİslemleri();
            DedemanRezervasyonIslemleri.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            odafiyat = 150;
            odanumarasi = 7;
            Form DedemanRezervasyonIslemleri = new frmDedemanRezervasyonİslemleri();
            DedemanRezervasyonIslemleri.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            odafiyat = 150;
            odanumarasi = 8;
            Form DedemanRezervasyonIslemleri = new frmDedemanRezervasyonİslemleri();
            DedemanRezervasyonIslemleri.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            odafiyat = 256;
            odanumarasi = 9;
            Form DedemanRezervasyonIslemleri = new frmDedemanRezervasyonİslemleri();
            DedemanRezervasyonIslemleri.Show();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            odafiyat = 256;
            odanumarasi = 10;
            Form DedemanRezervasyonIslemleri = new frmDedemanRezervasyonİslemleri();
            DedemanRezervasyonIslemleri.Show();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("server =.; Initial Catalog = OtelProje; Integrated Security = SSPI");
            SqlCommand cmd = new SqlCommand("select * from DedemanMusteriBilgileri", cnn);
            int bas;
            int bit;
            int aralik;
            cmd.Connection.Open();
            SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            if (rd.HasRows) // Girilen K.Adı ve K.Parola Dahilinde Gelen Data var ise 
            {
                while (rd.Read()) // reader Okuyabiliyorsa
                {
                    if (Convert.ToDateTime(rd["RezBaslangic"]).Day > dateTimePicker1.Value.Date.Day && dateTimePicker1.Value.Date.Day < Convert.ToDateTime(rd["RezBitis"]).Day)
                    {
                        bas = Convert.ToDateTime(rd["RezBaslangic"]).Day;
                        bit = Convert.ToDateTime(rd["RezBitis"]).Day;
                        aralik = bit - bas;
                        if (aralik == 1)
                        {
                            LblOda1Tarih2.BackColor = Color.Red;
                        }
                    }

                }
            }

        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            Form frmGit = new OtelSecim();
            frmGit.Show();
            this.Hide();
        }

        private void btnAnaMenuCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
