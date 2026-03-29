namespace EczaneTakipApp
{
    partial class FrmMenu
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
            this.lblMenuBaslik = new System.Windows.Forms.Label();
            this.btnHastalar = new System.Windows.Forms.Button();
            this.btnHastaReceteleri = new System.Windows.Forms.Button();
            this.btnKritikStok = new System.Windows.Forms.Button();
            this.btnReceteDetay = new System.Windows.Forms.Button();
            this.btnStokGuncelle = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenuBaslik
            // 
            this.lblMenuBaslik.AutoSize = true;
            this.lblMenuBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenuBaslik.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMenuBaslik.Location = new System.Drawing.Point(1473, 671);
            this.lblMenuBaslik.Name = "lblMenuBaslik";
            this.lblMenuBaslik.Size = new System.Drawing.Size(243, 54);
            this.lblMenuBaslik.TabIndex = 0;
            this.lblMenuBaslik.Text = "Ana Menü";
            // 
            // btnHastalar
            // 
            this.btnHastalar.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnHastalar.Location = new System.Drawing.Point(1137, 769);
            this.btnHastalar.Name = "btnHastalar";
            this.btnHastalar.Size = new System.Drawing.Size(271, 115);
            this.btnHastalar.TabIndex = 1;
            this.btnHastalar.Text = "Hastaları Listele";
            this.btnHastalar.UseVisualStyleBackColor = false;
            this.btnHastalar.Click += new System.EventHandler(this.btnHastalar_Click);
            // 
            // btnHastaReceteleri
            // 
            this.btnHastaReceteleri.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnHastaReceteleri.Location = new System.Drawing.Point(1462, 769);
            this.btnHastaReceteleri.Name = "btnHastaReceteleri";
            this.btnHastaReceteleri.Size = new System.Drawing.Size(244, 115);
            this.btnHastaReceteleri.TabIndex = 2;
            this.btnHastaReceteleri.Text = "Hasta Reçeteleri";
            this.btnHastaReceteleri.UseVisualStyleBackColor = false;
            this.btnHastaReceteleri.Click += new System.EventHandler(this.btnHastaReceteleri_Click);
            // 
            // btnKritikStok
            // 
            this.btnKritikStok.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnKritikStok.Location = new System.Drawing.Point(1756, 769);
            this.btnKritikStok.Name = "btnKritikStok";
            this.btnKritikStok.Size = new System.Drawing.Size(268, 115);
            this.btnKritikStok.TabIndex = 3;
            this.btnKritikStok.Text = "Kritik Stoktaki İlaçlar";
            this.btnKritikStok.UseVisualStyleBackColor = false;
            this.btnKritikStok.Click += new System.EventHandler(this.btnKritikStok_Click);
            // 
            // btnReceteDetay
            // 
            this.btnReceteDetay.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnReceteDetay.Location = new System.Drawing.Point(1274, 937);
            this.btnReceteDetay.Name = "btnReceteDetay";
            this.btnReceteDetay.Size = new System.Drawing.Size(296, 131);
            this.btnReceteDetay.TabIndex = 4;
            this.btnReceteDetay.Text = "Reçete Detayları";
            this.btnReceteDetay.UseVisualStyleBackColor = false;
            this.btnReceteDetay.Click += new System.EventHandler(this.btnReceteDetay_Click);
            // 
            // btnStokGuncelle
            // 
            this.btnStokGuncelle.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnStokGuncelle.Location = new System.Drawing.Point(1635, 937);
            this.btnStokGuncelle.Name = "btnStokGuncelle";
            this.btnStokGuncelle.Size = new System.Drawing.Size(293, 131);
            this.btnStokGuncelle.TabIndex = 5;
            this.btnStokGuncelle.Text = "İlaç Stok Güncelle";
            this.btnStokGuncelle.UseVisualStyleBackColor = false;
            this.btnStokGuncelle.Click += new System.EventHandler(this.btnStokGuncelle_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Crimson;
            this.btnCikis.Location = new System.Drawing.Point(1137, 1145);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(171, 56);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(2196, 1377);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnStokGuncelle);
            this.Controls.Add(this.btnReceteDetay);
            this.Controls.Add(this.btnKritikStok);
            this.Controls.Add(this.btnHastaReceteleri);
            this.Controls.Add(this.btnHastalar);
            this.Controls.Add(this.lblMenuBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1300, 1000);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuBaslik;
        private System.Windows.Forms.Button btnHastalar;
        private System.Windows.Forms.Button btnHastaReceteleri;
        private System.Windows.Forms.Button btnKritikStok;
        private System.Windows.Forms.Button btnReceteDetay;
        private System.Windows.Forms.Button btnStokGuncelle;
        private System.Windows.Forms.Button btnCikis;
    }
}