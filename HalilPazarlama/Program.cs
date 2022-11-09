using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Cryptography;
using System.Reflection;
using System.Management.Instrumentation;
using System.Reflection.Emit;

namespace HalilPazarlama
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region URUN EKLEME
            #region NESNE TANIMLAMA
            BulasikMakinesi bm = new BulasikMakinesi();
            Buzdolabi b = new Buzdolabi();
            CamasirMakinesi cm = new CamasirMakinesi();
            Firin f = new Firin();
            Supurge s = new Supurge();
            Televizyon tv = new Televizyon();
            #endregion
            
            BulasikMakinesi bulasik1 = new BulasikMakinesi();
            bulasik1.urunKodu = 101;
            bulasik1.marka = "VESTEL";
            bulasik1.model = "BM-402";
            bulasik1.garantiSuresi = "24";
            bulasik1.programSayisi = 4;
            bulasik1.enerjiSinifi = "B";
            bulasik1.kapasite = "13 Kişilik";
            bulasik1.fiyat = 5499;
            bulasik1.stok = 6;

            BulasikMakinesi bulasik2 = new BulasikMakinesi()
            {
                urunKodu = 102,
                marka = "ALTUS",
                model = "AL403",
                garantiSuresi = "36",
                programSayisi = 3,
                enerjiSinifi = "C",
                kapasite = "9 Kişilik",
                fiyat = 4799,
                stok = 11
            };

            BulasikMakinesi bulasik3 = new BulasikMakinesi()
            {
                urunKodu = 103,
                marka = "HOOVER",
                model = "HF-E5E",
                garantiSuresi = "12",
                programSayisi = 9,
                enerjiSinifi = "A",
                kapasite = "15 Kişilik",
                fiyat = 4949,
                stok = 10
            };

            BulasikMakinesi bulasik4 = new BulasikMakinesi()
            {
                urunKodu = 104,
                marka = "HOOVER",
                model = "HFDN",
                garantiSuresi = "24",
                programSayisi = 7,
                enerjiSinifi = "A",
                kapasite = "13 Kişilik",
                fiyat = 4899,
                stok = 3
            };

            BulasikMakinesi bulasik5 = new BulasikMakinesi()
            {
                urunKodu = 105,
                marka = "GRUNDIG",
                model = "GDF-6503",
                garantiSuresi = "36",
                programSayisi = 11,
                enerjiSinifi = "B",
                kapasite = "14 Kişilik",
                fiyat = 5999,
                stok = 2
            };
            BulasikMakinesi bulasik6 = new BulasikMakinesi()
            {
                urunKodu = 106,
                marka = "VESTEL",
                model = "BM-5101",
                garantiSuresi = "36",
                programSayisi = 11,
                enerjiSinifi = "A",
                kapasite = "13 Kişilik",
                fiyat = 6248,
                stok = 4
            };

            List<BulasikMakinesi> bulasikMakineleri = new List<BulasikMakinesi>();
            bulasikMakineleri.Add(bulasik1);
            bulasikMakineleri.Add(bulasik2);
            bulasikMakineleri.Add(bulasik3);
            bulasikMakineleri.Add(bulasik4);
            bulasikMakineleri.Add(bulasik5);
            bulasikMakineleri.Add(bulasik6);

            Buzdolabi buz1 = new Buzdolabi()
            {
                urunKodu = 201,
                marka = "REGAL",
                model = "NF-3",
                garantiSuresi = "48",
                enerjiSinifi = "C",
                boyut = "166x63",
                kapiSayisi = "2",
                fiyat = 4899,
                stok = 3
            };

            Buzdolabi buz2 = new Buzdolabi()
            {
                urunKodu = 202,
                marka = "VESTEL",
                model = "NF48",
                garantiSuresi = "36",
                enerjiSinifi = "D",
                boyut = "70x72",
                kapiSayisi = "1",
                fiyat = 8372,
                stok = 1
            };

            Buzdolabi buz3 = new Buzdolabi()
            {
                urunKodu = 201,
                marka = "WINDSOR",
                model = "WS-4700",
                garantiSuresi = "48",
                enerjiSinifi = "A+",
                boyut = "65x183",
                kapiSayisi = "2",
                fiyat = 5899,
                stok = 7
            };

            List<Buzdolabi> buzdolaplari = new List<Buzdolabi>();
            buzdolaplari.Add(buz1);
            buzdolaplari.Add(buz2);
            buzdolaplari.Add(buz3);

            CamasirMakinesi camasir1 = new CamasirMakinesi()
            {
                urunKodu = 301,
                marka = "HOOVER",
                model = "H3W",
                garantiSuresi = "24",
                yikamaKapasitesi = 10,
                enerjiSinifi = "A+++",
                boyut = "85x60x58",
                akilliYikama = true,
                fiyat = 7399,
                stok = 6
            };

            CamasirMakinesi camasir2 = new CamasirMakinesi()
            {
                urunKodu = 302,
                marka = "REGAL",
                model = "CM710",
                garantiSuresi = "12",
                yikamaKapasitesi = 7,
                enerjiSinifi = "C",
                boyut = "59x84x49",
                akilliYikama = false,
                fiyat = 5440,
                stok = 2
            };

            CamasirMakinesi camasir3 = new CamasirMakinesi()
            {
                urunKodu = 303,
                marka = "VESTEL",
                model = "CMI-97",
                garantiSuresi = "12",
                yikamaKapasitesi = 11,
                enerjiSinifi = "A",
                boyut = "100x80x50",
                fiyat = 7500,
                stok = 1
            };

            CamasirMakinesi camasir4 = new CamasirMakinesi()
            {
                urunKodu = 304,
                marka = "HOOVER",
                model = "H3WS",
                garantiSuresi = "24",
                yikamaKapasitesi = 14,
                enerjiSinifi = "A",
                boyut = "110x65x49",
                fiyat = 11900,
                stok = 3
            };

            List<CamasirMakinesi> camasirlar = new List<CamasirMakinesi>();
            camasirlar.Add(camasir1);
            camasirlar.Add(camasir2);
            camasirlar.Add(camasir3);
            camasirlar.Add(camasir4);

            Firin firin1 = new Firin()
            {
                urunKodu = 401,
                marka = "Uğur",
                model = "U-1",
                garantiSuresi = "12",
                programSayisi = 1,
                urunOzellikleri = "Davul Fırın Tek Tepsili, Bordo ",
                fiyat = 392,
                stok = 14
            };

            Firin firin2 = new Firin()
            {
                urunKodu = 402,
                marka = "ALVEUS",
                model = "Mfa-627",
                garantiSuresi = "24",
                programSayisi = 6,
                urunOzellikleri = "Kir tutmayan emaye yüzey | Pop-Up & Touch Kontrol | Keskin kenarsız tepsi",
                fiyat = 1866,
                stok = 8
            };

            Firin firin3 = new Firin()
            {
                urunKodu = 403,
                marka = "TANQ",
                model = "Tmf-3600",
                garantiSuresi = "36",
                programSayisi = 6,
                urunOzellikleri = "Yüksek ısıya dayanıklı özel tamperli cam | 80-320 derece ayarlanabilir otomatik termostat ",
                fiyat = 799,
                stok = 6
            };

            Firin firin4 = new Firin()
            {
                urunKodu = 404,
                marka = "VESTEL",
                model = "AF-7684",
                garantiSuresi = "12",
                programSayisi = 8,
                urunOzellikleri = "Gömülebilir Düğme ",
                fiyat = 4180,
                stok = 3
            };

            List<Firin> firinlar = new List<Firin>();
            firinlar.Add(firin1);
            firinlar.Add(firin2);
            firinlar.Add(firin3);
            firinlar.Add(firin4);

            Supurge supurge1 = new Supurge()
            {
                urunKodu = 501,
                marka = "DYSON",
                model = "D-01",
                garantiSuresi = "24",
                motorGucu = 1500,
                suHaznesi = false,
                renk = "Kırmızı",
                fiyat = 6299,
                stok = 4
            };

            Supurge supurge2 = new Supurge()
            {
                urunKodu = 502,
                marka = "GoldMaster",
                model = "G-012",
                garantiSuresi = "12",
                motorGucu = 1500,
                suHaznesi = true,
                renk = "Krem",
                fiyat = 2049,
                stok = 15
            };

            Supurge supurge3 = new Supurge()
            {
                urunKodu = 503,
                marka = "PHLIPS",
                model = "PowerPro",
                garantiSuresi = "12",
                motorGucu = 1800,
                suHaznesi = true,
                renk = "Mor",
                fiyat = 1749,
                stok = 9
            };

            List<Supurge> supurgeler = new List<Supurge>();
            supurgeler.Add(supurge1);
            supurgeler.Add(supurge2);
            supurgeler.Add(supurge3);

            Televizyon tv1 = new Televizyon()
            {
                urunKodu = 601,
                marka = "Axen",
                model = "AX32",
                garantiSuresi = "24",
                ekranBoyutu = 80,
                smartTv = true,
                dahiliUyduAlici = true,
                renk = "SİYAH",
                wifi = false,
                goruntuKalitesi = "HD Ready",
                fiyat = 2148,
                stok = 13
            };

            Televizyon tv2 = new Televizyon()
            {
                urunKodu = 602,
                marka = "TOSHIBA",
                model = "66UA3D",
                garantiSuresi = "12",
                ekranBoyutu = 164,
                smartTv = true,
                dahiliUyduAlici = true,
                renk = "SİYAH",
                wifi = true,
                goruntuKalitesi = "4K ULTRA HD",
                fiyat = 11339,
                stok = 3
            };

            Televizyon tv3 = new Televizyon()
            {
                urunKodu = 603,
                marka = "SONY",
                model = "KD-32",
                garantiSuresi = "12",
                ekranBoyutu = 139,
                smartTv = true,
                dahiliUyduAlici = true,
                renk = "MAVİ",
                wifi = true,
                goruntuKalitesi = "4K ULTRA HD",
                fiyat = 15487,
                stok = 9
            };

            List<Televizyon> televizyonlar = new List<Televizyon>();
            televizyonlar.Add(tv1);
            televizyonlar.Add(tv2);
            televizyonlar.Add(tv3);

            #endregion

            
        }
    }
}
