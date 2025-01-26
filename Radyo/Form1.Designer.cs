namespace Radyo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PanelUst = new System.Windows.Forms.Panel();
            this.lblKapat = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblAyar = new System.Windows.Forms.Label();
            this.Favori = new System.Windows.Forms.Label();
            this.lblRadio = new System.Windows.Forms.Label();
            this.lblAcKapat = new System.Windows.Forms.Label();
            this.flowLayoutOrta = new System.Windows.Forms.FlowLayoutPanel();
            this.radioPanel1 = new Radyo.radioPanel();
            this.radioPanel2 = new Radyo.radioPanel();
            this.radioPanel3 = new Radyo.radioPanel();
            this.radioPanel4 = new Radyo.radioPanel();
            this.timerMenu = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.PanelUst.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.flowLayoutOrta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelUst
            // 
            this.PanelUst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.PanelUst.Controls.Add(this.lblKapat);
            this.PanelUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelUst.Location = new System.Drawing.Point(0, 0);
            this.PanelUst.Name = "PanelUst";
            this.PanelUst.Size = new System.Drawing.Size(839, 31);
            this.PanelUst.TabIndex = 0;
            this.PanelUst.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelUst_MouseDown);
            this.PanelUst.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelUst_MouseMove);
            this.PanelUst.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelUst_MouseUp);
            // 
            // lblKapat
            // 
            this.lblKapat.AutoSize = true;
            this.lblKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKapat.ForeColor = System.Drawing.Color.White;
            this.lblKapat.Location = new System.Drawing.Point(806, 0);
            this.lblKapat.Name = "lblKapat";
            this.lblKapat.Size = new System.Drawing.Size(33, 32);
            this.lblKapat.TabIndex = 0;
            this.lblKapat.Text = "X";
            this.lblKapat.Click += new System.EventHandler(this.lblKapat_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Gray;
            this.panelMenu.Controls.Add(this.lblAyar);
            this.panelMenu.Controls.Add(this.Favori);
            this.panelMenu.Controls.Add(this.lblRadio);
            this.panelMenu.Controls.Add(this.lblAcKapat);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 31);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(223, 422);
            this.panelMenu.TabIndex = 1;
            // 
            // lblAyar
            // 
            this.lblAyar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAyar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAyar.ForeColor = System.Drawing.Color.White;
            this.lblAyar.Image = ((System.Drawing.Image)(resources.GetObject("lblAyar.Image")));
            this.lblAyar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAyar.Location = new System.Drawing.Point(12, 230);
            this.lblAyar.Name = "lblAyar";
            this.lblAyar.Size = new System.Drawing.Size(211, 60);
            this.lblAyar.TabIndex = 1;
            this.lblAyar.Text = "AYARLAR";
            this.lblAyar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAyar.MouseLeave += new System.EventHandler(this.lblAyar_MouseLeave);
            this.lblAyar.MouseHover += new System.EventHandler(this.lblAyar_MouseHover);
            // 
            // Favori
            // 
            this.Favori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Favori.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Favori.ForeColor = System.Drawing.Color.White;
            this.Favori.Image = ((System.Drawing.Image)(resources.GetObject("Favori.Image")));
            this.Favori.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Favori.Location = new System.Drawing.Point(7, 128);
            this.Favori.Name = "Favori";
            this.Favori.Size = new System.Drawing.Size(216, 60);
            this.Favori.TabIndex = 1;
            this.Favori.Text = "FAVORİLER";
            this.Favori.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Favori.MouseLeave += new System.EventHandler(this.Favori_MouseLeave);
            this.Favori.MouseHover += new System.EventHandler(this.Favori_MouseHover);
            // 
            // lblRadio
            // 
            this.lblRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRadio.ForeColor = System.Drawing.Color.White;
            this.lblRadio.Image = ((System.Drawing.Image)(resources.GetObject("lblRadio.Image")));
            this.lblRadio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRadio.Location = new System.Drawing.Point(7, 42);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(216, 60);
            this.lblRadio.TabIndex = 1;
            this.lblRadio.Text = "RADYOLAR";
            this.lblRadio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblRadio.Click += new System.EventHandler(this.lblRadio_Click);
            this.lblRadio.MouseLeave += new System.EventHandler(this.lblRadio_MouseLeave);
            this.lblRadio.MouseHover += new System.EventHandler(this.lblRadio_MouseHover);
            // 
            // lblAcKapat
            // 
            this.lblAcKapat.AutoSize = true;
            this.lblAcKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAcKapat.Location = new System.Drawing.Point(12, 3);
            this.lblAcKapat.Name = "lblAcKapat";
            this.lblAcKapat.Size = new System.Drawing.Size(40, 42);
            this.lblAcKapat.TabIndex = 0;
            this.lblAcKapat.Text = ">";
            this.lblAcKapat.Click += new System.EventHandler(this.lblAcKapat_Click);
            this.lblAcKapat.MouseLeave += new System.EventHandler(this.lblAcKapat_MouseLeave);
            this.lblAcKapat.MouseHover += new System.EventHandler(this.lblAcKapat_MouseHover);
            // 
            // flowLayoutOrta
            // 
            this.flowLayoutOrta.AutoScroll = true;
            this.flowLayoutOrta.BackColor = System.Drawing.Color.Coral;
            this.flowLayoutOrta.Controls.Add(this.radioPanel1);
            this.flowLayoutOrta.Controls.Add(this.radioPanel2);
            this.flowLayoutOrta.Controls.Add(this.radioPanel3);
            this.flowLayoutOrta.Controls.Add(this.radioPanel4);
            this.flowLayoutOrta.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutOrta.Location = new System.Drawing.Point(223, 31);
            this.flowLayoutOrta.Name = "flowLayoutOrta";
            this.flowLayoutOrta.Size = new System.Drawing.Size(361, 422);
            this.flowLayoutOrta.TabIndex = 2;
            this.flowLayoutOrta.Visible = false;
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
            this.radioPanel1.TabIndex = 0;
            this.radioPanel1.Tur = "Türkce";
            this.radioPanel1.Click += new System.EventHandler(this.radioPanelBest_Click);
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
            this.radioPanel2.TabIndex = 1;
            this.radioPanel2.Tur = "Türkce";
            this.radioPanel2.Click += new System.EventHandler(this.radioPanel2_Click);
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
            this.radioPanel3.TabIndex = 2;
            this.radioPanel3.Tur = "Türkce";
            this.radioPanel3.Click += new System.EventHandler(this.radioPanel3_Click);
            // 
            // radioPanel4
            // 
            this.radioPanel4._logo = null;
            this.radioPanel4.BackColor = System.Drawing.Color.IndianRed;
            this.radioPanel4.Frekans = "100.0";
            this.radioPanel4.Isim = "Çalmıyor";
            this.radioPanel4.Location = new System.Drawing.Point(3, 390);
            this.radioPanel4.Name = "radioPanel4";
            this.radioPanel4.Size = new System.Drawing.Size(353, 123);
            this.radioPanel4.TabIndex = 3;
            this.radioPanel4.Tur = "Rep";
            this.radioPanel4.Click += new System.EventHandler(this.radioPanel4_Click);
            // 
            // timerMenu
            // 
            this.timerMenu.Interval = 10;
            this.timerMenu.Tick += new System.EventHandler(this.timerMenu_Tick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(584, 31);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(255, 422);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(839, 453);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.flowLayoutOrta);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.PanelUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "FORM1";
            this.PanelUst.ResumeLayout(false);
            this.PanelUst.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.flowLayoutOrta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelUst;
        private System.Windows.Forms.Label lblKapat;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.Label lblAcKapat;
        private System.Windows.Forms.Label lblAyar;
        private System.Windows.Forms.Label Favori;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutOrta;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Timer timerMenu;
        private radioPanel radioPanel1;
        private radioPanel radioPanel2;
        private radioPanel radioPanel3;
        private radioPanel radioPanel4;
    }
}

