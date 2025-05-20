using WFAPlakDukkani.UI.Context;
using WFAPlakDukkani.UI.Helper;

namespace WFAPlakDukkani.UI
{
    public partial class FRMGirisEkrani : Form
    {
        private readonly MyDbContext _db;
        public FRMGirisEkrani()
        {
            InitializeComponent();
            _db = new();
            txtSifre.PasswordChar = '*';
        }

        private void lnkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRMKayitOl fRMKayitOl = new FRMKayitOl();
            fRMKayitOl.ShowDialog();
            this.Hide();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text))
            {
                MessageBox.Show("Kullan�c� ad� bo� ge�ilemez!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("�ifre bo� ge�ilemez!");
                return;
            }
            if (!_db.Yoneticiler.Any(y => y.KullaniciAdi == txtKullaniciAdi.Text.Trim() && y.Sifre == Sifreleme.Sha256Hash(txtSifre.Text)))
            {
                MessageBox.Show("B�yle bir kullan�c� bulunamad�! L�tfen t�m bilgileri do�ru girdi�inizden emin olun.");
                return;
            }
            else
            {
                FRMAnaMenu fRMAnaMenu = new FRMAnaMenu(txtKullaniciAdi.Text);
                fRMAnaMenu.ShowDialog();
                this.Close();
            }
        }

        private void chkSifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSifreyiGoster.Checked)
            {
                txtSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '*';
            }
        }
    }
}
