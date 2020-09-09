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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn = new SqlConnection("server =.; Initial Catalog = OtelProje; Integrated Security = SSPI");
                SqlCommand cmd = new SqlCommand("select KullaniciTipi from Kullanicilar where KullaniciAdi = @KAdi and Sifre = @KParola", cnn);
                cmd.Parameters.AddWithValue("@KAdi", txtkullaniciadi.Text);
                cmd.Parameters.AddWithValue("@KParola", txtsifre.Text);
                cmd.Connection.Open();
                SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (rd.HasRows) // Girilen K.Adı ve K.Parola Dahilinde Gelen Data var ise 
                {
                    while (rd.Read()) // reader Okuyabiliyorsa
                    {
                        if (rd["KullaniciTipi"].ToString() == "1") // 1 Rolü Admin'e ait olarak Ayarlanmışdır
                        {
                            Form adminOtel = new frmAdminOtelSecim();
                            adminOtel.Show();
                            this.Hide();
                        }
                        else
                        {
                            Form OtelSecim = new OtelSecim();
                            OtelSecim.Show();
                            this.Hide();

                        }
                    }
                }
                else /// Reader SATIR döndüremiyorsa K.Adı Parola Yanlış Demekdir
                {
                    rd.Close();
                    MessageBox.Show("Kullanıcı Adı veya Parola Geçersizdir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch // Bağlantı açamayıp Sorgu Çalıştıramıyorsa Veritabanına Ulaşamıyor Demekdir
            {
                MessageBox.Show("DB ye ulaşılamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnyeniuye_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmYeniUyeKayit();
            frm1.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
