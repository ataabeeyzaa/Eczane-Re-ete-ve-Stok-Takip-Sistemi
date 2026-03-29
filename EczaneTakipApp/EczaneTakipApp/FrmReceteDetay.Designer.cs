namespace EczaneTakipApp
{
    partial class FrmReceteDetay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtReceteId = new System.Windows.Forms.TextBox();
            this.btnDetayGetir = new System.Windows.Forms.Button();
            this.dgvDetaylar = new System.Windows.Forms.DataGridView();
            this.btnKapat = new System.Windows.Forms.Button();
            this.sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetaylar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(41, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reçete ID:";
            // 
            // txtReceteId
            // 
            this.txtReceteId.Location = new System.Drawing.Point(210, 94);
            this.txtReceteId.Name = "txtReceteId";
            this.txtReceteId.Size = new System.Drawing.Size(410, 38);
            this.txtReceteId.TabIndex = 1;
            // 
            // btnDetayGetir
            // 
            this.btnDetayGetir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDetayGetir.Location = new System.Drawing.Point(685, 81);
            this.btnDetayGetir.Name = "btnDetayGetir";
            this.btnDetayGetir.Size = new System.Drawing.Size(209, 62);
            this.btnDetayGetir.TabIndex = 2;
            this.btnDetayGetir.Text = "Detayları Getir";
            this.btnDetayGetir.UseVisualStyleBackColor = false;
            this.btnDetayGetir.Click += new System.EventHandler(this.btnDetayGetir_Click);
            // 
            // dgvDetaylar
            // 
            this.dgvDetaylar.AllowUserToAddRows = false;
            this.dgvDetaylar.AllowUserToDeleteRows = false;
            this.dgvDetaylar.AllowUserToResizeRows = false;
            this.dgvDetaylar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetaylar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetaylar.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetaylar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetaylar.Location = new System.Drawing.Point(56, 149);
            this.dgvDetaylar.MultiSelect = false;
            this.dgvDetaylar.Name = "dgvDetaylar";
            this.dgvDetaylar.ReadOnly = true;
            this.dgvDetaylar.RowHeadersVisible = false;
            this.dgvDetaylar.RowHeadersWidth = 102;
            this.dgvDetaylar.RowTemplate.Height = 40;
            this.dgvDetaylar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetaylar.Size = new System.Drawing.Size(1725, 888);
            this.dgvDetaylar.TabIndex = 3;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.BackColor = System.Drawing.Color.Crimson;
            this.btnKapat.Location = new System.Drawing.Point(1585, 79);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(152, 67);
            this.btnKapat.TabIndex = 4;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // FrmReceteDetay
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1844, 1088);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.dgvDetaylar);
            this.Controls.Add(this.btnDetayGetir);
            this.Controls.Add(this.txtReceteId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReceteDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReceteDetay";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetaylar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReceteId;
        private System.Windows.Forms.Button btnDetayGetir;
        private System.Windows.Forms.DataGridView dgvDetaylar;
        private System.Windows.Forms.Button btnKapat;
        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
    }
}