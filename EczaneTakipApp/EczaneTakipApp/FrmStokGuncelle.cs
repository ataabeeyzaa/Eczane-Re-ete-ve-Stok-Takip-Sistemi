using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace EczaneTakipApp
{
    public partial class FrmStokGuncelle : Form
    {
        public FrmStokGuncelle()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(1200, 700);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=.;Database=EczaneTakipDB;User Id=EczaneAppLogin;Password=EczaneApp123!;TrustServerCertificate=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_IlacStokGuncelle", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ilac_id", Convert.ToInt32(txtIlacId.Text));
                        cmd.Parameters.AddWithValue("@yeni_stok", Convert.ToInt32(txtYeniStok.Text));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Stok başarıyla güncellendi.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
