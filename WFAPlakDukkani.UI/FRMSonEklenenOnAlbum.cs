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
    public partial class FRMSonEklenenOnAlbum : Form
    {
        private readonly MyDbContext _db;
        public FRMSonEklenenOnAlbum()
        {
            InitializeComponent();
            _db = new MyDbContext();
        }

        private void FRMSonEklenenOnAlbum_Load(object sender, EventArgs e)
        {
            var istenenler = _db.Albumler.Include(a => a.Sanatci).OrderByDescending(a => a.Id).Take(10).ToList();
            dgvSonEklenenOnAlbum.DataSource = istenenler;
            dgvSonEklenenOnAlbum.Columns["Id"].Visible = false;
            dgvSonEklenenOnAlbum.Columns["SanatciId"].Visible = false;
        }
    }
}
