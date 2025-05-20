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
    public partial class FRMSanatcilar : Form
    {
        private readonly MyDbContext _db;
        Sanatci secilenSanatci = new Sanatci();
        public FRMSanatcilar()
        {
            InitializeComponent();
            _db = new MyDbContext();
            DgvListele();
            Temizle();

        }

        public void DgvListele()
        {
            dgvSanatcilar.DataSource = _db.Sanatcilar.ToList();
            dgvSanatcilar.Columns["Id"].Visible = false;
        }

        public void Temizle()
        {
            txtSanatciAdi.Text = string.Empty;
            secilenSanatci = null;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSanatciAdi.Text))
            {
                MessageBox.Show("Sanatçı/Grup adı boş bırakılmamalıdır.");
                return;
            }
            Sanatci sanatci = new Sanatci
            {
                SanatciAdi = txtSanatciAdi.Text,
            };
            _db.Sanatcilar.Add(sanatci);
            _db.SaveChanges();

            MessageBox.Show("Sanatçı başarıyla eklendi.");
            DgvListele();
            Temizle();
        }

        private void dgvSanatcilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenSanatci = dgvSanatcilar.SelectedRows[0].DataBoundItem as Sanatci;
            txtSanatciAdi.Text = secilenSanatci.SanatciAdi;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(secilenSanatci==null)
            {
                MessageBox.Show("Silmek istediğiniz sanatçıyı seçiniz.");
                return;
            }
            _db.Sanatcilar.Remove(secilenSanatci);
            _db.SaveChanges();

            MessageBox.Show("Sanatçı başarıyla silindi.");
            DgvListele();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenSanatci == null)
            {
                MessageBox.Show("Güncellemek istediğiniz sanatçıyı seçiniz.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSanatciAdi.Text))
            {
                MessageBox.Show("Sanatçı/Grup adı boş bırakılmamalıdır.");
                return;
            }
            secilenSanatci.SanatciAdi = txtSanatciAdi.Text;

            _db.SaveChanges();
            MessageBox.Show("Sanatçı başarıyla güncellendi.");
            DgvListele();
            Temizle();

        }
    }
}
