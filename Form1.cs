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
    public partial class Form1 : Form
    {
        public Form1()
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
            if (textBox1.Text == "admin" && textBox2.Text == "admin123")
            {
                Form2 mudur = new Form2();
                mudur.Show();
                this.Hide();
                LoginControl.typeYaz(LoginControl.LoginType.Admin);
            }
            else if (textBox1.Text == "sideadmin" && textBox2.Text == "456456")
            {
                Form5 yardimci = new Form5();
                yardimci.Show();
                this.Hide();
                LoginControl.typeYaz(LoginControl.LoginType.Moderator);
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
