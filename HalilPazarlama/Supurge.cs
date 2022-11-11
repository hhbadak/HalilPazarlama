using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HalilPazarlama
{
    public class Supurge : Urun
    {
        public int urunKodu;
        public int motorGucu;
        public bool suHaznesi;
        public string renk;

        public override string Yazdir()
        {
            return $"Ürün Kodu : {urunKodu}\n{base.Yazdir()}\nMotor Gücü : {motorGucu}\nSu Haznesi : {suHaznesi}\nRenk : {renk}";
        }
    }
}
