using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaneTakipApp
{
    public partial class FrmReceteDetay : Form
    {
        public FrmReceteDetay()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(1200, 700);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            dgvDetaylar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetaylar.AllowUserToAddRows = false;
            dgvDetaylar.ReadOnly = true;
            dgvDetaylar.RowHeadersVisible = false;
            dgvDetaylar.BackgroundColor = Color.White;
            dgvDetaylar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetaylar.MultiSelect = false;
        }

        private void btnDetayGetir_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=.;Database=EczaneTakipDB;User Id=EczaneAppLogin;Password=EczaneApp123!;TrustServerCertificate=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_ReceteDetayGetir", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@recete_id", Convert.ToInt32(txtReceteId.Text));

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvDetaylar.DataSource = dt;
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
