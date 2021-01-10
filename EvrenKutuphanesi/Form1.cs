using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvrenKutuphanesi
{
    public partial class Form1 : Form
    {
        EvrenKutuphanesiEntities tt = new EvrenKutuphanesiEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void PersonelGirisBtn_Click(object sender, EventArgs e)
        {
            string gelenAd = AdGiristxt.Text;
            string gelenSifre = SifreGiristxt.Text;

            var personel = tt.Personeller.Where(x=>x.personel_ad.Equals(gelenAd) && x.personel_Sifre.Equals(gelenSifre)).FirstOrDefault();
            

            if (personel == null)
            {
                MessageBox.Show("Kulanıcı adı veya şifre hatalı");
            }

            else
            {
                MessageBox.Show("Başarılı");
                Islempaneli panel = new Islempaneli();
                panel.Show();
                this.Hide();
            }
        }
    }
}
