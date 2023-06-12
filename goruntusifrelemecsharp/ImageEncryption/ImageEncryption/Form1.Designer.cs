
namespace ImageEncryption
{
    partial class Form1
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
            this.pbOriginal = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.pbEncrypted = new System.Windows.Forms.PictureBox();
            this.pbDecrypted = new System.Windows.Forms.PictureBox();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEncrypted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDecrypted)).BeginInit();
            this.SuspendLayout();
            // 
            // pbOriginal
            // 
            this.pbOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbOriginal.Location = new System.Drawing.Point(102, 120);
            this.pbOriginal.Name = "pbOriginal";
            this.pbOriginal.Size = new System.Drawing.Size(304, 295);
            this.pbOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbOriginal.TabIndex = 0;
            this.pbOriginal.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Orange;
            this.btnOpen.Location = new System.Drawing.Point(257, 525);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(167, 51);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Resmi Aç";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.Orange;
            this.btnEncrypt.Location = new System.Drawing.Point(440, 525);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(167, 51);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Şifrele";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.Orange;
            this.btnDecrypt.Location = new System.Drawing.Point(805, 525);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(167, 51);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "Şifre Çöz";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // pbEncrypted
            // 
            this.pbEncrypted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbEncrypted.Location = new System.Drawing.Point(439, 120);
            this.pbEncrypted.Name = "pbEncrypted";
            this.pbEncrypted.Size = new System.Drawing.Size(310, 295);
            this.pbEncrypted.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbEncrypted.TabIndex = 4;
            this.pbEncrypted.TabStop = false;
            // 
            // pbDecrypted
            // 
            this.pbDecrypted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDecrypted.Location = new System.Drawing.Point(769, 120);
            this.pbDecrypted.Name = "pbDecrypted";
            this.pbDecrypted.Size = new System.Drawing.Size(319, 295);
            this.pbDecrypted.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbDecrypted.TabIndex = 5;
            this.pbDecrypted.TabStop = false;
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(293, 43);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(236, 22);
            this.tbKey.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Orange;
            this.btnSave.Location = new System.Drawing.Point(622, 525);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(167, 51);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Resmi Kaydet";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(99, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Şifrelenecek resime isim ver:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(208, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Orjinal Resim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(537, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Şifrelenmiş Resim";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(860, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Şifresi Çözülmüş Resim";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1193, 615);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.pbDecrypted);
            this.Controls.Add(this.pbEncrypted);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.pbOriginal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEncrypted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDecrypted)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbOriginal;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.PictureBox pbEncrypted;
        private System.Windows.Forms.PictureBox pbDecrypted;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

