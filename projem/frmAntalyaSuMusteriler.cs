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
using System.Collections;

namespace projem
{
    public partial class frmAntalyaSuMusteriler : Form
    {
        public frmAntalyaSuMusteriler()
        {
            InitializeComponent();
        }
        public SqlConnection bag = new SqlConnection("server=.; Initial Catalog=OtelProje;Integrated Security=SSPI");
        public SqlCommand kmt = new SqlCommand();
        public SqlDataAdapter adtr = new SqlDataAdapter();
        public DataSet dtst = new DataSet();
        public static int ID;

        private void frmAntalyaSuMusteriler_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            SqlConnection cnn = new SqlConnection("server =.; Initial Catalog = OtelProje; Integrated Security = SSPI");
            SqlCommand cmd = new SqlCommand("select * from AntalyaSuMusteriBilgileri", cnn);
            cmd.Connection.Open();
            SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            if (rd.HasRows) // Girilen K.Adı ve K.Parola Dahilinde Gelen Data var ise 
            {
                while (rd.Read()) // reader Okuyabiliyorsa
                {
                    dataGridView2.Rows.Add(rd["AntalyaSuMusteriID"].ToString(), rd["TC"].ToString(), rd["Ad"].ToString(), rd["Soyad"].ToString(), rd["BabaAdi"].ToString(), rd["AnneAdi"].ToString(), rd["DogumTarihi"].ToString(), rd["Cinsiyet"].ToString(), rd["MedeniHali"].ToString());
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn = new SqlConnection("server =.; Initial Catalog = OtelProje; Integrated Security = SSPI");
                SqlCommand cmd = new SqlCommand("delete from AntalyaSuMusteriBilgileri where AntalyaSuMusteriID=@ID", cnn);
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value));

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                dataGridView2.SelectedRows[0].Cells[0].Value = "";
                dataGridView2.SelectedRows[0].Cells[1].Value = "";
                dataGridView2.SelectedRows[0].Cells[2].Value = "";
                dataGridView2.SelectedRows[0].Cells[2].Value = "";
                dataGridView2.SelectedRows[0].Cells[3].Value = "";
                dataGridView2.SelectedRows[0].Cells[4].Value = "";
                dataGridView2.SelectedRows[0].Cells[5].Value = "";
                dataGridView2.SelectedRows[0].Cells[6].Value = "";
                dataGridView2.SelectedRows[0].Cells[7].Value = "";
                dataGridView2.SelectedRows[0].Cells[8].Value = "";

                MessageBox.Show("SİLİNDI VALLAHA SILINDI ALLAH CARPSIN GİT BAK ISTERSEN");

            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
            Form frm = new frmAntalyaSuGuncelle();
            frm.Show();
        }
        StringFormat strFormat;
        ArrayList arrColumnLefts = new ArrayList();
        ArrayList arrColumnWidths = new ArrayList();
        int iCellHeight = 0;
        int iTotalWidth = 0;
        int iRow = 0;
        bool bFirstPage = false;
        bool bNewPage = false;
        int iHeaderHeight = 0;

        private void MusteriKaydet_Click(object sender, EventArgs e)
        {
            Form frmGit = new frmAntalyaSuRezervasyonIslemleri();
            frmGit.Show();
        }

        private void MusterilerCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog onizleme = new PrintPreviewDialog();
            onizleme.Document = printDocument1;
            onizleme.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                int iLeftMargin = e.MarginBounds.Left;
                int iTopMargin = e.MarginBounds.Top;
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;
                bFirstPage = true;

                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in dataGridView2.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)iTotalWidth * (double)iTotalWidth *
                                       ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;


                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }

                while (iRow <= dataGridView2.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = dataGridView2.Rows[iRow];

                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;

                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {

                            e.Graphics.DrawString("AntalyaSu Otel Müşteriler", new Font(dataGridView2.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("AntalyaSu Otel Müşteriler", new Font(dataGridView2.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();

                            e.Graphics.DrawString(strDate, new Font(dataGridView2.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(dataGridView2.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("AntalyaSu Otel Müşteriler", new Font(new Font(dataGridView2.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);


                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in dataGridView2.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;

                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                            new SolidBrush(Cel.InheritedStyle.ForeColor),
                                            new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                            (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                            }

                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                    iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }


                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in dataGridView2.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new frmAntalyaSuMusteriler();
            frm.Show();
            this.Hide();
        }
    }
}
