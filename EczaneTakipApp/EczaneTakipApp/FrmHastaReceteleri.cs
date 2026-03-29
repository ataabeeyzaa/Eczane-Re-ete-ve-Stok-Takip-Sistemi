using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Microsoft.Data.SqlClient;

namespace EczaneTakipApp
{
    public partial class FrmHastaReceteleri : Form
    {
        public FrmHastaReceteleri()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(1200, 700);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            dgvReceteler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReceteler.AllowUserToAddRows = false;
            dgvReceteler.ReadOnly = true;
            dgvReceteler.RowHeadersVisible = false;
            dgvReceteler.BackgroundColor = Color.White;
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=.;Database=EczaneTakipDB;User Id=EczaneAppLogin;Password=EczaneApp123!;TrustServerCertificate=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_HastaReceteleri", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@hasta_id", Convert.ToInt32(txtHastaId.Text));

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvReceteler.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
