using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvrenKutuphanesi.Kullanicilar
{
    public partial class KullaniciEkleForm : Form
    {
        public KullaniciEkleForm()
        {
            InitializeComponent();
        }
        EvrenKutuphanesiEntities tt = new EvrenKutuphanesiEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            Kullanicilar kullanicilar = new Kullanicilar();
            kullanicilar.kullanici_ad = adtxt.Text;
            kullanicilar.kullanici_soyad= soyadtxt.Text;
            kullanicilar.kullanici_tc = tctxt.Text;
            kullanicilar.kullanici_mail = mailtxt.Text;
            kullanicilar.kullanici_tel = teltxt.Text;
            kullanicilar.kullanici_ceza = Convert.ToDouble(cezatxt.Text);
            if(radioE.Checked == true)
            {
                kullanicilar.kullanici_cinsiyet = "E";
            }
            else if(radioK.Checked == true)
            {
                kullanicilar.kullanici_cinsiyet = "K";
            }
            tt.Kullanicilar.Add(kullanicilar);
            tt.SaveChanges();
            Listele();   
        }

        public void Listele()
        {
          
            var kullanicilar = tt.Kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
        }

        private void KullaniciEkleForm_Load(object sender, EventArgs e)
        {
                Listele();
        }
        
    }
}
