using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WFAPlakDukkani.UI.Migrations
{
    /// <inheritdoc />
    public partial class M2_SeedDatalarEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sanatcilar",
                columns: new[] { "Id", "SanatciAdi" },
                values: new object[,]
                {
                    { 1, "Sezen Aksu" },
                    { 2, "Tarkan" },
                    { 3, "MFÖ" },
                    { 4, "Teoman" },
                    { 5, "Duman" },
                    { 6, "Berkay" },
                    { 7, "Adele" },
                    { 8, "Coldplay" },
                    { 9, "Taylor Swift" },
                    { 10, "The Weeknd" },
                    { 11, "Ed Sheeran" },
                    { 12, "Hadise" },
                    { 13, "Ajda Pekkan" },
                    { 14, "Barış Manço" },
                    { 15, "Sertab Erener" },
                    { 16, "Kenan Doğulu" },
                    { 17, "Zeynep Bastık" },
                    { 18, "Mabel Matiz" },
                    { 19, "Yalın" },
                    { 20, "Nil Karaibrahimgil" },
                    { 21, "Edis" },
                    { 22, "Gülşen" },
                    { 23, "Athena" },
                    { 24, "Ceza" },
                    { 25, "Sagopa Kajmer" },
                    { 26, "Ezhel" },
                    { 27, "Uzi" },
                    { 28, "Mero" },
                    { 29, "BTS" },
                    { 30, "BLACKPINK" },
                    { 31, "Shakira" },
                    { 32, "Rihanna" },
                    { 33, "Beyoncé" },
                    { 34, "Justin Bieber" },
                    { 35, "Ariana Grande" },
                    { 36, "Imagine Dragons" },
                    { 37, "Linkin Park" },
                    { 38, "Green Day" },
                    { 39, "OneRepublic" },
                    { 40, "Maroon 5" }
                });

            migrationBuilder.InsertData(
                table: "Albumler",
                columns: new[] { "Id", "AlbumAdi", "CikisTarihi", "Fiyat", "IndirimOrani", "SanatciId", "SatistaMi" },
                values: new object[,]
                {
                    { 1, "Aşk Şarkıları", new DateTime(2010, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 150m, 0.10000000000000001, 1, true },
                    { 2, "Yolla", new DateTime(2016, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 175m, 0.14999999999999999, 2, true },
                    { 3, "Ele Güne Karşı", new DateTime(1992, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 120m, 0.20000000000000001, 3, false },
                    { 4, "İnsanlık Halleri", new DateTime(2004, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 135m, 0.10000000000000001, 4, true },
                    { 5, "Seni Kendime Sakladım", new DateTime(2005, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 140m, 0.25, 5, false },
                    { 6, "Derin", new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 180m, 0.29999999999999999, 6, true },
                    { 7, "30", new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 250m, 0.050000000000000003, 7, true },
                    { 8, "Parachutes", new DateTime(2000, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 210m, 0.20000000000000001, 8, false },
                    { 9, "1989", new DateTime(2014, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 230m, 0.10000000000000001, 9, true },
                    { 10, "Starboy", new DateTime(2016, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 190m, 0.14999999999999999, 10, false },
                    { 11, "Divide", new DateTime(2017, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 200m, 0.20000000000000001, 11, true },
                    { 12, "Aşk Kaç Beden Giyer?", new DateTime(2011, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 160m, 0.10000000000000001, 12, true },
                    { 13, "Ajda 1990", new DateTime(1990, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 110m, 0.34999999999999998, 13, false },
                    { 14, "Sarı Çizmeli Mehmet Ağa", new DateTime(1989, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 95m, 0.40000000000000002, 14, false },
                    { 15, "Rengarenk", new DateTime(2010, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 145m, 0.20000000000000001, 15, true },
                    { 16, "Festival", new DateTime(2006, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 170m, 0.10000000000000001, 16, true },
                    { 17, "Zeynodisco", new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 200m, 0.14999999999999999, 17, true },
                    { 18, "Maya", new DateTime(2018, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 190m, 0.25, 18, false },
                    { 19, "Herşey Sensin", new DateTime(2009, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 130m, 0.20000000000000001, 19, false },
                    { 20, "Ben Buraya Çıplak Geldim", new DateTime(2012, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 140m, 0.10000000000000001, 20, true },
                    { 21, "An", new DateTime(2018, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 155m, 0.29999999999999999, 21, true },
                    { 22, "Bangır Bangır", new DateTime(2015, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 170m, 0.10000000000000001, 22, false },
                    { 23, "Herşey Yolunda", new DateTime(2005, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 120m, 0.25, 23, false },
                    { 24, "Rapstar", new DateTime(2004, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 140m, 0.29999999999999999, 24, true },
                    { 25, "Kötü İnsanları Tanıma Senesi", new DateTime(2011, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 160m, 0.20000000000000001, 25, false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Albumler",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Albumler",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Albumler",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Albumler",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Albumler",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Albumler",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Albumler",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Albumler",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Albumler",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Albumler",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Albumler",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Albumler",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Albumler",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Albumler",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Albumler",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Albumler",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Albumler",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Albumler",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Albumler",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Albumler",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Albumler",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Albumler",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Albumler",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Albumler",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Albumler",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Sanatcilar",
                keyColumn: "Id",
                keyValue: 25);
        }
    }
}
