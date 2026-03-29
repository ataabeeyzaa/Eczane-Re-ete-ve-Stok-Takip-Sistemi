using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace EczaneTakipApp
{
    public partial class FrmKritikStok : Form
    {
        public FrmKritikStok()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(1200, 700);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            dgvKritikStok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKritikStok.AllowUserToAddRows = false;
            dgvKritikStok.ReadOnly = true;
            dgvKritikStok.RowHeadersVisible = false;
            dgvKritikStok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKritikStok.MultiSelect = false;
            dgvKritikStok.BackgroundColor = Color.White;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=.;Database=EczaneTakipDB;User Id=EczaneAppLogin;Password=EczaneApp123!;TrustServerCertificate=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_KritikStoktakiIlaclar", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvKritikStok.DataSource = dt;
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
