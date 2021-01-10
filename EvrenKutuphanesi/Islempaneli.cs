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
    public partial class Islempaneli : Form
    {
        EvrenKutuphanesiEntities tt = new EvrenKutuphanesiEntities();
        public Islempaneli()
        {
            InitializeComponent();
        }
        private void Islempaneli_Load(object sender, EventArgs e)
        {
            ekleBtn.Visible = false;
            silBtn.Visible = false;
            gncBtn.Visible = false;

            ekleKaynakbtn.Visible = false;
            silKaynakBtn.Visible = false;
            gncKaynakBtn.Visible = false;
        }

        private void kullaniciBtn_Click(object sender, EventArgs e)
        {
            if (ekleBtn.Visible == false)
            {
                ekleBtn.Visible = true;
                silBtn.Visible = true;
                gncBtn.Visible = true;
            }
            else
            {
                ekleBtn.Visible = false;
                silBtn.Visible = false;
                gncBtn.Visible = false;
            }

            KullaniciListeForm klisteForm = new KullaniciListeForm();
            klisteForm.MdiParent = this;
            klisteForm.Show(); 


            
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            KullaniciEkleForm ekleForm = new KullaniciEkleForm();
            ekleForm.MdiParent = this;
            ekleForm.Show();
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            KullaniciSilForm ksilForm = new KullaniciSilForm();
            ksilForm.MdiParent = this;
            ksilForm.Show();
        }

        private void gncBtn_Click(object sender, EventArgs e)
        {
            KullaniciGuncelleForm kgncForm = new KullaniciGuncelleForm();
            kgncForm.MdiParent = this;
            kgncForm.Show();
        }

        private void KaynakBtn_Click(object sender, EventArgs e)
        {
            if(ekleKaynakbtn.Visible==false)
            {
                ekleKaynakbtn.Visible = true;
                silKaynakBtn.Visible = true;
                gncKaynakBtn.Visible = true;
            }
            else
            {
                ekleKaynakbtn.Visible = false;
                silKaynakBtn.Visible = false;
                gncKaynakBtn.Visible = false;
            }
            KaynakListeForm kliste = new KaynakListeForm();
            kliste.MdiParent = this;
            kliste.Show();
        }

        private void ekleKaynakbtn_Click(object sender, EventArgs e)
        {
            KaynakEkleForm kEkle = new KaynakEkleForm();
            kEkle.MdiParent = this;
            kEkle.Show();
        }

        private void silKaynakBtn_Click(object sender, EventArgs e)
        {
            KaynakSilForm ksil = new KaynakSilForm();
            ksil.MdiParent = this;
            ksil.Show();
        }

        private void gncKaynakBtn_Click(object sender, EventArgs e)
        {
            KaynakGuncelleForm kGuncel = new KaynakGuncelleForm();
            kGuncel.MdiParent = this;
            kGuncel.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OduncVerForm kOdunc = new OduncVerForm();
            kOdunc.MdiParent = this;
            kOdunc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GeriAlForm geri = new GeriAlForm();
            geri.MdiParent = this;
            geri.Show();
        }
    }
}
