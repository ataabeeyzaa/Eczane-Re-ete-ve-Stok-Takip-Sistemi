namespace EczaneTakipApp
{
    partial class FrmHastaReceteleri
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
            this.txtHastaId = new System.Windows.Forms.TextBox();
            this.btnGetir = new System.Windows.Forms.Button();
            this.dgvReceteler = new System.Windows.Forms.DataGridView();
            this.btnKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceteler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(341, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta ID:";
            // 
            // txtHastaId
            // 
            this.txtHastaId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHastaId.Location = new System.Drawing.Point(411, 45);
            this.txtHastaId.Name = "txtHastaId";
            this.txtHastaId.Size = new System.Drawing.Size(322, 38);
            this.txtHastaId.TabIndex = 1;
            // 
            // btnGetir
            // 
            this.btnGetir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGetir.Location = new System.Drawing.Point(602, 35);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(224, 56);
            this.btnGetir.TabIndex = 2;
            this.btnGetir.Text = "Reçeteleri Getir";
            this.btnGetir.UseVisualStyleBackColor = false;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // dgvReceteler
            // 
            this.dgvReceteler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReceteler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceteler.Location = new System.Drawing.Point(88, 112);
            this.dgvReceteler.Name = "dgvReceteler";
            this.dgvReceteler.RowHeadersWidth = 102;
            this.dgvReceteler.RowTemplate.Height = 40;
            this.dgvReceteler.Size = new System.Drawing.Size(1673, 940);
            this.dgvReceteler.TabIndex = 3;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.BackColor = System.Drawing.Color.Crimson;
            this.btnKapat.Location = new System.Drawing.Point(1584, 45);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(142, 50);
            this.btnKapat.TabIndex = 4;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // FrmHastaReceteleri
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1844, 1088);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.dgvReceteler);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.txtHastaId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmHastaReceteleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHastaReceteleri";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceteler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHastaId;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.DataGridView dgvReceteler;
        private System.Windows.Forms.Button btnKapat;
    }
}