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
    public partial class frmAntalyaSuGuncelle : Form
    {
        public frmAntalyaSuGuncelle()
        {
            InitializeComponent();
        }

        private void frmAntalyaSuGuncelle_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            SqlConnection cnn = new SqlConnection("server =.; Initial Catalog = OtelProje; Integrated Security = SSPI");
            SqlCommand cmd = new SqlCommand("select * from AntalyaSuMusteriBilgileri where AntalyaSuMusteriID=@ID", cnn);
            cmd.Parameters.AddWithValue("@ID", frmAntalyaSuMusteriler.ID);
            cmd.Connection.Open();
            SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            if (rd.HasRows) // Girilen K.Adı ve K.Parola Dahilinde Gelen Data var ise 
            {
                while (rd.Read()) // reader Okuyabiliyorsa
                {
                    txtTcKimlikNo.Text = rd["TC"].ToString();
                    txtAd.Text = rd["Ad"].ToString();
                    txtSoyad.Text = rd["Soyad"].ToString();
                    txtBabaAdi.Text = rd["BabaAdi"].ToString();
                    txtAnneAdi.Text = rd["AnneAdi"].ToString();
                    datetimeDogumTarihi.Value = Convert.ToDateTime(rd["DogumTarihi"]).Date;
                    txtCepTel.Text = rd["CepTel"].ToString();
                    txtEvTel.Text = rd["EvTel"].ToString();
                    txtIsTel.Text = rd["IsTel"].ToString();
                    txtEmail.Text = rd["Email"].ToString();
                    txtMeslek.Text = rd["Meslek"].ToString();
                    txtEvAdresi.Text = rd["Adres"].ToString();
                    txtOdaNumarasi.Text = rd["AntalyaSuOdaID"].ToString();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn = new SqlConnection("server =.; Initial Catalog = OtelProje; Integrated Security = SSPI");
                SqlCommand cmd = new SqlCommand("UPDATE AntalyaSuMusteriBilgileri SET TC=@TC,Ad=@Ad,Soyad=@Soyad,BabaAdi=@BabaAdi,AnneAdi=@AnneAdi,DogumTarihi=@DogumTarihi,CepTel=@Ceptel,EvTel=@EvTel,IsTel=@IsTel,Email=@Email,Meslek=@Meslek,Adres=@Adres,AntalyaSuOdaID=@AntalyaSuOdaID where AntalyaSuMusteriID=@ID", cnn);
                cmd.Parameters.AddWithValue("@ID", frmAntalyaSuMusteriler.ID);
                cmd.Parameters.AddWithValue("@TC", Convert.ToInt32(txtTcKimlikNo.Text));
                cmd.Parameters.AddWithValue("@Ad", txtAd.Text);
                cmd.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                cmd.Parameters.AddWithValue("@BabaAdi", txtBabaAdi.Text);
                cmd.Parameters.AddWithValue("@AnneAdi", txtAnneAdi.Text);
                cmd.Parameters.AddWithValue("@DogumTarihi", datetimeDogumTarihi.Value.Date.ToShortDateString());
                cmd.Parameters.AddWithValue("@CepTel", txtCepTel.Text);
                cmd.Parameters.AddWithValue("@EvTel", txtEvTel.Text);
                cmd.Parameters.AddWithValue("@IsTel", txtIsTel.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Meslek", txtMeslek.Text);
                cmd.Parameters.AddWithValue("@Adres", txtEvAdresi.Text);
                cmd.Parameters.AddWithValue("@AntalyaSuOdaID", txtOdaNumarasi.Text);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Güncellendi");
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
