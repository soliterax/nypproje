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
    public partial class mudur : Form
    {
        public mudur()
        {
            InitializeComponent();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            urun_ekle urunekle = new urun_ekle();
            urunekle.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sepet sepet = new sepet();
            sepet.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            isci_ekle isci_Ekle = new isci_ekle();
            isci_Ekle.Show();
            this.Hide();
        }
    }
}
