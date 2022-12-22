using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace bankaOtomasyonu
{
    public partial class silmeEkrani : Form
    {
        public silmeEkrani()
        {
            InitializeComponent();
        }

        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=ders;username=postgres;Password=1234;Database=transkript;");

        public void showData(string txt)
        {
            conn.Open();
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;
            komut.CommandText = txt;
            NpgsqlDataReader dr = komut.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                derslerDataGrid.DataSource = dt;
            }
            komut.Dispose();
            conn.Close();
        }

        private void silmeEkrani_Load(object sender, EventArgs e)
        {
            showData("Select * from ders");
        }

        private void silBtn_Click(object sender, EventArgs e)
        {

        }

        private void silBtnIptal_Click(object sender, EventArgs e)
        {
            guncellemeVerileri guncelleme = new guncellemeVerileri();
            guncelleme.Show();
            this.Hide();
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = conn;

            komut_ekle.Parameters.AddWithValue("@ders_kodu", txtDersKodu.Text);
            komut_ekle.Parameters.AddWithValue("@ders_adi", dersAdi.Text);
            komut_ekle.Parameters.AddWithValue("@kredi", Convert.ToInt32(dersKredisi.Text));
            komut_ekle.Parameters.AddWithValue("@akts", Convert.ToInt32(dersAKTS.Text));
            komut_ekle.Parameters.AddWithValue("@ogretim_uyesi", ogrenimUyesi.Text);
            komut_ekle.Parameters.AddWithValue("@donem", donem.Text);
            komut_ekle.Parameters.AddWithValue("@harf_notu", harfNotu.Text);

            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into ders values (@ders_kodu, @ders_adi, @kredi, @akts, @ogretim_uyesi, @donem, @harf_notu)";

            NpgsqlDataReader dr = komut_ekle.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                derslerDataGrid.DataSource = dt;
            }
            komut_ekle.Dispose();
            conn.Close();

            showData("select * from ders");

        }

        private void silBtn_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand komut_sil = new NpgsqlCommand();
            komut_sil.Connection = conn;
            komut_sil.Parameters.AddWithValue("@ders_kodu", txtDersKodu.Text);

            komut_sil.CommandType = CommandType.Text;
            komut_sil.CommandText = "delete from ders where ders_kodu = @ders_kodu";

            NpgsqlDataReader dr = komut_sil.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                derslerDataGrid.DataSource = dt;
            }
            komut_sil.Dispose();
            conn.Close();

            showData("select * from ders");
        }

        private void guncelBtnIptal_Click(object sender, EventArgs e)
        {
            guncellemeVerileri guncelleme = new guncellemeVerileri();
            guncelleme.Show();
            this.Hide();
        }

        private void listGeriGetir_Click(object sender, EventArgs e)
        {
            showData("select * from ders");
        }

        private void veriGetirBtn_Click(object sender, EventArgs e)
        {
            showData("select * from ders\nwhere ders_kodu = '" + txtDersKodu.Text + "'");
        }

        private void derslerDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
