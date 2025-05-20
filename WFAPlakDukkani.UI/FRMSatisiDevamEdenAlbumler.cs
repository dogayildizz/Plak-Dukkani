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
    public partial class FRMSatisiDevamEdenAlbumler : Form
    {
        private readonly MyDbContext _db;
        public FRMSatisiDevamEdenAlbumler()
        {
            InitializeComponent();
            _db = new MyDbContext();
        }

        private void FRMSatisiDevamEdenAlbumler_Load(object sender, EventArgs e)
        {
            var istenenler = _db.Albumler.Include(a => a.Sanatci).Where(a => a.SatistaMi).ToList();
            dgvSatisiDevamEdenAlbumler.DataSource = istenenler;
            dgvSatisiDevamEdenAlbumler.Columns["Id"].Visible = false;
            dgvSatisiDevamEdenAlbumler.Columns["SanatciId"].Visible = false;

        }
    }
}
