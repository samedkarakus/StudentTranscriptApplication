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
    public partial class guncellemeEkrani : Form
    {
        public guncellemeEkrani()
        {
            InitializeComponent();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtAKTS_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click_1(object sender, EventArgs e)
        {

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=ders;username=postgres;Password=1234;Database=transkript;");

        private void guncelBtnIptal_Click(object sender, EventArgs e)
        {
            guncellemeVerileri guncelleme = new guncellemeVerileri();
            guncelleme.Show();
            this.Hide();
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand komut_guncelle = new NpgsqlCommand();
            komut_guncelle.Connection = conn;

            komut_guncelle.Parameters.AddWithValue("@ders_kodu", txtDersKodu.Text);
            komut_guncelle.Parameters.AddWithValue("@ders_adi", dersAdi.Text);
            komut_guncelle.Parameters.AddWithValue("@kredi", Convert.ToInt32(dersKredisi.Text));
            komut_guncelle.Parameters.AddWithValue("@akts", Convert.ToInt32(dersAKTS.Text));
            komut_guncelle.Parameters.AddWithValue("@ogretim_uyesi", ogrenimUyesi.Text);
            komut_guncelle.Parameters.AddWithValue("@donem", donem.Text);
            komut_guncelle.Parameters.AddWithValue("@harf_notu", harfNotu.Text);

            komut_guncelle.CommandType = CommandType.Text;
            komut_guncelle.CommandText = "update ders \nset ders_adi=@ders_adi, kredi=@kredi, akts= @akts, ogretim_uyesi=@ogretim_uyesi, donem=@donem, harf_notu=@harf_notu\n where ders_kodu = @ders_kodu";
            NpgsqlDataReader dr = komut_guncelle.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                derslerDataGrid.DataSource = dt;
            }
            komut_guncelle.Dispose();
            conn.Close();

            showData("Select * from ders\nwhere ders_kodu = '" + txtDersKodu.Text + "'");
        }

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

        private void Form1_Load(object sender, EventArgs e)
        {
            showData("Select * from ders");
        }

        private void listGeriGetir_Click(object sender, EventArgs e)
        {
            showData("Select * from ders");
        }

        private void veriGetirBtn_Click(object sender, EventArgs e)
        {
            showData("select * from ders\nwhere ders_kodu = '" + txtDersKodu.Text + "'");
        }

        private void dersKredisi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void dersAKTS_TextChanged(object sender, EventArgs e)
        {

        }

        private void donem_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void harfNotu_TextChanged(object sender, EventArgs e)
        {

        }

        private void ogrenimUyesi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void listGeriGetir_Click(object sender, EventArgs e)
        {
            showData("Select * from ders");
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
