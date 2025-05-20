namespace WFAPlakDukkani.UI
{
    partial class FRMAlbumler
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
            label1 = new Label();
            txtAlbumAdi = new TextBox();
            btnEkle = new Button();
            label2 = new Label();
            dtpCikisTarihi = new DateTimePicker();
            nudFiyat = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            nudIndirimOrani = new NumericUpDown();
            label5 = new Label();
            cmbSanatcilar = new ComboBox();
            btnSil = new Button();
            btnGuncelle = new Button();
            label6 = new Label();
            cmbSatistaMi = new ComboBox();
            dgvAlbumler = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudFiyat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudIndirimOrani).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlbumler).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 439);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 23);
            label1.TabIndex = 0;
            label1.Text = "Çıkış Tarihi";
            // 
            // txtAlbumAdi
            // 
            txtAlbumAdi.Location = new Point(283, 344);
            txtAlbumAdi.Margin = new Padding(4, 3, 4, 3);
            txtAlbumAdi.Name = "txtAlbumAdi";
            txtAlbumAdi.Size = new Size(278, 32);
            txtAlbumAdi.TabIndex = 1;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(693, 402);
            btnEkle.Margin = new Padding(4, 3, 4, 3);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(141, 43);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 347);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(115, 23);
            label2.TabIndex = 0;
            label2.Text = "Albüm Adı";
            // 
            // dtpCikisTarihi
            // 
            dtpCikisTarihi.Location = new Point(283, 435);
            dtpCikisTarihi.Name = "dtpCikisTarihi";
            dtpCikisTarihi.Size = new Size(278, 32);
            dtpCikisTarihi.TabIndex = 4;
            // 
            // nudFiyat
            // 
            nudFiyat.Location = new Point(283, 481);
            nudFiyat.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            nudFiyat.Name = "nudFiyat";
            nudFiyat.Size = new Size(278, 32);
            nudFiyat.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 485);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 23);
            label3.TabIndex = 0;
            label3.Text = "Fiyat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 531);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(132, 23);
            label4.TabIndex = 0;
            label4.Text = "İndirim Oranı";
            // 
            // nudIndirimOrani
            // 
            nudIndirimOrani.DecimalPlaces = 2;
            nudIndirimOrani.Location = new Point(284, 527);
            nudIndirimOrani.Name = "nudIndirimOrani";
            nudIndirimOrani.Size = new Size(277, 32);
            nudIndirimOrani.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(121, 393);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(155, 23);
            label5.TabIndex = 0;
            label5.Text = "Sanatçı / Grup";
            // 
            // cmbSanatcilar
            // 
            cmbSanatcilar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSanatcilar.FormattingEnabled = true;
            cmbSanatcilar.Location = new Point(283, 390);
            cmbSanatcilar.Name = "cmbSanatcilar";
            cmbSanatcilar.Size = new Size(278, 31);
            cmbSanatcilar.TabIndex = 6;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(693, 459);
            btnSil.Margin = new Padding(4, 3, 4, 3);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(141, 43);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(693, 516);
            btnGuncelle.Margin = new Padding(4, 3, 4, 3);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(141, 43);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(121, 577);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(121, 23);
            label6.TabIndex = 0;
            label6.Text = "Satışta Mı ?";
            // 
            // cmbSatistaMi
            // 
            cmbSatistaMi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSatistaMi.FormattingEnabled = true;
            cmbSatistaMi.Location = new Point(284, 574);
            cmbSatistaMi.Name = "cmbSatistaMi";
            cmbSatistaMi.Size = new Size(278, 31);
            cmbSatistaMi.TabIndex = 6;
            // 
            // dgvAlbumler
            // 
            dgvAlbumler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlbumler.Location = new Point(22, 12);
            dgvAlbumler.Name = "dgvAlbumler";
            dgvAlbumler.ReadOnly = true;
            dgvAlbumler.RowHeadersWidth = 51;
            dgvAlbumler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlbumler.Size = new Size(825, 326);
            dgvAlbumler.TabIndex = 7;
            dgvAlbumler.CellClick += dgvAlbumler_CellClick;
            // 
            // FRMAlbumler
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 238, 220);
            ClientSize = new Size(940, 673);
            Controls.Add(dgvAlbumler);
            Controls.Add(cmbSatistaMi);
            Controls.Add(cmbSanatcilar);
            Controls.Add(nudIndirimOrani);
            Controls.Add(nudFiyat);
            Controls.Add(dtpCikisTarihi);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(txtAlbumAdi);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FRMAlbumler";
            Text = "AlbumEkleSilGuncelle";
            Load += FRMAlbumler_Load;
            ((System.ComponentModel.ISupportInitialize)nudFiyat).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudIndirimOrani).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlbumler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAlbumAdi;
        private Button btnEkle;
        private Label label2;
        private DateTimePicker dtpCikisTarihi;
        private NumericUpDown nudFiyat;
        private Label label3;
        private Label label4;
        private NumericUpDown nudIndirimOrani;
        private Label label5;
        private ComboBox cmbSanatcilar;
        private Button btnSil;
        private Button btnGuncelle;
        private Label label6;
        private ComboBox cmbSatistaMi;
        private DataGridView dgvAlbumler;
    }
}