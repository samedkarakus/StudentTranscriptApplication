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
    public partial class transkriptEkrani : Form
    {
        public transkriptEkrani()
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

        public void ganoHesaplama(string txt)
        {
            //conn.Open();
            //NpgsqlCommand komut = new NpgsqlCommand();
            //komut.Connection = conn;
            //komut.CommandType = CommandType.Text;
            //komut.CommandText = txt;
            //NpgsqlDataReader dr = komut.ExecuteReader();

            //if (dr.HasRows)
            //{
            //    DataTable dt = new DataTable();
            //    dt.Load(dr);
            //    derslerDataGrid.DataSource = dt;
            //}
            //komut.Dispose();
            //conn.Close();

        }


        static int HarfleriSayiyaCevirme(char grade)
        {
            switch (grade.ToString())
            {
                case "AA":
                    return (int)4.0;
                case "BA":
                    return (int)3.5;
                case "BB":
                    return (int)3.0;
                case "CB":
                    return (int)2.5;
                case "CC":
                    return (int)2.0;
                case "DC":
                    return (int)1.5;
                case "DD":
                    return (int)1.0;
                case "FD":
                    return (int)0.5;
                case "FF":
                    return (int)0.00;
                default:
                    return 0;
            }

            //var notlar = new List<Not>();
            //using (var connection = new NpgsqlConnection(connectionString)
            //{
            //    connection.Open();
            //    using (var command = new SqlCommand("SELECT DersAdi, Kredi, Puan FROM Notlar", connection))
            //    using (var reader = command.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            var not = new Not
            //            {
            //                DersAdi = reader.GetString(0),
            //                Kredi = reader.GetInt32(1),
            //                Puan = reader.GetDouble(2)
            //            };
            //            notlar.Add(not);
            //        }
            //    }
            //}
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void transkriptEkrani_Load(object sender, EventArgs e)
        {
            showData("Select * from ders");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ganoHesaplaBtn_Click(object sender, EventArgs e)
        {
            //ganoHesaplama("Select HARF_NOTU from ders");
        }

        private void baslagicaDon_Click(object sender, EventArgs e)
        {
            guncellemeVerileri guncellemeVerileri = new guncellemeVerileri();
            guncellemeVerileri.Show();
            this.Hide();
        }

        private void derslerDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
