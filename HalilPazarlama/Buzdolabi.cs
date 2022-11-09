using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HalilPazarlama
{
    public class Buzdolabi : Urun
    {
        public int urunKodu;
        public string enerjiSinifi;
        public string boyut;
        public string kapiSayisi;

        public override string Yazdir()
        {
            return $"{base.Yazdir()}\nÜrün Kodu : {urunKodu}\nEnerji Sınıfı : {enerjiSinifi}\nÜrün Boyutu : {boyut}\nKapı Sayısı : {kapiSayisi}";
        }
    }
}
