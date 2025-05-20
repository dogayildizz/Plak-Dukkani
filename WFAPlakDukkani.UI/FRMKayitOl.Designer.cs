namespace WFAPlakDukkani.UI
{
    partial class FRMKayitOl
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
            txtKullaniciAdi = new TextBox();
            btnKayitOl = new Button();
            label2 = new Label();
            txtSifre = new TextBox();
            label3 = new Label();
            txtSifreTekrar = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 180);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 23);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(310, 177);
            txtKullaniciAdi.Margin = new Padding(4, 3, 4, 3);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(186, 32);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // btnKayitOl
            // 
            btnKayitOl.Location = new Point(322, 431);
            btnKayitOl.Margin = new Padding(4, 3, 4, 3);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(164, 48);
            btnKayitOl.TabIndex = 2;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 237);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(48, 23);
            label2.TabIndex = 0;
            label2.Text = "Şifre";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(310, 234);
            txtSifre.Margin = new Padding(4, 3, 4, 3);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(186, 32);
            txtSifre.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 294);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(125, 23);
            label3.TabIndex = 0;
            label3.Text = "Şifre (Tekrar)";
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Location = new Point(310, 291);
            txtSifreTekrar.Margin = new Padding(4, 3, 4, 3);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.Size = new Size(186, 32);
            txtSifreTekrar.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(138, 336);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(339, 80);
            label4.TabIndex = 3;
            label4.Text = "Şifreniz :\r\n- En az 8 karakterden oluşmalıdır.\r\n- En az 2 büyük ve 3 küçük harf içermelidir.\r\n- En az 2 özel karakter (\" ! , : , + , * \") içermelidir.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Görsel_2025_05_20_saat_16_43_52_30b6fb40;
            pictureBox1.Location = new Point(50, -89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(579, 313);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FRMKayitOl
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 238, 220);
            ClientSize = new Size(719, 506);
            Controls.Add(label4);
            Controls.Add(btnKayitOl);
            Controls.Add(txtSifreTekrar);
            Controls.Add(label3);
            Controls.Add(txtSifre);
            Controls.Add(label2);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FRMKayitOl";
            Text = "KayitOl";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKullaniciAdi;
        private Button btnKayitOl;
        private Label label2;
        private TextBox txtSifre;
        private Label label3;
        private TextBox txtSifreTekrar;
        private Label label4;
        private PictureBox pictureBox1;
    }
}