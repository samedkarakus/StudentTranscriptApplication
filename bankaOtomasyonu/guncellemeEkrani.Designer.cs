
namespace bankaOtomasyonu
{
    partial class guncellemeEkrani
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.guncelBtnIptal = new System.Windows.Forms.Button();
            this.harfNotu = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.donem = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dersAKTS = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ogrenimUyesi = new System.Windows.Forms.RichTextBox();
            this.guncelleBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dersKredisi = new System.Windows.Forms.RichTextBox();
            this.dersAdi = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dersVerileri = new System.Windows.Forms.GroupBox();
            this.txtDersKodu = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listGeriGetir = new System.Windows.Forms.Button();
            this.veriGetirBtn = new System.Windows.Forms.Button();
            this.derslerDataGrid = new System.Windows.Forms.DataGridView();
            this.dersVerileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.derslerDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // guncelBtnIptal
            // 
            this.guncelBtnIptal.BackColor = System.Drawing.Color.PaleVioletRed;
            this.guncelBtnIptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guncelBtnIptal.Font = new System.Drawing.Font("Poppins", 9F);
            this.guncelBtnIptal.ForeColor = System.Drawing.Color.White;
            this.guncelBtnIptal.Location = new System.Drawing.Point(560, 423);
            this.guncelBtnIptal.Margin = new System.Windows.Forms.Padding(5);
            this.guncelBtnIptal.Name = "guncelBtnIptal";
            this.guncelBtnIptal.Size = new System.Drawing.Size(193, 62);
            this.guncelBtnIptal.TabIndex = 34;
            this.guncelBtnIptal.Text = "Başlangıca Dön";
            this.guncelBtnIptal.UseVisualStyleBackColor = false;
            this.guncelBtnIptal.Click += new System.EventHandler(this.guncelBtnIptal_Click);
            // 
            // harfNotu
            // 
            this.harfNotu.BackColor = System.Drawing.Color.Gainsboro;
            this.harfNotu.Location = new System.Drawing.Point(704, 164);
            this.harfNotu.Margin = new System.Windows.Forms.Padding(5);
            this.harfNotu.Name = "harfNotu";
            this.harfNotu.Size = new System.Drawing.Size(201, 34);
            this.harfNotu.TabIndex = 27;
            this.harfNotu.Text = "";
            this.harfNotu.TextChanged += new System.EventHandler(this.harfNotu_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Poppins Light", 10.25F);
            this.label2.Location = new System.Drawing.Point(45, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 63);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ders Adı:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // donem
            // 
            this.donem.BackColor = System.Drawing.Color.Gainsboro;
            this.donem.Location = new System.Drawing.Point(215, 164);
            this.donem.Margin = new System.Windows.Forms.Padding(5);
            this.donem.Name = "donem";
            this.donem.Size = new System.Drawing.Size(201, 34);
            this.donem.TabIndex = 26;
            this.donem.Text = "";
            this.donem.TextChanged += new System.EventHandler(this.donem_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Poppins Light", 10.25F);
            this.label3.Location = new System.Drawing.Point(528, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 63);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ders Kredisi:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // dersAKTS
            // 
            this.dersAKTS.BackColor = System.Drawing.Color.Gainsboro;
            this.dersAKTS.Location = new System.Drawing.Point(215, 107);
            this.dersAKTS.Margin = new System.Windows.Forms.Padding(5);
            this.dersAKTS.Name = "dersAKTS";
            this.dersAKTS.Size = new System.Drawing.Size(201, 34);
            this.dersAKTS.TabIndex = 25;
            this.dersAKTS.Text = "";
            this.dersAKTS.TextChanged += new System.EventHandler(this.dersAKTS_TextChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Poppins Light", 10.25F);
            this.label9.Location = new System.Drawing.Point(528, 79);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 91);
            this.label9.TabIndex = 8;
            this.label9.Text = "Öğretim Üyesi:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // ogrenimUyesi
            // 
            this.ogrenimUyesi.BackColor = System.Drawing.Color.Gainsboro;
            this.ogrenimUyesi.Location = new System.Drawing.Point(704, 107);
            this.ogrenimUyesi.Margin = new System.Windows.Forms.Padding(5);
            this.ogrenimUyesi.Name = "ogrenimUyesi";
            this.ogrenimUyesi.Size = new System.Drawing.Size(201, 34);
            this.ogrenimUyesi.TabIndex = 24;
            this.ogrenimUyesi.Text = "";
            this.ogrenimUyesi.TextChanged += new System.EventHandler(this.ogrenimUyesi_TextChanged);
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.guncelleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guncelleBtn.Font = new System.Drawing.Font("Poppins", 9F);
            this.guncelleBtn.ForeColor = System.Drawing.Color.White;
            this.guncelleBtn.Location = new System.Drawing.Point(378, 423);
            this.guncelleBtn.Margin = new System.Windows.Forms.Padding(5);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(161, 62);
            this.guncelleBtn.TabIndex = 37;
            this.guncelleBtn.Text = "Güncelle";
            this.guncelleBtn.UseVisualStyleBackColor = false;
            this.guncelleBtn.Click += new System.EventHandler(this.guncelleBtn_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Poppins Light", 10.25F);
            this.label5.Location = new System.Drawing.Point(44, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 63);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dersin Dönemi:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // dersKredisi
            // 
            this.dersKredisi.BackColor = System.Drawing.Color.Gainsboro;
            this.dersKredisi.Location = new System.Drawing.Point(704, 48);
            this.dersKredisi.Margin = new System.Windows.Forms.Padding(5);
            this.dersKredisi.Name = "dersKredisi";
            this.dersKredisi.Size = new System.Drawing.Size(201, 34);
            this.dersKredisi.TabIndex = 23;
            this.dersKredisi.Text = "";
            this.dersKredisi.TextChanged += new System.EventHandler(this.dersKredisi_TextChanged);
            // 
            // dersAdi
            // 
            this.dersAdi.BackColor = System.Drawing.Color.Gainsboro;
            this.dersAdi.Location = new System.Drawing.Point(215, 48);
            this.dersAdi.Margin = new System.Windows.Forms.Padding(5);
            this.dersAdi.Name = "dersAdi";
            this.dersAdi.Size = new System.Drawing.Size(201, 34);
            this.dersAdi.TabIndex = 22;
            this.dersAdi.Text = "";
            this.dersAdi.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Poppins Light", 10.25F);
            this.label8.Location = new System.Drawing.Point(527, 150);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 63);
            this.label8.TabIndex = 13;
            this.label8.Text = "Harf Notu:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Click += new System.EventHandler(this.label8_Click_1);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Poppins Light", 10.25F);
            this.label7.Location = new System.Drawing.Point(44, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 63);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ders AKTS:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // dersVerileri
            // 
            this.dersVerileri.Controls.Add(this.harfNotu);
            this.dersVerileri.Controls.Add(this.label2);
            this.dersVerileri.Controls.Add(this.donem);
            this.dersVerileri.Controls.Add(this.label3);
            this.dersVerileri.Controls.Add(this.dersAKTS);
            this.dersVerileri.Controls.Add(this.label9);
            this.dersVerileri.Controls.Add(this.ogrenimUyesi);
            this.dersVerileri.Controls.Add(this.label5);
            this.dersVerileri.Controls.Add(this.dersKredisi);
            this.dersVerileri.Controls.Add(this.label7);
            this.dersVerileri.Controls.Add(this.dersAdi);
            this.dersVerileri.Controls.Add(this.label8);
            this.dersVerileri.Location = new System.Drawing.Point(85, 164);
            this.dersVerileri.Name = "dersVerileri";
            this.dersVerileri.Size = new System.Drawing.Size(950, 234);
            this.dersVerileri.TabIndex = 38;
            this.dersVerileri.TabStop = false;
            this.dersVerileri.Text = "Ders Verileri";
            // 
            // txtDersKodu
            // 
            this.txtDersKodu.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDersKodu.Location = new System.Drawing.Point(405, 92);
            this.txtDersKodu.Margin = new System.Windows.Forms.Padding(5);
            this.txtDersKodu.Name = "txtDersKodu";
            this.txtDersKodu.Size = new System.Drawing.Size(195, 34);
            this.txtDersKodu.TabIndex = 43;
            this.txtDersKodu.Text = "";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Poppins Light", 9F);
            this.label1.Location = new System.Drawing.Point(185, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 63);
            this.label1.TabIndex = 42;
            this.label1.Text = "Lütfen Ders Kodunu Giriniz:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listGeriGetir
            // 
            this.listGeriGetir.BackColor = System.Drawing.Color.PaleVioletRed;
            this.listGeriGetir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listGeriGetir.Font = new System.Drawing.Font("Poppins", 9F);
            this.listGeriGetir.ForeColor = System.Drawing.Color.White;
            this.listGeriGetir.Location = new System.Drawing.Point(809, 80);
            this.listGeriGetir.Margin = new System.Windows.Forms.Padding(5);
            this.listGeriGetir.Name = "listGeriGetir";
            this.listGeriGetir.Size = new System.Drawing.Size(150, 55);
            this.listGeriGetir.TabIndex = 45;
            this.listGeriGetir.Text = "Seçimi Kaldır";
            this.listGeriGetir.UseVisualStyleBackColor = false;
            this.listGeriGetir.Click += new System.EventHandler(this.listGeriGetir_Click);
            // 
            // veriGetirBtn
            // 
            this.veriGetirBtn.BackColor = System.Drawing.Color.DarkSalmon;
            this.veriGetirBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.veriGetirBtn.Font = new System.Drawing.Font("Poppins", 9F);
            this.veriGetirBtn.ForeColor = System.Drawing.Color.White;
            this.veriGetirBtn.Location = new System.Drawing.Point(649, 80);
            this.veriGetirBtn.Margin = new System.Windows.Forms.Padding(5);
            this.veriGetirBtn.Name = "veriGetirBtn";
            this.veriGetirBtn.Size = new System.Drawing.Size(150, 55);
            this.veriGetirBtn.TabIndex = 46;
            this.veriGetirBtn.Text = "Veriyi Getir";
            this.veriGetirBtn.UseVisualStyleBackColor = false;
            this.veriGetirBtn.Click += new System.EventHandler(this.veriGetirBtn_Click);
            // 
            // derslerDataGrid
            // 
            this.derslerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.derslerDataGrid.Location = new System.Drawing.Point(56, 507);
            this.derslerDataGrid.Name = "derslerDataGrid";
            this.derslerDataGrid.RowHeadersWidth = 51;
            this.derslerDataGrid.RowTemplate.Height = 24;
            this.derslerDataGrid.Size = new System.Drawing.Size(1014, 182);
            this.derslerDataGrid.TabIndex = 47;
            this.derslerDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.derslerDataGrid_CellContentClick);
            // 
            // guncellemeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 746);
            this.Controls.Add(this.derslerDataGrid);
            this.Controls.Add(this.veriGetirBtn);
            this.Controls.Add(this.listGeriGetir);
            this.Controls.Add(this.txtDersKodu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guncelBtnIptal);
            this.Controls.Add(this.guncelleBtn);
            this.Controls.Add(this.dersVerileri);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "guncellemeEkrani";
            this.Text = "Transkript";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.dersVerileri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.derslerDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button guncelBtnIptal;
        private System.Windows.Forms.RichTextBox harfNotu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox donem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox dersAKTS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox ogrenimUyesi;
        private System.Windows.Forms.Button guncelleBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox dersKredisi;
        private System.Windows.Forms.RichTextBox dersAdi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox dersVerileri;
        private System.Windows.Forms.RichTextBox txtDersKodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button listGeriGetir;
        private System.Windows.Forms.Button veriGetirBtn;
        private System.Windows.Forms.DataGridView derslerDataGrid;
    }
}

