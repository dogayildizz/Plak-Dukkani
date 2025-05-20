using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAPlakDukkani.UI
{
    public partial class FRMAnaMenu : Form
    {
        public FRMAnaMenu(string kullaniciAdi)
        {
            InitializeComponent();
            txtHosgeldinKullanici.Text = "Hoşgeldin "+kullaniciAdi+" !";

        }

        public void FormGetir(Form form)
        {
            pnlIcerik.Controls.Clear();
            form.MdiParent = this; //this form(içinde bulunduğumuz form), ana formdur. parametreden aldığımız form, ana formun alt formudur.
            form.FormBorderStyle = FormBorderStyle.None; //hareket etmesini engelledik
            pnlIcerik.Controls.Add(form);  //Çağırdığımız formu pnlIcerik adındaki panele ekledik.
            form.Show(); //Çağırdığımız formu göster dedik.
        }

        #region Buttonların click eventleri

        private void btnAlbumler_Click(object sender, EventArgs e)
        {
            FRMAlbumler fRMAlbumler = new FRMAlbumler();
            FormGetir(fRMAlbumler);
        }

        private void btnIndirimdekiAlbumler_Click(object sender, EventArgs e)
        {
            FRMIndirimdekiAlbumler fRMIndirimdekiAlbumler = new FRMIndirimdekiAlbumler();
            FormGetir(fRMIndirimdekiAlbumler);
        }

        private void btnSatistakiAlbumler_Click(object sender, EventArgs e)
        {
            FRMSatisiDevamEdenAlbumler fRMSatisiDevamEdenAlbumler = new FRMSatisiDevamEdenAlbumler();
            FormGetir(fRMSatisiDevamEdenAlbumler);
        }

        private void btnSatistaOlmayanAlbumler_Click(object sender, EventArgs e)
        {
            FRMSatisiDurmusAlbumler fRMSatisiDurmusAlbumler = new FRMSatisiDurmusAlbumler();
            FormGetir(fRMSatisiDurmusAlbumler);
        }

        private void btnSonEklenenOnAlbum_Click(object sender, EventArgs e)
        {
            FRMSonEklenenOnAlbum fRMSonEklenenOnAlbum = new FRMSonEklenenOnAlbum();
            FormGetir(fRMSonEklenenOnAlbum);
        }
        private void btnSanatcilar_Click(object sender, EventArgs e)
        {
            FRMSanatcilar fRMSanatcilar = new FRMSanatcilar();
            FormGetir(fRMSanatcilar);
        }

        #endregion

    }
}
