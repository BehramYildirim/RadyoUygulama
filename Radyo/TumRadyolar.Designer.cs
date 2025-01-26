namespace Radyo
{
    partial class TumRadyolar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TumRadyolar));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioPanel1 = new Radyo.radioPanel();
            this.radioPanel2 = new Radyo.radioPanel();
            this.radioPanel3 = new Radyo.radioPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.radioPanel1);
            this.flowLayoutPanel1.Controls.Add(this.radioPanel2);
            this.flowLayoutPanel1.Controls.Add(this.radioPanel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(361, 422);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // radioPanel1
            // 
            this.radioPanel1._logo = ((System.Drawing.Image)(resources.GetObject("radioPanel1._logo")));
            this.radioPanel1.BackColor = System.Drawing.Color.IndianRed;
            this.radioPanel1.Frekans = "98.2";
            this.radioPanel1.Isim = "KralPop";
            this.radioPanel1.Location = new System.Drawing.Point(3, 3);
            this.radioPanel1.Name = "radioPanel1";
            this.radioPanel1.Size = new System.Drawing.Size(353, 123);
            this.radioPanel1.TabIndex = 3;
            this.radioPanel1.Tur = "Türkce";
            // 
            // radioPanel2
            // 
            this.radioPanel2._logo = ((System.Drawing.Image)(resources.GetObject("radioPanel2._logo")));
            this.radioPanel2.BackColor = System.Drawing.Color.IndianRed;
            this.radioPanel2.Frekans = null;
            this.radioPanel2.Isim = "Joy Türk";
            this.radioPanel2.Location = new System.Drawing.Point(3, 132);
            this.radioPanel2.Name = "radioPanel2";
            this.radioPanel2.Size = new System.Drawing.Size(353, 123);
            this.radioPanel2.TabIndex = 4;
            this.radioPanel2.Tur = "Türkce";
            // 
            // radioPanel3
            // 
            this.radioPanel3._logo = null;
            this.radioPanel3.BackColor = System.Drawing.Color.IndianRed;
            this.radioPanel3.Frekans = "SALLADIM";
            this.radioPanel3.Isim = "ROCK";
            this.radioPanel3.Location = new System.Drawing.Point(3, 261);
            this.radioPanel3.Name = "radioPanel3";
            this.radioPanel3.Size = new System.Drawing.Size(353, 123);
            this.radioPanel3.TabIndex = 5;
            this.radioPanel3.Tur = "Türkce";
            // 
            // TumRadyolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "TumRadyolar";
            this.Size = new System.Drawing.Size(361, 422);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private radioPanel radioPanel1;
        private radioPanel radioPanel2;
        private radioPanel radioPanel3;
    }
}
