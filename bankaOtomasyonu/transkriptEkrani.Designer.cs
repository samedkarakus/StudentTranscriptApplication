
namespace bankaOtomasyonu
{
    partial class transkriptEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDersKodu = new System.Windows.Forms.RichTextBox();
            this.ganoHesaplaBtn = new System.Windows.Forms.Button();
            this.baslagicaDon = new System.Windows.Forms.Button();
            this.derslerDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.derslerDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(553, 440);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 63);
            this.label8.TabIndex = 13;
            this.label8.Text = "GANO:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(456, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 42);
            this.label1.TabIndex = 39;
            this.label1.Text = "Transkript Detayları";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDersKodu
            // 
            this.txtDersKodu.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDersKodu.Location = new System.Drawing.Point(631, 453);
            this.txtDersKodu.Margin = new System.Windows.Forms.Padding(5);
            this.txtDersKodu.Name = "txtDersKodu";
            this.txtDersKodu.ReadOnly = true;
            this.txtDersKodu.Size = new System.Drawing.Size(89, 34);
            this.txtDersKodu.TabIndex = 50;
            this.txtDersKodu.Text = "";
            // 
            // ganoHesaplaBtn
            // 
            this.ganoHesaplaBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.ganoHesaplaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ganoHesaplaBtn.Font = new System.Drawing.Font("Poppins", 9F);
            this.ganoHesaplaBtn.ForeColor = System.Drawing.Color.White;
            this.ganoHesaplaBtn.Location = new System.Drawing.Point(396, 526);
            this.ganoHesaplaBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ganoHesaplaBtn.Name = "ganoHesaplaBtn";
            this.ganoHesaplaBtn.Size = new System.Drawing.Size(215, 62);
            this.ganoHesaplaBtn.TabIndex = 51;
            this.ganoHesaplaBtn.Text = "GANO Hesapla";
            this.ganoHesaplaBtn.UseVisualStyleBackColor = false;
            this.ganoHesaplaBtn.Click += new System.EventHandler(this.ganoHesaplaBtn_Click);
            // 
            // baslagicaDon
            // 
            this.baslagicaDon.BackColor = System.Drawing.Color.PaleVioletRed;
            this.baslagicaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.baslagicaDon.Font = new System.Drawing.Font("Poppins", 9F);
            this.baslagicaDon.ForeColor = System.Drawing.Color.White;
            this.baslagicaDon.Location = new System.Drawing.Point(642, 526);
            this.baslagicaDon.Margin = new System.Windows.Forms.Padding(5);
            this.baslagicaDon.Name = "baslagicaDon";
            this.baslagicaDon.Size = new System.Drawing.Size(233, 62);
            this.baslagicaDon.TabIndex = 52;
            this.baslagicaDon.Text = "Başlangıca Dön";
            this.baslagicaDon.UseVisualStyleBackColor = false;
            this.baslagicaDon.Click += new System.EventHandler(this.baslagicaDon_Click);
            // 
            // derslerDataGrid
            // 
            this.derslerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.derslerDataGrid.Location = new System.Drawing.Point(127, 169);
            this.derslerDataGrid.Name = "derslerDataGrid";
            this.derslerDataGrid.ReadOnly = true;
            this.derslerDataGrid.RowHeadersWidth = 51;
            this.derslerDataGrid.RowTemplate.Height = 24;
            this.derslerDataGrid.Size = new System.Drawing.Size(1014, 254);
            this.derslerDataGrid.TabIndex = 53;
            this.derslerDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.derslerDataGrid_CellContentClick);
            // 
            // transkriptEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 667);
            this.Controls.Add(this.derslerDataGrid);
            this.Controls.Add(this.baslagicaDon);
            this.Controls.Add(this.ganoHesaplaBtn);
            this.Controls.Add(this.txtDersKodu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Name = "transkriptEkrani";
            this.Text = "transkriptEkrani";
            this.Load += new System.EventHandler(this.transkriptEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.derslerDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtDersKodu;
        private System.Windows.Forms.Button ganoHesaplaBtn;
        private System.Windows.Forms.Button baslagicaDon;
        private System.Windows.Forms.DataGridView derslerDataGrid;
    }
}