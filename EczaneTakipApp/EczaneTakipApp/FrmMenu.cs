using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaneTakipApp
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(1200, 700);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void btnHastalar_Click(object sender, EventArgs e)
        {
            FrmHastalar frm = new FrmHastalar();
            frm.ShowDialog();
        }

        private void btnHastaReceteleri_Click(object sender, EventArgs e)
        {
            FrmHastaReceteleri frm = new FrmHastaReceteleri();
            frm.ShowDialog();
        }

        private void btnKritikStok_Click(object sender, EventArgs e)
        {
            FrmKritikStok frm = new FrmKritikStok();
            frm.ShowDialog();
        }

        private void btnReceteDetay_Click(object sender, EventArgs e)
        {
            FrmReceteDetay frm = new FrmReceteDetay();
            frm.ShowDialog();
        }

        private void btnStokGuncelle_Click(object sender, EventArgs e)
        {
            FrmStokGuncelle frm = new FrmStokGuncelle();
            frm.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
