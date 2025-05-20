using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WFAPlakDukkani.UI.Helper
{
    public class Sifreleme
    {
       
            public static string Sha256Hash(string sifre)
            {
                using (SHA256 hash = SHA256Managed.Create())
                {
                    return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(s => s.ToString("X2")));
                }
            }

    }
}
