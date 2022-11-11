using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HalilPazarlama
{
    public class CamasirMakinesi : Urun
    {
        public int urunKodu;
        public int yikamaKapasitesi;
        public string enerjiSinifi;
        public string boyut;
        public bool akilliYikama;

        public override string Yazdir()
        {
            return $"Ürün Kodu : {urunKodu}\n{base.Yazdir()}\nYıkama Kapasitesi : {yikamaKapasitesi}\nEnerji Sınıfı : {enerjiSinifi}\nÜrün Boyutu : {boyut}\nAkıllı Yıkama : {akilliYikama}";
        }
    }
}
