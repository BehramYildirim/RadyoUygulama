using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radyo
{
    public partial class Form1 : Form
    {
        private int formKoor,formKoorX,formKoorY; //1
        private int panelMenuGenislik;
        private bool panelMenuGizli;
        public Form1()
        {
            InitializeComponent();
            panelMenuGenislik = panelMenu.Width;
            panelMenuGizli = false;
        }
        private void lblAcKapat_Click(object sender, EventArgs e)
        {
            timerMenu.Start();  
        }


        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenuGizli)
            {
                lblRadio.Width = lblRadio.Width + 3;
                lblRadio.Visible = true;
                Favori.Width = Favori.Width + 3;
                Favori.Visible = true;
                lblAyar.Width = lblAyar.Width + 3;
                lblAyar.Visible = true;
                panelMenu.Width = panelMenu.Width + 10;
                lblAcKapat.Text = "<";
                lblRadio.Text = "RADYOLAR";
                Favori.Text = "FAVORİLER";
                lblAyar.Text = "AYARLAR";
                if (panelMenu.Width >= panelMenuGenislik)
                {
                    timerMenu.Stop();   
                    panelMenuGizli = false; 
                    this.Refresh();
                }
            }
            else
            {
                lblRadio.Width =lblRadio.Width - 3;
                lblRadio.Visible = false;
                Favori.Width = Favori.Width - 3;
                Favori.Visible = false;
                lblAyar.Width = lblAyar.Width - 3;
                lblAyar.Visible = false;
                panelMenu.Width = panelMenu.Width - 10;
                    lblAcKapat.Text = ">";
                    lblRadio.Text = "";
                    Favori.Text = "";
                    lblAyar.Text = "";
                    if (panelMenu.Width <= 65)
                    {
                        timerMenu.Stop();
                        panelMenuGizli = true;
                        this.Refresh();
                }
            }
        }

        private void PanelUst_MouseDown(object sender, MouseEventArgs e)
        {
            formKoor = 1; formKoorX =e.X; formKoorY =e.Y;
        }

        private void PanelUst_MouseMove(object sender, MouseEventArgs e)
        {
            if (formKoor ==1)
            {
              this.SetDesktopLocation(MousePosition.X - formKoorX, MousePosition.Y - formKoorY);
            }
        }

        private void lblAcKapat_MouseHover(object sender, EventArgs e)
        {
            lblAcKapat.ForeColor = Color.Red;
        }

        private void lblAcKapat_MouseLeave(object sender, EventArgs e)
        {
            lblAcKapat.ForeColor= Color.White;    
        }

        private void lblRadio_MouseHover(object sender, EventArgs e)
        {
           lblRadio.ForeColor = Color.Red;
        }

        private void lblRadio_MouseLeave(object sender, EventArgs e)
        {
            lblRadio.ForeColor = Color.White;
        }

        private void Favori_MouseHover(object sender, EventArgs e)
        {
            Favori.ForeColor = Color.Red;
        }

        private void Favori_MouseLeave(object sender, EventArgs e)
        {
            Favori.ForeColor = Color.White;
        }

        private void lblAyar_MouseHover(object sender, EventArgs e)
        {
            lblAyar.ForeColor = Color.Red;
        }

        private void lblAyar_MouseLeave(object sender, EventArgs e)
        {
          lblAyar.ForeColor = Color.White;
        }

        private void radioPanelBest_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"http://kralpopwmp.radyotvonline.com/";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void radioPanel2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"https://playerservices.streamtheworld.com/api/livestream-redirect/JOY_TURK_SC?/;";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void radioPanel3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"https://playerservices.streamtheworld.com/api/livestream-redirect/JOYTURK_ROCK_SC?/";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void radioPanel4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"https://stream.guventechnology.com:2020/stream/ulusalradyorock";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void lblRadio_Click(object sender, EventArgs e)
        {
           flowLayoutOrta.Visible = true;
        }

        private void PanelUst_MouseUp(object sender, MouseEventArgs e)
        {
            formKoor = 0;
        }

        private void lblKapat_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0); 
        }
    }
}
