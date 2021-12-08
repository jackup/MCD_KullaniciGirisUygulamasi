using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCD_KullaniciGirisUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kAdi = txtKullaniciAd.Text;
            string sifre = txtSifre.Text;

            Kullanici bulunanKullanici = VirtualDatabase.kTablo.Find(i => i.kullaniciAdi == kAdi && i.sifre == sifre);

            if (bulunanKullanici != null)
            {
                AnaForm anaForm = new AnaForm(bulunanKullanici);
            }
        }
    }
}
