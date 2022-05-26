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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 geri2 = new Form2();      // geri butonu
            geri2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (LoginControl.typeOku() == LoginControl.LoginType.Admin)     //mudur isci ekleme (kaydetme butonu) 
            {
                Form2 kaydet = new Form2();
                kaydet.Show();
                this.Hide();  // veri tabanı kodları
            }
            else
            {
                Form6 kaydet = new Form6(); //hata kodları (orn. telefon numarası eksik girilirse vb....)
                kaydet.Show();
                this.Hide(); 
            }
        }
    }
}
