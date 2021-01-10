﻿using System;
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
    public partial class KullaniciListeForm : Form
    {
        public KullaniciListeForm()
        {
            InitializeComponent();
        }

        public void Listele()
        {
            EvrenKutuphanesiEntities tt = new EvrenKutuphanesiEntities();
            var kullanicilar = tt.Kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
        }

        private void KullaniciListeForm_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
