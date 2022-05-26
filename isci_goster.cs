using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SoliteraxLibrary;
using SoliteraxLibrary.SQLSystem;

namespace nypproje
{
    public partial class isci_goster : Form
    {
        SoliteraxConnection connection = new SoliteraxConnection(SoliteraxConnection.ConnectionType.SQL);
        ConnectSQL sql;
        SqlCommand komut;
        public isci_goster()
        {
            InitializeComponent();
        }
        void iscigetir(){
            connection.Connect("Data Source=DESKTOP-1PTCR12\\SQLEXPRESS;Initial Catalog=NYP_PROJE;Persist Security Info=True;User ID=metin;Password=23262326");
            sql = ((ConnectSQL)connection.GetConnection());
            sql.Connect();
            DataTable data = sql.GetManager().GetData("select * from isciler");
            dataGridView1.DataSource = data;
            sql.DisConnect();
        }
        private void isci_goster_Load(object sender, EventArgs e)
        {
            iscigetir();
        }

        private void button4_Click(object sender, EventArgs e) //geri
        {
            yardimci y = new yardimci();
            y.Visible = true;
            y.Show();
            this.Hide();
            GC.Collect();
        }
    }
}
