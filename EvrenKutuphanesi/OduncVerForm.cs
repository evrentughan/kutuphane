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
    public partial class OduncVerForm : Form
    {
        public OduncVerForm()
        {
            InitializeComponent();
        }

        EvrenKutuphanesiEntities tt = new EvrenKutuphanesiEntities();

        private void OduncVerForm_Load(object sender, EventArgs e)
        {
            var kayitList = tt.Kitaplar.ToList();
            dataGridView1.DataSource = kayitList.ToList();

            var kaynakList = tt.Kaynaklar.ToList();
            dataGridView2.DataSource = kaynakList.ToList();

            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string arananSecilen = tcBultxt.Text;
            var kullaniciVarMi = tt.Kullanicilar.Where(x => x.kullanici_tc == arananSecilen).FirstOrDefault();

            if (kullaniciVarMi != null)
            {
                label2.Text = kullaniciVarMi.kullanici_ad + " " + kullaniciVarMi.kullanici_soyad;
            }
            else
            {
                label2.Text = "Böyle bir kullanıcı yok";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string gelenAd = textBox1.Text;
            var bulunanKaynkalar = tt.Kaynaklar.Where(x => x.kaynaklar_ad.Contains(gelenAd)).ToList();
            dataGridView2.DataSource = bulunanKaynkalar;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string secilenKisiTc = tcBultxt.Text;
            var secilenKisi = tt.Kullanicilar.Where(x => x.kullanici_tc.Equals(secilenKisiTc)).FirstOrDefault();

            int secilenKitapId =Convert.ToInt16(dataGridView2.CurrentRow.Cells[0].Value);
            var secilenKitap = tt.Kaynaklar.Where(x => x.kaynaklar_id == secilenKitapId).FirstOrDefault();

            Kitaplar yeniKayit = new Kitaplar();
            yeniKayit.kitap_id = secilenKitap.kaynaklar_id;
            yeniKayit.kullanici_id = secilenKisi.kullanici_id;
            yeniKayit.alis_tarih = DateTime.Today;
            yeniKayit.durum = false;
            yeniKayit.son_tarih = DateTime.Today.AddDays(15);
            tt.Kitaplar.Add(yeniKayit);
            tt.SaveChanges();

            var kayitList = tt.Kitaplar.ToList();
            dataGridView1.DataSource = kayitList.ToList();
        }
    }
}
 