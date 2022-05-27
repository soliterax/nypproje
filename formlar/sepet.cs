using System;
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
    public partial class sepet : Form
    {
        public sepet()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (LoginControl.typeOku())
            {
                case LoginControl.LoginType.Admin:
                    mudur m = new mudur();
                    m.Visible = true;
                    m.Show();
                    this.Hide();
                    GC.Collect();
                    break;
                case LoginControl.LoginType.Moderator:
                    yardimci y = new yardimci();
                    y.Visible = true;
                    y.Show();
                    this.Hide();
                    GC.Collect();
                    break;
                case LoginControl.LoginType.Worker:
                    giris g = new giris();
                    g.Visible = true;
                    g.Show();
                    this.Hide();
                    GC.Collect();
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
