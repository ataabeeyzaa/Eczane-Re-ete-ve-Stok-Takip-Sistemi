using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace EczaneTakipApp
{
    public partial class FrmHastalar : Form
    {
        public FrmHastalar()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(1200, 700);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            dgvHastalar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHastalar.AllowUserToAddRows = false;
            dgvHastalar.ReadOnly = true;
            dgvHastalar.RowHeadersVisible = false;
            dgvHastalar.BackgroundColor = Color.White;
            dgvHastalar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHastalar.MultiSelect = false;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=.;Database=EczaneTakipDB;User Id=EczaneAppLogin;Password=EczaneApp123!;TrustServerCertificate=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_HastalariListele", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvHastalar.DataSource = dt;
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
