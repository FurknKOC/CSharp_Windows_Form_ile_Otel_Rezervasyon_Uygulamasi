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
    public partial class frmDedemanGuncelle : Form
    {
        public frmDedemanGuncelle()
        {
            InitializeComponent();
        }

        private void frmDedemanGuncelle_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            SqlConnection cnn = new SqlConnection("server =.; Initial Catalog = OtelProje; Integrated Security = SSPI");
            SqlCommand cmd = new SqlCommand("select * from DedemanMusteriBilgileri where DedemanMusteriID=@ID", cnn);
            cmd.Parameters.AddWithValue("@ID", frmDedemanMusteriler.ID);
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
                    txtOdaNumarasi.Text = rd["DedemanOdaID"].ToString();
                }
            }

        }

        private void MusteriGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn = new SqlConnection("server =.; Initial Catalog = OtelProje; Integrated Security = SSPI");
                SqlCommand cmd = new SqlCommand("UPDATE DedemanMusteriBilgileri SET TC=@TC,Ad=@Ad,Soyad=@Soyad,BabaAdi=@BabaAdi,AnneAdi=@AnneAdi,DogumTarihi=@DogumTarihi,CepTel=@Ceptel,EvTel=@EvTel,IsTel=@IsTel,Email=@Email,Meslek=@Meslek,Adres=@Adres,DedemanOdaID=@DedemanOdaID where DedemanMusteriID=@ID", cnn);
                cmd.Parameters.AddWithValue("@ID", frmDedemanMusteriler.ID);
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
                cmd.Parameters.AddWithValue("@DedemanOdaID", txtOdaNumarasi.Text);
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

        private void GuncelleCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
