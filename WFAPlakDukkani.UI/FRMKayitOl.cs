using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAPlakDukkani.UI.Context;
using WFAPlakDukkani.UI.Helper;
using WFAPlakDukkani.UI.Models;

namespace WFAPlakDukkani.UI
{
    public partial class FRMKayitOl : Form
    {
        private readonly MyDbContext _db;

        public bool SifreGecerliMi(string sifre, string sifreTekrar)
        {
            char[] ozelKarakterler = { '+', '*', ':', '!' };

            if (string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Şifre boş geçilemez!");
                return false;
            }
            if (txtSifre.Text.Length < 8)
            {
                MessageBox.Show("Şifre en az 8 karakterden oluşmalıdır!");
                return false;
            }
            if (txtSifre.Text.Count(char.IsUpper) < 2)
            {
                MessageBox.Show("Şifre en az 2 adet büyük harf içermelidir!");
                return false;
            }
            if (txtSifre.Text.Count(char.IsLower) < 3)
            {
                MessageBox.Show("Şifre en az 3 adet küçük harf içermelidir!");
                return false;
            }
            if (txtSifre.Text.Count(c => ozelKarakterler.Contains(c)) < 2)
            {
                MessageBox.Show("Şifre en az 2 adet özel karakter (+ , * , : , !) içermelidir!");
                return false;
            }
            if (txtSifre.Text != txtSifreTekrar.Text)
            {
                MessageBox.Show("Şifre tekrarı, şifre ile aynı olmalıdır!");
                return false;
            }
            return true;
        }
        public FRMKayitOl()
        {
            InitializeComponent();
            _db = new();
        }
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (!SifreGecerliMi(txtSifre.Text, txtSifreTekrar.Text))
            {
                txtSifre.Text = txtSifreTekrar.Text = string.Empty;
                return;
            }
            ;
            if(string.IsNullOrWhiteSpace(txtKullaniciAdi.Text))
            {
                MessageBox.Show("Kullanıcı adı boş geçilemez!");
                return;
            }
            if(_db.Yoneticiler.Any(y=> y.KullaniciAdi == txtKullaniciAdi.Text))
            {
                MessageBox.Show("Bu kullanıcı adı daha önce alınmış. Lütfen farklı bir kullanıcı adı giriniz.");
                txtKullaniciAdi.Text = string.Empty;
                return;
            }
            Yonetici yonetici = new Yonetici
            {
                KullaniciAdi = txtKullaniciAdi.Text,
                Sifre = Sifreleme.Sha256Hash(txtSifre.Text) 
            };
            _db.Add(yonetici);
            _db.SaveChanges();

            MessageBox.Show("Başarıyla kayıt olundu!");
            this.Close();
        }

    }
}
