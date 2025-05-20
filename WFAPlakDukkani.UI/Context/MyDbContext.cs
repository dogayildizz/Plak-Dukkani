using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFAPlakDukkani.UI.Models;

namespace WFAPlakDukkani.UI.Context
{
    public class MyDbContext : DbContext
    {
        public DbSet<Yonetici> Yoneticiler {  get; set; }
        public DbSet<Album> Albumler { get; set; } 
        public DbSet<Sanatci> Sanatcilar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DO¦A\\SQLEXPRESS; database=PlakDukkaniDB; trusted_connection=true; trustservercertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Yonetici>().HasIndex(y => y.KullaniciAdi).IsUnique();

            modelBuilder.Entity<Sanatci>().HasData(
                    new Sanatci { Id = 1, SanatciAdi = "Sezen Aksu" },
    new Sanatci { Id = 2, SanatciAdi = "Tarkan" },
    new Sanatci { Id = 3, SanatciAdi = "MFÖ" },
    new Sanatci { Id = 4, SanatciAdi = "Teoman" },
    new Sanatci { Id = 5, SanatciAdi = "Duman" },
    new Sanatci { Id = 6, SanatciAdi = "Berkay" },
    new Sanatci { Id = 7, SanatciAdi = "Adele" },
    new Sanatci { Id = 8, SanatciAdi = "Coldplay" },
    new Sanatci { Id = 9, SanatciAdi = "Taylor Swift" },
    new Sanatci { Id = 10, SanatciAdi = "The Weeknd" },
    new Sanatci { Id = 11, SanatciAdi = "Ed Sheeran" },
    new Sanatci { Id = 12, SanatciAdi = "Hadise" },
    new Sanatci { Id = 13, SanatciAdi = "Ajda Pekkan" },
    new Sanatci { Id = 14, SanatciAdi = "Barış Manço" },
    new Sanatci { Id = 15, SanatciAdi = "Sertab Erener" },
    new Sanatci { Id = 16, SanatciAdi = "Kenan Doğulu" },
    new Sanatci { Id = 17, SanatciAdi = "Zeynep Bastık" },
    new Sanatci { Id = 18, SanatciAdi = "Mabel Matiz" },
    new Sanatci { Id = 19, SanatciAdi = "Yalın" },
    new Sanatci { Id = 20, SanatciAdi = "Nil Karaibrahimgil" },
    new Sanatci { Id = 21, SanatciAdi = "Edis" },
    new Sanatci { Id = 22, SanatciAdi = "Gülşen" },
    new Sanatci { Id = 23, SanatciAdi = "Athena" },
    new Sanatci { Id = 24, SanatciAdi = "Ceza" },
    new Sanatci { Id = 25, SanatciAdi = "Sagopa Kajmer" },
    new Sanatci { Id = 26, SanatciAdi = "Ezhel" },
    new Sanatci { Id = 27, SanatciAdi = "Uzi" },
    new Sanatci { Id = 28, SanatciAdi = "Mero" },
    new Sanatci { Id = 29, SanatciAdi = "BTS" },
    new Sanatci { Id = 30, SanatciAdi = "BLACKPINK" },
    new Sanatci { Id = 31, SanatciAdi = "Shakira" },
    new Sanatci { Id = 32, SanatciAdi = "Rihanna" },
    new Sanatci { Id = 33, SanatciAdi = "Beyoncé" },
    new Sanatci { Id = 34, SanatciAdi = "Justin Bieber" },
    new Sanatci { Id = 35, SanatciAdi = "Ariana Grande" },
    new Sanatci { Id = 36, SanatciAdi = "Imagine Dragons" },
    new Sanatci { Id = 37, SanatciAdi = "Linkin Park" },
    new Sanatci { Id = 38, SanatciAdi = "Green Day" },
    new Sanatci { Id = 39, SanatciAdi = "OneRepublic" },
    new Sanatci { Id = 40, SanatciAdi = "Maroon 5" }
                );


            modelBuilder.Entity<Album>().HasData(
                 new Album { Id = 1, AlbumAdi = "Aşk Şarkıları", CikisTarihi = new DateTime(2010, 2, 14), Fiyat = 150, IndirimOrani = 0.1, SatistaMi = true, SanatciId = 1 },
    new Album { Id = 2, AlbumAdi = "Yolla", CikisTarihi = new DateTime(2016, 6, 10), Fiyat = 175, IndirimOrani = 0.15, SatistaMi = true, SanatciId = 2 },
    new Album { Id = 3, AlbumAdi = "Ele Güne Karşı", CikisTarihi = new DateTime(1992, 4, 1), Fiyat = 120, IndirimOrani = 0.2, SatistaMi = false, SanatciId = 3 },
    new Album { Id = 4, AlbumAdi = "İnsanlık Halleri", CikisTarihi = new DateTime(2004, 9, 5), Fiyat = 135, IndirimOrani = 0.1, SatistaMi = true, SanatciId = 4 },
    new Album { Id = 5, AlbumAdi = "Seni Kendime Sakladım", CikisTarihi = new DateTime(2005, 1, 20), Fiyat = 140, IndirimOrani = 0.25, SatistaMi = false, SanatciId = 5 },
    new Album { Id = 6, AlbumAdi = "Derin", CikisTarihi = new DateTime(2021, 11, 1), Fiyat = 180, IndirimOrani = 0.3, SatistaMi = true, SanatciId = 6 },
    new Album { Id = 7, AlbumAdi = "30", CikisTarihi = new DateTime(2021, 11, 19), Fiyat = 250, IndirimOrani = 0.05, SatistaMi = true, SanatciId = 7 },
    new Album { Id = 8, AlbumAdi = "Parachutes", CikisTarihi = new DateTime(2000, 7, 10), Fiyat = 210, IndirimOrani = 0.2, SatistaMi = false, SanatciId = 8 },
    new Album { Id = 9, AlbumAdi = "1989", CikisTarihi = new DateTime(2014, 10, 27), Fiyat = 230, IndirimOrani = 0.1, SatistaMi = true, SanatciId = 9 },
    new Album { Id = 10, AlbumAdi = "Starboy", CikisTarihi = new DateTime(2016, 11, 25), Fiyat = 190, IndirimOrani = 0.15, SatistaMi = false, SanatciId = 10 },
    new Album { Id = 11, AlbumAdi = "Divide", CikisTarihi = new DateTime(2017, 3, 3), Fiyat = 200, IndirimOrani = 0.2, SatistaMi = true, SanatciId = 11 },
    new Album { Id = 12, AlbumAdi = "Aşk Kaç Beden Giyer?", CikisTarihi = new DateTime(2011, 4, 12), Fiyat = 160, IndirimOrani = 0.1, SatistaMi = true, SanatciId = 12 },
    new Album { Id = 13, AlbumAdi = "Ajda 1990", CikisTarihi = new DateTime(1990, 5, 1), Fiyat = 110, IndirimOrani = 0.35, SatistaMi = false, SanatciId = 13 },
    new Album { Id = 14, AlbumAdi = "Sarı Çizmeli Mehmet Ağa", CikisTarihi = new DateTime(1989, 9, 20), Fiyat = 95, IndirimOrani = 0.4, SatistaMi = false, SanatciId = 14 },
    new Album { Id = 15, AlbumAdi = "Rengarenk", CikisTarihi = new DateTime(2010, 6, 11), Fiyat = 145, IndirimOrani = 0.2, SatistaMi = true, SanatciId = 15 },
    new Album { Id = 16, AlbumAdi = "Festival", CikisTarihi = new DateTime(2006, 8, 25), Fiyat = 170, IndirimOrani = 0.1, SatistaMi = true, SanatciId = 16 },
    new Album { Id = 17, AlbumAdi = "Zeynodisco", CikisTarihi = new DateTime(2023, 6, 5), Fiyat = 200, IndirimOrani = 0.15, SatistaMi = true, SanatciId = 17 },
    new Album { Id = 18, AlbumAdi = "Maya", CikisTarihi = new DateTime(2018, 6, 20), Fiyat = 190, IndirimOrani = 0.25, SatistaMi = false, SanatciId = 18 },
    new Album { Id = 19, AlbumAdi = "Herşey Sensin", CikisTarihi = new DateTime(2009, 3, 12), Fiyat = 130, IndirimOrani = 0.2, SatistaMi = false, SanatciId = 19 },
    new Album { Id = 20, AlbumAdi = "Ben Buraya Çıplak Geldim", CikisTarihi = new DateTime(2012, 9, 3), Fiyat = 140, IndirimOrani = 0.1, SatistaMi = true, SanatciId = 20 },

    new Album { Id = 21, AlbumAdi = "An", CikisTarihi = new DateTime(2018, 3, 23), Fiyat = 155, IndirimOrani = 0.3, SatistaMi = true, SanatciId = 21 },
    new Album { Id = 22, AlbumAdi = "Bangır Bangır", CikisTarihi = new DateTime(2015, 4, 29), Fiyat = 170, IndirimOrani = 0.1, SatistaMi = false, SanatciId = 22 },
    new Album { Id = 23, AlbumAdi = "Herşey Yolunda", CikisTarihi = new DateTime(2005, 8, 19), Fiyat = 120, IndirimOrani = 0.25, SatistaMi = false, SanatciId = 23 },
    new Album { Id = 24, AlbumAdi = "Rapstar", CikisTarihi = new DateTime(2004, 1, 15), Fiyat = 140, IndirimOrani = 0.3, SatistaMi = true, SanatciId = 24 },
    new Album { Id = 25, AlbumAdi = "Kötü İnsanları Tanıma Senesi", CikisTarihi = new DateTime(2011, 11, 18), Fiyat = 160, IndirimOrani = 0.2, SatistaMi = false, SanatciId = 25 }

                );
        }
    }
}
