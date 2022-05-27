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

namespace nypproje.formlar
{
    public partial class isci_goster : Form
    {
        SoliteraxConnection connection = new SoliteraxConnection(SoliteraxConnection.ConnectionType.Access);
        ConnectDatabase sql;
        SqlCommand komut;
        public isci_goster()
        {
            InitializeComponent();
        }
        void iscigetir(){
            connection.Connect("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\nypProjectDatabase.accdb");
            sql = ((ConnectDatabase)connection.GetConnection());
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
