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
    public partial class frmEceSarayRezervasyon : Form
    {
        public frmEceSarayRezervasyon()
        {
            InitializeComponent();
        }

        private void frmEceSarayRezervasyon_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            SqlConnection cnn = new SqlConnection("server =.; Initial Catalog = OtelProje; Integrated Security = SSPI");
            SqlCommand cmd = new SqlCommand("select * from EceSarayOdaDurum  where EceSarayOdaDurum.EceSarayOdaID=@IDler ", cnn);
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
            cmd.Parameters.AddWithValue("@IDler", 10);
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
            odafiyat = 150;
            Form EceSarayRezervasyonIslemleri = new frmEceSarayRezervasyonIslemleri();
            EceSarayRezervasyonIslemleri.Show();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            odanumarasi = 2;
            odafiyat = 150;
            Form EceSarayRezervasyonIslemleri = new frmEceSarayRezervasyonIslemleri();
            EceSarayRezervasyonIslemleri.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            odanumarasi = 3;
            odafiyat = 150;
            Form EceSarayRezervasyonIslemleri = new frmEceSarayRezervasyonIslemleri();
            EceSarayRezervasyonIslemleri.Show();
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            odanumarasi = 4;
            odafiyat = 150;
            Form EceSarayRezervasyonIslemleri = new frmEceSarayRezervasyonIslemleri();
            EceSarayRezervasyonIslemleri.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            odanumarasi = 5;
            odafiyat = 150;
            Form EceSarayRezervasyonIslemleri = new frmEceSarayRezervasyonIslemleri();
            EceSarayRezervasyonIslemleri.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            odanumarasi = 6;
            odafiyat = 150;
            Form EceSarayRezervasyonIslemleri = new frmEceSarayRezervasyonIslemleri();
            EceSarayRezervasyonIslemleri.Show();
           
        }

       

        private void button7_Click(object sender, EventArgs e)
        {
            odanumarasi = 7;
            odafiyat = 271;
            Form EceSarayRezervasyonIslemleri = new frmEceSarayRezervasyonIslemleri();
            EceSarayRezervasyonIslemleri.Show();
          
        }

        private void button8_Click(object sender, EventArgs e)
        {
            odanumarasi = 8;
            odafiyat = 271;
            Form EceSarayRezervasyonIslemleri = new frmEceSarayRezervasyonIslemleri();
            EceSarayRezervasyonIslemleri.Show();
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            odanumarasi = 9;
            odafiyat = 271;
            Form EceSarayRezervasyonIslemleri = new frmEceSarayRezervasyonIslemleri();
            EceSarayRezervasyonIslemleri.Show();
        
        }

        private void button10_Click(object sender, EventArgs e)
        {
            odanumarasi = 10;
            odafiyat = 271;
            Form EceSarayRezervasyonIslemleri = new frmEceSarayRezervasyonIslemleri();
            EceSarayRezervasyonIslemleri.Show();
           
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
