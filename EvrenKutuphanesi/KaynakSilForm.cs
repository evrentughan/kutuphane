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
    public partial class KaynakSilForm : Form
    {
        public KaynakSilForm()
        {
            InitializeComponent();
        }
        EvrenKutuphanesiEntities tt = new EvrenKutuphanesiEntities();
        private void KaynakSilForm_Load(object sender, EventArgs e)
        {
            var kaynaklar = tt.Kaynaklar.ToList();
            dataGridView1.DataSource = kaynaklar.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var silinenKaynak = tt.Kaynaklar.Where(x => x.kaynaklar_id == secilenId).FirstOrDefault();
            tt.Kaynaklar.Remove(silinenKaynak);
            tt.SaveChanges();
            var kaynaklar = tt.Kaynaklar.ToList();
            dataGridView1.DataSource = kaynaklar.ToList();

        }
    }
}
