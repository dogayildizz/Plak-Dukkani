using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAPlakDukkani.UI.Context;
using WFAPlakDukkani.UI.Models;

namespace WFAPlakDukkani.UI
{
    public partial class FRMAlbumler : Form
    {
        private readonly MyDbContext _db;
        Album seciliAlbum = new();
        public FRMAlbumler()
        {
            InitializeComponent();
            _db = new MyDbContext();
        }


        public void DgvListele()
        {
            dgvAlbumler.DataSource = _db.Albumler.ToList();
        }
        public void Temizle()
        {
            txtAlbumAdi.Text = nudFiyat.Text = nudIndirimOrani.Text = string.Empty;
            cmbSanatcilar.SelectedItem = cmbSatistaMi.SelectedItem = null;
            dtpCikisTarihi.Value = DateTime.Now;
            seciliAlbum = null;
        }
        private void FRMAlbumler_Load(object sender, EventArgs e)
        {
            DgvListele();
            dgvAlbumler.Columns["Id"].Visible = false;
            dgvAlbumler.Columns["SanatciId"].Visible = false;
            Temizle();
            cmbSatistaMi.Items.Add("Evet");
            cmbSatistaMi.Items.Add("Hayır");
            cmbSanatcilar.DataSource = _db.Sanatcilar.ToList();
            cmbSanatcilar.ValueMember = "Id";
            cmbSanatcilar.DisplayMember = "SanatciAdi";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtAlbumAdi.Text)|| cmbSanatcilar.SelectedItem == null || cmbSatistaMi.SelectedItem == null || nudFiyat.Value == null || nudIndirimOrani.Value == null)
            {
                MessageBox.Show("Lütfen tüm bilgileri girdiğinizden emin olun!");
                return;
            }
            Album album = new Album
            {
                AlbumAdi = txtAlbumAdi.Text,
                Sanatci = cmbSanatcilar.SelectedItem as Sanatci,
                CikisTarihi = dtpCikisTarihi.Value,
                Fiyat = nudFiyat.Value,
                IndirimOrani = (double)nudIndirimOrani.Value,
                SatistaMi = cmbSatistaMi.SelectedItem == "Evet" ? true : false,
            };
            _db.Albumler.Add(album);
            _db.SaveChanges();
            MessageBox.Show("Albüm başarıyla eklendi!");
            Temizle();
            DgvListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(seciliAlbum == null)
            {
                MessageBox.Show("Silmek istediğiniz albümü seçiniz.");
                return;
            }

            _db.Albumler.Remove(seciliAlbum);
            _db.SaveChanges();
            MessageBox.Show("Albüm başarıyla silindi!");
            Temizle();
            DgvListele();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliAlbum == null)
            {
                MessageBox.Show("Güncellemek istediğiniz albümü seçiniz.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAlbumAdi.Text) || cmbSanatcilar.SelectedItem == null || cmbSatistaMi.SelectedItem == null || nudFiyat.Value == null || nudIndirimOrani.Value == null)
            {
                MessageBox.Show("Lütfen tüm bilgileri girdiğinizden emin olun!");
                return;
            }
            seciliAlbum.AlbumAdi = txtAlbumAdi.Text;
            seciliAlbum.CikisTarihi = dtpCikisTarihi.Value;
            seciliAlbum.Sanatci = cmbSanatcilar.SelectedItem as Sanatci;
            seciliAlbum.SatistaMi = cmbSatistaMi.SelectedItem == "Evet" ? true : false;
            seciliAlbum.Fiyat = nudFiyat.Value;
            seciliAlbum.IndirimOrani = (double)nudIndirimOrani.Value;

            _db.SaveChanges();
            MessageBox.Show("Albüm başarıyla güncellendi!");
            Temizle();
            DgvListele();
        }

        private void dgvAlbumler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Temizle();
            seciliAlbum = dgvAlbumler.SelectedRows[0].DataBoundItem as Album;
            txtAlbumAdi.Text = seciliAlbum.AlbumAdi;
            cmbSanatcilar.SelectedItem = seciliAlbum.Sanatci;
            dtpCikisTarihi.Value = seciliAlbum.CikisTarihi;
            nudFiyat.Value = seciliAlbum.Fiyat;
            nudIndirimOrani.Value = (decimal)seciliAlbum.IndirimOrani;
            if(seciliAlbum.SatistaMi)
                cmbSatistaMi.SelectedItem = "Evet";
            else
                cmbSatistaMi.SelectedItem = "Hayır";

        }
    }
}
