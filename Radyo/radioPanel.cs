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
    public partial class radioPanel : UserControl
    {
        private Image Logo;
        private string _isim;
        private string _frekans;  // _Frekans tanımlandı
        private string _tur;      // _Tur tanımlandı

        public radioPanel()
        {
            InitializeComponent();
        }

        private void radioPanel_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Coral;
        }

        private void radioPanel_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.IndianRed;
        }

        [Category("Radyo Panel Özellikleri")]
        public Image _logo
        {
            get { return Logo; }
            set
            {
                Logo = value;
                pictureLogo.Image = value;
            }
        }

        [Category("Radyo Panel Özellikleri")]
        public string Isim
        {
            get { return _isim; }
            set
            {
                _isim = value;
                lblRadioİsim.Text = value;
            }
        }

        [Category("Radyo Panel Özellikleri")]
        public string Frekans
        {
            get { return _frekans; }   // Doğru değişken ismi
            set
            {
                _frekans = value;
                lblFrekans.Text = value;
            }
        }

        [Category("Radyo Panel Özellikleri")]
        public string Tur
        {
            get { return _tur; }  // Doğru değişken ismi
            set
            {
                _tur = value;
                lblTur.Text = value;
            }
        }
    }
}
