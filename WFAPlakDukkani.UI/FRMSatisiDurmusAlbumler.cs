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
    public partial class FRMSatisiDurmusAlbumler : Form
    {
        private readonly MyDbContext _db;
        public FRMSatisiDurmusAlbumler()
        {
            InitializeComponent();
            _db = new MyDbContext();
        }

        private void FRMSatisiDurmusAlbumler_Load(object sender, EventArgs e)
        {
            var istenenler = _db.Albumler.Include(a=>a.Sanatci).Where(a => !a.SatistaMi).ToList();
            dgvSatisiDurmusAlbumler.DataSource = istenenler;
            dgvSatisiDurmusAlbumler.Columns["Id"].Visible = false;
            dgvSatisiDurmusAlbumler.Columns["SanatciId"].Visible = false;
        }
    }
}
