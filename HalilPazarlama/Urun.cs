using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HalilPazarlama
{
    public class Urun
    {
        public string marka;
        public string model;
        public string garantiSuresi;
        public double fiyat;
        public int stok;
        public virtual string Yazdir()
        {

            return $"Marka : {marka}\nModel : {model}\nGaranti Süresi : {garantiSuresi}\nFiyat : {fiyat}";
        }
    }
    
}
