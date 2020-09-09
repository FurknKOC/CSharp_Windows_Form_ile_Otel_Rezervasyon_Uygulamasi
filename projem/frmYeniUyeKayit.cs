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
    public partial class frmYeniUyeKayit : Form
    {
        public frmYeniUyeKayit()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn = new SqlConnection("server =.; Initial Catalog = OtelProje; Integrated Security = SSPI");
                SqlCommand cmd = new SqlCommand();
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandText = "insert into Kullanicilar(TC,Adi,Soyadi,Telefonu,Mail,Sehir,KullaniciAdi,Sifre ) values (" + Convert.ToInt32(txttc.Text) + ",'" + txtadi.Text + "','" + txtsoyadi.Text + "','" + txttelefon.Text + "','" + txtemail.Text + "','" + txtsehir.Text + "','" + txtkullaniciadi.Text + "','" + txtsifre.Text + "')";
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

        private void frmYeniUyeKayit_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
