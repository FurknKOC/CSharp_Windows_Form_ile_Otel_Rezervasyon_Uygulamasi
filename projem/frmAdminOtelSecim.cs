using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projem
{
    public partial class frmAdminOtelSecim : Form
    {
        public frmAdminOtelSecim()
        {
            InitializeComponent();
        }

        private void btnDedeman_Click(object sender, EventArgs e)
        {
            Form dedemanMusteriler = new frmDedemanMusteriler();
            dedemanMusteriler.Show();
            
        }

        private void btnHilton_Click(object sender, EventArgs e)
        {
            Form hiltonMusteriler = new frmHiltonMusteriler();
            hiltonMusteriler.Show();
            
        }

        private void btnKutberk_Click(object sender, EventArgs e)
        {
            Form kutberkMusteriler = new frmKutberkMusteriler();
            kutberkMusteriler.Show();
           
        }

        private void frmAdminOtelSecim_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnEceSaray_Click(object sender, EventArgs e)
        {
            Form ecesarayMusteriler = new frmEceSarayMusteriler();
            ecesarayMusteriler.Show();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form antalyasuMusteriler = new frmAntalyaSuMusteriler();
            antalyasuMusteriler.Show();
            
        }
    }
}
