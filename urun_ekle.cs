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
    public partial class urun_ekle : Form
    {
        SoliteraxConnection connection = new SoliteraxConnection(SoliteraxConnection.ConnectionType.SQL);
        ConnectSQL sql;
        SqlCommand komut;
        public urun_ekle()
        {
            InitializeComponent();
        }

        void urungetir() {
            connection.Connect("Data Source=DESKTOP-1PTCR12\\SQLEXPRESS;Initial Catalog=NYP_PROJE;Persist Security Info=True;User ID=metin;Password=23262326");
            sql = ((ConnectSQL)connection.GetConnection());
            sql.Connect();
            DataTable data = sql.GetManager().GetData("select * from urunler");
            dataGridView1.DataSource = data;
            sql.DisConnect();
        }
        private void urun_ekle_Load(object sender, EventArgs e)
        {
            urungetir();

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            string sorgu = "INSERT INTO urunler(kategori,urun_ad,urun_miktar,urun_ucret) VALUES (@kategori,@urun_ad,@urun_miktar,@urun_ucret)";
            sql = ((ConnectSQL)connection.GetConnection());
            sql.Connect();
            komut.Parameters.AddWithValue("@kategori", txtkategori.Text);
            komut.Parameters.AddWithValue("@urun_ad", txtad.Text);
            komut.Parameters.AddWithValue("@urun_miktar", txtmiktar.Text);
            komut.Parameters.AddWithValue("@urun_ucret", txtucret.Text);
            komut.CommandText = sorgu;
            sql.GetManager().SendData(komut);
            sql.DisConnect();
            komut = null;
            GC.Collect();
            urungetir();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM urunler Where urun_ad=@urun_ad";

            komut = new SqlCommand();
            sql.Connect();

            komut.Parameters.AddWithValue("@kategori", txtkategori.Text);
            komut.Parameters.AddWithValue("@urun_ad", txtad.Text);
            komut.Parameters.AddWithValue("@urun_miktar", txtmiktar.Text);
            komut.Parameters.AddWithValue("@urun_ucret", txtucret.Text);
            komut.CommandText = sorgu;
            sql.GetManager().SendData(komut);
            sql.DisConnect();
            komut = null;
            urungetir();
            GC.Collect();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtkategori.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtmiktar.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtucret.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch(LoginControl.typeOku())
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
                default:
                    throw new ArgumentException();
            }
            
        }
    }
}
