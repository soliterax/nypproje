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
    public partial class isci_ekle : Form
    {
        SoliteraxConnection connection = new SoliteraxConnection(SoliteraxConnection.ConnectionType.SQL);
        ConnectSQL sql;       
        SqlCommand komut;
        public isci_ekle()
        {
            InitializeComponent();
        }

        void iscigetir()
        {
            
            connection.Connect("Data Source=DESKTOP-1PTCR12\\SQLEXPRESS;Initial Catalog=NYP_PROJE;Persist Security Info=True;User ID=metin;Password=23262326");
            sql = ((ConnectSQL)connection.GetConnection());
            sql.Connect();
            DataTable data = sql.GetManager().GetData("select * from isciler");
            dataGridView1.DataSource = data;
            sql.DisConnect();
            
            /*
            baglanti = new SqlConnection("Data Source=DESKTOP-1PTCR12\\SQLEXPRESS;Initial Catalog=NYP_PROJE;Persist Security Info=True;User ID=metin;Password=23262326");
            baglanti.Open();
            da = new SqlDataAdapter("Select * From isciler", baglanti);
            DataTable ds = new DataTable();
            da.Fill(ds);
            dataGridView1.DataSource = ds;
            baglanti.Close();
            */

        }

        private void isci_ekle_Load(object sender, EventArgs e)
        {
            iscigetir();
        }
    

        private void button1_Click(object sender, EventArgs e)  //ekleme butonu
        {
            SqlCommand komut = new SqlCommand();
            string sorgu = "INSERT INTO isciler(ad,soyad,telefon,dogum_tarih) VALUES (@ad,@soyad,@telefon,@dogum_tarih)";
            sql = ((ConnectSQL)connection.GetConnection());
            sql.Connect();
            komut.Parameters.AddWithValue("@ad", txtad.Text);
            komut.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txttel.Text);
            komut.Parameters.AddWithValue("@dogum_tarih", dateTimePicker1.Value);
            komut.CommandText = sorgu;
            sql.GetManager().SendData(komut);
            sql.DisConnect();
            komut = null;
            GC.Collect();
            iscigetir();
        }   

        private void button2_Click(object sender, EventArgs e) //sil butonu
        {
            string sorgu = "DELETE FROM isciler Where id=@id";

            komut = new SqlCommand();
            sql.Connect();
            komut.Parameters.AddWithValue("@id", txtid.Text);
            komut.Parameters.AddWithValue("@ad", txtad.Text);
            komut.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            komut.Parameters.AddWithValue("@dogum_tarih", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@telefon", txttel.Text);
            komut.CommandText = sorgu;
            sql.GetManager().SendData(komut);
            sql.DisConnect();
            komut = null;
            iscigetir();
            GC.Collect();
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txttel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e) //geri tuşu
        {
            mudur mudur = new mudur();
            mudur.Visible = true;
            mudur.Show();
            this.Hide();
            GC.Collect();
        }

        private void btguncelle_Click(object sender, EventArgs e) // güncelle butonu
        {
            sql = (ConnectSQL)connection.GetConnection();
            sql.Connect();
            sql.GetManager().UpdateData("isciler", new ManageSQL.SQLCondition[]
            {
                new ManageSQL.SQLCondition()
                {
                    title = "ad",
                    value = txtad.Text.ToString(),
                },
                new ManageSQL.SQLCondition()
                {
                    title = "soyad",
                    value = txtsoyad.Text.ToString()
                },
                new ManageSQL.SQLCondition()
                {
                    title = "telefon",
                    value = txttel.Text.ToString()
                },
                new ManageSQL.SQLCondition()
                {
                    title = "dogum_tarih",
                    value = dateTimePicker1.Value
                }
            }, new ManageSQL.SQLCondition() { title = "id", value = int.Parse(txtid.Text.ToString()) });
            sql.DisConnect();
            iscigetir();
            GC.Collect();
        }
    }
}
