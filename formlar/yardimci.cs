﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nypproje.formlar
{
    public partial class yardimci : Form
    {
        public yardimci()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) //isciler
        {
            isci_goster isci = new isci_goster();
            isci.Visible = true;
            isci.Show();
            this.Hide();
            GC.Collect();
        }
        private void button5_Click(object sender, EventArgs e) //urun
        {
            urun_ekle urunekle = new urun_ekle();
            urunekle.Visible = true;
            urunekle.Show();
            this.Hide();
            GC.Collect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sepet s = new sepet();
            s.Visible = true;
            s.Show();
            this.Hide();
            GC.Collect();
        }
    }
}
