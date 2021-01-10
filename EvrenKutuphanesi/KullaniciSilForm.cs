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
    public partial class KullaniciSilForm : Form
    {
        public KullaniciSilForm()
        {
            InitializeComponent();
        }

        EvrenKutuphanesiEntities tt = new EvrenKutuphanesiEntities();
        public void Listele()
        {
            var kullanicilar = tt.Kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
        }
        private void KullaniciSilForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var kullanici = tt.Kullanicilar.Where(x =>x.kullanici_id == secilenId).FirstOrDefault();
            tt.Kullanicilar.Remove(kullanici);
            tt.SaveChanges();
            Listele();
        }
    }
}
