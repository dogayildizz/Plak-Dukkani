using Microsoft.EntityFrameworkCore;
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

namespace WFAPlakDukkani.UI
{
    public partial class FRMIndirimdekiAlbumler : Form
    {
        private readonly MyDbContext _db;
        public FRMIndirimdekiAlbumler()
        {
            InitializeComponent();
            _db = new MyDbContext();
        }

        private void FRMIndirimdekiAlbumler_Load(object sender, EventArgs e)
        {
            var istenenler = _db.Albumler.Include(a => a.Sanatci).Where(a => a.IndirimOrani != 0)
                .Select(a=> new
                {
                    a.AlbumAdi,
                    a.Sanatci,
                    IndirimliFiyat = (a.IndirimOrani*(double)a.Fiyat).ToString("c2"),
                    a.IndirimOrani,
                    a.CikisTarihi,
                    a.SatistaMi
                })
                .ToList();
            dgvIndirimdekiAlbumler.DataSource = istenenler;
        }
    }
}
