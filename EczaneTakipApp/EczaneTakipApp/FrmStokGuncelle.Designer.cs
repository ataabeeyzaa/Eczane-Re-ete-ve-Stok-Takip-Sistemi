namespace EczaneTakipApp
{
    partial class FrmStokGuncelle
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
            this.txtIlacId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYeniStok = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(865, 621);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlaç ID:";
            // 
            // txtIlacId
            // 
            this.txtIlacId.Location = new System.Drawing.Point(1052, 621);
            this.txtIlacId.Name = "txtIlacId";
            this.txtIlacId.Size = new System.Drawing.Size(268, 38);
            this.txtIlacId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(826, 708);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yeni Stok:";
            // 
            // txtYeniStok
            // 
            this.txtYeniStok.Location = new System.Drawing.Point(1052, 710);
            this.txtYeniStok.Name = "txtYeniStok";
            this.txtYeniStok.Size = new System.Drawing.Size(268, 38);
            this.txtYeniStok.TabIndex = 3;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGuncelle.Location = new System.Drawing.Point(1465, 627);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(226, 122);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Stok Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Crimson;
            this.btnKapat.Location = new System.Drawing.Point(2049, 898);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(138, 62);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // FrmStokGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(2275, 1308);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtYeniStok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIlacId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FrmStokGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStokGuncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIlacId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYeniStok;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKapat;
    }
}