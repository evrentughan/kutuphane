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
    public partial class KaynakGuncelleForm : Form
    {
        public KaynakGuncelleForm()
        {
            InitializeComponent();
        }

        EvrenKutuphanesiEntities tt = new EvrenKutuphanesiEntities();

        private void KaynakGuncelleForm_Load(object sender, EventArgs e)
        {
            var kaynaklar = tt.Kaynaklar.ToList();
            dataGridView1.DataSource = kaynaklar.ToList();
        }
       
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            kaynakAdtxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            kaynakYazartxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            kaynakYayincitxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            numericUpDown1.Value =Convert.ToDecimal(dataGridView1.CurrentRow.Cells[4].Value);
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenKaynak = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var guncellenecekKaynak = tt.Kaynaklar.Where(x => x.kaynaklar_id == secilenKaynak).FirstOrDefault();
            guncellenecekKaynak.kaynaklar_ad = kaynakAdtxt.Text;
            guncellenecekKaynak.kaynak_yazar = kaynakYazartxt.Text;
            guncellenecekKaynak.kaynak_yayinci = kaynakYayincitxt.Text;
            guncellenecekKaynak.kaynak_sayfasayisi = Convert.ToInt16(numericUpDown1.Value);
            guncellenecekKaynak.kaynak_basimtarihi = dateTimePicker1.Value;
            tt.SaveChanges();
            var kaynaklar = tt.Kaynaklar.ToList();
            dataGridView1.DataSource = kaynaklar.ToList();


        }
    }
}
