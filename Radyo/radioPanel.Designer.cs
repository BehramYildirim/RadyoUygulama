namespace Radyo
{
    partial class radioPanel
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(radioPanel));
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.lblRadioİsim = new System.Windows.Forms.Label();
            this.lblFrekans = new System.Windows.Forms.Label();
            this.lblTur = new System.Windows.Forms.Label();
            this.btnFavori = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureLogo
            // 
            this.pictureLogo.Location = new System.Drawing.Point(10, 10);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(100, 100);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // lblRadioİsim
            // 
            this.lblRadioİsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRadioİsim.ForeColor = System.Drawing.Color.White;
            this.lblRadioİsim.Location = new System.Drawing.Point(116, 18);
            this.lblRadioİsim.Name = "lblRadioİsim";
            this.lblRadioİsim.Size = new System.Drawing.Size(224, 23);
            this.lblRadioİsim.TabIndex = 1;
            this.lblRadioİsim.Text = "Radyo isimi";
            // 
            // lblFrekans
            // 
            this.lblFrekans.AutoSize = true;
            this.lblFrekans.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFrekans.ForeColor = System.Drawing.Color.White;
            this.lblFrekans.Location = new System.Drawing.Point(239, 84);
            this.lblFrekans.Name = "lblFrekans";
            this.lblFrekans.Size = new System.Drawing.Size(64, 20);
            this.lblFrekans.TabIndex = 2;
            this.lblFrekans.Text = "100.0";
            // 
            // lblTur
            // 
            this.lblTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTur.Location = new System.Drawing.Point(118, 53);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(150, 23);
            this.lblTur.TabIndex = 3;
            this.lblTur.Text = "Şarkı Türü";
            // 
            // btnFavori
            // 
            this.btnFavori.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFavori.BackgroundImage")));
            this.btnFavori.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFavori.FlatAppearance.BorderSize = 0;
            this.btnFavori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavori.Location = new System.Drawing.Point(123, 79);
            this.btnFavori.Name = "btnFavori";
            this.btnFavori.Size = new System.Drawing.Size(37, 31);
            this.btnFavori.TabIndex = 4;
            this.btnFavori.UseVisualStyleBackColor = true;
            // 
            // radioPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.Controls.Add(this.btnFavori);
            this.Controls.Add(this.lblTur);
            this.Controls.Add(this.lblFrekans);
            this.Controls.Add(this.lblRadioİsim);
            this.Controls.Add(this.pictureLogo);
            this.Name = "radioPanel";
            this.Size = new System.Drawing.Size(353, 123);
            this.MouseLeave += new System.EventHandler(this.radioPanel_MouseLeave);
            this.MouseHover += new System.EventHandler(this.radioPanel_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label lblRadioİsim;
        private System.Windows.Forms.Label lblFrekans;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.Button btnFavori;
    }
}
