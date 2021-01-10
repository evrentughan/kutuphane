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
    public partial class KaynakEkleForm : Form
    {
        public KaynakEkleForm()
        {
            InitializeComponent();
        }

        EvrenKutuphanesiEntities tt = new EvrenKutuphanesiEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            Kaynaklar kaynaklar = new Kaynaklar();
            kaynaklar.kaynaklar_ad = kaynakAdtxt.Text;
            kaynaklar.kaynak_yazar = kaynakYazartxt.Text;
            kaynaklar.kaynak_yayinci = kaynakYayincitxt.Text;
            kaynaklar.kaynak_sayfasayisi = Convert.ToInt16(numericUpDown1.Value);
            kaynaklar.kaynak_basimtarihi = dateTimePicker1.Value;
            tt.Kaynaklar.Add(kaynaklar);
            tt.SaveChanges();

            var kliste = tt.Kaynaklar.ToList();
            dataGridView1.DataSource = kliste.ToList();
        }
    }
}
