namespace EczaneTakipApp
{
    partial class FrmAnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBaglantiTest = new System.Windows.Forms.Button();
            this.dgvVeriler = new System.Windows.Forms.DataGridView();
            this.btnKritikStok = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeriler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBaglantiTest
            // 
            this.btnBaglantiTest.Location = new System.Drawing.Point(979, 12);
            this.btnBaglantiTest.Name = "btnBaglantiTest";
            this.btnBaglantiTest.Size = new System.Drawing.Size(134, 82);
            this.btnBaglantiTest.TabIndex = 0;
            this.btnBaglantiTest.Text = "Bağlantıyı Test Et";
            this.btnBaglantiTest.UseVisualStyleBackColor = true;
            this.btnBaglantiTest.Click += new System.EventHandler(this.btnBaglantiTest_Click);
            // 
            // dgvVeriler
            // 
            this.dgvVeriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeriler.Location = new System.Drawing.Point(56, 162);
            this.dgvVeriler.Name = "dgvVeriler";
            this.dgvVeriler.RowHeadersWidth = 102;
            this.dgvVeriler.RowTemplate.Height = 40;
            this.dgvVeriler.Size = new System.Drawing.Size(955, 510);
            this.dgvVeriler.TabIndex = 1;
            // 
            // btnKritikStok
            // 
            this.btnKritikStok.Location = new System.Drawing.Point(56, 35);
            this.btnKritikStok.Name = "btnKritikStok";
            this.btnKritikStok.Size = new System.Drawing.Size(238, 111);
            this.btnKritikStok.TabIndex = 2;
            this.btnKritikStok.Text = "Kritik Stoktaki İlaçları Listele";
            this.btnKritikStok.UseVisualStyleBackColor = true;
            this.btnKritikStok.Click += new System.EventHandler(this.btnKritikStok_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 111);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kritik Stoktaki İlaçları Listele";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2007, 1418);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnKritikStok);
            this.Controls.Add(this.dgvVeriler);
            this.Controls.Add(this.btnBaglantiTest);
            this.Name = "FrmAnaSayfa";
            this.Text = "Eczane Reçete ve Stok Takip Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeriler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBaglantiTest;
        private System.Windows.Forms.DataGridView dgvVeriler;
        private System.Windows.Forms.Button btnKritikStok;
        private System.Windows.Forms.Button button1;
    }
}

