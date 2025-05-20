using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAPlakDukkani.UI.Models
{
    public class Sanatci
    {
        public int Id { get; set; }
        public string SanatciAdi { get; set; }
        public List<Album> Albumler { get; set; }
        public override string ToString()
        {
            return SanatciAdi;
        }
    }
}
