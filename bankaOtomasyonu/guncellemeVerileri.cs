using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankaOtomasyonu
{
    public partial class guncellemeVerileri : Form
    {
        public guncellemeVerileri()
        {
            InitializeComponent();
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            guncellemeEkrani guncellemeEkrani = new guncellemeEkrani();
            guncellemeEkrani.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            silmeEkrani silmeEkrani = new silmeEkrani();
            silmeEkrani.Show();
            this.Hide();
        }

        private void txtDersKodu_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            transkriptEkrani transkriptEkrani = new transkriptEkrani();
            transkriptEkrani.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
