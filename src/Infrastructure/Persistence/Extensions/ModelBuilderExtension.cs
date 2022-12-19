using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Extensions;

public static class ModelBuilderExtension
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        var rnd = new Random();
 
        modelBuilder.Entity<AccountGroup>().HasData(
            new List<AccountGroup>()
            {
                 new AccountGroup
            {
                Id = 1, Name = "SATIŞLARDAN GELİRLER", Parent = 0, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 2, Name = "DEĞİŞKEN GİDERLER", Parent = 0, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 3, Name = "SABİT MASRAFLAR", Parent = 0, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 4, Name = "PERSONEL GİDERLERİ", Parent = 0, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 5, Name = "TEDARİKÇİ BORÇLARI", Parent = 0, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 6, Name = "POS KOMİSYONU & MASRAF", Parent = 2, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 7, Name = "ARACI SİTE KOMİSYONU", Parent = 6, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 8, Name = "IYZICO KOMİSYONU", Parent = 6, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 9, Name = "POS MASRAFLARI", Parent = 6, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 10, Name = "KARGO", Parent = 2, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 11, Name = "YURTİÇİ KARGO", Parent = 10, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 12, Name = "HEPSİBURADA", Parent = 10, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 13, Name = "DHL", Parent = 10, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 14, Name = "PTT", Parent = 10, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 15, Name = "TRENDYOL", Parent = 10, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 16, Name = "AMBALAJ", Parent = 2, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 17, Name = "BEZ POŞET", Parent = 16, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 18, Name = "KARTON POŞET", Parent = 16, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 19, Name = "KUTU", Parent = 16, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 20, Name = "PERSONEL PRİMLERİ", Parent = 2, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 21, Name = "KİRALAR", Parent = 3, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 22, Name = "KİRA (+STOPAJ)", Parent = 21, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 23, Name = "AİDAT BEDELİ", Parent = 21, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 24, Name = "VERGİ", Parent = 21, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 25, Name = "STOPAJ", Parent = 21, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 26, Name = "TÜKETİM BEDELLERİ VE SABİT GİDERLER", Parent = 3, CreatedDate = DateTime.Now,
                CreatedUser = "SeedDb", UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 27, Name = "ELEKTRİK TÜKETİM GİDERLERİ", Parent = 26, CreatedDate = DateTime.Now,
                CreatedUser = "SeedDb", UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 28, Name = "SU TÜKETİM GİDERLERİ", Parent = 26, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 29, Name = "DOĞALGAZ VE DİĞER YAKIT GİDERLERİ", Parent = 26, CreatedDate = DateTime.Now,
                CreatedUser = "SeedDb", UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 30, Name = "SABİT TELEFON GİDERLERİ", Parent = 26, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 31, Name = "GSM TELEFON GİDERLERİ", Parent = 26, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 32, Name = "İNTERNET KULLANIM GİDERLERİ", Parent = 26, CreatedDate = DateTime.Now,
                CreatedUser = "SeedDb", UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 33, Name = "GÜVENLİK HİZMET GİDERLERİ", Parent = 26, CreatedDate = DateTime.Now,
                CreatedUser = "SeedDb", UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 34, Name = "SU ARTIMA GİDERLERİ", Parent = 26, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 35, Name = "KOKULANDIRMA GİDERLERİ", Parent = 26, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 36, Name = "SERVİS BAKIM VE ONARIM GİDERLERİ", Parent = 26, CreatedDate = DateTime.Now,
                CreatedUser = "SeedDb", UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 37, Name = "TEMİZ-MUTFAK VS.", Parent = 26, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 38, Name = "GÜNDELİK TEMİZLİK", Parent = 26, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 39, Name = "KIRTASİYE", Parent = 26, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 40, Name = "SİGORTALAMA GİDERLERİ", Parent = 26, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 41, Name = "BİL VE ELEK MALZ.KÜÇÜK DEMİRBAŞ", Parent = 26, CreatedDate = DateTime.Now,
                CreatedUser = "SeedDb", UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 42, Name = "KİŞİ SAYIM CİHAZI", Parent = 26, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 43, Name = "DANIŞMANLIK VE MÜŞAVİRLİK GİDERLERİ", Parent = 3, CreatedDate = DateTime.Now,
                CreatedUser = "SeedDb", UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 44, Name = "DANIŞMANLIK HİZMETİ GİDERLERİ", Parent = 43, CreatedDate = DateTime.Now,
                CreatedUser = "SeedDb", UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 45, Name = "DANIŞMANLIK-AVUKATLIK", Parent = 43, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 46, Name = "DANIŞMANLIK-MALİ MÜŞAVİRLİK", Parent = 43, CreatedDate = DateTime.Now,
                CreatedUser = "SeedDb", UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 47, Name = "PAZARLAMA GİDERLERİ", Parent = 3, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 48, Name = "EŞANTİYON VE PROMOSYON", Parent = 47, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 49, Name = "SOSYAL MEDYA REKLAMLARI", Parent = 47, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 50, Name = "DERGİ, GAZETE VS BASILI PLATFROM", Parent = 47, CreatedDate = DateTime.Now,
                CreatedUser = "SeedDb", UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 51, Name = "DİJİTAL PLATFOMLAR", Parent = 3, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 52, Name = "YÖNETİM GİDERLERİ", Parent = 3, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 53, Name = "ARAÇ YAKIT GİDERLERİ", Parent = 52, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 54, Name = "ARAÇ KİRALAMA GİDERLERİ", Parent = 52, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 55, Name = "ARAÇ SERVİS BAKIM GİDERLERİ", Parent = 52, CreatedDate = DateTime.Now,
                CreatedUser = "SeedDb", UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 56, Name = "ARAÇLARA İLİŞKİN GİDERLER", Parent = 52, CreatedDate = DateTime.Now,
                CreatedUser = "SeedDb", UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 57, Name = "AYLIK YAZILIM KULLANMA GİDERLERİ", Parent = 52, CreatedDate = DateTime.Now,
                CreatedUser = "SeedDb", UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 58, Name = "KREDİ ÖDEMELERİ", Parent = 3, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 59, Name = "İŞBANKASI", Parent = 58, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 60, Name = "GARANTİ BBVA", Parent = 58, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 61, Name = "VAKIF LEASİNG", Parent = 58, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 62, Name = "YAPIKREDİ", Parent = 58, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 63, Name = "ZİRAAT BANKASI", Parent = 58, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 64, Name = "NORMAL ÜCRETLER", Parent = 4, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 65, Name = "PRİM ÜCRETLERİ", Parent = 4, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 66, Name = "PERSONEL SGK", Parent = 4, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 67, Name = "PERSONEL YEMEK", Parent = 4, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 68, Name = "PERSONEL KIYAFET", Parent = 4, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 69, Name = "PERSONEL KID. TAZ", Parent = 4, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 70, Name = "PERSONEL IHB. TAZ", Parent = 4, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 71, Name = "PERSONEL KIYAFET", Parent = 4, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            },
            new AccountGroup
            {
                Id = 73, Name = "GELİR VERGİSİ", Parent = 4, CreatedDate = DateTime.Now, CreatedUser = "SeedDb",
                UpdatedDate = DateTime.Now, UpdatedUser = "SeedDb", Blocked = false
            }
            }
             
            );

        var accounts = Enumerable.Range(1, 1000).Select(

            id => new Account
            {
                Id = id,
                SourceId = $"Source{id}",
                AccountGroupId = rnd.Next(1,50),
                CreatedUser = "seed",
                UpdatedUser = "seed",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Blocked = false,
                Name = $"Account #{id}",
                IBAN = $"TR001 0332 1234 0000 {id}",
                TaxOffice = "Same Place",
                TaxNumber = $"{id}"
            }

        );
        modelBuilder.Entity<Account>().HasData(accounts);
    }
}