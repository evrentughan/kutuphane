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
    public partial class GeriAlForm : Form
    {
        public GeriAlForm()
        {
            InitializeComponent();
        }

        EvrenKutuphanesiEntities tt = new EvrenKutuphanesiEntities();

        private void GeriAlForm_Load(object sender, EventArgs e)
        {
            var kayitlar = tt.Kitaplar.Where(x => x.durum == false).ToList();
            dataGridView1.DataSource = kayitlar.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenKayitId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var kayit = tt.Kitaplar.Where(x => x.kayit_id == secilenKayitId).FirstOrDefault();
            kayit.durum = true;
            tt.SaveChanges();
            var kayitlar = tt.Kitaplar.Where(x => x.durum == false).ToList();
            dataGridView1.DataSource = kayitlar.ToList();
            


        }
    }
}
