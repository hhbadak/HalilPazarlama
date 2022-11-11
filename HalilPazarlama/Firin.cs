using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HalilPazarlama
{
    public class Firin : Urun
    {
        public int urunKodu;
        public int programSayisi;
        public string urunOzellikleri;

        public override string Yazdir()
        {
            return $"Ürün Kodu : {urunKodu}\n{base.Yazdir()}\nProgram Sayısı : {programSayisi}\nÜrün Özellikleri : {urunOzellikleri}";
        }
    }
}
