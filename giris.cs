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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "a" && textBox2.Text == "1")
            {
                mudur mudur = new mudur();
                mudur.Visible = true;
                mudur.Show();
                this.Hide();
                LoginControl.typeYaz(LoginControl.LoginType.Admin);
                GC.Collect();
            }
            else if (textBox1.Text == "y" && textBox2.Text == "1")
            {
                yardimci yardimci = new yardimci();
                yardimci.Visible = true;
                yardimci.Show();
                this.Hide();
                LoginControl.typeYaz(LoginControl.LoginType.Moderator);
                GC.Collect();
            }
            else if (textBox1.Text=="i" && textBox2.Text=="1")
            {
                sepet sepet = new sepet();
                sepet.Visible = true;
                sepet.Show();
                this.Hide();
                GC.Collect();
            }
            else 
            {
                MessageBox.Show("Yanlış kullanıcı adı veya parola... " +
                    "Yeniden deneyiniz!");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
