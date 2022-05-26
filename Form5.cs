using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nypproje
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 urunekle = new Form4();
            urunekle.Show();
            this.Hide(); 
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 isci = new Form6();
            isci.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 urunduzenle = new Form4();       // mudur yardımcı (urun degistirme)  veri tabanından veri getirme komutları 
            urunduzenle.Show();
            this.Hide();
        }
    }
}
