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
    public partial class mudur_indirim : Form
    {
        public mudur_indirim()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mudur mudurekran = new mudur();
            mudurekran.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
