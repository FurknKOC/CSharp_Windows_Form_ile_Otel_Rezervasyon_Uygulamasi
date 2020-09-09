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
using AForge.Video;
using AForge.Video.DirectShow;

namespace projem
{
    public partial class frmAntalyaSuRezervasyonIslemleri : Form
    {
        public frmAntalyaSuRezervasyonIslemleri()
        {
            InitializeComponent();
        }
        private FilterInfoCollection webcam; //webcam isminde tanımladığımız değişken bilgisayara kaç kamera bağlıysa onları tutan bir dizi.

        private VideoCaptureDevice cam; //cam ise bizim kullanacağımız aygıt.

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn = new SqlConnection("server =.; Initial Catalog = OtelProje; Integrated Security = SSPI");
                SqlCommand cmd = new SqlCommand();
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandText = " insert into AntalyaSuMusteriBilgileri(TC,Ad,Soyad,BabaAdi,AnneAdi,DogumTarihi,Cinsiyet,MedeniHali,CepTel,EvTel,IsTel,Email,Meslek,Adres,AntalyaSuOdaID,RezBaslangic,RezBitis,OdemeTuru,Ucret,MusteriResim) values (" + Convert.ToInt32(txtTcKimlikNo.Text) + ",'" + txtAd.Text + "','" + txtSoyad.Text + "','" + txtBabaAdi.Text + "','" + txtAnneAdi.Text + "','" + datetimeDogumTarihi.Value.Date.ToShortDateString() + "','" + comboCinsiyet.Text + "','" + comboMedeniHal.Text + "','" + txtCepTel.Text + "','" + txtEvTel.Text + "','" + txtIsTel.Text + "','" + txtEmail.Text + "','" + txtMeslek.Text + "','" + txtEvAdresi.Text + "','" + Convert.ToInt32(txtOdaNumarasi.Text) + "','" + datetimeBaslangicRezarvasyonTarihi.Value.Date.ToShortDateString() + "','" + datetimeBitisRezarvasyonTarihi.Value.Date.ToShortDateString() + "','" + comboOdemeTuru.Text + "','" + txtUcret.Text + "','" + FotografYolu.ToString() + "')";
                //cmd.CommandText = " insert into DedemanMusteriBilgileri(TC,Ad,Soyad,BabaAdi,AnneAdi,Cinsiyet,MedeniHali,CepTel,EvTel,IsTel,Email,Meslek,Adres,DedemanOdaID,OdemeTuruID,Ucret) values (" + Convert.ToInt32(txtTcKimlikNo.Text) + ",'" + txtAd.Text + "','" + txtSoyad.Text + "','" + txtBabaAdi.Text + "','" + txtAnneAdi.Text + "','" + comboCinsiyet.Text + "','" + comboMedeniHal.Text + "','" + txtCepTel.Text + "','" + txtEvTel.Text + "','" + txtIsTel.Text + "','" + txtEmail.Text + "','" + txtMeslek.Text + "','" + txtEvAdresi.Text + "','" + Convert.ToInt32(txtOdaNumarasi.Text) + "','" + comboOdemeTuru.SelectedValue + "','" + Convert.ToInt32(txtUcret.Text) + "')";

                cmd.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Kayıt Başarılı");
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
                throw;
            }

        }

        private void frmAntalyaSuRezervasyonIslemleri_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            SqlConnection cnn = new SqlConnection("server =.; Initial Catalog = OtelProje; Integrated Security = SSPI");
            SqlCommand cmd = new SqlCommand("select * from AntalyaSuOdaDurum  where AntalyaSuOdaDurum.AntalyaSuOdaID=@IDler ", cnn);
            cmd.Parameters.AddWithValue("@IDler", frmAntalyaSuRezervasyon.odanumarasi);
            cmd.Connection.Open();
            SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            if (rd.HasRows) // Girilen K.Adı ve K.Parola Dahilinde Gelen Data var ise 
            {
                while (rd.Read()) // reader Okuyabiliyorsa
                {
                    txtOdaNumarasi.Text = rd["AntalyaSuOdaID"].ToString();
                }
            }
            comboBox2.SelectedIndex = 0;
            //kamera

            webcam = new

             FilterInfoCollection(FilterCategory.VideoInputDevice); //webcam dizisine mevcut kameraları dolduruyoruz.

            foreach (FilterInfo item in webcam)
            {

                cmbKameralar.Items.Add(item.Name); //kameraları combobox a dolduruyoruz.

            }

            cmbKameralar.SelectedIndex = 0;
        }
        private void cam_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone(); //kısaca bu eventta kameradan alınan görüntüyü picturebox a atıyoruz.
            pictureBox1.Image = bmp;
        }
        int fiyat = frmAntalyaSuRezervasyon.odafiyat;
        double ucret = 0;
        int deger = 0;

        private void datetimeBitisRezarvasyonTarihi_ValueChanged(object sender, EventArgs e)
        {
            deger = datetimeBitisRezarvasyonTarihi.Value.Day - datetimeBaslangicRezarvasyonTarihi.Value.Day;
            if (comboBox2.SelectedIndex == 0)
            {
                ucret = (fiyat * deger);
            }
            else
            {
                ucret = ((fiyat * deger) * 0.75);
            }
            txtUcret.Text = ucret.ToString();
        }
        public static string FotografYolu = "";

        private void btnCek_Click(object sender, EventArgs e)
        {
            SaveFileDialog swf = new SaveFileDialog();

            swf.Filter = "(*.jpg)|*.jpg|Bitma*p(*.bmp)|*.bmp";
            swf.InitialDirectory = @"C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources";
            DialogResult dialog = swf.ShowDialog();  //fotoğrafı çekiyoruz ve aşağıda da kaydediyoruz.


            if (dialog == DialogResult.OK)
            {
                pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

                swf.Title = "AntalyaSu Musteri";
                swf.ShowDialog();
                pictureBox1.Image.Save(swf.FileName);
                FotografYolu = swf.FileName;
                pictureBox1.ImageLocation = FotografYolu;
                if (cam.IsRunning)
                {
                    cam.Stop(); // kamerayı durduruyoruz.
                }
            }
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            if (cam.IsRunning)
            {
                cam.Stop(); // kamerayı durduruyoruz.
            }
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            cam = new

                VideoCaptureDevice(webcam[cmbKameralar.SelectedIndex].MonikerString); //başlaya basıldığında yukarıda tanımladığımız cam değişkenine comboboxta seçilmiş olan kamerayı atıyoruz.

            cam.NewFrame += cam_NewFrame;

            cam.Start(); //kamerayı başlatıyoruz.
        }
    }
}
