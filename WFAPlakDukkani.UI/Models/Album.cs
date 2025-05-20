using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAPlakDukkani.UI.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string AlbumAdi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public decimal Fiyat { get; set; }
        public double IndirimOrani { get; set; }
        public bool SatistaMi { get; set; }
        public Sanatci Sanatci { get; set; }
        public int SanatciId { get; set; }

    }
}
