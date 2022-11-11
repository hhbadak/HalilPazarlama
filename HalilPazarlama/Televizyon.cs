using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HalilPazarlama
{
    public class Televizyon : Urun
    {
        public int urunKodu;
        public int ekranBoyutu;
        public bool smartTv;
        public bool dahiliUyduAlici;
        public string renk;
        public bool wifi;
        public string goruntuKalitesi;
        public override string Yazdir()
        {
            return $"Ürün Kodu : {urunKodu}\n{base.Yazdir()}\nEkran Boyutu : {ekranBoyutu}\nSmartTv Özelliği : {smartTv}\nDahili Uydu Alıcısı : {dahiliUyduAlici}\nRenk : {renk}\nWi-Fi Özelliği : {wifi}\nGörüntü Kalitesi : {goruntuKalitesi}";
        }
    }

}
