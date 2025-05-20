namespace WFAPlakDukkani.UI
{
    partial class FRMGirisEkrani
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtKullaniciAdi = new TextBox();
            btnGirisYap = new Button();
            lnkKayitOl = new LinkLabel();
            chkSifreyiGoster = new CheckBox();
            label2 = new Label();
            txtSifre = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 218);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 23);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(328, 214);
            txtKullaniciAdi.Margin = new Padding(4, 3, 4, 3);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(230, 32);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // btnGirisYap
            // 
            btnGirisYap.Location = new Point(328, 355);
            btnGirisYap.Margin = new Padding(4, 3, 4, 3);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(154, 43);
            btnGirisYap.TabIndex = 2;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // lnkKayitOl
            // 
            lnkKayitOl.AutoSize = true;
            lnkKayitOl.Location = new Point(328, 431);
            lnkKayitOl.Margin = new Padding(4, 0, 4, 0);
            lnkKayitOl.Name = "lnkKayitOl";
            lnkKayitOl.Size = new Size(75, 23);
            lnkKayitOl.TabIndex = 3;
            lnkKayitOl.TabStop = true;
            lnkKayitOl.Text = "Üye Ol";
            lnkKayitOl.LinkClicked += lnkKayitOl_LinkClicked;
            // 
            // chkSifreyiGoster
            // 
            chkSifreyiGoster.AutoSize = true;
            chkSifreyiGoster.Location = new Point(328, 303);
            chkSifreyiGoster.Margin = new Padding(4, 3, 4, 3);
            chkSifreyiGoster.Name = "chkSifreyiGoster";
            chkSifreyiGoster.Size = new Size(154, 27);
            chkSifreyiGoster.TabIndex = 4;
            chkSifreyiGoster.Text = "Şifreyi Göster";
            chkSifreyiGoster.UseVisualStyleBackColor = true;
            chkSifreyiGoster.CheckedChanged += chkSifreyiGoster_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 268);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(48, 23);
            label2.TabIndex = 0;
            label2.Text = "Şifre";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(328, 265);
            txtSifre.Margin = new Padding(4, 3, 4, 3);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(230, 32);
            txtSifre.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(156, 431);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(164, 23);
            label3.TabIndex = 0;
            label3.Text = "Üye değil misin?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Görsel_2025_05_20_saat_16_43_52_30b6fb40;
            pictureBox1.Location = new Point(12, -66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(579, 313);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // FRMGirisEkrani
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 238, 220);
            ClientSize = new Size(658, 561);
            Controls.Add(chkSifreyiGoster);
            Controls.Add(lnkKayitOl);
            Controls.Add(btnGirisYap);
            Controls.Add(txtSifre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            MinimizeBox = false;
            Name = "FRMGirisEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Yap";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKullaniciAdi;
        private Button btnGirisYap;
        private LinkLabel lnkKayitOl;
        private CheckBox chkSifreyiGoster;
        private Label label2;
        private TextBox txtSifre;
        private Label label3;
        private PictureBox pictureBox1;
    }
}
