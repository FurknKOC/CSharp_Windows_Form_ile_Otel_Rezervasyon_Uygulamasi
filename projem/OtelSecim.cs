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
    public partial class OtelSecim : Form
    {
        public OtelSecim()
        {
            InitializeComponent();
        }
        public static int[] id = new int[100];
        public static int secilenotel = 0;
        private void btnfiltrele_Click(object sender, EventArgs e)
        {
            if (chckonaklama.CheckedItems.Count==0 || chcuygunluk.CheckedItems.Count==0 || chctema.CheckedItems.Count == 0 || chcyildiz.CheckedItems.Count == 0)
            {
                MessageBox.Show("Az çok demeyelim boş geçmeyelim");
            }
            else
            {

            
            try
            {
                    listBox1.Items.Clear();
                SqlConnection cnn = new SqlConnection("server =.; Initial Catalog = OtelProje; Integrated Security = SSPI");
                SqlCommand cmd = new SqlCommand("select * from OtelSecimi inner join KonaklamaTipi on OtelSecimi.KonaklamaTipiID=KonaklamaTipi.KonaklamaTipiID inner join Erisebilirlik on OtelSecimi.ErisebilirlikID=Erisebilirlik.ErisilebilirlikID inner join OtelTemasi on OtelSecimi.OtelTemasiID=OtelTemasi.OtelTemasiID inner join Uygunluk on OtelSecimi.UygunlukID=Uygunluk.UygunlukID inner join YildizSayisi on OtelSecimi.YildizSayisiID=YildizSayisi.YildizSayisiID Where (@ApartHotel=KonaklamaTipi.ApartHotel OR @Resort=KonaklamaTipi.Resort OR @Yazlik=KonaklamaTipi.Yazlik OR @Otel=KonaklamaTipi.Otel) AND (@LuksOtel = OtelTemasi.LuksOtel OR @SehirOteli = OtelTemasi.SehirOteli OR @DogaOteli = OtelTemasi.DogaOteli OR @SaglikOteli = OtelTemasi.SaglikOteli )AND (@Aileler = Uygunluk.Aileler OR @BalayiCiftleri = Uygunluk.BalayiCiftleri OR	@Bekarlar = Uygunluk.Bekarlar OR @EngelliOtoparki = Erisebilirlik.EngelliOtoparki OR @EngellilereOzelYol = Erisebilirlik.EngellilereOzelYol OR @EngellilereOzelOda = Erisebilirlik.EngellilereOzelOda OR @TekerlekliSandalye = Erisebilirlik.TekerlekliSandalye) AND  (@YildizSayisi = YildizSayisi.YildizSayisi)", cnn);
                cmd.Parameters.AddWithValue("@ApartHotel", false);
                cmd.Parameters.AddWithValue("@Resort", false);
                cmd.Parameters.AddWithValue("@Yazlik", false);
                cmd.Parameters.AddWithValue("@Otel", false);
                cmd.Parameters.AddWithValue("@LuksOtel", false);
                cmd.Parameters.AddWithValue("@SehirOteli", false);
                cmd.Parameters.AddWithValue("@DogaOteli", false);
                cmd.Parameters.AddWithValue("@SaglikOteli", false);
                cmd.Parameters.AddWithValue("@Aileler", false);
                cmd.Parameters.AddWithValue("@BalayiCiftleri", false);
                cmd.Parameters.AddWithValue("@Bekarlar", false);
                cmd.Parameters.AddWithValue("@EngelliOtoparki", false);
                cmd.Parameters.AddWithValue("@EngellilereOzelYol", false);
                cmd.Parameters.AddWithValue("@EngellilereOzelOda", false);
                cmd.Parameters.AddWithValue("@TekerlekliSandalye", false);
                cmd.Parameters.AddWithValue("@YildizSayisi", 0);
                
                for (int i = 0; i < chckonaklama.CheckedItems.Count; i++)
                {
                    int degisken = chckonaklama.CheckedIndices[i];
                    switch (degisken)
                    {

                        case 0:
                            cmd.Parameters.RemoveAt("@ApartHotel");
                            cmd.Parameters.AddWithValue("@ApartHotel", true);

                            break;

                        case 1:
                            cmd.Parameters.RemoveAt("@Resort");
                            cmd.Parameters.AddWithValue("@Resort", true);

                            break;
                        case 2:
                            cmd.Parameters.RemoveAt("@Yazlik");
                            cmd.Parameters.AddWithValue("@Yazlik", true);

                            break;
                        case 3:
                            cmd.Parameters.RemoveAt("@Otel");
                            cmd.Parameters.AddWithValue("@Otel", true);


                            break;



                    }
                }
                for (int i = 0; i < chctema.CheckedItems.Count; i++)
                {
                    int degisken = chctema.CheckedIndices[i];
                    switch (degisken)
                    {

                        case 0:
                            cmd.Parameters.RemoveAt("@LuksOtel");
                            cmd.Parameters.AddWithValue("@LuksOtel", true);

                            break;

                        case 1:
                            cmd.Parameters.RemoveAt("@SehirOteli");
                            cmd.Parameters.AddWithValue("@SehirOteli", true);

                            break;
                        case 2:
                            cmd.Parameters.RemoveAt("@DogaOteli");
                            cmd.Parameters.AddWithValue("@DogaOteli", true);
                            break;
                        case 3:
                            cmd.Parameters.RemoveAt("@SaglikOteli");
                            cmd.Parameters.AddWithValue("@SaglikOteli", true);
                            break;

                    }
                }

                for (int i = 0; i < chcuygunluk.CheckedItems.Count; i++)
                {
                    int degisken = chcuygunluk.CheckedIndices[i];
                    switch (degisken)
                    {

                        case 0:
                            cmd.Parameters.RemoveAt("@Aileler");
                            cmd.Parameters.AddWithValue("@Aileler", true);

                            break;

                        case 1:
                            cmd.Parameters.RemoveAt("@BalayiCiftleri");
                            cmd.Parameters.AddWithValue("@BalayiCiftleri", true);
                            break;
                        case 2:
                            cmd.Parameters.RemoveAt("@Bekarlar");
                            cmd.Parameters.AddWithValue("@Bekarlar", true);
                            break;


                    }
                }
                for (int i = 0; i < chcerisebilirlik.CheckedItems.Count; i++)
                {
                    int degisken = chcerisebilirlik.CheckedIndices[i];
                    switch (degisken)
                    {

                        case 0:
                            cmd.Parameters.RemoveAt("@EngelliOtoparki");
                            cmd.Parameters.AddWithValue("@EngelliOtoparki", true);
                            break;

                        case 1:
                            cmd.Parameters.RemoveAt("@EngellilereOzelOda");
                            cmd.Parameters.AddWithValue("@EngellilereOzelOda", true);
                            break;
                        case 2:
                            cmd.Parameters.RemoveAt("@EngellilereOzelYol");
                            cmd.Parameters.AddWithValue("@EngellilereOzelYol", true);
                            break;
                        case 3:
                            cmd.Parameters.RemoveAt("@TekerlekliSandalye");
                            cmd.Parameters.AddWithValue("@TekerlekliSandalye", true);
                            break;

                    }
                }
                for (int i = 0; i < chcyildiz.CheckedItems.Count; i++)
                {
                    int degisken = chcyildiz.CheckedIndices[i];
                    switch (degisken)
                    {

                        case 0:
                            cmd.Parameters.RemoveAt("@YildizSayisi");
                            cmd.Parameters.AddWithValue("@YildizSayisi", 1);
                            break;

                        case 1:
                            cmd.Parameters.RemoveAt("@YildizSayisi");
                            cmd.Parameters.AddWithValue("@YildizSayisi", 2);
                            break;
                        case 2:
                            cmd.Parameters.RemoveAt("@YildizSayisi");
                            cmd.Parameters.AddWithValue("@YildizSayisi", 3);
                            break;
                        case 3:
                            cmd.Parameters.RemoveAt("@YildizSayisi");
                            cmd.Parameters.AddWithValue("@YildizSayisi", 4);
                            break;
                        case 4:
                            cmd.Parameters.RemoveAt("@YildizSayisi");
                            cmd.Parameters.AddWithValue("@YildizSayisi", 5);
                            break;
                    }
                }
                cmd.Connection.Open();
                SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    int sayac = 0;
                if (rd.HasRows) // Girilen K.Adı ve K.Parola Dahilinde Gelen Data var ise 
                {
                    while (rd.Read()) // reader Okuyabiliyorsa
                    {
                           
                        listBox1.Items.Add(rd["OtelIsmı"]);
                            label10.Text = rd["OtelAciklama"].ToString();
                            id[sayac] =Convert.ToInt32(rd["ID"]);
                           sayac++;

                    }
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);

            }
            }

        }

        private void chckonaklama_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            label6.Visible = false;
         
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            SqlConnection cnn = new SqlConnection("server =.; Initial Catalog = OtelProje; Integrated Security = SSPI");
            SqlCommand cmd = new SqlCommand("select * from OtelSecimi  where ID=@IDler", cnn);
            cmd.Parameters.AddWithValue("@IDler", id[listBox1.SelectedIndex]);
            cmd.Connection.Open();
            SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        
            if (rd.HasRows) // Girilen K.Adı ve K.Parola Dahilinde Gelen Data var ise 
            {
                while (rd.Read()) // reader Okuyabiliyorsa
                {
                    label10.Text = rd["OtelAciklama"].ToString();
                    pictureBox1.Image = Image.FromFile(rd["OtelResim"].ToString());
                }
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            secilenotel = id[listBox1.SelectedIndex];
            

            switch (secilenotel)
            {
                case 9:
                    Form frmDedeman = new frmDedemanRezervasyon();
                    frmDedeman.Show();
                    this.Hide();
                    break;
                case 10:
                    Form frmHilton = new frmHiltonRezervasyon();
                    frmHilton.Show();
                    this.Hide();
                    break;
                case 11:
                    Form frmKutberk = new frmKutberkRezervasyon();
                    frmKutberk.Show();
                    this.Hide();
                    break;
                case 12:
                    Form frmEceSaray = new frmEceSarayRezervasyon();
                    frmEceSaray.Show();
                    this.Hide();
                    break;
                case 13:
                    Form frmAntalyaSu = new frmAntalyaSuRezervasyon();
                    frmAntalyaSu.Show();
                    this.Hide();
                    break;
            }
            

        }

        private void chctema_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chctema_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            label7.Visible = false;
        }

        private void chcuygunluk_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            label8.Visible = false;
        }

        private void chcyildiz_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            label9.Visible = false;
        }

        private void OtelSecim_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}

